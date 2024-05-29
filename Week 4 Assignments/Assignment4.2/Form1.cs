namespace Assignment4._2
{
    public partial class Login_Form : Form
    {

        bool loginStatus = false;
        string userName = "Teacher";
        string password = "Admin";
        public Login_Form()
        {
            InitializeComponent();
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (Username_TextBox.Text == userName && Password_TextBox.Text == password)
            {
                //Successful login
                loginStatus = true;
                Teacher_Form TeacherForm = new Teacher_Form();
                TeacherForm.Show();
                Username_TextBox.Clear();
                Password_TextBox.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }
    }
}
