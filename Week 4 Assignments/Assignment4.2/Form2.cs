using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._2
{
    public partial class Teacher_Form : Form
    {
        public Teacher_Form()
        {
            InitializeComponent();
        }
        private void AddStudent_Label_Click(object sender, EventArgs e)
        {
            AddStudent_Form AddStudent = new AddStudent_Form(this);
            AddStudent.Show();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteStudent_Button_Click(object sender, EventArgs e)
        {

        }
        public void UpdateListView()
        {
            StudentList_ListView.Items.Clear();
            foreach (var student in Program.studentList)
            {
                var row = new ListViewItem(student.StudentName);
                row.SubItems.Add(student.StudentName);
                StudentList_ListView.Items.Add(row);
            }
        }
        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            { 
                using (StreamWriter writer = new StreamWriter("C:\\MSSA\\Test.txt"))
                {
                    writer.WriteLine(Program.studentList[0].GPA);
                    writer.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                MessageBox.Show("Successfully saved file.");
            }
        }
    }
}
