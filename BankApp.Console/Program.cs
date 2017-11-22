using Bank.Services;
using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening Screen
                System.Console.WriteLine(FiggleFonts.Standard.Render("Bank of Tomorrow"));
                Thread.Sleep(1000);
                System.Console.WriteLine(FiggleFonts.Standard.Render("Welcome"));
                Thread.Sleep(3000);
                System.Console.WriteLine("Please Press Enter 2X To Begin");
                System.ConsoleKeyInfo keyInfo = System.Console.ReadKey(true);
            
            //Allows user to proceed only after hitting Enter twice
                do
                {
                   keyInfo = System.Console.ReadKey(true);
                    if (keyInfo.Key != ConsoleKey.Enter)
                    {                  
                        System.Console.WriteLine("Please Press Enter 2X To Begin");
                    }
                }
                while (keyInfo.Key != ConsoleKey.Enter);
                System.Console.Clear();

            //Menu of options
                System.Console.WriteLine(FiggleFonts.Standard.Render("ATM"));
                System.Console.WriteLine("\nMain Menu\n" +
                   "1: Login\n" +
                   "2: Create Account\n" +
                   "3: Exit\n"); 
                int inputOpt = Int32.Parse(System.Console.ReadLine());

            //Login
            if(inputOpt == 1) { 
                System.Console.Clear();
                System.Console.WriteLine(FiggleFonts.Standard.Render("ATM"));
                System.Console.WriteLine("Enter name and PIN number");
                //Reference Database to see if user info is vaild
                string userName = System.Console.ReadLine();
                System.Console.WriteLine(userName);
                }


            //Create Account
                //Connect Database

            //Exit
                //Break the application 
            System.Console.ReadLine();



        }
    }
}
