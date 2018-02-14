using System;
using conta;
using Microsoft.EntityFrameworkCore;

namespace App2
{
    class Program
    {
        DataContext contexto;
        static void Main(string[] args)
        {
            contexto = new DataContext();
            int option;
            do
            {
                option = menu();
                Console.WriteLine(option);
                contexto.Contas.Add();
            } while (option != 0);
        }

        static void criar()
        {
            Console.WriteLine(
                "Tipo de Conta:" + "\n" +
                "[ 1 ] - Corrente" + "\n" +
                "[ 2 ] - Poupança"
            );
            int cType = Console.ReadLine();
                Console.Write("Titular: ");
                string titular = Console.ReadLine();
                DateTime aniversario = DateTime.Now;
                Console.Write("Jutos: R$ ");
                double juros = Convert.ToDouble(Console.ReadLine());
            if(cType == 1)
            {
                ContaCorrente conta = new ContaCorrente(juros, aniversario, titular);
                this.contexto.Set<ContaCorrente>().Add(conta);
            }
            // Conta c = new Conta(Console.ReadLine());
        }

        static int menu() {
            Console.WriteLine(
                "Menu" + "\n" +
                "[ 1 ] - Criar Conta" + "\n" +
                "[ 2 ] - Listar Conta" + "\n" +
                "[ 0 ] - Sair"
            );
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    }
}
