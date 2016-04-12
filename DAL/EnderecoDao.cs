using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class EnderecoDao
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=banco_qualquer;Uid=root;Pwd=root;");
        public void dataService(Endereco endereco, Cliente cliente)
        {
            string sql = "insert into endereco(cep, logradouro, numero, complemento, bairro, cidade, estado, pais, cliente_id) values"
                    + "(?oCep, ?oLogradouro, ?oNumero, ?oComplemento, ?oBairro, ?oCidade, ?oEstado, ?oPais, ?oCliente_id)";
            MySqlCommand command = new MySqlCommand(sql, connection);


            command.Parameters.AddWithValue("oCep", endereco.Cep);
            command.Parameters.AddWithValue("oLogradouro", endereco.Logradouro);
            command.Parameters.AddWithValue("oNumero", endereco.Numero);
            command.Parameters.AddWithValue("oComplemento", endereco.Complemento);
            command.Parameters.AddWithValue("oBairro", endereco.Bairro);
            command.Parameters.AddWithValue("oCidade", endereco.Ciadade);
            command.Parameters.AddWithValue("oEstado", endereco.Estado);
            command.Parameters.AddWithValue("oPais", endereco.Pais);
            command.Parameters.AddWithValue("oCliente_id", cliente.Id);


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable dataServiceSelect(String sql, object endereco)
        {
            MySqlCommand com = new MySqlCommand(sql, connection);

            foreach (var item in endereco.GetType().GetProperties())
            {
                com.Parameters.AddWithValue(item.Name, endereco.ToString());

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
