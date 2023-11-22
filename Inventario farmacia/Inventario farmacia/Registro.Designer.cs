namespace Inventario_farmacia
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            txtna = new TextBox();
            txtusuario = new TextBox();
            txtedad = new TextBox();
            txtcontra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            btnregistrar = new Button();
            SuspendLayout();
            // 
            // txtna
            // 
            txtna.BackColor = Color.White;
            txtna.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtna.Location = new Point(45, 183);
            txtna.Name = "txtna";
            txtna.Size = new Size(428, 47);
            txtna.TabIndex = 0;
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtusuario.Location = new Point(45, 361);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(428, 47);
            txtusuario.TabIndex = 1;
            // 
            // txtedad
            // 
            txtedad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtedad.Location = new Point(819, 361);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(125, 47);
            txtedad.TabIndex = 2;
            txtedad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtcontra
            // 
            txtcontra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtcontra.Location = new Point(45, 518);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(428, 47);
            txtcontra.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(408, 32);
            label1.Name = "label1";
            label1.Size = new Size(386, 46);
            label1.TabIndex = 4;
            label1.Text = "Registro de trabajadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 136);
            label2.Name = "label2";
            label2.Size = new Size(234, 35);
            label2.TabIndex = 5;
            label2.Text = "Nombre y apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(138, 312);
            label3.Name = "label3";
            label3.Size = new Size(100, 35);
            label3.TabIndex = 6;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(118, 467);
            label4.Name = "label4";
            label4.Size = new Size(140, 35);
            label4.TabIndex = 7;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(842, 312);
            label5.Name = "label5";
            label5.Size = new Size(71, 35);
            label5.TabIndex = 8;
            label5.Text = "Edad";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(819, 183);
            button1.Name = "button1";
            button1.Size = new Size(61, 56);
            button1.TabIndex = 9;
            button1.Text = "M";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(886, 183);
            button2.Name = "button2";
            button2.Size = new Size(61, 56);
            button2.TabIndex = 10;
            button2.Text = "F";
            button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(846, 136);
            label6.Name = "label6";
            label6.Size = new Size(67, 35);
            label6.TabIndex = 11;
            label6.Text = "Sexo";
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = Color.LightSteelBlue;
            btnregistrar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnregistrar.ForeColor = Color.Black;
            btnregistrar.Location = new Point(544, 571);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(143, 58);
            btnregistrar.TabIndex = 12;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1151, 680);
            Controls.Add(btnregistrar);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtcontra);
            Controls.Add(txtedad);
            Controls.Add(txtusuario);
            Controls.Add(txtna);
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtna;
        private TextBox txtusuario;
        private TextBox txtedad;
        private TextBox txtcontra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label6;
        private Button btnregistrar;
    }
}