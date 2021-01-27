using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CustomerCheckManager:ICustomerCheckManager
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
