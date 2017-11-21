using Bank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class CustomerServices
    {
       public bool CreateCustomer(string first, string last, int ID)
        {
            using (var context = new Bank_AppEntities())
            {
                var newUser = new Customer
                {
                    CustomerID = ID,
                    FirstName = first,
                    LastName = last
                };
                context.Customers.Add(newUser);

                return context.SaveChanges() == 1;
            }
        }


    }
}
