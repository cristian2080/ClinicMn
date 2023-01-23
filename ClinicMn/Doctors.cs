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
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
            DisplayDoc();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cristian\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayDoc()
        {
            Con.Open();
            string Query = "Select * from DoctorTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builer = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void clear()
        {
            DNameTb.Text = "";
            DocPhoneTb.Text = "";
            DocAddTb.Text = "";
            DocExpTb.Text = "";
            DocPassWordTb.Text = "";
            DocGenCb.SelectedIndex = 0;
            DocSpecCb.SelectedIndex = 0;
            key = 0;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DocPassWordTb.Text == "" || DocPhoneTb.Text == "" || DocAddTb.Text == "" || DocGenCb.SelectedIndex == -1 || DocSpecCb.SelectedIndex == -1)
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

                    SqlCommand cmd = new SqlCommand("insert into DoctorTb1(DocName,DocDOB,DOCGEN,DOCSPEC,DOCEXP,DOCPHONE,DOCADD,DOCPASS)values(@DN,@DD,@DG,@DS,@DE,@DP,@DA,@DPA)", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DocSpecCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DocPassWordTb.Text);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Added");
                    Con.Close();
                    DisplayDoc();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        int key = 0;
        private void DoctorsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DoctorsDGV.SelectedRows[0].Cells[1].Value.ToString();
            DocDOB.Text = DoctorsDGV.SelectedRows[0].Cells[2].Value.ToString();
            DocGenCb.SelectedItem = DoctorsDGV.SelectedRows[0].Cells[3].Value.ToString();
            DocSpecCb.SelectedItem = DoctorsDGV.SelectedRows[0].Cells[4].Value.ToString();
            DocExpTb.Text = DoctorsDGV.SelectedRows[0].Cells[5].Value.ToString();
            DocPhoneTb.Text = DoctorsDGV.SelectedRows[0].Cells[6].Value.ToString();
            DocAddTb.Text = DoctorsDGV.SelectedRows[0].Cells[7].Value.ToString();
            DocPassWordTb.Text = DoctorsDGV.SelectedRows[0].Cells[8].Value.ToString();
            
            if (DNameTb.Text == "")
            {

                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DoctorsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DocPassWordTb.Text == "" || DocPhoneTb.Text == "" || DocAddTb.Text == "" || DocGenCb.SelectedIndex == -1 || DocSpecCb.SelectedIndex == -1)
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

                    SqlCommand cmd = new SqlCommand("Update DoctorTb1 set DocName=@DN,DocDOB=@DD,DOCGEN=@DG,DOCSPEC=@DS,DOCEXP=@DE,DOCPHONE=@DP,DOCADD=@DA,DOCPASS=@DPA where DOCID=@DKEY", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DocSpecCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DocPassWordTb.Text);
                    cmd.Parameters.AddWithValue("@DKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Edited");
                    Con.Close();
                    DisplayDoc();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Doctor");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();

                    }

                    SqlCommand cmd = new SqlCommand("Delete from DoctorTb1 where DOCId=@DKey", Con);

                    cmd.Parameters.AddWithValue("@DKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted");
                    Con.Close();
                    DisplayDoc();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
     
        }

        private void label12_Click(object sender, EventArgs e)
        {
            LabTests Obj = new LabTests();
            Obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
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
