using System;
using conta;

namespace App
{
    class Cliente
    {
        public string Nome {get; set;}
        
        public Cliente(string nome)
        {
            this.Nome = nome;
        }
    }
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Work");
        } 
    }
}
