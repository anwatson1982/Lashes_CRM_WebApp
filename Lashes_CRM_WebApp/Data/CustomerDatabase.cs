﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

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
