using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    abstract class ASystem
    {
        string sname;
        DateTime established;

        public string SName
        {
            get { return sname; }
            set
            {
                if (value == null) throw new ArgumentNullException("Null name");
                sname = value;
            }
        }

        public DateTime Established
        //you are required to add an exception if the value is greater that Now 
        {
            get { return established; }
            set
            {
                if (value == null) throw new ArgumentNullException("Null DateTime Value is not allowed");
                if (value.Year> DateTime.Now.Year ||((value.Year== DateTime.Now.Year)&& (value.Month > DateTime.Now.Month))||((value.Year == DateTime.Now.Year) && (value.Month == DateTime.Now.Month) && (value.Day < DateTime.Now.Day)))
                {
                    throw new ArgumentException("You can't enter a Date bigger then now");
                }
                established = value;
            }
        }

        public ASystem(string name, DateTime established)
        { SName = name; Established = established; }

        public ASystem(string name)
        { SName = name; established = DateTime.Now; }


        // string with information about system usage
        public abstract string systemPurpose();

        public override string ToString()
        { return sname + " exist since " + established.ToShortDateString(); }
    }

}
