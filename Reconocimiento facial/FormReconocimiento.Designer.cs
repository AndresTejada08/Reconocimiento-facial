
namespace Reconocimiento_facial
{
    partial class FormReconocimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReconocimiento));
            this.panelTopForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCerrar = new System.Windows.Forms.PictureBox();
            this.bttnDesconectar = new System.Windows.Forms.Button();
            this.bttnRegistrar = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNadie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeroDetect = new System.Windows.Forms.Label();
            this.dgvPrueba = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTopForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopForm
            // 
            this.panelTopForm.BackColor = System.Drawing.Color.Black;
            this.panelTopForm.Controls.Add(this.pictureBox1);
            this.panelTopForm.Controls.Add(this.label1);
            this.panelTopForm.Controls.Add(this.bttnCerrar);
            this.panelTopForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopForm.Location = new System.Drawing.Point(0, 0);
            this.panelTopForm.Name = "panelTopForm";
            this.panelTopForm.Size = new System.Drawing.Size(873, 43);
            this.panelTopForm.TabIndex = 188;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reconocimiento_facial.Properties.Resources.San_Agustin;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "M A N T E N I M I E N T O    R E C O N O C I M I E N T O    F A C I A L";
            // 
            // bttnCerrar
            // 
            this.bttnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("bttnCerrar.Image")));
            this.bttnCerrar.Location = new System.Drawing.Point(836, 4);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(33, 34);
            this.bttnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnCerrar.TabIndex = 3;
            this.bttnCerrar.TabStop = false;
            this.bttnCerrar.Click += new System.EventHandler(this.bttnCerrar_Click);
            // 
            // bttnDesconectar
            // 
            this.bttnDesconectar.BackColor = System.Drawing.Color.Black;
            this.bttnDesconectar.FlatAppearance.BorderSize = 0;
            this.bttnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDesconectar.ForeColor = System.Drawing.Color.White;
            this.bttnDesconectar.Location = new System.Drawing.Point(560, 104);
            this.bttnDesconectar.Name = "bttnDesconectar";
            this.bttnDesconectar.Size = new System.Drawing.Size(177, 35);
            this.bttnDesconectar.TabIndex = 187;
            this.bttnDesconectar.Text = "Desconectar";
            this.bttnDesconectar.UseVisualStyleBackColor = false;
            this.bttnDesconectar.Click += new System.EventHandler(this.bttnDesconectar_Click);
            // 
            // bttnRegistrar
            // 
            this.bttnRegistrar.BackColor = System.Drawing.Color.Black;
            this.bttnRegistrar.FlatAppearance.BorderSize = 0;
            this.bttnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRegistrar.ForeColor = System.Drawing.Color.White;
            this.bttnRegistrar.Location = new System.Drawing.Point(560, 145);
            this.bttnRegistrar.Name = "bttnRegistrar";
            this.bttnRegistrar.Size = new System.Drawing.Size(177, 35);
            this.bttnRegistrar.TabIndex = 186;
            this.bttnRegistrar.Text = "Registrar";
            this.bttnRegistrar.UseVisualStyleBackColor = false;
            this.bttnRegistrar.Click += new System.EventHandler(this.bttnRegistrar_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(13, 14);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(440, 434);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 181;
            this.imageBoxFrameGrabber.TabStop = false;
            this.imageBoxFrameGrabber.WaitOnLoad = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(527, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 22);
            this.label5.TabIndex = 185;
            this.label5.Text = "PERSONAS DETECTADAS";
            // 
            // lblNadie
            // 
            this.lblNadie.AutoSize = true;
            this.lblNadie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNadie.ForeColor = System.Drawing.Color.Gray;
            this.lblNadie.Location = new System.Drawing.Point(545, 42);
            this.lblNadie.Name = "lblNadie";
            this.lblNadie.Size = new System.Drawing.Size(0, 17);
            this.lblNadie.TabIndex = 184;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(469, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 182;
            this.label2.Text = "Número de Personas:";
            // 
            // lblNumeroDetect
            // 
            this.lblNumeroDetect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDetect.AutoSize = true;
            this.lblNumeroDetect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDetect.ForeColor = System.Drawing.Color.Gray;
            this.lblNumeroDetect.Location = new System.Drawing.Point(641, 70);
            this.lblNumeroDetect.Name = "lblNumeroDetect";
            this.lblNumeroDetect.Size = new System.Drawing.Size(17, 17);
            this.lblNumeroDetect.TabIndex = 183;
            this.lblNumeroDetect.Text = "0";
            // 
            // dgvPrueba
            // 
            this.dgvPrueba.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrueba.Location = new System.Drawing.Point(560, 313);
            this.dgvPrueba.Name = "dgvPrueba";
            this.dgvPrueba.Size = new System.Drawing.Size(177, 82);
            this.dgvPrueba.TabIndex = 192;
            this.dgvPrueba.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(469, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 191;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.Black;
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Location = new System.Drawing.Point(560, 252);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(177, 35);
            this.btnAsistencia.TabIndex = 190;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(469, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 189;
            this.label3.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.imageBoxFrameGrabber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.bttnDesconectar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bttnRegistrar);
            this.panel1.Controls.Add(this.dgvPrueba);
            this.panel1.Controls.Add(this.lblNumeroDetect);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNadie);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 460);
            this.panel1.TabIndex = 194;
            // 
            // FormReconocimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTopForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReconocimiento";
            this.Text = "FormReconocimiento";
            this.Load += new System.EventHandler(this.FormReconocimiento_Load);
            this.panelTopForm.ResumeLayout(false);
            this.panelTopForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bttnCerrar;
        private System.Windows.Forms.Button bttnDesconectar;
        private System.Windows.Forms.Button bttnRegistrar;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNadie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroDetect;
        private System.Windows.Forms.DataGridView dgvPrueba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}