namespace UserBase
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //Declare all the required variable for the click event.
            string name;
            string surname;
            string gender;
            string email;
            string password;
            string confirmPassword;

            //Get user data from user input.
            name = NameTxt.Text;
            surname = SurnameTxt.Text;
            email = EmailTxt.Text;
            password = PasswordTxt.Text;
            confirmPassword = ConfirmPasswordTxt.Text;

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
