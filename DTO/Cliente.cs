using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cliente
    {
        private int id;
        private String nome;
        private String sobrenome;
        private String email;
        private String cpf;
        private String telefone;
        private String celular;
        private String dataDoNascimento;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public static explicit operator Cliente(DataRow v)
        {
            throw new NotImplementedException();
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }

            set
            {
                sobrenome = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string DataDoNascimento
        {
            get
            {
                return dataDoNascimento;
            }

            set
            {
                dataDoNascimento = value;
            }
        }

        public void teste()
        {
            Console.WriteLine(nome);
            Console.WriteLine(email);
        }

    }
}
