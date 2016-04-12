using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class ClienteDao
    {

        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=banco_qualquer;Uid=root;Pwd=root;");
        public void dataService(Cliente cliente)
        {
            string sql = "insert into cliente(nome, sobrenome, email, cpf, data_nascimento, telefone, celular) values"
                    + "(?cNome, ?sobrenome, ?cEmail, ?cCpf, ?cData_nascimento, ?cTelefone, ?cCelular)";
            MySqlCommand command = new MySqlCommand(sql, connection);


                command.Parameters.AddWithValue("cNome", cliente.Nome);
                command.Parameters.AddWithValue("sobrenome", cliente.Sobrenome);
                command.Parameters.AddWithValue("cEmail", cliente.Email);
                command.Parameters.AddWithValue("cCpf", cliente.Cpf);
                command.Parameters.AddWithValue("cData_nascimento", cliente.DataDoNascimento);
                command.Parameters.AddWithValue("cTelefone", cliente.Telefone);
                command.Parameters.AddWithValue("cCelular", cliente.Celular);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
        }
         public DataTable dataServiceSelect(String sql, object cliente)
        {
            MySqlCommand com = new MySqlCommand(sql, connection);

            foreach (var item in cliente.GetType().GetProperties())
            {
                com.Parameters.AddWithValue(item.Name, cliente.ToString());

            }
            MySqlDataAdapter da = new MySqlDataAdapter(com);


            connection.Open();
            com.ExecuteReader();
            connection.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
