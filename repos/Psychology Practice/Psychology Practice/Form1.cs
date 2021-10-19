using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psychology_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (lastNameText.Text == "")
            {
                MessageBox.Show("Must enter last name");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Server=DESKTOP-5SIR5IV;Database=Psychology_Practice;Integrated Security=true");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand
                ($"insert into patients(firstname,lastname,Tel,Cell,Address,Email,Psychiatrist)values('{firstNameText.Text}', '{lastNameText.Text}','{telText.Text}','{cellText.Text}','{addressText.Text}','{emailText.Text}','{curPsychText.Text}')", conn);
                cmd1.ExecuteNonQuery();
                SubmitButton.Hide();
            }
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientListButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection("Server=DESKTOP-5SIR5IV;Database=Psychology_Practice;Integrated Security=true");
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Patients", conn2);
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show("ID: " + reader.GetValue(0).ToString() +
                    "\nFirst Name: " + reader.GetValue(1).ToString() +
                    "\nLast Name: " + reader.GetValue(2).ToString() +
                    "\nTel: " + reader.GetValue(3).ToString() +
                "\nAddress: " + reader.GetValue(5).ToString() +
                "\nEmail: " + reader.GetValue(7).ToString());
            }
        }

        private void SpecificPatientInfoButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection("Server=DESKTOP-5SIR5IV;Database=Psychology_Practice;Integrated Security=true");
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand($"SELECT * FROM Patients WHERE lastName = '{specificPatientNameTextBox.Text}'", conn2);
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show("ID: " + reader.GetValue(0).ToString() +
                    "\nFirst Name: " + reader.GetValue(1).ToString() +
                    "\nLast Name: " + reader.GetValue(2).ToString() +
                    "\nTel: " + reader.GetValue(3).ToString() +
                "\nAddress: " + reader.GetValue(5).ToString() +
                "\nEmail: " + reader.GetValue(7).ToString());
            }
        }
    }
}
