using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HMS
{
    public partial class infoUpdate : Form
    {

        private readonly string CONNECTION_STRING =
        @"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\Dhrubo Roy\source\repos\HMS\HotelDatabase.mdf;
        Integrated Security=True";

        public infoUpdate()
        {
            InitializeComponent();
        }


        private void infoUpdate_Load(object sender, EventArgs e)
        {
            // Nothing required here for now
        }


        private void radioone_CheckedChanged(object sender, EventArgs e)
        {
            if (radioone.Checked)
            {
                keytb.Clear();
                keytb.PlaceholderText = "Enter Contact Number";
            }
        }


        private void radiotwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radiotwo.Checked)
            {
                keytb.Clear();
                keytb.PlaceholderText = "Enter NID";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioone.Checked && !radiotwo.Checked)
            {
                MessageBox.Show("Please select Contact or NID to search");
                return;
            }

            if (string.IsNullOrWhiteSpace(keytb.Text))
            {
                MessageBox.Show("Please enter a value to search");
                return;
            }

            string query;

            if (radioone.Checked)
            {
                query = "SELECT Name, Contact, Email, NID FROM customers WHERE Contact = @key";
            }
            else
            {
                query = "SELECT Name, Contact, Email, NID FROM customers WHERE NID = @key";
            }

            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@key", keytb.Text.Trim());

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    tbname.Text = reader["Name"].ToString();
                    tbcontact.Text = reader["Contact"].ToString();
                    tbemail.Text = reader["Email"].ToString();
                    tbnid.Text = reader["NID"].ToString();
                }
                else
                {
                    MessageBox.Show("No client found");
                    ClearFields();
                }
            }
        }


        private void ClearFields()
        {
            tbname.Clear();
            tbcontact.Clear();
            tbemail.Clear();
            tbnid.Clear();
            keytb.Clear();
        }


        private void upbtn_Click(object sender, EventArgs e)
        {
            if (!radioone.Checked && !radiotwo.Checked)
            {
                MessageBox.Show("Please select Contact or NID to update");
                return;
            }

            if (string.IsNullOrWhiteSpace(keytb.Text))
            {
                MessageBox.Show("Please enter a value to identify the client");
                return;
            }

            string query;

            if (radioone.Checked)
            {
                query = @"UPDATE customers
                          SET Name=@Name, Email=@Email, NID=@NID
                          WHERE Contact=@key";
            }
            else
            {
                query = @"UPDATE customers
                          SET Name=@Name, Email=@Email, Contact=@Contact
                          WHERE NID=@key";
            }

            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Name", tbname.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", tbemail.Text.Trim());
                cmd.Parameters.AddWithValue("@Contact", tbcontact.Text.Trim());
                cmd.Parameters.AddWithValue("@NID", tbnid.Text.Trim());
                cmd.Parameters.AddWithValue("@key", keytb.Text.Trim());

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Client information updated successfully!");
                else
                    MessageBox.Show("Update failed. Client not found.");
            }
        }


        private void outbtn_Click(object sender, EventArgs e)
        {
            if (!radioone.Checked && !radiotwo.Checked)
            {
                MessageBox.Show("Please select Contact or NID to delete");
                return;
            }

            if (string.IsNullOrWhiteSpace(keytb.Text))
            {
                MessageBox.Show("Please enter a value to identify the client");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this client?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
            if (dr != DialogResult.Yes) return;

            string query = radioone.Checked
                ? "DELETE FROM customers WHERE Contact=@key"
                : "DELETE FROM customers WHERE NID=@key";

            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@key", keytb.Text.Trim());

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Client deleted successfully!");
                    ClearFields();
                }
                else
                    MessageBox.Show("Delete failed. Client not found.");
            }
        }
    }
}
