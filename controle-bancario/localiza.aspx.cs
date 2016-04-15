﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controle_bancario
{
    public partial class localiza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cadastrar_Click(object sender, EventArgs e)
        {
            BLL.Cliente validaCliente = new BLL.Cliente();
            BLL.Endereco validaEndereco = new BLL.Endereco();
            DTO.Cliente cliente = new DTO.Cliente();
            DTO.Endereco endereco = new DTO.Endereco();



            cliente.Cpf = cpf.Text;


            cliente = validaCliente.localizar(cliente);

            limpaaErros();
            if (cliente.Email != null)
            {

                nome.Text = cliente.Nome;
                sobreNome.Text = cliente.Sobrenome;
                cpf.Text = cliente.Cpf;
                telefone.Text = cliente.Telefone;
                email.Text = cliente.Email;
                celular.Text = cliente.Celular;
                dataNascimento.Text = cliente.Data_nascimento.ToShortDateString();

                endereco.Cliente_id = cliente.Id;
                endereco = validaEndereco.localizar(endereco);

                cep.Text = endereco.Cep;
                logradouro.Text = endereco.Logradouro;
                numero.Text = endereco.Numero;
                complemento.Text = endereco.Complemento;
                bairro.Text = endereco.Bairro;
                cidade.Text = endereco.Cidade;
                estado.Text = endereco.Estado;
                pais.Text = endereco.Pais;
            }
            else
            {
                cpfErro.Text = "Cpf invalido ou o cliente não é cadastrado!";
            }
        }
        protected void limpaaErros()
        {
            nome.Text = "";
            sobreNome.Text = "";
            email.Text = "";
            telefone.Text = "";
            celular.Text = "";
            cpfErro.Text = "";
            logradouro.Text = "";
            cep.Text = "";
            pais.Text = "";
            cidade.Text = "";
            numero.Text = "";
            complemento.Text = "";
            estado.Text = "";
        }
    }
}