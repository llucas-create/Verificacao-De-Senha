using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.AccessControl;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE SUA SENHA");

            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.WriteLine("Senha invalida");
                
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha correta");
            Console.ReadKey();
        }

   
        
        
        
        
        

        
    }
}
