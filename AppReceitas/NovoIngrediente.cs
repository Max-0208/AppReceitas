using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace AppReceitas
{
    internal class NovoIngrediente
    {
        private int id;
        private string material;
        private float valor;
        private int qtd;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }

        //Metodo de cadastro de ingrediente.
        public bool adicionarIngrediente()
        {
            try
            {
                //abre a conexão com o banco de dados
                MySqlConnection MySqlConexaoDB = new MySqlConnection(ConexaoDB.conexaoDB);
                MySqlConexaoDB.Open();

                //adiciona linha no banco de dados. 
                //insert into é codigo do mysql e os valores estão sendo puxados dos metodos Nome e Ingredientes.
                string insert = $"insert into ingredientes (material,valor,qtd) values ('{Material}'),('{Valor}'),('{Qtd}')";

                //envia o comando insert para o mysql
                MySqlCommand commandSql = MySqlConexaoDB.CreateCommand();
                commandSql.CommandText = insert;

                //executa o comando no MySql
                commandSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método adicionarIngrediente: " + ex.Message);
                return false;
            }
        }
    }
}
