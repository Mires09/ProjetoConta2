using System;

class Program
{
    static void Main()
    {
        //Criando as contas usando os construtores

        Corrente conta1 = new Corrente("João", "001", 1000, 1000);
        Corrente conta2 = new Corrente("Maria", "002", 2000, 1000);

        Caixinha caixinha1 = new Caixinha("Paulo", "003", 500, 100);
        Caixinha caixinha2 = new Caixinha("Ana", "004", 800, 200);

        //Saldos Iniciais

        Console.WriteLine("--- Saldos Iniciais ---");
        Console.WriteLine();

        conta1.MostrarSaldo();
        Console.WriteLine();

        conta2.MostrarSaldo();
        Console.WriteLine();

        caixinha1.MostrarSaldo();
        Console.WriteLine();

        caixinha1.MostrarSaldo();

        //Saque que funciona

        Console.WriteLine();
        Console.WriteLine("--- Saque ---");
        Console.WriteLine();

        decimal valorSaque = 200;

        if(conta1.Saca(valorSaque))
        {
            Console.WriteLine("Conta: " + conta1.numeroConta);
            Console.WriteLine("Nomea: " + conta1.nomeCliente);
            Console.WriteLine("Valor sacado: R$" + valorSaque);
            Console.WriteLine("Saque realizado com sucesso");
            Console.WriteLine();

            Console.WriteLine("Saldo após saque:");
            conta1.MostrarSaldo();
        }

        else
        {
            Console.WriteLine("Não foi possível realizar o saque!");
        }

        //Saque com erro

        Console.WriteLine();
        Console.WriteLine("--- Saque com erro ---");
        Console.WriteLine();

        decimal saqueErro = 1000;

        if(conta1.Saca(saqueErro))
        {
            Console.WriteLine("Saque realizado com sucesso!");
        }

        else
        {
            Console.WriteLine("Não foi possível realizar o saque! Verifique seu saldo e tente novamente!");
            Console.WriteLine("Saldo insuficiente para sacar R$" + saqueErro);
        }

        Console.WriteLine();
        Console.WriteLine("Saldo da conta:");
        conta1.MostrarSaldo();

        //Transferência que funciona

        Console.WriteLine();
        Console.WriteLine("--- Transferência ---");
        Console.WriteLine();

        decimal valorTransferencia = 300;

        if(conta1.Transfere(valorTransferencia, caixinha1))
        {
            Console.WriteLine("Origem:");
            Console.WriteLine("Nome: " + conta1.nomeCliente);
            Console.WriteLine("Conta: " + conta1.numeroConta);

            Console.WriteLine();

            Console.WriteLine("Destino:");
            Console.WriteLine("Nome: " + caixinha1.nomeCliente);
            Console.WriteLine("Conta: " + caixinha1.numeroConta);

            Console.WriteLine();

            Console.WriteLine("Valor transferido: R$ " + valorTransferencia);
            Console.WriteLine("Transferência realizada com sucesso!");

            Console.WriteLine();

            Console.WriteLine("Saldo da conta de origem:");
            conta1.MostrarSaldo();

            Console.WriteLine();

            Console.WriteLine("Saldo da conta de destino:");
            caixinha1.MostrarSaldo();
        }

        else
        {
            Console.WriteLine("Não foi possível realizar a transferência.");
        }

        //Transferência com erro

        Console.WriteLine();
        Console.WriteLine("--- Transferência com erro ---");
        Console.WriteLine();

        decimal transferenciaErro = 1000;

        if (conta1.Transfere(transferenciaErro, caixinha1))
        {
            Console.WriteLine("Transferência realizada com sucesso!");
        }

        else 
        {
            Console.WriteLine("Não foi possível realizar a transferência!");
            Console.WriteLine("Saldo insuficiente para transferir R$" + transferenciaErro);
        }

        Console.WriteLine();
        Console.WriteLine("Saldo da conta de origem:");
        conta1.MostrarSaldo();

        Console.WriteLine();

        Console.WriteLine("Saldo da conta de destino:");
        caixinha1.MostrarSaldo();

        //Saldos Finais

        Console.WriteLine();
        Console.WriteLine("--- Saldos Finais ---");
        Console.WriteLine();

        conta1.MostrarSaldo();
        Console.WriteLine();

        conta2.MostrarSaldo();
        Console.WriteLine();

        caixinha1.MostrarSaldo();
        Console.WriteLine();

        caixinha2.MostrarSaldo();
    }
}