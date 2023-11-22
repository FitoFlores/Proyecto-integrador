namespace Inventario_farmacia
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            cmbcategoria = new ComboBox();
            label1 = new Label();
            btnguar = new Button();
            dataGridView1 = new DataGridView();
            txtpre = new TextBox();
            txtcant = new TextBox();
            txtnomb = new TextBox();
            Cant = new Label();
            Prec = new Label();
            Nomb = new Label();
            btn12 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rectangle_61;
            pictureBox1.Location = new Point(222, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Rectangle_57;
            pictureBox2.Location = new Point(359, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(112, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(222, 239);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 99);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(359, 239);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(112, 99);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(291, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 47);
            textBox1.TabIndex = 4;
            textBox1.Text = "Buscar";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.images;
            pictureBox5.Location = new Point(714, 28);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbcategoria);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnguar);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txtpre);
            panel1.Controls.Add(txtcant);
            panel1.Controls.Add(txtnomb);
            panel1.Controls.Add(Cant);
            panel1.Controls.Add(Prec);
            panel1.Controls.Add(Nomb);
            panel1.Location = new Point(553, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 572);
            panel1.TabIndex = 6;
            // 
            // cmbcategoria
            // 
            cmbcategoria.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmbcategoria.FormattingEnabled = true;
            cmbcategoria.Items.AddRange(new object[] { "Pastillas", "Jarabes", "Pomadas" });
            cmbcategoria.Location = new Point(161, 195);
            cmbcategoria.Name = "cmbcategoria";
            cmbcategoria.Size = new Size(201, 38);
            cmbcategoria.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 195);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 10;
            label1.Text = "Categoria";
            label1.Click += label1_Click;
            // 
            // btnguar
            // 
            btnguar.BackColor = Color.LightGray;
            btnguar.BackgroundImageLayout = ImageLayout.Center;
            btnguar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnguar.Location = new Point(18, 289);
            btnguar.Name = "btnguar";
            btnguar.Size = new Size(123, 37);
            btnguar.TabIndex = 9;
            btnguar.Text = "Guardar";
            btnguar.UseVisualStyleBackColor = false;
            btnguar.Click += btnguar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(484, 168);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtpre
            // 
            txtpre.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtpre.Location = new Point(141, 79);
            txtpre.Name = "txtpre";
            txtpre.Size = new Size(221, 36);
            txtpre.TabIndex = 7;
            // 
            // txtcant
            // 
            txtcant.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtcant.Location = new Point(141, 134);
            txtcant.Name = "txtcant";
            txtcant.Size = new Size(221, 36);
            txtcant.TabIndex = 5;
            // 
            // txtnomb
            // 
            txtnomb.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtnomb.Location = new Point(141, 24);
            txtnomb.Name = "txtnomb";
            txtnomb.Size = new Size(221, 36);
            txtnomb.TabIndex = 4;
            // 
            // Cant
            // 
            Cant.AutoSize = true;
            Cant.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Cant.Location = new Point(13, 134);
            Cant.Name = "Cant";
            Cant.Size = new Size(99, 30);
            Cant.TabIndex = 2;
            Cant.Text = "Cantidad";
            // 
            // Prec
            // 
            Prec.AutoSize = true;
            Prec.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Prec.Location = new Point(18, 79);
            Prec.Name = "Prec";
            Prec.Size = new Size(73, 30);
            Prec.TabIndex = 1;
            Prec.Text = "Precio";
            // 
            // Nomb
            // 
            Nomb.AutoSize = true;
            Nomb.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Nomb.Location = new Point(18, 24);
            Nomb.Name = "Nomb";
            Nomb.Size = new Size(94, 30);
            Nomb.TabIndex = 0;
            Nomb.Text = "Nombre";
            // 
            // btn12
            // 
            btn12.BackgroundImage = (Image)resources.GetObject("btn12.BackgroundImage");
            btn12.BackgroundImageLayout = ImageLayout.Stretch;
            btn12.Location = new Point(1036, 22);
            btn12.Name = "btn12";
            btn12.Size = new Size(50, 47);
            btn12.TabIndex = 7;
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += btn12_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2023_11_17_a_las_13_16_50_08067a69;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1119, 659);
            Controls.Add(btn12);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(textBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox textBox1;
        private PictureBox pictureBox5;
        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox txtpre;
        private TextBox txtcant;
        private TextBox txtnomb;
        private Label Cant;
        private Label Prec;
        private Label Nomb;
        private Button btn12;
        private Button btnguar;
        private Label label1;
        private ComboBox cmbcategoria;
    }
}