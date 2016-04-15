using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FW;
namespace DAL
{
    public class Conta
    {
        public void dataService(DTO.Conta conta)
        {
            Banco banco = new Banco();

            banco.dataServiceInsertUpdateDelete("insert into conta(cliente_id, tipo, agencia, saldo) values (?cliente_id, ?tipo, ?agencia, ?saldo)", conta);
        }
    }
}
