using Bank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    class AuthServices
    {
        void login() {

            var db = new Bank_AppEntities();

            User user = (from u in db.Customers
                         where u.FirstName.Equals(firstname) &&
                         u.LastName.Equals(lastname) &&
                         from p in db.Accounts
                         where p.PIN.Equals(pin)
                         select p).FirstOrDefault();

            if (user == null)
            {
                //Invalid 
            }
            else
            {
                // Success
            }
            
                }
    }
}
