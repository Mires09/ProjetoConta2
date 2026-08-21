using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Conta
{
    public string nomeCliente;
    public string numeroConta;
    private decimal saldo;

    //Construtor

    public Conta(string nomeCliente, string numeroConta, decimal saldo)
    {
        this.nomeCliente = nomeCliente;
        this.numeroConta = numeroConta;
        this.saldo = saldo;
    }

    public bool Saca(decimal valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;

            return true;
        }

        else
        {
            Console.WriteLine("Você não possui saldo suficiente para saque!");
            return false;
        }
    }

    public void Deposita(decimal valor)
    {
        saldo += valor;
    }

    public void MostrarSaldo()
    {
        Console.WriteLine("Nome: " + nomeCliente);
        Console.WriteLine("Númeroe: " + numeroConta);
        Console.WriteLine("Saldo: " + saldo);
    }
    public bool Transfere(decimal valor, Conta conta)
    {
        if (Saca(valor))
        {
            conta.Deposita(valor);
            return true;
        }
        return false;
    }
}