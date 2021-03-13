using CoffeeShopCustomerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCustomerManager.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to Starbucks dataBase: " + customer.FirstName + " " + customer.LastName);

        }

        public virtual void Save2(Customer customer)
        {
            Console.WriteLine("Saved to Nero dataBase: " + customer.FirstName + " " + customer.LastName);

        }
    }
}
