using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controle_bancario
{
    public partial class clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BLL.Cliente validaCliente = new BLL.Cliente();
            BLL.Endereco validaEndereco = new BLL.Endereco();
            DTO.Cliente cliente = new DTO.Cliente();
            DTO.Endereco endereco = new DTO.Endereco();



            GridView1.DataSource = validaCliente.localizarTodo();
        }
    }
}