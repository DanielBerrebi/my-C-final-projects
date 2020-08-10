using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Company
    {
        private string companyName;
        protected DateTime startingDate;
        public Company(string companyName, DateTime startingDate)
        {
            CompanyName = companyName;
            StartingDate = startingDate;
        }
        public string CompanyName
        {
            get { return companyName; }
            set
            {
                if (value == null) throw new ArgumentNullException("Null name");
                companyName = value;
            }
        }

        public DateTime StartingDate
        //you are required to add an exception if the value is greater that Now 
        {
            get { return startingDate; }
            set
            {
                if (value == null) throw new ArgumentNullException("Null DateTime Value is not allowed");
                if (value.Year > DateTime.Now.Year || ((value.Year == DateTime.Now.Year) && (value.Month > DateTime.Now.Month)) || ((value.Year == DateTime.Now.Year) && (value.Month == DateTime.Now.Month) && (value.Day < DateTime.Now.Day)))
                {
                    throw new ArgumentException("You can't enter a Date bigger then now");
                }
                startingDate = value;
            }
        }
    }
}
