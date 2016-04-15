

using System;
using System.Globalization;
using System.Web.UI.WebControls;

namespace controle_bancario
{
    public partial class cadastro : System.Web.UI.Page
    {

        protected string error = "Por favor preencha o campo";

    protected void Page_Load(object sender, EventArgs e)
        {
            tiposDeConta.Items.Add("Tipo da conta");
            agencia.Items.Add("Agência");

            foreach (DTO.TiposDeConta tipo in Enum.GetValues(typeof(DTO.TiposDeConta)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(DTO.TiposDeConta), tipo), tipo.ToString());
                tiposDeConta.Items.Add(item);
            }
            foreach (DTO.Agencia tipo in Enum.GetValues(typeof(DTO.Agencia)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(DTO.Agencia), tipo), tipo.ToString());
                agencia.Items.Add(item);
            }
        }

        protected void cadastrar_Click(object sender, EventArgs e)
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




            if ((DTO.TiposDeConta)Enum.Parse(typeof(DTO.TiposDeConta), tiposDeConta.SelectedValue) == DTO.TiposDeConta.Corrente)
            {
                contaCorrente = new DTO.ContaCorrente();
                contaCorrente.Tipo = (DTO.TiposDeConta)Enum.Parse(typeof(DTO.TiposDeConta), tiposDeConta.SelectedValue);
                contaCorrente.Saldo = decimal.Parse(saldoDeEntrada.Text);
                contaCorrente.Cliente_id = cliente.Id;

                if (agencia.SelectedIndex != 0)
                {
                    contaCorrente.Agencia = (DTO.Agencia)Enum.Parse(typeof(DTO.Agencia), agencia.SelectedValue);
                    efetuaCadastro(cliente, endereco, contaCorrente);
                }
                else
                {
                    agenciaErro.Text = error;
                }
            }
            else
            {
                contaPoupanca = new DTO.ContaPoupanca();
                contaPoupanca.Tipo = (DTO.TiposDeConta)Enum.Parse(typeof(DTO.TiposDeConta), tiposDeConta.SelectedValue);
                contaPoupanca.Saldo = decimal.Parse(saldoDeEntrada.Text);
                contaPoupanca.Cliente_id = cliente.Id;
                if (agencia.SelectedIndex != 0)
                {
                    contaPoupanca.Agencia = (DTO.Agencia)Enum.Parse(typeof(DTO.Agencia), agencia.SelectedValue);
                    efetuaCadastro(cliente, endereco, contaPoupanca);

                }
                else
                {
                    agenciaErro.Text = error;
                }
            }
        }


        private static void efetuaCadastro(DTO.Cliente cliente, DTO.Endereco endereco, DTO.Conta conta)
        {
            BLL.Cliente validaCliente = new BLL.Cliente();
            BLL.Conta validaConta = new BLL.Conta();
            BLL.Endereco validaEndereco = new BLL.Endereco();

            endereco.Cliente_id = validaCliente.cadastrar(cliente);
            validaEndereco.cadastrar(endereco);

            conta.Cliente_id = endereco.Cliente_id;
            validaConta.cadastrar(conta);

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
            saldoErro.Text = "";
            contaTipoErro.Text = "";
            agenciaErro.Text = "";
        }
    }
}