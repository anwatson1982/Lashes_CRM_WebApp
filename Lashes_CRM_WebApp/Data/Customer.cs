using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Lashes_CRM_WebApp
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }

        public string LashType;
        public List<string> LashSize;
    //    public Dictionary<string, bool> LashSizeDict = new Dictionary<string, bool>();
        public string TreatmentType;
        public bool ActiveUser = true;
        private bool _subscriberList = true;


        //   [XmlIgnore]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        //   public bool SubscriberList { get => _subscriberList; set => _subscriberList = value; }

        //   public Customer()
        //   {
        //       date = DateTime.Now;
        //  }

        public override string ToString()
        {
            //LashSizeDict.Add("0.1", false);

            //foreach(var e in LashSizeDict)
            //{
            //    // => e.Key (title of checkbox)
            //    //e.Value (checkbox active)
            //}

            //LashSizeDict["0.1mm"] = false;

            //if(LashSizeDict.ContainsKey("0.1"))
            //{

            //}

            return $"{CustomerID} - {FullName} - {EmailAddress} - {PhoneNumber}";
        }
    }
}
