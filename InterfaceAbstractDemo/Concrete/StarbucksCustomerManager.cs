using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService CustomerCheckService;
        public override void Save(Customer customer)
        {
            if (CustomerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        

        
    }
}
