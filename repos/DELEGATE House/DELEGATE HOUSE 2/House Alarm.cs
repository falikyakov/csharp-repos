using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATE_HOUSE_2
{
    class House_Alarm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Temperature { get; set; }
        public int NoiseLevel { get; set; }
        public House_Alarm(string name, string address, int temp, int noise)
        {
            this.Name = name;
            this.Address = address;
            this.Temperature = temp;
            this.NoiseLevel = noise;
        }
        public Action Warning;
        public void IncreaseTemp()
        {
            Temperature += 5;
            if ((Temperature > 100)&&(Warning!=null))
            {
              Warning(); 
            }
        }
        public void IncreaseDecibels()
        {
            NoiseLevel += 5;
            if ((NoiseLevel > 50)&& (Warning != null))
            {
                Warning();
            }
        }

    }
}
