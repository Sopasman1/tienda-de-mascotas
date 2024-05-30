namespace tienda_de_mascotas
{
    partial class Form1
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
            panel1 = new Panel();
            button5 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            Btncarrito = new Button();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            Formularios = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LawnGreen;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Btncarrito);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 471);
            panel1.TabIndex = 0;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(22, 415);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 1;
            button5.Text = "salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.limpieza1;
            pictureBox3.Location = new Point(3, 310);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.carro_de_la_compra;
            pictureBox5.Location = new Point(-1, 124);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.hueso1;
            pictureBox2.Location = new Point(3, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(46, 310);
            button4.Name = "button4";
            button4.Size = new Size(75, 30);
            button4.TabIndex = 6;
            button4.Text = "Limpieza";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.comida_de_perro;
            pictureBox1.Location = new Point(3, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Btncarrito
            // 
            Btncarrito.FlatStyle = FlatStyle.Popup;
            Btncarrito.ImageAlign = ContentAlignment.TopLeft;
            Btncarrito.Location = new Point(46, 124);
            Btncarrito.Name = "Btncarrito";
            Btncarrito.Size = new Size(75, 30);
            Btncarrito.TabIndex = 1;
            Btncarrito.Text = "Carrito";
            Btncarrito.UseVisualStyleBackColor = true;
            Btncarrito.Click += Btncarrito_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(118, 85);
            panel2.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.veterinary__1_;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(118, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(46, 248);
            button3.Name = "button3";
            button3.Size = new Size(75, 30);
            button3.TabIndex = 3;
            button3.Text = "Juguetes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(46, 188);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 2;
            button2.Text = "Comida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Formularios
            // 
            Formularios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Formularios.Location = new Point(124, 0);
            Formularios.Name = "Formularios";
            Formularios.Size = new Size(844, 471);
            Formularios.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 471);
            Controls.Add(Formularios);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button Btncarrito;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button5;
        private Panel Formularios;
    }
}
