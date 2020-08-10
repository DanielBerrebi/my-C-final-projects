using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class DataItem
    {
        protected int number;
        protected string topic;
        protected string content;
        protected string img;
        //builder without image
        public DataItem(int num, string topic, string content)
        {
            this.number = num;
            this.topic = topic;
            this.content = content;
        }
        //builder with image
        public DataItem(int num, string topic, string content,string img)
        {
            this.number = num;
            this.topic = topic;
            this.content = content;
            this.img = img;
        }
        //returning info number
        public int getNumber()
        {
            return this.number;
        }
        // returning the topic
        public string getTopic()
        {
            return this.topic;
        }
        //returning the content
        public string getContent()
        {
            return this.content;
        }
        //returning the image 
        public string getImg()
        {
            return this.img;
        }
        public void setImg(string str)
        {
            this.img = str;
        }
        public string TurnToFormat()
        {
            string str = "" + number + ";" + topic + ";" + content;
            if(img!=null)
            {
                str += ";" + img;
            }
            return str;
        }
    }
}
