namespace Assignment10._1
{
    internal class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private string _gender;
        
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
