using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.DataAccessor
{
    public class VoterReader
    {
        public List<Citizen> GetCitizens(){
            List<Citizen> result = new List<Citizen>();

            result.Add(new Citizen { Name="Yanky", ID=1, Address="hdbsdkfbsdkfh", TeudatZehut=123456789});
            result.Add(new Citizen { Name = "shmanky", ID = 3, Address = "hffffffffffh", TeudatZehut = 1565656789 });

            result.Add(new Citizen { Name = "banky", ID = 5, Address = "aaaaaaaakfh", TeudatZehut = 989898889 });

            return result;
        } 

    }
}
