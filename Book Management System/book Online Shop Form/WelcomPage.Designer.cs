namespace book_Online_Shop_Form
{
    partial class WelcomPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomPage));
            Admin = new Button();
            Reader = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Admin
            // 
            Admin.Font = new Font("Segoe UI Symbol", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Admin.Location = new Point(173, 184);
            Admin.Name = "Admin";
            Admin.Size = new Size(272, 152);
            Admin.TabIndex = 0;
            Admin.Text = "Login as Admin";
            Admin.UseVisualStyleBackColor = true;
            Admin.Click += Login_Click;
            // 
            // Reader
            // 
            Reader.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Reader.Location = new Point(320, 564);
            Reader.Name = "Reader";
            Reader.Size = new Size(274, 143);
            Reader.TabIndex = 1;
            Reader.Text = "Registration";
            Reader.UseVisualStyleBackColor = true;
            Reader.Click += Registration_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(553, 184);
            button1.Name = "button1";
            button1.Size = new Size(272, 152);
            button1.TabIndex = 2;
            button1.Text = "Login as Reader";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // WelcomPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1541, 845);
            Controls.Add(button1);
            Controls.Add(Reader);
            Controls.Add(Admin);
            Cursor = Cursors.AppStarting;
            Name = "WelcomPage";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Admin;
        private Button Reader;
        private Button button1;
    }
}