using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppReceitas
{
    public partial class AddIngrediente : Form
    {
        public AddIngrediente()
        {
            InitializeComponent();
        }

        private void bntAddIngr_Click(object sender, EventArgs e)
        {

            try
            {
                if (!txtMaterial.Text.Equals("") && !txtQtd.Text.Equals("") && !txtValor.Text.Equals(""))
                {
                    int qtd = int.Parse(txtQtd.Text);
                    float valor = float.Parse(txtValor.Text);
                    NovoIngrediente addIngrediente = new NovoIngrediente();
                    addIngrediente.Material = txtMaterial.Text;
                    addIngrediente.Valor = valor;
                    addIngrediente.Qtd = qtd;

                    if (addIngrediente.adicionarIngrediente())
                    {
                        MessageBox.Show($"O ingrediente {addIngrediente.Material} foi cadastrado com sucesso!");
                        txtMaterial.Clear();
                        txtValor.Clear();
                        txtQtd.Clear();
                        txtMaterial.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel adicionar o ingrediente");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente");
                    txtMaterial.Clear();
                    txtValor.Clear();
                    txtQtd.Clear();
                    txtMaterial.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar ingrediente: " + ex.Message);
            }
        }

        private void bntVoltarMenu_Click(object sender, EventArgs e)
        {
            TelaInicial form1 = new TelaInicial();
            form1.Show();
            this.Close();
        }
    }
}
