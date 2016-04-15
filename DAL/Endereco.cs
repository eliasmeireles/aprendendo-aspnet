using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using FW;

namespace DAL
{
    public class Endereco
    {
        public void dataService(DTO.Endereco endereco)
        {
            Banco banco = new Banco();
            banco.dataServiceInsertUpdateDelete("insert into endereco(cep, logradouro, numero, complemento, bairro, cidade, estado, pais, cliente_id) values"
                    + "(?cep, ?logradouro, ?numero, ?complemento, ?bairro, ?cidade, ?estado, ?pais, ?cliente_id)", endereco);
        }


        public void update(DTO.Endereco endereco)
        {
            Banco banco = new Banco();
            banco.dataServiceInsertUpdateDelete("update endereco set cep = ?cep, logradouro = ?logradouro, numero =?numero, "
                + "complemento = ?complemento, bairro = ?bairro, cidade = ?cidade, estado = ?estado, pais = ?pais where cliente_id = ?cliente_id ", endereco);
        }

        public DTO.Endereco localizar(DTO.Cliente cliente)
        {

            Banco banco = new Banco();

            string sql = "select cep ce, logradouro lo, numero nu, complemento co, bairro ba, cidade ci, estado es, pais pa from endereco en where en.cliente_id = 3";

            DataTable table = banco.dataServiceSelect(sql, cliente);

            DTO.Endereco endereco = new DTO.Endereco();

            endereco.Cep = table.Rows[0]["ce"].ToString();
            endereco.Logradouro = table.Rows[0]["lo"].ToString();
            endereco.Numero = table.Rows[0]["nu"].ToString();
            endereco.Complemento = table.Rows[0]["co"].ToString();
            endereco.Bairro = table.Rows[0]["ba"].ToString();
            endereco.Cidade = table.Rows[0]["ci"].ToString();
            endereco.Estado = table.Rows[0]["es"].ToString();
            endereco.Pais = table.Rows[0]["pa"].ToString();

            return endereco;
        }

        public DataTable localizarTodo(DTO.Cliente cliente)
        {

            Banco banco = new Banco();

            string sql = "select cep ce, logradouro lo, numero nu, complemento co, bairro ba, cidade ci, estado es, pais pa from endereco";

            DataTable table = banco.dataServiceSelect(sql, null);

            //List<DTO.Endereco> enderecos = new List<DTO.Endereco>();

            //foreach (var item in table.Rows)
            //{

            //    DTO.Endereco endereco = new DTO.Endereco();

            //    endereco.Cep = table.Rows[iten]["ce"].ToString();
            //    endereco.Logradouro = table.Rows[0]["lo"].ToString();
            //    endereco.Numero = table.Rows[0]["nu"].ToString();
            //    endereco.Complemento = table.Rows[0]["co"].ToString();
            //    endereco.Bairro = table.Rows[0]["ba"].ToString();
            //    endereco.Cidade = table.Rows[0]["ci"].ToString();
            //    endereco.Estado = table.Rows[0]["es"].ToString();
            //    endereco.Pais = table.Rows[0]["pa"].ToString();

            //    enderecos.Add(endereco);
            //}


            return table;
        }

    }
}
