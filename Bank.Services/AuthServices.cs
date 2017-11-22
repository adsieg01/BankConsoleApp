using Bank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class AuthServices
    {
        private Bank_AppEntities db = new Bank_AppEntities();


        public bool VerifyAccount(int pin, int accountNum)
        {
            var query = from a in db.Accounts
                        where a.PIN == pin && a.Account_ == accountNum
                        select a;
            foreach (var acc in query)
            {
                System.Console.Clear();
                Console.WriteLine("Welcome to your account.");
                return true;
            }
            System.Console.Clear();
            Console.WriteLine("We can't seem to find your account infomation.\n" +
                "Please call customer service for assistance.");
            return false;
        } 







        //public void login() { 
            
        //    User user = (from u in db.Customers
        //                 where u.FirstName.Equals() &&
        //                 u.LastName.Equals()
        //                 select u).FirstOrDefault();

        //    if (user == null)
        //    {
        //        System.Console.WriteLine("We can't seem to find your account.");
        //    }
        //    else
        //    {
        //        System.Console.WriteLine("Welcome to your account.");
        //    }
            
        //        }
    }
}
