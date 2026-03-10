using Microsoft.Data.SqlClient;

namespace HMS
{
    public partial class userLOGIN : Form
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dhrubo Roy\source\repos\HMS\HotelDatabase.mdf;Integrated Security = True; Connect Timeout = 30";
        public userLOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text.ToString();
            string password = passwordTextbox.Text.ToString();


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                DialogResult digres = MessageBox.Show("INVALID ~ FIELDS CAN'T BE EMPTY", "!! LOGIN ERROR !!", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONNECTION_STRING;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM user_table WHERE username = '" + username + "' AND password = '" + password + "'";
                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.HasRows)
                {
                    FormHome home = new FormHome();
                    home.Show();
                    this.Hide();    // CLOSES THE LOGIN PAGE 
                }
                else
                {
                    MessageBox.Show("INVALID USERNAME OR PASSWORD !!", "!! LOGIN ERROR !!", MessageBoxButtons.OK);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userLOGIN_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
