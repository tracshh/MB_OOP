namespace Project_OOP
{
    public partial class login : Form
    {
        int Balance_1 = 3000000;
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_input_username.Text;
            string pass = txt_input_pass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
                MessageBox.Show("لطفا فیلدها را پر کنید",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            else if (username == "tracy" && pass == "4321")
            {
                this.Hide();
                new main(Balance_1).Show();
            }
            else
                MessageBox.Show("رمز کاربری یا پسورد اشتباه است",
                                "Error",
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);

        }
    }
}