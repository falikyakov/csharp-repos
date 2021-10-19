using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATE_House
{
    class Program
    {
        static void Main(string[] args)
        {
           
            House NachalUriah7 = new House(85, 45, "Nachal Uriah 7, Beit Shemesh");



            NewTemp();
            NewTemp();
            NewTemp();
            NewTemp();
            NewTemp();
            NewTemp();
            Console.WriteLine("----------------------------------------");
            NewDb();
            NewDb();
            NewDb();
            NewDb();

            void NewDb()
            {
                SetWarning();
                NachalUriah7.IncreaseDb();
                Console.WriteLine("New Db: {0}",NachalUriah7.Decibels);
                
            }

            void NewTemp(){
                SetWarning();
                NachalUriah7.IncreaseTemp();
                Console.WriteLine(NachalUriah7.Degrees);
                
            }
            void SetWarning()
            {
                 NachalUriah7.Warning = null; 
                if (NachalUriah7.Degrees > 90 && NachalUriah7.Decibels < 51)
                {
                    NachalUriah7.Warning = FireAlertToDept;
                    NachalUriah7.Warning += FireAlertToOwner;
                }
                else if (NachalUriah7.Degrees < 91 && NachalUriah7.Decibels > 50)
                {
                    NachalUriah7.Warning = BreakInOwner;
                    NachalUriah7.Warning += BreakInPolice;
                }
                else if (NachalUriah7.Degrees > 90 && NachalUriah7.Decibels > 50)
                {
                    NachalUriah7.Warning = FireAlertToDept;
                    NachalUriah7.Warning += FireAlertToOwner;
                    NachalUriah7.Warning += BreakInOwner;
                    NachalUriah7.Warning += BreakInPolice;
                }
              

            }



            void FireAlertToOwner()
            {
                Console.WriteLine("Please be advised, there's a fire in your house.");
            }

            void FireAlertToDept()
            {
                Console.WriteLine("Please be advised, there's a fire burning at {0}", NachalUriah7.Address);
            }

            //void FireAlert() { FireAlertToOwner(); FireAlertToDept(); }

            void BreakInOwner()
            {
                Console.WriteLine("Please be advised, there's a break-in at your house.");
            }

            void BreakInPolice()
            {
                Console.WriteLine("Please be advised, there's a break-in at {0}", NachalUriah7.Address);
            }

            //void BreakInAlert() { BreakInOwner(); BreakInPolice(); }


            Console.ReadLine();
        }


    }

    class House
    {
        public Action Warning = null;
        public int Degrees { get; set; }
        public int Decibels { get; set; }
        public string Address;

        public House(int dgr, int dcb, string adr)
        {
            this.Degrees = dgr;
            this.Decibels = dcb;
            this.Address = adr;
        }

        public void ShowTemp()
        {
            Console.WriteLine(Degrees);
        }

        public bool highDegrees()
        {
            bool result = false;
            if (Degrees > 90)
                result = true;
            return result;
        }
        
        public void IncreaseTemp()
        {
            Degrees += 5;
            if ((Degrees > 90) && (Warning != null))
                Warning();
        }

        public void ShowDb()
        {
            Console.WriteLine(Decibels);
        }

        public void IncreaseDb()
        {
            Decibels += 5;
            if ((Decibels > 50)&&(Warning!=null))
                Warning();
        }
    }
}
