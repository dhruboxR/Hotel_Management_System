namespace HMS
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm regform = new RegistrationForm();
            this.Hide();
            regform.ShowDialog();
            this.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchClient searchC = new SearchClient();
            this.Hide();
            searchC.ShowDialog();
            this.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            infoUpdate infoup = new infoUpdate();
            this.Hide();
            infoup.ShowDialog();
            this.Show();
        }
    }
}
