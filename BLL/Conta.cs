using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Conta
    {
        public void cadastrar(DTO.Conta conta)
        {
            DAL.Conta c = new DAL.Conta();
            c.dataService(conta);

        }
    }
}
