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
    public class Cliente
    {
        public int dataService(DTO.Cliente cliente)
        {
            Banco banco = new Banco();

            string sql = "insert into cliente(nome, sobrenome, email, cpf, data_nascimento, telefone, celular) values"
                    + "(?nome, ?sobrenome, ?email, ?cpf, ?data_nascimento, ?telefone, ?celular)";

            banco.dataServiceInsertUpdateDelete(sql, cliente);

            banco = new Banco();

            cliente.Id = Convert.ToInt32(banco.dataServiceSelectScalar("select max(id) from cliente", null));

            return cliente.Id;

        }

        public int update(DTO.Cliente cliente)
        {
            Banco banco = new Banco();

            string sql = "update cliente set nome = ?nome, sobrenome = ?sobrenome, email = ?email, cpf = ?cpf, data_nascimento = ?data_nascimento, "
                + "telefone = ?telefone, celular = ?celular where cpf = ?cpf";

            banco.dataServiceInsertUpdateDelete(sql, cliente);

            banco = new Banco();

            cliente.Id = Convert.ToInt32(banco.dataServiceSelectScalar("select max(id) from cliente", null));

            return cliente.Id;

        }


        public DTO.Cliente localizar(DTO.Cliente cliente)
        {

            Banco banco = new Banco();

            string sql = "select id i, nome n, sobrenome s, email e, cpf c, data_nascimento d, "
                + "telefone t, celular ce from cliente";

            DataTable table = banco.dataServiceSelect(sql, cliente);

            DTO.Cliente c = new DTO.Cliente();

            c.Id = int.Parse(table.Rows[0]["i"].ToString());
            c.Nome = table.Rows[0]["n"].ToString();
            c.Sobrenome = table.Rows[0]["s"].ToString();
            c.Cpf = table.Rows[0]["c"].ToString();
            c.Email = table.Rows[0]["e"].ToString();
            c.Data_nascimento = DateTime.Parse(table.Rows[0]["d"].ToString());
            c.Telefone = table.Rows[0]["t"].ToString();
            c.Celular = table.Rows[0]["ce"].ToString();

            return c;
        }

        public DataTable localizarTdo()
        {

            Banco banco = new Banco();

            string sql = "select id i, nome n, sobrenome s, email e, cpf c, data_nascimento d, "
                + "telefone t, celular ce from cliente";

            DataTable table = banco.dataServiceSelect(sql, null);

            return table;
        }

    }
}
