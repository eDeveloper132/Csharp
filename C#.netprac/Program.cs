using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
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
            Console.WriteLine();
            string[] Menu = { 
                             "MuttonBiryani",
                             "ZingerBurger",
                             "Broast",
                             "MuttonRoast",
                             "ChickenChargha",
                             "SpecialAptechShawarma",
                             "OkhaiDaalChawal",
                             "MuttonPulao",
                             "LavaPizzaSpecial" };
            int[] Price = { 300 , 150 , 200 , 500 , 450 , 300 , 100 , 300 , 600 };
            var discount = 20;
            var Note = " Congratulation Your Order was Dispatch, Order Discount When You Order From Application Rupees 20 Your bill is : ";
            string[] OriginalPrice = { 
                                       Note + $"\u001b[1m{Price[0] - discount}\u001b[0m",
                                       Note + $"\u001b[1m{Price[1] - discount}\u001b[0m",
                                       Note + $"\u001b[1m{Price[2] - discount}\u001b[0m",
                                       Note + $"\u001b[1m{Price[3] - discount}\u001b[0m",
                                       Note + $"\u001b[1m{Price[4] - discount}\u001b[0m",
                                       Note + $"\u001b[1m{Price[5] - discount}\u001b[0m",
                                       Note + $"\u001b[1m{Price[6] - discount}\u001b[0m",
                                       Note + $"\u001b[1m{Price[7] - discount}\u001b[0m",
                                       Note + $"\u001b[1m{Price[8] - discount}\u001b[0m" };
            for(int i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Menu[i]}. {Price[i]}");
            }
            Console.WriteLine("Enter What Will You Order From Menu, Order Using Serial Numbers");
            Console.WriteLine();
            int usereat = int.Parse(Console.ReadLine());
            switch(usereat)
            {
                case 1:
                    Console.WriteLine($"{Menu[0]}.{Price[0]}/rs order dispatched");
                    switch (1)
                    {
                        case 1:
                            Console.WriteLine($"{OriginalPrice[0]}");
                        break;
                    }
                break;
                case 2:
                    Console.WriteLine($"{Menu[1]}.{Price[1]}/rs order dispatched");
                    switch (2)
                    {
                        case 2:
                            Console.WriteLine($"{OriginalPrice[1]}");
                        break;
                    }
                break;
                case 3:
                    Console.WriteLine($"{Menu[2]}.{Price[2]}/rs order dispatched");
                    switch (3)
                    {
                        case 3:
                            Console.WriteLine($"{OriginalPrice[2]}");
                        break;
                    }
                break;
                case 4:
                    Console.WriteLine($"{Menu[3]}.{Price[3]}/rs order dispatched");
                    switch (4)
                    {
                        case 4:
                            Console.WriteLine($"{OriginalPrice[3]}");
                        break;
                    }
                break;
                case 5:
                    Console.WriteLine($"{Menu[4]}.{Price[4]}/rs order dispatched");
                    switch (5)
                    {
                        case 5:
                            Console.WriteLine($"{OriginalPrice[4]}");
                        break;
                    }
                break;
                case 6:
                    Console.WriteLine($"{Menu[5]}.{Price[5]}/rs order dispatched");
                    switch (6)
                    {
                        case 6:
                            Console.WriteLine($"{OriginalPrice[5]}");
                        break;
                    }
                break;
                case 7:
                    Console.WriteLine($"{Menu[6]}.{Price[6]}/rs order dispatched");
                    switch (7)
                    {
                        case 7:
                            Console.WriteLine($"{OriginalPrice[6]}");
                        break;
                    }
                break;
                case 8:
                    Console.WriteLine($"{Menu[7]}.{Price[7]}/rs order dispatched");
                    switch (8)
                    {
                        case 8:
                            Console.WriteLine($"{OriginalPrice[7]}");
                        break;
                    }
                break;
                case 9:
                    Console.WriteLine($"{Menu[8]}.{Price[8]}/rs order dispatched");
                    switch (9)
                    {
                        case 9:
                            Console.WriteLine($"{OriginalPrice[8]}");
                        break;
                    }
                break;
                default:
                    Console.WriteLine("Dear User You Entered a Wrong Number Please Select From The Menu");
                break;
            }
//            for(int i = 0; i <= 4; i++)
//            {
//                for (int j = 0; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//            for(int i = 3; i >= 0; i--)
//            {
//                for (int j = 0; j <= i; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
            Console.ReadLine();

        }
        
    }
}
