using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    interface ICustomerService
    {
        void Save(Customer customer);
    }
}
