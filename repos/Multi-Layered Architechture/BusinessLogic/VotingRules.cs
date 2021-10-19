using BusinessEntities;
using ML.DataAccessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class VotingRules
    {
        public List<Citizen> GetVoters()
        {
            List<Citizen> result;
            VoterReader dal = new VoterReader();

            result = dal.GetCitizens();

            return result;
        }
    }
}
