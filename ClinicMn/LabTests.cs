using Org.BouncyCastle.Asn1.X509;
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
    public partial class LabTests : Form
    {
        public LabTests()
        {
            InitializeComponent();
            DisplayTest();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cristian\Documents\ClinicDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayTest()
        {
            Con.Open();
            string Query = "Select * from TestTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builer = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LabTestDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int key = 0;
        private void clear()
        {
            LabTestTb.Text = "";
            LabCostTb.Text = "";
           
            key = 0;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (LabCostTb.Text == "" || LabTestTb.Text == "")
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

                    SqlCommand cmd = new SqlCommand("insert into TestTb1(TestName,TestCost)values(@TN,@TC)", Con);
                    cmd.Parameters.AddWithValue("@TN", LabTestTb.Text);
                    cmd.Parameters.AddWithValue("@TC", LabCostTb.Text);
                



                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Added");
                    Con.Close();
                    DisplayTest();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void LabTestDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LabTestTb.Text = LabTestDGV.SelectedRows[0].Cells[1].Value.ToString();
            LabCostTb.Text = LabTestDGV.SelectedRows[0].Cells[2].Value.ToString();
            
            if (LabTestTb.Text == "")
            {

                key = 0;
            }
            else
            {
                key = Convert.ToInt32(LabTestDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (LabCostTb.Text == "" || LabTestTb.Text == "")
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

                    SqlCommand cmd = new SqlCommand("Update TestTb1 set TestName=@TN,TestCost=@TC where TestNum=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TN", LabTestTb.Text);
                    cmd.Parameters.AddWithValue("@TC", LabCostTb.Text);
                    cmd.Parameters.AddWithValue("@TKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Updated");
                    Con.Close();
                    DisplayTest();
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
                MessageBox.Show("Select the Lab Test");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();

                    }

                    SqlCommand cmd = new SqlCommand("Delete from TestTb1 where TestNum=@TKey", Con);

                    cmd.Parameters.AddWithValue("@TKey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lab Test Deleted");
                    Con.Close();
                    DisplayTest();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
