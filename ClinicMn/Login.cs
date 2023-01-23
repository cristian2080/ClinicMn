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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            RoleCb.SelectedIndex = 0;
            UnameTb.Text = "";
            PassTb.Text = "";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cristian\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");
        public static string Role;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select your Position");
            }
            else if (RoleCb.SelectedIndex == 0)
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Admin Name and Password");
                }

            
            else if(UnameTb.Text == "Admin" && PassTb.Text == "Password")
            {
                    Role = "Admin";
                Patients Obj = new Patients();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Admin Name and Password");
            }
            }else if(RoleCb.SelectedIndex == 1)
            { 
                    if (UnameTb.Text == "" || PassTb.Text == "")
                    {
                        MessageBox.Show("Enter Both Doctor Name and Password");
                    }
                    else 
                    {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoctorTb1 where DocName='" + UnameTb.Text + "' and Docpass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Doctor";
                        Prescriptions Obj = new Prescriptions();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor Not Found");
                    }
                    Con.Close();
                    }
                    
                }
            
            else
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Receptionist Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ReceptionistTb1 where RecepName='" + UnameTb.Text + "' and RecepPass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Receptionist";
                        Homes Obj = new Homes();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor Not Found");
                    }
                    Con.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                PassTb.UseSystemPasswordChar = false;
            }
            else
            {
                PassTb.UseSystemPasswordChar = true;
            }
        }
    }
}
