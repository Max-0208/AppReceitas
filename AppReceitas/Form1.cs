namespace AppReceitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                const string servidor = "Local instance MySQL80";
                const string db = "dbReceitas";
                const string usuario = "root";
                const string senha = "123456";

                string conexaoBD = $"server={servidor}; user id={usuario}; database={db}; password={senha}";

                lbl1.Text = "conexão ok";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro"+ex.Message);
            }
        }
    }
}
