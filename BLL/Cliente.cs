using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BLL
{
    public class Cliente
    {

        public int cadastrar(DTO.Cliente cliente)
        {
            DAL.Cliente c = new DAL.Cliente();
           return c.dataService(cliente);

        }

        public DTO.Cliente localizar(DTO.Cliente cliente)
        {
            DAL.Cliente c = new DAL.Cliente();
            if (cliente.Cpf != "")
            {
                return c.localizar(cliente);
            }
            return new DTO.Cliente();
        }

        public int update(DTO.Cliente cliente)
        {
            DAL.Cliente c = new DAL.Cliente();
            return c.update(cliente);
        }

        public DataTable localizarTodo()
        {
            DAL.Cliente c = new DAL.Cliente();
            DataTable table;
            return table = c.localizarTdo();
        }
    }
}
