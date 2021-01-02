using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lashes_CRM_WebApp.Pages
{
    partial class Add_User
    {
        public static bool Intialize()
        {
            try
            {
                //Function to check if XML file exists or not if it does exist load data into customers list if it does not exist create the document
                CustomerDatabase.LoadCustomerData(Configuration.CustomerFileLocation);
                //Function to see if Lash Data config file exists 
                TreatmentDatabase.LoadLashData(Configuration.LashFileLocation, TreatmentDatabase.Treatments);
                return true;
            }
            catch (Exception e)
            {
                Logger.Log("Intialisation: " + e.Message + e.StackTrace);
                return false;
            }
        }

        public static void Saving(Customer customer1)
        {


            CustomerDatabase.AddCustomer(customer1);


        }
        protected override void OnAfterRender(bool firstRender)
        {
            // execute conditionally for loading data, otherwise this will load
            // every time the page refreshes
            if (firstRender)
            {
                // Do work to load page data and set properties
            }
        }

    }
}

