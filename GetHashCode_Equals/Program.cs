using System;
using GetHashCode_Equals.Entities;

namespace GetHashCode_Equals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string a = "Johnny";
            string b = "Johnny";
            
            //equals é mais lento (pouco) porém ele é 100% de certeza a resposta
            Console.WriteLine(a.Equals(b));
            
            // mais rapido porém não com 100% de certeza , pode ser que de numero errado
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            
            /*
             melhor forma quando tiver uma lista grande usa o getHashCode e quando achar
             valida novamente com o Equals que olha o valor em si do campo
            */
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--------------------------------------------");
            
            Client ca = new Client{ Name = "Maria", Email = "maria@gmail.com"};
            Client cb = new Client{ Name = "Alex", Email = "alex@gmail.com"};

            Console.WriteLine(ca.Equals(cb));
            Console.WriteLine(ca.GetHashCode());
            Console.WriteLine(cb.GetHashCode());
            
        }
    }
}