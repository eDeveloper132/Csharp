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

            Console.WriteLine("Enter Your Mail");
            string UserMail = Console.ReadLine();

            Console.WriteLine("Enter Your Address");
            String UserAddress = Console.ReadLine();

            Console.WriteLine("***Ans***");
            Console.WriteLine("User Name is "+ UserName);
            Console.WriteLine("User Age is "+ UserAge);
            Console.WriteLine("User Mail is " + UserMail);
            Console.WriteLine("User Address is"+ UserAddress);
            Console.ReadLine();


        }
    }
}
