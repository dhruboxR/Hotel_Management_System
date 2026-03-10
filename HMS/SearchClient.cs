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
    public partial class SearchClient : Form
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dhrubo Roy\source\repos\HMS\HotelDatabase.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True";

        // variables for showing client's data
        SqlDataAdapter adapter;
        DataTable dataTable;

        public SearchClient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchClient_Load(object sender, EventArgs e)
        {
            ShowCustomerData();
        }

        private void ShowCustomerData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "SELECT * FROM customers"; // change table name if needed

                    adapter = new SqlDataAdapter(query, con);
                    dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridViewAllclients.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            bool IdSearch = radioButtonCid.Checked;
            bool ContactSearch = radioButtonCphoneNumber.Checked;
            bool NameSearch = radioButtonCname.Checked;

            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            string keyval = key.Text.ToString();

            if (IdSearch)
            {
                MessageBox.Show("Search completed [ ID ]", "Result", MessageBoxButtons.OK);

                string query = "SELECT * FROM customers WHERE RoomID LIKE '%" + keyval + "%'";

                adapter = new SqlDataAdapter(query, con);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewSearchResult.DataSource = dataTable;


            }
            else if (ContactSearch)
            {
                MessageBox.Show("Search completed [ Contact No ]", "Result", MessageBoxButtons.OK);

                string query = "SELECT * FROM customers WHERE Contact LIKE '%" + keyval + "%'";

                adapter = new SqlDataAdapter(query, con);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewSearchResult.DataSource = dataTable;

            }
            else if (NameSearch)
            {
                MessageBox.Show("Search completed [ Name ]", "Result", MessageBoxButtons.OK);

                string query = "SELECT * FROM customers WHERE Name LIKE '%" + keyval + "%'";

                adapter = new SqlDataAdapter(query, con);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewSearchResult.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("Please select one method for searching", "!! E R R O R !!", MessageBoxButtons.OK);
            }
        }

        private void groupBoxSearch_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
