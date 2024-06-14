namespace book_Online_Shop_Form
{
    partial class AdminAcountSettings
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
            label1 = new Label();
            UsernameLabel = new Label();
            label2 = new Label();
            EmailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label3 = new Label();
            SaveChangesBtn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 59);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(122, 59);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(51, 20);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "label2";
            UsernameLabel.Click += UsernameLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 106);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(122, 103);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(172, 27);
            EmailTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(122, 150);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(125, 27);
            passwordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 157);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // SaveChangesBtn
            // 
            SaveChangesBtn.Location = new Point(148, 198);
            SaveChangesBtn.Name = "SaveChangesBtn";
            SaveChangesBtn.Size = new Size(146, 43);
            SaveChangesBtn.TabIndex = 6;
            SaveChangesBtn.Text = "Save Changes";
            SaveChangesBtn.UseVisualStyleBackColor = true;
            SaveChangesBtn.Click += SaveChangesBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(122, 9);
            label4.Name = "label4";
            label4.Size = new Size(260, 35);
            label4.TabIndex = 7;
            label4.Text = "Account Infomration";
            // 
            // AdminAcountSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 290);
            Controls.Add(label4);
            Controls.Add(SaveChangesBtn);
            Controls.Add(label3);
            Controls.Add(passwordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(label2);
            Controls.Add(UsernameLabel);
            Controls.Add(label1);
            Name = "AdminAcountSettings";
            Text = "AdminAcountSettings";
            Load += AdminAcountSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label UsernameLabel;
        private Label label2;
        private TextBox EmailTextBox;
        private TextBox passwordTextBox;
        private Label label3;
        private Button SaveChangesBtn;
        private Label label4;
    }
}