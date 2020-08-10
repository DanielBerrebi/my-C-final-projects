using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class EntertainmentSystems
    {
        protected List<ASystem> entertainmentSystems = new List<ASystem>();

        //a builder with 3 systems
        public EntertainmentSystems(ASystem aSystem, ASystem aSystem1, ASystem aSystem2)
        {
            add(aSystem);
            add(aSystem1);
            add(aSystem2);
        }
        //a builder with only audio system
        public EntertainmentSystems(ASystem aSystem)
        {
            add(aSystem);
        }
        //Empty builder
        public EntertainmentSystems()
        {

        }
        //adding an entertainment system to the suitable list (you can't enter a obj that are already in the entertainment systems)
        public void add(ASystem obj)
        {
            if (entertainmentSystems.Contains(obj))
            {
                throw new Exception("you can't add a system that already in the entertainment systems");
            }
            else
            {
                entertainmentSystems.Add((ASystem)obj);
            }
        }

        public void toString()
        {
            Console.WriteLine("Printing the entertainment systems.......");
            for (int i = 0; i < entertainmentSystems.Count; i++)
            {
                Console.WriteLine(entertainmentSystems[i].ToString());
            }
        }
        //search a system by id and if he exist return him else return null
        public object search(int id)
        {
            for (int i = 0; i < entertainmentSystems.Count; i++)
            {
                if (entertainmentSystems[i] is VideoSystem)
                {
                    VideoSystem video = (VideoSystem)entertainmentSystems[i];
                    if (id == video.getID())
                    {
                        return video;
                    }
                }
                else
                {
                    AudioSystem audio = (AudioSystem)entertainmentSystems[i];
                    if (id == audio.getID())
                    {
                        return audio;
                    }
                }
            }
            return null;
        }
        //remove an entertainment system by his obj if it in the class
        public void remove(ASystem obj)
        {

            if (!entertainmentSystems.Contains(obj))
            {
                throw new Exception("this is not a in the Entertainment systems");
            }
            entertainmentSystems.Remove(obj);
        }

    }
}
