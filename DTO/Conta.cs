using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class Conta
    {
        protected int id;
        protected int cliente_id;
        protected Agencia agencia;
        protected decimal saldo;
        protected TiposDeConta tipo;

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


        public decimal Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public TiposDeConta Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public int Cliente_id
        {
            get
            {
                return cliente_id;
            }

            set
            {
                cliente_id = value;
            }
        }

        public Agencia Agencia
        {
            get
            {
                return agencia;
            }

            set
            {
                agencia = value;
            }
        }
    }
}
