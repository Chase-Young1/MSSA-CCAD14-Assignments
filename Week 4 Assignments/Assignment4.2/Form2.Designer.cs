namespace Assignment4._2
{
    partial class Teacher_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddStudent_Label = new Button();
            Logout_Button = new Button();
            StudentList_ListView = new ListView();
            StudentList_Label = new Label();
            DeleteStudent_Button = new Button();
            Save_Button = new Button();
            SuspendLayout();
            // 
            // AddStudent_Label
            // 
            AddStudent_Label.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddStudent_Label.Location = new Point(12, 12);
            AddStudent_Label.Name = "AddStudent_Label";
            AddStudent_Label.Size = new Size(168, 46);
            AddStudent_Label.TabIndex = 6;
            AddStudent_Label.Text = "Add Student";
            AddStudent_Label.UseVisualStyleBackColor = true;
            AddStudent_Label.Click += AddStudent_Label_Click;
            // 
            // Logout_Button
            // 
            Logout_Button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout_Button.Location = new Point(697, 404);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(75, 34);
            Logout_Button.TabIndex = 9;
            Logout_Button.Text = "Logout";
            Logout_Button.UseVisualStyleBackColor = true;
            Logout_Button.Click += Logout_Button_Click;
            // 
            // StudentList_ListView
            // 
            StudentList_ListView.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentList_ListView.Location = new Point(306, 39);
            StudentList_ListView.Name = "StudentList_ListView";
            StudentList_ListView.Size = new Size(322, 240);
            StudentList_ListView.TabIndex = 10;
            StudentList_ListView.UseCompatibleStateImageBehavior = false;
            // 
            // StudentList_Label
            // 
            StudentList_Label.AutoSize = true;
            StudentList_Label.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentList_Label.Location = new Point(397, 12);
            StudentList_Label.Name = "StudentList_Label";
            StudentList_Label.Size = new Size(131, 24);
            StudentList_Label.TabIndex = 11;
            StudentList_Label.Text = "Student List";
            // 
            // DeleteStudent_Button
            // 
            DeleteStudent_Button.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteStudent_Button.Location = new Point(12, 116);
            DeleteStudent_Button.Name = "DeleteStudent_Button";
            DeleteStudent_Button.Size = new Size(168, 46);
            DeleteStudent_Button.TabIndex = 12;
            DeleteStudent_Button.Text = "Delete Student";
            DeleteStudent_Button.UseVisualStyleBackColor = true;
            DeleteStudent_Button.Click += DeleteStudent_Button_Click;
            // 
            // Save_Button
            // 
            Save_Button.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save_Button.Location = new Point(12, 64);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(168, 46);
            Save_Button.TabIndex = 13;
            Save_Button.Text = "Save To File";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Button_Click;
            // 
            // Teacher_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save_Button);
            Controls.Add(DeleteStudent_Button);
            Controls.Add(StudentList_Label);
            Controls.Add(StudentList_ListView);
            Controls.Add(Logout_Button);
            Controls.Add(AddStudent_Label);
            Name = "Teacher_Form";
            Text = "Teacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddStudent_Label;
        private Button Logout_Button;
        private ListView StudentList_ListView;
        private Label StudentList_Label;
        private Button DeleteStudent_Button;
        private Button Save_Button;
    }
}