using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppReceitas
{
    internal class novaReceita
    {
        private int id;
        private string nome;
        public string ingredientes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; } 
        }
        public string Ingredientes
        { 
            get { return ingredientes; } 
            set { ingredientes = value; } 
        }
        
        //Cadastro de novas receitas.
        public bool addReceita()
        {
            try
            {
                //abre a conexão com o banco de dados
                MySqlConnection MysqlconexaoDB = new MySqlConnection(ConexaoDB.conexaoDB);
                MysqlconexaoDB.Open();

                //adiciona linha no banco de dados. 
                //insert into é codigo do mysql e os valores estão sendo puxados dos metodos Nome e Ingredientes.
                string insert = $"insert into receitas (nome, ingredientes) value ('{Nome}','{Ingredientes}')";

                //envia o comando insert para o mysql
                MySqlCommand comandoSql = MysqlconexaoDB.CreateCommand();
                comandoSql.CommandText = insert;

                //executa o comando no MySql
                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erro na conexão do banco de dados" + ex.Message);
                return false;
            }
           
        }
    }
}
