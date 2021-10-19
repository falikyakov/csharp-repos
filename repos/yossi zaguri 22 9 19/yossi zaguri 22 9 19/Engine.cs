using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yossi_zaguri_22_9_19
{
    public class Engine : IEngine
    {
        public int MaxRPM { get; set; }
        public int Delta { get; set; }
        public string Manufacturer { get; set; }
        public int Volume { get; set; }
        private int RPM { get; set; }

        public Engine(int MaxRPM, int Delta)
        {
            this.MaxRPM = MaxRPM;
            this.Delta = Delta;
        }

        public int IncreaseRpm()
        {
            int NewRPM = RPM + Delta;
            if (NewRPM < MaxRPM)
            {
                RPM = NewRPM;
            }
            return RPM;
        }

        public int DecreaseRPM()
        {
            int NewRPM = RPM - Delta;
            if (NewRPM > 0)
            {
                RPM = NewRPM;
            }
            return RPM;
        }
    }
}
