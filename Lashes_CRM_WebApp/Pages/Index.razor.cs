using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lashes_CRM_WebApp.Pages
{
    partial class Index
    {
        protected override void OnAfterRender(bool firstRender)
        {
            try
            {
                //Function to check if XML file exists or not if it does exist load data into customers list if it does not exist create the document
                CustomerDatabase.LoadCustomerData(Configuration.CustomerFileLocation);
                //Function to see if Lash Data config file exists 
                TreatmentDatabase.LoadLashData(Configuration.LashFileLocation, TreatmentDatabase.Treatments);

            }
            catch (Exception e)
            {
                Logger.Log("Intialisation: " + e.Message + e.StackTrace);

            }
            if (firstRender)
            {
                // Do work to load page data and set properties
            }
        }
    }
}
