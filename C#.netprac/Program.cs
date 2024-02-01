using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.netprac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Enter Your Name");
            string UserName = Console.ReadLine();

            Console.WriteLine("Enter Your Age");
            int UserAge = int.Parse(Console.ReadLine());

            Console.WriteLine("***Ans***");
            Console.WriteLine("User Name is ");
            Console.WriteLine(UserName);
            Console.WriteLine("User Age is ");
            Console.WriteLine(UserAge);
            Console.ReadLine();


        }
    }
}
