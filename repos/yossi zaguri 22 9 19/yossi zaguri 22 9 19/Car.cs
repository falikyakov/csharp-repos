using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yossi_zaguri_22_9_19
{
    public class Car
    {
        public int Liscence { get; set; }
        public string Owner { get; set; }
        public string Munfacturer { get; set; }


        public int Speed
        {
            get { return RPM * 2; }
        }
        private int RPM;
        private IEngine engine;

        public Car(int Liscence)
        {
            this.Liscence = Liscence;
            this.RPM = 0;
        }

        public Car(int Liscence, IEngine engine) : this(Liscence)
        {
            this.engine = engine; 
        }
        public void Accelerate()
        {
            RPM = engine.IncreaseRpm();
        }
        public void SlowDown()
        {
            RPM = engine.DecreaseRPM();
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();
            report.Append("car owner is: " + this.Owner + "\n");
            report.Append("car Liscence  is: " + this.Liscence + "\n");
            report.Append("car speed is: " + this.Speed + "\n");
            return report.ToString();

        }
    }
}
