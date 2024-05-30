namespace tienda_de_mascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Abrirform(object formcarrito)
        {
            if (this.Formularios.Controls.Count > 0)
                this.Formularios.Controls.RemoveAt(0);
            Form carrio = formcarrito as Form;
            carrio.TopLevel = false;
            carrio.Dock = DockStyle.Fill;
            this.Formularios.Controls.Add(carrio);
            this.Formularios.Tag = carrio;
            carrio.Show();
        }

        private void Btncarrito_Click(object sender, EventArgs e)
        {
            Abrirform(new carrito());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abrirform(new comida());
        }
    }
}
