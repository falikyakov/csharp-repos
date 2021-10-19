using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComputer
{
    class Computer
    {
        public Action<string, string, int> Alert;
        public string Name { get; set; }
        private int _temp;

        public int Temp
        {
            get { return _temp; }
            set
            {
                _temp = value;
                if ((_temp > 70) && (Alert != null))
                {
                    Alert(this.Name, "Temperature", Temp);
                }
            }
        }
        public int newSpeed = 0;
        private int _speed;

        public int Speed
        {
            get { return _speed; }
            set
            {
                newSpeed = value;
                if ((_speed != value) && (Alert != null))
                {
                    Alert(this.Name, "speed", Speed);
                }

                _speed = newSpeed;



            }
        }

        public void Accelerate()
        {
            Speed += 5;
        }


    }
}
