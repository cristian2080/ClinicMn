using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicMn
{
    public partial class Receptionists : Form
    {
        public Receptionists()
        {
            InitializeComponent();
            DisplayRec();
        }

        //private void textBox5_TextChanged(object sender, EventArgs e)
        // {

        //}
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cristian\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Receptionist");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();

                    }

                    SqlCommand cmd = new SqlCommand("Delete from ReceptionistTb1 where RecepId=@RKey", Con);
                    
                    cmd.Parameters.AddWithValue("@RKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Deleted");
                    Con.Close();
                    DisplayRec();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        private void DisplayRec()
        {
            Con.Open();
            string Query = "Select * from ReceptionistTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builer = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReceptionistDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
           
                if (RNameTb.Text == "" || RPassword.Text == "" || RPhoneTb.Text == "" || RAddressTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    { 
                       if(Con.State == ConnectionState.Closed)
                    { 
                        Con.Open();

                    }
                        
                        SqlCommand cmd = new SqlCommand("insert into ReceptionistTb1(RecepName,RecepPhone,RecepAdd,RecepPass)values(@RN,@RP,@RA,@RPA)", Con);
                        cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                        cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                        cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                        cmd.Parameters.AddWithValue("@RPA", RPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Receptionist Added");
                        Con.Close();
                        DisplayRec();
                        clear();
                    }catch(Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                
            }
        }
        int key = 0;
        private void ReceptionistDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            RNameTb.Text = ReceptionistDGV.SelectedRows[0].Cells[1].Value.ToString();
            RPhoneTb.Text = ReceptionistDGV.SelectedRows[0].Cells[2].Value.ToString();
            RAddressTb.Text = ReceptionistDGV.SelectedRows[0].Cells[3].Value.ToString();
            RPassword.Text = ReceptionistDGV.SelectedRows[0].Cells[4].Value.ToString();
           if(RNameTb.Text == "")
            {

                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ReceptionistDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RPassword.Text == "" || RPhoneTb.Text == "" || RAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();

                    }

                    SqlCommand cmd = new SqlCommand("update ReceptionistTb1 set RecepName=@RN,RecepPhone=@RP,RecepAdd=@RA,RecepPass=@RPA where RecepId=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPassword.Text);
                    cmd.Parameters.AddWithValue("@RKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Updated");
                    Con.Close();
                    DisplayRec();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        private void clear()
        {
            RNameTb.Text = "";
            RPassword.Text = "";
            RPhoneTb.Text = "";
            RAddressTb.Text = "";
            key = 0;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
