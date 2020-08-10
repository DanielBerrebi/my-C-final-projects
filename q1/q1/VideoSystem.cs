using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class VideoSystem : ASystem, IEntertiable
    {
        static int videoSystemCounter = 1;
        protected int id;//an spacific id for video system (must be odd number)
        protected bool isSupportHD;
        protected Company company;
        protected int electrictyUsePerHour = 110;//electricty use in volt


        //builder with all paramters
        public VideoSystem(string sname, DateTime Established, bool isSupportHD, Company company, int electrictyUsePerHour)
            : base(sname, Established)
        {
            this.isSupportHD = isSupportHD;
            this.company = company;
            ElectrictyUsePerHour = electrictyUsePerHour;
            id = videoSystemCounter;
            videoSystemCounter+=2;
        }

        //builder with no electrcy use per hour
        public VideoSystem(string sname, DateTime Established, bool isSupportHD, Company company)
            : base(sname, Established)
        {
            this.isSupportHD = isSupportHD;
            this.company = company;
            id = videoSystemCounter;
            videoSystemCounter++;
        }
        //builder with no establish date and no electrcy use per hour
        public VideoSystem(string sname, bool isSupportHD, Company company)
            : base(sname)
        {
            this.isSupportHD = isSupportHD;
            this.company = company;
            id = videoSystemCounter;
            videoSystemCounter++;
        }
        public override string systemPurpose()
        {
            return "I am a video streaming system";
        }
        public override string ToString()
        {
            return String.Format("id {4},{0}, does it support hd? {1} , Company name {2} , electrcy use per hour {3} volts", base.ToString(), isSupportHD.ToString(), company.CompanyName, electrictyUsePerHour,id);
        }
        public int ElectrictyUsePerHour
        //you are required a positve number
        {
            get { return electrictyUsePerHour; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("You can't enter a negative number as electricty use");
                }
                electrictyUsePerHour = value;
            }
        }
        // compare by electricty use per hour
        public int CompareTo(Object obj)
        {
            if (!(obj is VideoSystem))
                throw new Exception("this is not a Video System");
            VideoSystem video = (VideoSystem)obj;
            if (electrictyUsePerHour == video.ElectrictyUsePerHour)
                return 0;
            if (electrictyUsePerHour < video.ElectrictyUsePerHour)
                return -1;
            return 1;

        }
        //returning electricty used by time
        public double electrictyUsedByTime(int hours)
        {
            return ((double)electrictyUsePerHour * hours);
        }
        //return if a video system is new (in video system is younger the 3 years)
        public bool isItNew()
        {
            TimeSpan t = DateTime.Now - this.Established;
            int years = t.Days / 365;
            if (years<3)
            {
                return true;
            }
            return false;
        }
        public int getID()
        {
            return id;
        }
    }

}
