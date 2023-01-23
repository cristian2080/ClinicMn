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

namespace ClinicMn
{
    public partial class Homes : Form
    {
        public Homes()
        {
            InitializeComponent();
            if(Login.Role == "Receptionist")
            {
                ReceLbl.Enabled = false;
                DoctorLbl.Enabled = false;
                LabLbl.Enabled = false;
                
            }
            CountPatients();
            CountDoctors();
            CountTest();
            CountHIV();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cristian\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void CountPatients()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PatientTb1", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountHIV()
        {
            string Stare = "Positive";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PatientTb1 where PatHIV='"+Stare+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            HIVLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DoctorTb1", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DocNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountTest()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from TestTb1", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LabTestLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PatLbl_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }

        private void DoctorLbl_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void LabLbl_Click(object sender, EventArgs e)
        {
            LabTests Obj = new LabTests();
            Obj.Show();
            this.Hide();
        }

        private void ReceLbl_Click(object sender, EventArgs e)
        {
            Receptionists Obj = new Receptionists();
            Obj.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
