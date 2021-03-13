using CoffeeShopCustomerManager.Abstract;
using CoffeeShopCustomerManager.Adapter;
using CoffeeShopCustomerManager.Concrete;
using CoffeeShopCustomerManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCustomerManager
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2000,10,17), FirstName = "Yasin", LastName = "Çetin", NationalityId = "49561131730" });
            Console.ReadLine();
        }
    }
}
