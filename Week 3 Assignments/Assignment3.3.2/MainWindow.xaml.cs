using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3._3._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> StudentList = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {

            var student = new Student();

            if (String.IsNullOrEmpty(this.studentID.Text))
            {
                MessageBox.Show("The student must have a Student ID.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
                student.StudentId = this.studentID.Text;

            if (String.IsNullOrEmpty(this.firstName.Text))
            {
                MessageBox.Show("The student must have a First name.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
                student.FirstName = this.firstName.Text;

            if (String.IsNullOrEmpty(this.lastName.Text))
            {
                MessageBox.Show("The student must have a Last name.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
                student.LastName = this.lastName.Text;

            if (String.IsNullOrEmpty(this.address.Text))
            {
                MessageBox.Show("The student must have an address.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
                student.Address = this.address.Text;

            if (String.IsNullOrEmpty(this.monthOfAdmission.Text))
            {
                MessageBox.Show("The student must have a month of admission.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
                student.MonthOfAdmisson = this.monthOfAdmission.Text;

            if (String.IsNullOrEmpty(this.GPA.Text))
            {
                MessageBox.Show("The student must have a Student ID", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
                student.GPA = Double.Parse(this.GPA.Text);

            StudentList.Add(student);
        }
    }
}