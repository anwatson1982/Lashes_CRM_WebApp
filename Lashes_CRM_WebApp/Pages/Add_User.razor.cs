using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lashes_CRM_WebApp.Pages
{
    partial class Add_User
    {
        public static void Saving(Customer customer1)
        {
            CustomerDatabase.AddCustomer(customer1);
        }

    }
}

