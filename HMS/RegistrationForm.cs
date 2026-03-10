using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HMS
{
    public partial class RegistrationForm : Form
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dhrubo Roy\source\repos\HMS\HotelDatabase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            // CUSTOMER REGISTRATION FORM DETAILS 

            string Customer_Name, Customer_Contact, Customer_Email, Customer_Nid;

            Customer_Name = cnameTextbox.Text.ToString();
            Customer_Contact = ccontactTextbox.Text.ToString();
            Customer_Email = cemailTextbox.Text.ToString();
            Customer_Nid = cnidTextbox.Text.ToString();

            // no empty fields are allowed 
            if (string.IsNullOrEmpty(Customer_Name) || string.IsNullOrEmpty(Customer_Contact) || string.IsNullOrEmpty(Customer_Email) || string.IsNullOrEmpty(Customer_Nid))
            {
                MessageBox.Show("Null fields are not allowed !!", "!! LOGIN ERROR !!", MessageBoxButtons.OK);
            }
            else
            {
                // we insert the custotmer details in the database 
                // databse connection setup

                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONNECTION_STRING;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO customers (name, contact, email, nid) VALUES ('" + Customer_Name + "', '" + Customer_Contact + "', '" + Customer_Email + "', '" + Customer_Nid + "')";
                cmd.Connection = con;

                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                {
                    MessageBox.Show("REGISTRATION SUCCESSFULL", "R E G S T E R E D", MessageBoxButtons.OK);

                    // update the textboxes
                    cnameTextbox.Text = "";
                    ccontactTextbox.Text = "";
                    cemailTextbox.Text = "";
                    cnidTextbox.Text = "";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
