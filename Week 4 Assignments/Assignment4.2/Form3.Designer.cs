namespace Assignment4._2
{
    partial class AddStudent_Form
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
            GPA_TextBox = new TextBox();
            StudentName_TextBox = new TextBox();
            StudentID_TextBox = new TextBox();
            GPA_Label = new Label();
            StudentName_Label = new Label();
            StudentID_Label = new Label();
            Add_Button = new Button();
            SuspendLayout();
            // 
            // GPA_TextBox
            // 
            GPA_TextBox.Location = new Point(133, 99);
            GPA_TextBox.Name = "GPA_TextBox";
            GPA_TextBox.Size = new Size(252, 23);
            GPA_TextBox.TabIndex = 11;
            // 
            // StudentName_TextBox
            // 
            StudentName_TextBox.Location = new Point(133, 52);
            StudentName_TextBox.Name = "StudentName_TextBox";
            StudentName_TextBox.Size = new Size(252, 23);
            StudentName_TextBox.TabIndex = 10;
            // 
            // StudentID_TextBox
            // 
            StudentID_TextBox.Location = new Point(133, 13);
            StudentID_TextBox.Name = "StudentID_TextBox";
            StudentID_TextBox.Size = new Size(252, 23);
            StudentID_TextBox.TabIndex = 9;
            // 
            // GPA_Label
            // 
            GPA_Label.AutoSize = true;
            GPA_Label.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GPA_Label.Location = new Point(78, 104);
            GPA_Label.Name = "GPA_Label";
            GPA_Label.Size = new Size(49, 18);
            GPA_Label.TabIndex = 8;
            GPA_Label.Text = "GPA:";
            // 
            // StudentName_Label
            // 
            StudentName_Label.AutoSize = true;
            StudentName_Label.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentName_Label.Location = new Point(1, 57);
            StudentName_Label.Name = "StudentName_Label";
            StudentName_Label.Size = new Size(126, 18);
            StudentName_Label.TabIndex = 7;
            StudentName_Label.Text = "Student Name:";
            // 
            // StudentID_Label
            // 
            StudentID_Label.AutoSize = true;
            StudentID_Label.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentID_Label.Location = new Point(30, 18);
            StudentID_Label.Name = "StudentID_Label";
            StudentID_Label.Size = new Size(97, 18);
            StudentID_Label.TabIndex = 6;
            StudentID_Label.Text = "Student ID:";
            // 
            // Add_Button
            // 
            Add_Button.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_Button.Location = new Point(182, 128);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(151, 60);
            Add_Button.TabIndex = 12;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = true;
            Add_Button.Click += Add_Button_Click;
            // 
            // AddStudent_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Add_Button);
            Controls.Add(GPA_TextBox);
            Controls.Add(StudentName_TextBox);
            Controls.Add(StudentID_TextBox);
            Controls.Add(GPA_Label);
            Controls.Add(StudentName_Label);
            Controls.Add(StudentID_Label);
            Name = "AddStudent_Form";
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox GPA_TextBox;
        private TextBox StudentName_TextBox;
        private TextBox StudentID_TextBox;
        private Label GPA_Label;
        private Label StudentName_Label;
        private Label StudentID_Label;
        private Button Add_Button;
    }
}