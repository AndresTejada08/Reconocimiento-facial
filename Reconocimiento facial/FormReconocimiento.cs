using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Speech.Synthesis;
using System.Media;

namespace Reconocimiento_facial
{
    public partial class FormReconocimiento : Form
    {
        SoundPlayer media = new SoundPlayer();
        SpeechSynthesizer vos = new SpeechSynthesizer();
        //DECLARANDO TODAS LAS VARIABLES, vectores y  haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.9d);
        Image<Gray, byte> result = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> labels1 = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null, Labelsinfo;

        // Llamar al servicio
        private static ServiceReference1.wsColegioSoapClient servicio;

        public FormReconocimiento()
        {
            InitializeComponent();
            DeteccionCaras();
        }

        private void DeteccionCaras()
        {
            //GARGAMOS LA DETECCION DE LAS CARAS POR  haarcascades 
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                //carga de caras y etiquetas para cada imagen
                Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "No hay ningun rosto registrado).", "Cargar rostros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Reconocer()
        {
            //Iniciar el dispositivo de captura
            grabber = new Capture();
            grabber.QueryFrame();
            //Iniciar el evento FrameGraber
            Application.Idle += new EventHandler(FrameGrabber);
        }

        private void Desconectar()
        {
            Application.Idle -= new EventHandler(FrameGrabber);
            grabber.Dispose();
            imageBoxFrameGrabber.ImageLocation = "img/1.png";
            lblNadie.Text = string.Empty;
            lblNumeroDetect.Text = string.Empty;
            bttnDesconectar.Text = "Conectar";
        }

        private void FrameGrabber(object sender, EventArgs e)
        {
            lblNumeroDetect.Text = "0";
            NamePersons.Add("");

            //Obtener la secuencia del dispositivo de captura
            try
            {
                currentFrame = grabber.QueryFrame().Resize(640, 480, INTER.CV_INTER_CUBIC);
            }
            catch (Exception)
            {
                lblNadie.Text = "";
                imageBoxFrameGrabber.Image = null;
            }

            //Convertir a escala de grises
            gray = currentFrame.Convert<Gray, Byte>();

            //Detector de Rostros
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, HAAR_DETECTION_TYPE.FIND_BIGGEST_OBJECT, new Size(20, 20));

            //Accion para cada elemento detectado
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(173, 168, INTER.CV_INTER_CUBIC);
                //Dibujar el cuadro para el rostro
                currentFrame.Draw(f.rect, new Bgr(Color.LightGreen), 1);

                if (trainingImages.ToArray().Length != 0)
                {
                    //Clase para reconocimiento con el nùmero de imagenes
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Clase Eigen para reconocimiento de rostro
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), ref termCrit);
                    var fa = new Image<Gray, byte>[trainingImages.Count]; //currentFrame.Convert<Bitmap>();

                    name = recognizer.Recognize(result);
                    //Dibujar el nombre para cada rostro detectado y reconocido
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.YellowGreen));
                }

                NamePersons[t - 1] = name;

                //Establecer el nùmero de rostros detectados
                lblNumeroDetect.Text = facesDetected[0].Length.ToString();
                lblNadie.Text = name;

            }
            t = 0;

            //Nombres concatenados de todos los rostros reconocidos
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
            }

            //Mostrar los rostros procesados y reconocidos
            imageBoxFrameGrabber.Image = currentFrame;

            //Borrar la lista de nombres            
            NamePersons.Clear();
        }

        private void bttnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReconocimiento_Load(object sender, EventArgs e)
        {
            Reconocer();
            //media.SoundLocation = "sounds/2.wav";
            //media.Play();
        }

        private void bttnDesconectar_Click(object sender, EventArgs e)
        {
            switch (bttnDesconectar.Text)
            {
                case "Conectar":
                    Reconocer();
                    bttnDesconectar.Text = "Desconectar";
                    break;
                case "Desconectar":
                    Desconectar();
                    break;
            }
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            Desconectar();
            FormRegistrar form = new FormRegistrar();
            form.Show();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            string nombreCompleto = lblNadie.Text.Trim();

            // Inicializamos el servicio
            servicio = new ServiceReference1.wsColegioSoapClient();
            dgvPrueba.DataSource = servicio.BuscarCoencidencia(nombreCompleto).Tables[0];

            try
            {
                int codPersona = Convert.ToInt32(dgvPrueba.Rows[0].Cells[0].Value.ToString());
                string fecha = DateTime.Now.ToString("dd/MM/yyyy");
                string hora = DateTime.Now.ToString("hh:mm:ss");

                // Agregamos Asistencia
                servicio.AgregarAsistencia(fecha, hora, codPersona);
                label4.Text = "Asistencia Registrada!";
            }
            catch (Exception ex)
            {
                label4.Text = "No se encontró un registro";
                MessageBox.Show("ERROR: " + ex);
            }
        }
    }
}
