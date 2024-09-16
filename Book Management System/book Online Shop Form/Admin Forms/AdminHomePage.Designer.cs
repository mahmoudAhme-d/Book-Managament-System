namespace book_Online_Shop_Form
{
    partial class AdminHomePage
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
            panel1 = new Panel();
            AddBookBtn = new Button();
            AccountSettingBtn = new Button();
            UpdateBookBTn = new Button();
            DeleteBookBtn = new Button();
            LogOutBtn = new Button();
            bookControl2 = new BookControl();
            SaveUpdates = new Button();
            bookControl1 = new BookControl();
            AddBtn = new Button();
            displayBooksControl1 = new DisplayBooksControl();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(AddBookBtn);
            panel1.Controls.Add(AccountSettingBtn);
            panel1.Controls.Add(UpdateBookBTn);
            panel1.Controls.Add(DeleteBookBtn);
            panel1.Location = new Point(9, 94);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 618);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // AddBookBtn
            // 
            AddBookBtn.Location = new Point(8, 15);
            AddBookBtn.Margin = new Padding(4, 5, 4, 5);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(333, 71);
            AddBookBtn.TabIndex = 14;
            AddBookBtn.Text = "Add Book";
            AddBookBtn.UseVisualStyleBackColor = true;
            AddBookBtn.Click += AddBookBtn_Click;
            // 
            // AccountSettingBtn
            // 
            AccountSettingBtn.Location = new Point(4, 538);
            AccountSettingBtn.Margin = new Padding(4, 5, 4, 5);
            AccountSettingBtn.Name = "AccountSettingBtn";
            AccountSettingBtn.Size = new Size(333, 75);
            AccountSettingBtn.TabIndex = 20;
            AccountSettingBtn.Text = "Account Settings";
            AccountSettingBtn.UseVisualStyleBackColor = true;
            AccountSettingBtn.Click += AccountSettingBtn_Click;
            // 
            // UpdateBookBTn
            // 
            UpdateBookBTn.Location = new Point(4, 96);
            UpdateBookBTn.Margin = new Padding(4, 5, 4, 5);
            UpdateBookBTn.Name = "UpdateBookBTn";
            UpdateBookBTn.Size = new Size(333, 71);
            UpdateBookBTn.TabIndex = 3;
            UpdateBookBTn.Text = "Update Book";
            UpdateBookBTn.UseVisualStyleBackColor = true;
            UpdateBookBTn.Click += UpdateBookBTn_Click;
            // 
            // DeleteBookBtn
            // 
            DeleteBookBtn.Location = new Point(4, 177);
            DeleteBookBtn.Margin = new Padding(4, 5, 4, 5);
            DeleteBookBtn.Name = "DeleteBookBtn";
            DeleteBookBtn.Size = new Size(333, 75);
            DeleteBookBtn.TabIndex = 2;
            DeleteBookBtn.Text = "Delete Book";
            DeleteBookBtn.UseVisualStyleBackColor = true;
            DeleteBookBtn.Click += DeleteBookBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.LightBlue;
            LogOutBtn.Location = new Point(17, 873);
            LogOutBtn.Margin = new Padding(4, 5, 4, 5);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(162, 75);
            LogOutBtn.TabIndex = 22;
            LogOutBtn.Text = "Log Out";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // bookControl2
            // 
            bookControl2.AuthorText = "";
            bookControl2.AvailableCopyText = "";
            bookControl2.BookNameText = "";
            bookControl2.CategoryText = "";
            bookControl2.Location = new Point(566, 546);
            bookControl2.Name = "bookControl2";
            bookControl2.PriceText = "";
            bookControl2.Size = new Size(1062, 109);
            bookControl2.TabIndex = 8;
            bookControl2.Visible = false;
            bookControl2.Load += bookControl2_Load;
            // 
            // SaveUpdates
            // 
            SaveUpdates.Location = new Point(1619, 824);
            SaveUpdates.Name = "SaveUpdates";
            SaveUpdates.Size = new Size(229, 62);
            SaveUpdates.TabIndex = 10;
            SaveUpdates.Text = "Save Changes";
            SaveUpdates.UseVisualStyleBackColor = true;
            SaveUpdates.Visible = false;
            SaveUpdates.Click += SaveUpdates_Click;
            // 
            // bookControl1
            // 
            bookControl1.AuthorText = "";
            bookControl1.AvailableCopyText = "";
            bookControl1.BookNameText = "";
            bookControl1.CategoryText = "";
            bookControl1.Location = new Point(468, 796);
            bookControl1.Name = "bookControl1";
            bookControl1.PriceText = "";
            bookControl1.Size = new Size(1062, 109);
            bookControl1.TabIndex = 9;
            bookControl1.Visible = false;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(913, 678);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(229, 62);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add Book";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Visible = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // displayBooksControl1
            // 
            displayBooksControl1.BooksDataSource = null;
            displayBooksControl1.Location = new Point(468, 62);
            displayBooksControl1.Name = "displayBooksControl1";
            displayBooksControl1.Size = new Size(1548, 479);
            displayBooksControl1.TabIndex = 11;
            displayBooksControl1.Load += displayBooksControl1_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(884, 758);
            label1.Name = "label1";
            label1.Size = new Size(275, 35);
            label1.TabIndex = 12;
            label1.Text = "Update Selected Book";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(953, 493);
            label2.Name = "label2";
            label2.Size = new Size(130, 35);
            label2.TabIndex = 13;
            label2.Text = "Add Book";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1924, 953);
            Controls.Add(LogOutBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(displayBooksControl1);
            Controls.Add(SaveUpdates);
            Controls.Add(bookControl1);
            Controls.Add(bookControl2);
            Controls.Add(AddBtn);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminHomePage";
            Text = "AdminHomePage";
            Load += AdminHomePage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.CodeDom.CodeTypeReference userControl11;
        private System.CodeDom.CodeTypeReference userControl12;

        private Button DeleteBookBtn;
        private Button UpdateBookBTn;
        private BookControl bookControl2;
        private Button SaveUpdates;
        private BookControl bookControl1;
        private Button AddBtn;
        private DisplayBooksControl displayBooksControl1;
        private Label label1;
        private Label label2;
        private Button AccountSettingBtn;
        private Button AddBookBtn;
        private Button LogOutBtn;
    }
}