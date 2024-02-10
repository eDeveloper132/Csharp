using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace C_.netprac
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Enter Your Name");
            //string UserName = Console.ReadLine();

            //Console.WriteLine("Enter Your Age");
            //int UserAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Your Mail");
            //string UserMail = Console.ReadLine();

            //Console.WriteLine("Enter Your Address");
            //String UserAddress = Console.ReadLine();

            //Console.WriteLine("***Ans***");

            //Console.WriteLine("User Name is "+ UserName);
            //Console.WriteLine("User Age is "+ UserAge);
            //Console.WriteLine("User Mail is " + UserMail);
            //Console.WriteLine("User Address is "+ UserAddress);
            //Console.ReadLine();

            //Fast Food Menu
            Console.WriteLine("*****" + "Assalam u Alaikum" + "*****");
            Console.WriteLine("*****" + "Welcome To Our Aptech Organization Restaurant" + "*****");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Restaurant Menu is :");
            string[] Menu = { "MuttonBiryani", "ZingerBurger", "Broast", "MuttonRoast", "ChickenChargha", "SpecialAptechShawarma", "OkhaiDaalChawal", "MuttonPulao", "LavaPizzaSpecial" };
            int[] Price = { 300 , 150 , 200 , 500 , 450 , 300 , 100 , 300 , 600 };
            for (int i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Menu[i]}. {Price[i]}");
            }
            Console.WriteLine("Enter What Will You Eat From Menu's Serial Number");
            int usereat = int.Parse(Console.ReadLine());

            switch(usereat)
            {
                case 1:
                    Console.WriteLine($"{Menu[0]}.{Price[0]}/rs order dispatched");
                break;
                case 2:
                    Console.WriteLine($"{Menu[1]}.{Price[1]}/rs order dispatched");
                break;
                case 3:
                    Console.WriteLine($"{Menu[2]}.{Price[2]}/rs order dispatched");
                break;
                case 4:
                    Console.WriteLine($"{Menu[3]}.{Price[3]}/rs order dispatched");
                break;
                case 5:
                    Console.WriteLine($"{Menu[4]}.{Price[4]}/rs order dispatched");
                break;
                case 6:
                    Console.WriteLine($"{Menu[5]}.{Price[5]}/rs order dispatched");
                break;
                case 7:
                    Console.WriteLine($"{Menu[6]}.{Price[6]}/rs order dispatched");
                break;
                case 8:
                    Console.WriteLine($"{Menu[7]}.{Price[7]}/rs order dispatched");
                break;
                case 9:
                    Console.WriteLine($"{Menu[8]}.{Price[8]}/rs order dispatched");
                break;
                default:
                    Console.WriteLine("Dear User You Entered a Wrong Number Please Select From The Menu");
                break;
            }
            Console.ReadLine();

        }
        
    }
}
