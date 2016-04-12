using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DTO;

namespace controle_bancario
{
    public partial class localiza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cadastrar_Click(object sender, EventArgs e)
        {
            ValidaCliente valida = new ValidaCliente();
            Cliente cliente = new Cliente();

            cliente.Email = email.Text;

            cliente = valida.localizar(cliente);

            nome.Text = cliente.Nome;
            sobreNome.Text = cliente.Sobrenome;
            cpf.Text = cliente.Cpf;
            telefone.Text = cliente.Telefone;
            celular.Text = cliente.Celular;
            dataNascimento.Text = cliente.DataDoNascimento;

        }
    }
}