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
            return $"{CustomerID} - {FullName} - {EmailAddress} - {PhoneNumber}";
        }
    }
}
