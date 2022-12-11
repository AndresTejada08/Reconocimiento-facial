
namespace Reconocimiento_facial
{
    partial class FormRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrar));
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnDetectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.imbImagenGuradado = new Emgu.CV.UI.ImageBox();
            this.bttnLimpiar = new System.Windows.Forms.Button();
            this.panelTopForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnCerrar = new System.Windows.Forms.PictureBox();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.bttnDesconectar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumeroDetect = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbImagenGuradado)).BeginInit();
            this.panelTopForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.BackColor = System.Drawing.Color.Black;
            this.bttnAgregar.FlatAppearance.BorderSize = 0;
            this.bttnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregar.ForeColor = System.Drawing.Color.White;
            this.bttnAgregar.Location = new System.Drawing.Point(464, 428);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(120, 40);
            this.bttnAgregar.TabIndex = 29;
            this.bttnAgregar.Text = "AGREGAR";
            this.bttnAgregar.UseVisualStyleBackColor = false;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "NOMBRE COMPLETO:";
            // 
            // bttnDetectar
            // 
            this.bttnDetectar.BackColor = System.Drawing.Color.Black;
            this.bttnDetectar.FlatAppearance.BorderSize = 0;
            this.bttnDetectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDetectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDetectar.ForeColor = System.Drawing.Color.White;
            this.bttnDetectar.Location = new System.Drawing.Point(14, 453);
            this.bttnDetectar.Name = "bttnDetectar";
            this.bttnDetectar.Size = new System.Drawing.Size(173, 40);
            this.bttnDetectar.TabIndex = 172;
            this.bttnDetectar.Text = "DETECTAR";
            this.bttnDetectar.UseVisualStyleBackColor = false;
            this.bttnDetectar.Click += new System.EventHandler(this.bttnDetectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.imbImagenGuradado);
            this.groupBox1.ForeColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Location = new System.Drawing.Point(446, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 407);
            this.groupBox1.TabIndex = 173;
            this.groupBox1.TabStop = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_nombre.Location = new System.Drawing.Point(18, 355);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(284, 22);
            this.txt_nombre.TabIndex = 140;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(7, 345);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(304, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 139;
            this.pictureBox5.TabStop = false;
            // 
            // imbImagenGuradado
            // 
            this.imbImagenGuradado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbImagenGuradado.Location = new System.Drawing.Point(18, 19);
            this.imbImagenGuradado.Name = "imbImagenGuradado";
            this.imbImagenGuradado.Size = new System.Drawing.Size(284, 282);
            this.imbImagenGuradado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imbImagenGuradado.TabIndex = 28;
            this.imbImagenGuradado.TabStop = false;
            // 
            // bttnLimpiar
            // 
            this.bttnLimpiar.BackColor = System.Drawing.Color.Black;
            this.bttnLimpiar.FlatAppearance.BorderSize = 0;
            this.bttnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLimpiar.ForeColor = System.Drawing.Color.White;
            this.bttnLimpiar.Location = new System.Drawing.Point(628, 428);
            this.bttnLimpiar.Name = "bttnLimpiar";
            this.bttnLimpiar.Size = new System.Drawing.Size(120, 40);
            this.bttnLimpiar.TabIndex = 34;
            this.bttnLimpiar.Text = "LIMPIAR";
            this.bttnLimpiar.UseVisualStyleBackColor = false;
            this.bttnLimpiar.Click += new System.EventHandler(this.bttnLimpiar_Click);
            // 
            // panelTopForm
            // 
            this.panelTopForm.BackColor = System.Drawing.Color.Black;
            this.panelTopForm.Controls.Add(this.pictureBox1);
            this.panelTopForm.Controls.Add(this.label4);
            this.panelTopForm.Controls.Add(this.bttnCerrar);
            this.panelTopForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopForm.Location = new System.Drawing.Point(0, 0);
            this.panelTopForm.Name = "panelTopForm";
            this.panelTopForm.Size = new System.Drawing.Size(802, 43);
            this.panelTopForm.TabIndex = 177;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reconocimiento_facial.Properties.Resources.San_Agustin;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(616, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "M A N T E N I M I E N T O    R E C O N O C I M I E N T O    F A C I A L";
            // 
            // bttnCerrar
            // 
            this.bttnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("bttnCerrar.Image")));
            this.bttnCerrar.Location = new System.Drawing.Point(766, 5);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(33, 34);
            this.bttnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnCerrar.TabIndex = 3;
            this.bttnCerrar.TabStop = false;
            this.bttnCerrar.Click += new System.EventHandler(this.bttnCerrar_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(14, 14);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(419, 407);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 171;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // bttnDesconectar
            // 
            this.bttnDesconectar.BackColor = System.Drawing.Color.Black;
            this.bttnDesconectar.FlatAppearance.BorderSize = 0;
            this.bttnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDesconectar.ForeColor = System.Drawing.Color.White;
            this.bttnDesconectar.Location = new System.Drawing.Point(260, 453);
            this.bttnDesconectar.Name = "bttnDesconectar";
            this.bttnDesconectar.Size = new System.Drawing.Size(173, 40);
            this.bttnDesconectar.TabIndex = 176;
            this.bttnDesconectar.Text = "DESCONECTAR";
            this.bttnDesconectar.UseVisualStyleBackColor = false;
            this.bttnDesconectar.Click += new System.EventHandler(this.bttnDesconectar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(212, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 17);
            this.label3.TabIndex = 175;
            this.label3.Text = "ROSTROS DETECTADOS:";
            // 
            // lblNumeroDetect
            // 
            this.lblNumeroDetect.AutoSize = true;
            this.lblNumeroDetect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDetect.ForeColor = System.Drawing.Color.Gray;
            this.lblNumeroDetect.Location = new System.Drawing.Point(414, 428);
            this.lblNumeroDetect.Name = "lblNumeroDetect";
            this.lblNumeroDetect.Size = new System.Drawing.Size(17, 17);
            this.lblNumeroDetect.TabIndex = 174;
            this.lblNumeroDetect.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.imageBoxFrameGrabber);
            this.panel1.Controls.Add(this.bttnDetectar);
            this.panel1.Controls.Add(this.bttnLimpiar);
            this.panel1.Controls.Add(this.lblNumeroDetect);
            this.panel1.Controls.Add(this.bttnAgregar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bttnDesconectar);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 501);
            this.panel1.TabIndex = 178;
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTopForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrar";
            this.Load += new System.EventHandler(this.FormRegistrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbImagenGuradado)).EndInit();
            this.panelTopForm.ResumeLayout(false);
            this.panelTopForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnDetectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Emgu.CV.UI.ImageBox imbImagenGuradado;
        private System.Windows.Forms.Button bttnLimpiar;
        private System.Windows.Forms.Panel panelTopForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox bttnCerrar;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Button bttnDesconectar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumeroDetect;
        private System.Windows.Forms.Panel panel1;
    }
}