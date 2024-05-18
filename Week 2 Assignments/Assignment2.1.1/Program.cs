namespace Assignment2._1._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentId = 1;
            student.StudentFirstName = "Chase";
            student.StudentLastName = "Young";
            student.StudentGrade = 'A';
            Console.WriteLine("Student ID: " + student.StudentId);
            Console.WriteLine("Student first name: " + student.StudentFirstName);
            Console.WriteLine("Student last name: " + student.StudentLastName);
            Console.WriteLine("Student grade: " + student.StudentGrade);
        }
    }
    public class Student
    {
        private int _studentId;
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }

        }
        private string _studentFirstName;
        public string StudentFirstName
        {
            get { return _studentFirstName; }
            set { _studentFirstName = value; }
        }
        private string _studentLastName;
        public string StudentLastName
        {
            get { return _studentLastName; }
            set { _studentLastName = value; }
        }
        private char _studentGrade;
        public char StudentGrade
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }
    }
}