using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DAL;
using DTO;

namespace BLL
{
    public class ValidaEndereco
    {
        public void cadastrarEndereco(Endereco endereco, Cliente cliente) 
        {
            ValidaCliente validaCliente = new ValidaCliente();
            cliente = validaCliente.localizar(cliente);


            EnderecoDao enderecoDao = new EnderecoDao();
            enderecoDao.dataService(endereco, cliente);
        }
    }
}
