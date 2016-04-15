using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;

namespace controle_bancario
{
    public partial class alterar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void atualiza_Click(object sender, EventArgs e)
        {
            limpaaErros();
            DTO.ContaCorrente contaCorrente;
            DTO.ContaPoupanca contaPoupanca;

            DTO.Cliente cliente = new DTO.Cliente();
            DTO.Endereco endereco = new DTO.Endereco();

            cliente.Nome = nome.Text;
            cliente.Sobrenome = sobreNome.Text;
            cliente.Email = email.Text;
            cliente.Cpf = cpf.Text;
            cliente.Celular = celular.Text;
            cliente.Telefone = telefone.Text;

            DateTime loadedDate = DateTime.ParseExact(dataNascimento.Text, "d", null);

            cliente.Data_nascimento = loadedDate.Date;

            endereco.Cep = cep.Text;
            endereco.Logradouro = logradouro.Text;
            endereco.Numero = numero.Text;
            endereco.Complemento = complemento.Text;
            endereco.Bairro = bairro.Text;
            endereco.Cidade = cidade.Text;
            endereco.Estado = estado.Text;
            endereco.Pais = pais.Text;

            efetuaUpadate(cliente, endereco);
            
        }

        private static void efetuaUpadate(DTO.Cliente cliente, DTO.Endereco endereco)
        {
            BLL.Cliente validaCliente = new BLL.Cliente();
            BLL.Endereco validaEndereco = new BLL.Endereco();

            endereco.Cliente_id = validaCliente.update(cliente);
            validaEndereco.updae(endereco);
        }

        protected void limpaaErros()
        {
            nomeErro.Text = "";
            sobrenomeErro.Text = "";
            emailErro.Text = "";
            telefoneErro.Text = "";
            celularErro.Text = "";
            cpfErro.Text = "";
            logradouroErro.Text = "";
            cepErro.Text = "";
            paisErro.Text = "";
            cidadeErro.Text = "";
            numeroErro.Text = "";
            complementoErro.Text = "";
            estadoErro.Text = "";
        }
    }
}