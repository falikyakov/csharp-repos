using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_DELEGATE_Car
{
    class CarComputer
    {
        public Action<int, string, Trend> Notify;
        public string  Name { get; set; }
        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if ((Temperature > 80) && (Notify != null))
                {
                    Notify(Temperature, this.Name, Trend.TooHigh);
                }
                _temperature = value;
            }
        }

    }
}
