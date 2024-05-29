namespace Assignment4._2
{
    partial class Login_Form
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
            Username_TextBox = new TextBox();
            Password_TextBox = new TextBox();
            Login_Button = new Button();
            Username_Label = new Label();
            Password_Label = new Label();
            SuspendLayout();
            // 
            // Username_TextBox
            // 
            Username_TextBox.Location = new Point(242, 146);
            Username_TextBox.Name = "Username_TextBox";
            Username_TextBox.Size = new Size(295, 23);
            Username_TextBox.TabIndex = 0;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Location = new Point(242, 175);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.Size = new Size(295, 23);
            Password_TextBox.TabIndex = 1;
            // 
            // Login_Button
            // 
            Login_Button.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Button.Location = new Point(300, 204);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(188, 37);
            Login_Button.TabIndex = 2;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_Label.Location = new Point(127, 147);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(109, 22);
            Username_Label.TabIndex = 3;
            Username_Label.Text = "Username:";
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_Label.Location = new Point(127, 176);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(106, 22);
            Password_Label.TabIndex = 4;
            Password_Label.Text = "Password:";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password_Label);
            Controls.Add(Username_Label);
            Controls.Add(Login_Button);
            Controls.Add(Password_TextBox);
            Controls.Add(Username_TextBox);
            Name = "Login_Form";
            Text = "Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username_TextBox;
        private TextBox Password_TextBox;
        private Button Login_Button;
        private Label Username_Label;
        private Label Password_Label;
    }
}
