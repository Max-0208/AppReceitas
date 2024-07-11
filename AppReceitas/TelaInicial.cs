namespace AppReceitas
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnAddIngr_Click(object sender, EventArgs e)
        {
            AddIngrediente form2 = new AddIngrediente();
            form2.Show();
            this.Hide();
        }
    }
}
