using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace Lashes_CRM_WebApp
{
    public static class CustomerDatabase
    {

        public static void LoadCustomerData(String fileName)
        {
            _customers = Utilities.XMLLoad<List<Customer>>(fileName);  
        }

        public static bool SaveCustomerData(string fileName)
        {
           return Utilities.XMLSave<List<Customer>>(fileName, Customers);
        }

        public static bool Save(String fileName)
        {
            return false;
        }

        public static void AddCustomer(Customer c)
        {

            var lastID = 0;
            if (Customers.Count > 0)

                lastID = _customers.Max(s => s.CustomerID);


                c.CustomerID = lastID + 1;
                _customers.Add(c);
         
        
        }

        public static Customer GetCustomer(int ID)
        {
            //  var allCustomers = from customerid in CustomerDatabase.Customers;
            var querAllCustomers = from cust in _customers
                                   where cust.CustomerID == 20
                                   select cust;
            querAllCustomers = _customers;
                                   
            return new Customer();
        }

        private static List<Customer> _customers;

        public static List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        /*      public static List<Customer> FindByName(String name)
               {
                   name = "test";
                   return name;
               } */

    }
}
