using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BLL
{
    public class ValidaCliente
    {
        
        public void cadastrarCliente(Cliente cliente)
        {
            ClienteDao clienteDao = new ClienteDao();
            clienteDao.dataService(cliente);

        }



        public Cliente localizar(Cliente cliente)
        {

            ClienteDao clienteDao = new ClienteDao();


            DataTable table = clienteDao.dataServiceSelect("select id i, nome n, sobrenome s, email e, cpf c, data_nascimento d, telefone t, celular ce from cliente", cliente.Email);

            Cliente c = new Cliente();
            c.Id = int.Parse(table.Rows[0]["i"].ToString());
            c.Nome = table.Rows[0]["n"].ToString();
            c.Sobrenome = table.Rows[0]["s"].ToString();
            c.Cpf = table.Rows[0]["c"].ToString();
            c.Email = table.Rows[0]["e"].ToString();
            c.DataDoNascimento = table.Rows[0]["d"].ToString();
            c.Telefone = table.Rows[0]["t"].ToString();
            c.Celular = table.Rows[0]["ce"].ToString();

            return c;
        }
    }
}
