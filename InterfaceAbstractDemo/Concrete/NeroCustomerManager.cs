using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    class NeroCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService customerCheckService;

        public NeroCustomerManager()
        {
        }

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (customerCheckService.CheckIfRealPerson(customer))
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
