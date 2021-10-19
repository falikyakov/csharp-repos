using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psychology_Practice
{
    class PatientInfo
    {
        public void NewFunction()
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-5SIR5IV;Database=Psychology Practice;Integrated Security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Patients", conn);
        }

       
    }
}
