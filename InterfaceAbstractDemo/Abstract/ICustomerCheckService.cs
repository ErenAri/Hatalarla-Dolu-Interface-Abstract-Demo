using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    interface ICustomerCheckService
    {
        Boolean CheckIfRealPerson(Customer customer);
    }
}
