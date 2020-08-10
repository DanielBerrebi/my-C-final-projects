using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class PortableAudioSystem : AudioSystem
    {
        protected double weight;//in kilograms
        protected Stack<string> supportingFormat;//a stack of all the soprting audio format of the systam like mp3 ,wav ,m4b
        protected int battaryStorage;//Battary electricty storage
        protected int electrictyUsePerHour = 50;
        //builder with all the parameters
        public PortableAudioSystem(string sname, DateTime Established, bool isSupportHD, int maxDecibel,double weight, Stack<string> supportingFormat, int battaryStorage,int electrictyUsePerHour)
       : base(sname, Established, isSupportHD, maxDecibel)
        {
            Weight = weight;
            SupportingFormat = supportingFormat;
            BattaryStorage = battaryStorage;
            ElectrictyUsePerHour = electrictyUsePerHour;
        }
        //builder with all the parameters except electricty use per hour
        public PortableAudioSystem(string sname, DateTime Established, bool isSupportHD, int maxDecibel, double weight, Stack<string> supportingFormat, int battaryStorage)
       : base(sname, Established, isSupportHD, maxDecibel)
        {
            Weight = weight;
            SupportingFormat = supportingFormat;
            BattaryStorage = battaryStorage;
        }
        //compare by max battary Storage
        public new int CompareTo(object obj)
        {
            if (!(obj is PortableAudioSystem))
                throw new Exception("this is not a Portable audio system");
            PortableAudioSystem audio = (PortableAudioSystem)obj;
            if (BattaryStorage == audio.battaryStorage)
                return 0;
            if (BattaryStorage < audio.battaryStorage)
                return -1;
            return 1;
        }
        public override string systemPurpose()
        {
            return "I am a portable audio system";
        }
        public Stack<string> SupportingFormat
        //you are required a positive number
        {
            get { return supportingFormat; }
            set
            {
                if (value.Count==0)
                {
                    throw new ArgumentException("You can't enter a empty stack of supporting format");
                }
                supportingFormat = value;
            }
        }

        public double Weight
        //you are required a positive number
        {
            get { return weight; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("You can't enter a negative number as a weight");
                }
                weight = value;
            }
        }
        public int BattaryStorage
        //you are required a battary Storage that have to be at least 200 volts
        {
            get { return battaryStorage; }
            set
            {
                if (value < 200)
                {
                    throw new ArgumentException("You can't enter a battary storage less then 200 volts");
                }
                battaryStorage = value;
            }
        }
        public int ElectrictyUsePerHour
        //you are required a positive number
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
        //print the max time that the system can be used without charging
        public string maxTimeWithoutCharging()
        {
            double time = (double)battaryStorage / electrictyUsePerHour;
            time *= 60;
            string str = "it can hold up to " + ((int)time / 60) + " hours and "+((int)time % 60) + " minutes ";
            return str;
        }
        //return true if it's heavy (weight more the 5 kg)
        public bool isHeavy()
        {
            if (weight > 5)
            {
                return true;
            }
            return false;
        }
        public string returnAllSupportFormatAsAString()
        {
            string str = "";
            string[] formats = supportingFormat.ToArray();
            for (int i = 0; i < formats.Length; i++)
            {
                if (i == 0)
                {
                    str += formats[i];
                }
                else
                {
                    str += ","+formats[i];
                }
            }
            return str;
        }
        //print infromation on the system
        public override string ToString()
        {
            return String.Format("{0},\nweight: {1} , supporting {2} formats , battaryStorage {3} ,electricty Use Per Hour {4}", base.ToString(), weight, returnAllSupportFormatAsAString(), battaryStorage, electrictyUsePerHour);
        }
        public void Add(string format)
        {
            if (format ==null)
            {
                throw new ArgumentException("You can't add to the stack an empty string");
            }
            supportingFormat.Push(format);
        }
    }
}
