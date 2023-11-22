namespace Inventario_farmacia
{
    partial class iniciosecion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iniciosecion));
            panel1 = new Panel();
            btnregistro = new Button();
            btnacceso = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtclave = new TextBox();
            txtnombre = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btnregistro);
            panel1.Controls.Add(btnacceso);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtclave);
            panel1.Controls.Add(txtnombre);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(102, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 526);
            panel1.TabIndex = 0;
            // 
            // btnregistro
            // 
            btnregistro.BackColor = Color.LightSteelBlue;
            btnregistro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnregistro.Location = new Point(263, 340);
            btnregistro.Name = "btnregistro";
            btnregistro.Size = new Size(126, 52);
            btnregistro.TabIndex = 6;
            btnregistro.Text = "Registro";
            btnregistro.UseVisualStyleBackColor = false;
            btnregistro.Click += btnregistro_Click;
            // 
            // btnacceso
            // 
            btnacceso.AccessibleName = "";
            btnacceso.BackColor = Color.LightSteelBlue;
            btnacceso.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnacceso.Location = new Point(72, 340);
            btnacceso.Name = "btnacceso";
            btnacceso.Size = new Size(126, 52);
            btnacceso.TabIndex = 5;
            btnacceso.Text = "Acceso";
            btnacceso.UseVisualStyleBackColor = false;
            btnacceso.Click += btnguardar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 207);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // txtclave
            // 
            txtclave.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtclave.Location = new Point(72, 207);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(377, 41);
            txtclave.TabIndex = 2;
            txtclave.Text = "Contraseña";
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.White;
            txtnombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombre.Location = new Point(72, 125);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(377, 41);
            txtnombre.TabIndex = 1;
            txtnombre.Text = "Nombre";
            txtnombre.TextChanged += textBox1_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(455, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 526);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(449, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 46);
            label1.TabIndex = 7;
            label1.Text = "Inicio de sesion";
            // 
            // iniciosecion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 659);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "iniciosecion";
            Text = "Inicio de sesion";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtclave;
        private TextBox txtnombre;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnregistro;
        private Label label1;
        public Button btnacceso;
    }
}