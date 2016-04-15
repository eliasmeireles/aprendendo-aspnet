using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW
{
    public class Banco
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=banco_qualquer;Uid=root;Pwd=root;");
        MySqlCommand command;
        public DataTable dataServiceSelect(string sql, object dados)
        {
            command = new MySqlCommand(sql, connection);
            if (dados != null)
            {
                foreach (var item in dados.GetType().GetProperties())
                {
                    command.Parameters.AddWithValue(item.Name, dados.ToString());

                }
            }
            MySqlDataAdapter da = new MySqlDataAdapter(command);


            connection.Open();
            command.ExecuteReader();
            connection.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public object dataServiceSelectScalar(string sql, object dados)
        {
            command = new MySqlCommand(sql, connection);

            if (dados != null)
            {
                foreach (var item in dados.GetType().GetProperties())
                {
                    command.Parameters.AddWithValue(item.Name, dados.ToString());

                }
            }

            connection.Open();
            object resposta = command.ExecuteScalar();
            connection.Close();

            return resposta;
        }

        public void dataService(string sql, object parametros)
        {

            MySqlCommand com = new MySqlCommand(sql, connection);

            foreach (var item in parametros.GetType().GetProperties())
                com.Parameters.AddWithValue(item.Name, item.GetValue(parametros));

            connection.Open();
            com.ExecuteNonQuery();
            connection.Close();

        }


        public int dataServiceInsertUpdateDelete(string sql, object dados)
        {
            command = new MySqlCommand(sql, connection);

            foreach (var item in dados.GetType().GetProperties())
            {
                command.Parameters.AddWithValue(item.Name, item.GetValue(dados));

            }

            connection.Open();
            int resposta = command.ExecuteNonQuery();
            connection.Close();
            return resposta;
        }
    }
}