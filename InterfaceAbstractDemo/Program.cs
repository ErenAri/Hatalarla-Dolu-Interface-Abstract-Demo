using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer
            {
                DateOfBirth = new DateTime(2004, 04, 07),
                FirstName = "Eren",
                LastName = "Arı",
                Id = 1,
                NationalyId = "12345678900"
            });
            Console.ReadLine();
        }

    }
}
