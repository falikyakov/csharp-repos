using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_10_2019
{
    class Stock
    {
        public Action<float, string, Trend> ChangeNotification;
        public string Name { get; set; }
        private float _value;
        public float Value
        {
            get { return _value; }
            set
            {
                if ((_value > value) && (ChangeNotification != null))
                {
                    ChangeNotification(value, this.Name, Trend.Down);
                }
                _value = value;
                LastUpdate = DateTime.Now;
            }
        }
        public DateTime LastUpdate { get; set; }

        public Stock(string name, float value)
        {
            Name = name;
            this.Value = value;
        }
    }
}
