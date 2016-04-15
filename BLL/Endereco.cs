using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BLL
{
    public class Endereco
    {
        public void cadastrar(DTO.Endereco endereco)
        {
            DAL.Endereco e = new DAL.Endereco();
            e.dataService(endereco);
        }
        public DTO.Endereco localizar(DTO.Endereco endereco)
        {
            DAL.Endereco e = new DAL.Endereco();
            return e.localizar(endereco);
        }
        public void updae(DTO.Endereco endereco)
        {
            DAL.Endereco e = new DAL.Endereco();
            e.update(endereco);
        }
        public DataTable localizarTodo(DTO.Cliente cliente)
        {
            DataTable table;
            DAL.Endereco e = new DAL.Endereco();

            return table = e.localizarTodo(cliente);
        }
    }
}
