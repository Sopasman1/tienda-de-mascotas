namespace tienda_de_mascotas
{
    partial class carrito
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
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LawnGreen;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 56);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(14, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 45);
            panel2.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.Image = Properties.Resources.carro_de_la_compra;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(342, 4);
            label3.Name = "label3";
            label3.Size = new Size(120, 45);
            label3.TabIndex = 6;
            label3.Text = "Carrito";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(127, 37);
            label1.TabIndex = 1;
            label1.Text = "Articulos";
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 243);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(105, 30);
            button1.TabIndex = 5;
            button1.Text = "Comprar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(listView1);
            panel3.Location = new Point(12, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 243);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Location = new Point(109, 389);
            panel4.Name = "panel4";
            panel4.Size = new Size(120, 23);
            panel4.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Location = new Point(683, 381);
            panel5.Name = "panel5";
            panel5.Size = new Size(105, 30);
            panel5.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(713, 73);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // button3
            // 
            button3.Location = new Point(6, 389);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = " Total=";
            button3.UseVisualStyleBackColor = true;
            // 
            // carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "carrito";
            Text = "carrito";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox5;
        private Label label1;
        private ListView listView1;
        private Label label3;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Button button2;
        private Button button3;
    }
}