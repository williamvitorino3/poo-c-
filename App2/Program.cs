using System;
using conta;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataContext;

namespace App2
{
    class Program
    {
        private static Context _;
        static void Main(string[] args)
        {
            _ = new Context();
            int option;
            do
            {
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    criar();
                }else if(option == 2)
                {
                    Console.WriteLine("Contas Corrente:");
                    foreach (var conta in _.Set<ContaCorrente>())
                        Console.WriteLine(conta.Id);
                    Console.WriteLine();
                    Console.WriteLine("Contas Poupança:");
                    foreach (var conta in _.Set<ContaPoupanca>())
                        Console.WriteLine(conta.Id);
                    Console.WriteLine();
                }
            } while (option != 0);
        }

        static void criar()
        {
            Console.WriteLine(
                "Tipo de Conta:" + "\n" +
                "[ 1 ] - Corrente" + "\n" +
                "[ 2 ] - Poupança"
            );
            int cType = Convert.ToInt32(Console.ReadLine());
            Console.Write("Titular: ");
            string titular = Console.ReadLine();
            DateTime aniversario = DateTime.Now;
            Console.Write("Juros: R$ ");
            double juros = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            if(cType == 1)
            {
                try{
                    ContaCorrente conta = new ContaCorrente(juros, aniversario, titular);
                    _.Set<ContaCorrente>().Add(conta);
                    _.SaveChanges();
                }catch(DbUpdateException e){
                    Console.WriteLine(e.InnerException.Message);
                }
            } else if(cType == 2)
            {
                try{
                    ContaPoupanca conta = new ContaPoupanca(juros, aniversario, titular);
                    _.Set<ContaPoupanca>().Add(conta);
                    _.SaveChanges();
                }catch(DbUpdateException e){
                    Console.WriteLine(e.InnerException.Message);
                }
            }
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
