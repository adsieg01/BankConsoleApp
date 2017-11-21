using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerServices bank = new CustomerServices();
            bank.CreateCustomer("Jack", "Sparrow", 7);
        

        }
    }
}
