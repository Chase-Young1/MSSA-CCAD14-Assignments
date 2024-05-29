namespace Assignment4._1._1
{
    partial class PhoneBook_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Enter_Button = new Button();
            FirstName_Label = new Label();
            LastName_Label = new Label();
            MobilePhone_Label = new Label();
            WorkPhone_Label = new Label();
            Address_Label = new Label();
            FirstName_TextBox = new TextBox();
            LastName_TextBox = new TextBox();
            MobilePhone_TextBox = new TextBox();
            WorkPhone_TextBox = new TextBox();
            Address_TextBox = new TextBox();
            SuspendLayout();
            // 
            // Enter_Button
            // 
            Enter_Button.Location = new Point(92, 189);
            Enter_Button.Name = "Enter_Button";
            Enter_Button.Size = new Size(118, 25);
            Enter_Button.TabIndex = 0;
            Enter_Button.Text = "Enter";
            Enter_Button.UseVisualStyleBackColor = true;
            Enter_Button.Click += Enter_Button_Click;
            // 
            // FirstName_Label
            // 
            FirstName_Label.AutoSize = true;
            FirstName_Label.Location = new Point(7, 20);
            FirstName_Label.Name = "FirstName_Label";
            FirstName_Label.Size = new Size(67, 15);
            FirstName_Label.TabIndex = 1;
            FirstName_Label.Text = "First Name:";
            // 
            // LastName_Label
            // 
            LastName_Label.AutoSize = true;
            LastName_Label.Location = new Point(7, 52);
            LastName_Label.Name = "LastName_Label";
            LastName_Label.Size = new Size(66, 15);
            LastName_Label.TabIndex = 2;
            LastName_Label.Text = "Last Name:";
            // 
            // MobilePhone_Label
            // 
            MobilePhone_Label.AutoSize = true;
            MobilePhone_Label.Location = new Point(7, 85);
            MobilePhone_Label.Name = "MobilePhone_Label";
            MobilePhone_Label.Size = new Size(84, 15);
            MobilePhone_Label.TabIndex = 3;
            MobilePhone_Label.Text = "Mobile Phone:";
            // 
            // WorkPhone_Label
            // 
            WorkPhone_Label.AutoSize = true;
            WorkPhone_Label.Location = new Point(7, 119);
            WorkPhone_Label.Name = "WorkPhone_Label";
            WorkPhone_Label.Size = new Size(75, 15);
            WorkPhone_Label.TabIndex = 4;
            WorkPhone_Label.Text = "Work Phone:";
            // 
            // Address_Label
            // 
            Address_Label.AutoSize = true;
            Address_Label.Location = new Point(7, 151);
            Address_Label.Name = "Address_Label";
            Address_Label.Size = new Size(49, 15);
            Address_Label.TabIndex = 5;
            Address_Label.Text = "Address";
            // 
            // FirstName_TextBox
            // 
            FirstName_TextBox.Location = new Point(92, 12);
            FirstName_TextBox.Name = "FirstName_TextBox";
            FirstName_TextBox.Size = new Size(158, 23);
            FirstName_TextBox.TabIndex = 6;
            // 
            // LastName_TextBox
            // 
            LastName_TextBox.Location = new Point(92, 44);
            LastName_TextBox.Name = "LastName_TextBox";
            LastName_TextBox.Size = new Size(158, 23);
            LastName_TextBox.TabIndex = 7;
            // 
            // MobilePhone_TextBox
            // 
            MobilePhone_TextBox.Location = new Point(92, 77);
            MobilePhone_TextBox.Name = "MobilePhone_TextBox";
            MobilePhone_TextBox.Size = new Size(158, 23);
            MobilePhone_TextBox.TabIndex = 8;
            // 
            // WorkPhone_TextBox
            // 
            WorkPhone_TextBox.Location = new Point(92, 111);
            WorkPhone_TextBox.Name = "WorkPhone_TextBox";
            WorkPhone_TextBox.Size = new Size(158, 23);
            WorkPhone_TextBox.TabIndex = 9;
            // 
            // Address_TextBox
            // 
            Address_TextBox.Location = new Point(92, 143);
            Address_TextBox.Name = "Address_TextBox";
            Address_TextBox.Size = new Size(158, 23);
            Address_TextBox.TabIndex = 10;
            // 
            // PhoneBook_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Address_TextBox);
            Controls.Add(WorkPhone_TextBox);
            Controls.Add(MobilePhone_TextBox);
            Controls.Add(LastName_TextBox);
            Controls.Add(FirstName_TextBox);
            Controls.Add(Address_Label);
            Controls.Add(WorkPhone_Label);
            Controls.Add(MobilePhone_Label);
            Controls.Add(LastName_Label);
            Controls.Add(FirstName_Label);
            Controls.Add(Enter_Button);
            Name = "PhoneBook_Form";
            Text = "Phone Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enter_Button;
        private Label FirstName_Label;
        private Label LastName_Label;
        private Label MobilePhone_Label;
        private Label WorkPhone_Label;
        private Label Address_Label;
        private TextBox FirstName_TextBox;
        private TextBox LastName_TextBox;
        private TextBox MobilePhone_TextBox;
        private TextBox WorkPhone_TextBox;
        private TextBox Address_TextBox;
    }
}
