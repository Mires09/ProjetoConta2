using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Caixinha : Conta
    {
        public decimal lucro;

        //Construtor

        public Caixinha(string nomeCliente, string numeroConta, decimal saldo, decimal lucro) : base(nomeCliente, numeroConta, saldo)
        {
            this.lucro = lucro;
        }
    }
