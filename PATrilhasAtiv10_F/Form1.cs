namespace PATrilhasAtiv10_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {


            lblSucesso.Visible = false;
            lblErro.Visible = false;

            if (String.IsNullOrWhiteSpace(textBox1.Text))

            {
                lblErro.Text = "Erro! A caixa de texto est� vazia.";
                lblErro.Visible = true;
            }
            else
            {
                lblSucesso.Text = "Sucesso! A caixa de Texto est� Preenchida.";
                lblSucesso.Visible = true;
            }
        }

        private void lblErro_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
