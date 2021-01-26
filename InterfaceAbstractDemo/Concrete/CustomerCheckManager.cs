using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public Boolean CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
