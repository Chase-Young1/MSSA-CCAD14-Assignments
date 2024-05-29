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
    public partial class AddStudent_Form : Form
    {
        Student newStudent = new Student();
        private Teacher_Form teacherForm;
        public AddStudent_Form(Teacher_Form form)
        {
            InitializeComponent();
            this.teacherForm = form;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (StudentID_TextBox.Text != null)
            {
                newStudent.StudentId = StudentID_TextBox.Text;
            }
            else
            {
                MessageBox.Show("Enter a valid Student ID.");
            }
            if (StudentName_TextBox.Text != null)
            {
                newStudent.StudentName = StudentName_TextBox.Text;
            }
            else
            {
                MessageBox.Show("Enter a valid Student Name.");
            }
            if (GPA_TextBox.Text != null)
            {
                newStudent.GPA = double.Parse(GPA_TextBox.Text);
            }
            else
            {
                MessageBox.Show("Enter a valid GPA.");
            }
            StudentID_TextBox.Clear();
            StudentName_TextBox.Clear();
            GPA_TextBox.Clear();
            Program.studentList.Add(newStudent);
            teacherForm.UpdateListView();
        }
    }
}
