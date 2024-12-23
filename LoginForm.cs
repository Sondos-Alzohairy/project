namespace project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            SignUp signUpForm = new SignUp();


            signUpForm.Show();


            this.Hide();
        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                if (username == "admin" && password == "password")
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.passwordTextBox.PasswordChar = '*';

        }
    }
}
