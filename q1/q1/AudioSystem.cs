using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class AudioSystem : ASystem, IEntertiable
    {
        static int audioSystemCounter = 0;
        protected int id;//an spacific id for audio system (must be even number)
        protected bool isSupportHD;
        protected int maxDecibel = 80;//Max decibel that can be provide
        //builder with all paramters
        public AudioSystem(string sname, DateTime Established, bool isSupportHD,int maxDecibel)
            : base(sname, Established)
        {
            this.isSupportHD = isSupportHD;
            MaxDecibel = maxDecibel;
            id = audioSystemCounter;
            audioSystemCounter+=2;
        }

        //builder with no establish date
        public AudioSystem(string sname, bool isSupportHD, int maxDecibel)
            : base(sname)
        {
            this.isSupportHD = isSupportHD;
            MaxDecibel = maxDecibel;
            id = audioSystemCounter;
            audioSystemCounter++;
        }
        //builder with no establish date and no max decibel
        public AudioSystem(string sname, bool isSupportHD)
            : base(sname)
        {
            this.isSupportHD = isSupportHD;
            MaxDecibel = maxDecibel;
            id = audioSystemCounter;
            audioSystemCounter++;
        }
        public int getID()
        {
            return id;
        }
        //compare by max decibel
        public int CompareTo(object obj)
        {
            if (!(obj is AudioSystem))
                throw new Exception("this is not a Audio system");
            AudioSystem audio = (AudioSystem)obj;
            if (MaxDecibel == audio.MaxDecibel)
                return 0;
            if (MaxDecibel < audio.MaxDecibel)
                return -1;
            return 1;
        }
        //returning the recommanded volume (80% of the max Decibel)
        public double recommandedDecibelToUse()
        {
            double recommanded = MaxDecibel;
            recommanded *= 0.8;
            return recommanded;
        }
        //return if a audio system is new (in audio system is younger the 2 years )
        public bool isItNew()
        {
            TimeSpan t = DateTime.Now - this.Established;
            int years = t.Days / 365;
            if (years < 2)
            {
                return true;
            }
            return false;
        }
        public override string systemPurpose()
        {
            return "I am a audio system";
        }
        public int MaxDecibel
        //you are required a positve number
        {
            get { return maxDecibel; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("You can't enter a negative number as max decibel");
                }
                maxDecibel = value;
            }
        }
        //print infromation on the system
        public override string ToString()
        {
            return String.Format("id {3} ,{0}, does it support hd? {1} , Max decibel {2}", base.ToString(), isSupportHD.ToString(),MaxDecibel,id);
        }
    }
}
