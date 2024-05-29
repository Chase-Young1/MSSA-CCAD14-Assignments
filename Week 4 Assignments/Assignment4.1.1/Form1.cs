namespace Assignment4._1._1
{
    public partial class PhoneBook_Form : Form
    {
        Dictionary<string, Person> phoneBook = new Dictionary<string, Person>();
        public PhoneBook_Form()
        {
            InitializeComponent();
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();

            newPerson.FirstName = FirstName_TextBox.Text;
            newPerson.LastName = LastName_TextBox.Text;
            newPerson.MobilePhone = MobilePhone_TextBox.Text;
            newPerson.WorkPhone = WorkPhone_TextBox.Text;
            newPerson.Address = Address_TextBox.Text;

            string fullName = FirstName_TextBox.Text + LastName_TextBox.Text;
            phoneBook.Add(fullName, newPerson);

        }
    }
}
