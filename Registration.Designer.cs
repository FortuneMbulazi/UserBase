namespace UserBase
{
    partial class Registration
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
            NameLbl = new Label();
            NameTxt = new TextBox();
            SurnameLbl = new Label();
            EmailLbl = new Label();
            SurnameTxt = new TextBox();
            EmailTxt = new TextBox();
            GenderLbl = new Label();
            GenderCmb = new ComboBox();
            PasswordLbl = new Label();
            ConfirmPasswordTxt = new Label();
            PasswordTxt = new TextBox();
            textBox5 = new TextBox();
            RegisterBtn = new Button();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(124, 135);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(49, 20);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "Name";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(273, 128);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(226, 27);
            NameTxt.TabIndex = 1;
            // 
            // SurnameLbl
            // 
            SurnameLbl.AutoSize = true;
            SurnameLbl.Location = new Point(124, 187);
            SurnameLbl.Name = "SurnameLbl";
            SurnameLbl.Size = new Size(67, 20);
            SurnameLbl.TabIndex = 2;
            SurnameLbl.Text = "Surname";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Location = new Point(127, 242);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(46, 20);
            EmailLbl.TabIndex = 3;
            EmailLbl.Text = "Email";
            // 
            // SurnameTxt
            // 
            SurnameTxt.Location = new Point(273, 184);
            SurnameTxt.Name = "SurnameTxt";
            SurnameTxt.Size = new Size(226, 27);
            SurnameTxt.TabIndex = 4;
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(273, 239);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(226, 27);
            EmailTxt.TabIndex = 5;
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.Location = new Point(127, 300);
            GenderLbl.Name = "GenderLbl";
            GenderLbl.Size = new Size(57, 20);
            GenderLbl.TabIndex = 6;
            GenderLbl.Text = "Gender";
            // 
            // GenderCmb
            // 
            GenderCmb.Items.AddRange(new object[] { "Male", "Female", "Other" });
            GenderCmb.Location = new Point(273, 297);
            GenderCmb.Name = "GenderCmb";
            GenderCmb.Size = new Size(226, 28);
            GenderCmb.TabIndex = 14;
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(124, 355);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(70, 20);
            PasswordLbl.TabIndex = 8;
            PasswordLbl.Text = "Password";
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.AutoSize = true;
            ConfirmPasswordTxt.Location = new Point(124, 416);
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.Size = new Size(127, 20);
            ConfirmPasswordTxt.TabIndex = 9;
            ConfirmPasswordTxt.Text = "Confirm Password";
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(273, 352);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(226, 27);
            PasswordTxt.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(273, 413);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(226, 27);
            textBox5.TabIndex = 11;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(124, 517);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(150, 50);
            RegisterBtn.TabIndex = 12;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(352, 517);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(147, 50);
            LoginBtn.TabIndex = 13;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 628);
            Controls.Add(LoginBtn);
            Controls.Add(RegisterBtn);
            Controls.Add(textBox5);
            Controls.Add(PasswordTxt);
            Controls.Add(ConfirmPasswordTxt);
            Controls.Add(PasswordLbl);
            Controls.Add(GenderCmb);
            Controls.Add(GenderLbl);
            Controls.Add(EmailTxt);
            Controls.Add(SurnameTxt);
            Controls.Add(EmailLbl);
            Controls.Add(SurnameLbl);
            Controls.Add(NameTxt);
            Controls.Add(NameLbl);
            Name = "Registration";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private TextBox NameTxt;
        private Label SurnameLbl;
        private Label EmailLbl;
        private TextBox SurnameTxt;
        private TextBox EmailTxt;
        private Label GenderLbl;
        private ComboBox GenderCmb;
        private Label PasswordLbl;
        private Label ConfirmPasswordTxt;
        private TextBox PasswordTxt;
        private TextBox textBox5;
        private Button RegisterBtn;
        private Button LoginBtn;
    }
}
