namespace AppReceitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtReceita.Text.Equals("") && !txtIngr.Text.Equals(""))
                {
                    novaReceita novaReceita = new novaReceita();
                    novaReceita.Nome = txtReceita.Text;
                    novaReceita.Ingredientes = txtIngr.Text;

                    if (novaReceita.addReceita())
                    {
                        MessageBox.Show($"A receita {novaReceita.Nome} foi adicionada com sucesso!");
                        txtReceita.Clear();
                        txtIngr.Clear();
                        txtReceita.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Não foi possivel adicionar a receita");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Não foi possivel adicionar"+ex.Message);
            }

        }
    }
}
