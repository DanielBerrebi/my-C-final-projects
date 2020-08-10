using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time1 = new DateTime(2017, 7, 22);
            DateTime time2 = new DateTime(2018, 9, 26);
            DateTime time3 = new DateTime(2020, 4, 22);
            DateTime time4 = new DateTime(2012, 11, 26);
            try
            {
                Company samsang = new Company("samsang", time2);
                Company lg = new Company("LG", time4);
                Company sony = new Company("SONY", time1);
                VideoSystem tv = new VideoSystem("Television 4K", time3, true, samsang, 70);
                VideoSystem tvFlay = new VideoSystem("Television 3D ", time2, true, lg, 200);
                VideoSystem projector = new VideoSystem("Projector", time4, false, sony, 30);
                AudioSystem radio = new AudioSystem("radio", time1, true, 80);
                AudioSystem subboffer = new AudioSystem("Subboffer", false);
                AudioSystem speaker = new AudioSystem("speaker", true, 120);
                Stack<string> formats1 = new Stack<string>();
                Stack<string> formats2 = new Stack<string>();
                Stack<string> formats3 = new Stack<string>();
                formats1.Push("mp3");
                formats2.Push("mp3");
                formats2.Push("WAV");
                formats2.Push("m4b");
                formats3.Push("m4b");
                PortableAudioSystem walkman = new PortableAudioSystem("Walkman", time4, true,80,6,formats1,500,60);
                PortableAudioSystem mp3 = new PortableAudioSystem("mp3", time2, false, 50, 0.75, formats2, 370);
                PortableAudioSystem jbl = new PortableAudioSystem("JBL", time3, true, 180, 3.55, formats3, 400, 120);
                walkman.Add("WAV");
                EntertainmentSystems entertainmentSystems = new EntertainmentSystems(walkman, radio,tv);
                Console.WriteLine("EntertainmentSystems methods");
                Console.WriteLine();
                entertainmentSystems.toString();
                Console.WriteLine();
                Console.WriteLine("using remove function");
                entertainmentSystems.remove(radio);
                Console.WriteLine();
                entertainmentSystems.toString();
                Console.WriteLine();
                Console.WriteLine("using add function");
                entertainmentSystems.add(radio);
                Console.WriteLine();
                entertainmentSystems.toString();
                Console.WriteLine();
                Console.WriteLine("searching id = 1 in the EntertainmentSystems");
                ASystem a=(ASystem)entertainmentSystems.search(1);
                Console.WriteLine("\n"+ a.ToString()+"\n");
                entertainmentSystems.toString();
                entertainmentSystems.add(tvFlay);
                entertainmentSystems.add(projector);
                entertainmentSystems.add(subboffer);
                entertainmentSystems.add(speaker);
                entertainmentSystems.add(mp3);
                entertainmentSystems.add(jbl);
                Console.WriteLine("VideoSystem methods");
                Console.WriteLine();
                Console.WriteLine(tv.systemPurpose());
                Console.WriteLine();
                Console.WriteLine(tv.ToString());
                Console.WriteLine();
                Console.WriteLine(tvFlay.ToString());
                Console.WriteLine("CompareTo Them by electrictyUsePerHour");
                Console.WriteLine(tv.CompareTo(tvFlay));
                Console.WriteLine();
                Console.WriteLine("Electricty used after 8 hours of use " + tv.electrictyUsedByTime(8));
                Console.WriteLine();
                Console.WriteLine("is it new (exist less then 3 year) " + tv.isItNew());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("AudioSystem methods");
                Console.WriteLine();
                Console.WriteLine(radio.systemPurpose());
                Console.WriteLine();
                Console.WriteLine(radio.ToString());
                Console.WriteLine();
                Console.WriteLine(subboffer.ToString());
                Console.WriteLine("CompareTo comparing by max decibel");
                Console.WriteLine(radio.CompareTo(subboffer));
                Console.WriteLine();
                Console.WriteLine("is it new (exist less then 2 year) " + radio.isItNew());
                Console.WriteLine();
                Console.WriteLine("the recommanded volume (80% of the max decimel) " + radio.recommandedDecibelToUse());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("PortableAudioSystem methods");
                Console.WriteLine();
                Console.WriteLine(walkman.systemPurpose());
                Console.WriteLine();
                Console.WriteLine(walkman.ToString());
                Console.WriteLine();
                Console.WriteLine(mp3.ToString());
                Console.WriteLine("CompareTo by max battary Storage");
                Console.WriteLine(walkman.CompareTo(mp3));
                Console.WriteLine();
                Console.WriteLine("is it new (exist less then 2 year) " + walkman.isItNew());
                Console.WriteLine();
                Console.WriteLine("the recommanded volume (80% of the max decimel) " + walkman.recommandedDecibelToUse());
                Console.WriteLine(walkman.ToString());
                Console.WriteLine();
                Console.WriteLine("Using Add to add the string M4A");
                walkman.Add("M4A");
                Console.WriteLine();
                Console.WriteLine(walkman.ToString());
                Console.WriteLine();
                Console.WriteLine(walkman.maxTimeWithoutCharging());
                Console.WriteLine();
                Console.WriteLine("is the device is heavy (more the 5 kg)"+walkman.isHeavy());

            }
            catch (FormatException formatException)
            {
                Console.WriteLine(formatException.Message);
                Console.WriteLine("Please try again");
            }
            catch (ArgumentNullException argumentNullException)
            {
                Console.WriteLine(argumentNullException.Message);
                Console.WriteLine("Please try again");
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
                Console.WriteLine("Please try again");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Please try again");
            }
            Console.ReadKey();
        }
    }
}
