using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controle_bancario
{
    public partial class cadastro : System.Web.UI.Page
    {

        protected string error = "Por favor preencha o campo ";

    protected void Page_Load(object sender, EventArgs e)
        {
            foreach (TiposDeConta tipo in Enum.GetValues(typeof(TiposDeConta)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(TiposDeConta), tipo), tipo.ToString());
                tiposDeConta.Items.Add(item);
            }
        }

        protected void cadastrar_Click(object sender, EventArgs e)
        {
            ContaCorrente contaCorrente;
            ContaPoupanca contaPoupanca;
            Cliente cliente = new Cliente();
            Endereco endereco = new Endereco();

            cliente.Nome = nome.Text;
            cliente.Sobrenome = sobreNome.Text;
            cliente.Email = email.Text;
            cliente.Cpf = cpf.Text;
            cliente.Celular = celular.Text;
            cliente.Telefone = telefone.Text;
            cliente.DataDoNascimento = dataNascimento.Text;

            endereco.Cep = cep.Text;
            endereco.Logradouro = logradouro.Text;
            endereco.Numero = numero.Text;
            endereco.Cliente = cliente;
            endereco.Complemento = complemento.Text;
            endereco.Bairro = bairro.Text;
            endereco.Ciadade = cidade.Text;
            endereco.Estado = estado.Text;
            endereco.Pais = pais.Text;

            if ((TiposDeConta)Enum.Parse(typeof(TiposDeConta), tiposDeConta.SelectedValue) == TiposDeConta.Corrente)
            {
                contaCorrente = new ContaCorrente();
                contaCorrente.Tipo = (TiposDeConta)Enum.Parse(typeof(TiposDeConta), tiposDeConta.SelectedValue);
                contaCorrente.Saldo = decimal.Parse(saldoDeEntrada.Text);
                contaCorrente.Cliente = cliente;
            }
            else
            {
                contaPoupanca = new ContaPoupanca();
                contaPoupanca.Tipo = (TiposDeConta)Enum.Parse(typeof(TiposDeConta), tiposDeConta.SelectedValue);
                contaPoupanca.Saldo = decimal.Parse(saldoDeEntrada.Text);
                contaPoupanca.Cliente = cliente;
            }
            ValidaCliente validaCliente = new ValidaCliente();
            ValidaEndereco validaEndereco = new BLL.ValidaEndereco();

            validaCliente.cadastrarCliente(cliente);
            validaEndereco.cadastrarEndereco(endereco, cliente);



        }

        protected void limpaaErros()
        {
            nomeErro.Text = "";
            sobrenomeErro.Text = "";
            emailErro.Text = "";
            telefoneErro.Text = "";
            celularErro.Text = "";
            dataNascimento.Text = "";
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