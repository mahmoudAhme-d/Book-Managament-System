namespace book_Online_Shop_Form
{
    partial class ReaderHomePage
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
            displayBooksControl1 = new DisplayBooksControl();
            panel1 = new Panel();
            OrderedBookList = new Button();
            AccountSettingBtn = new Button();
            LogOutBtn = new Button();
            OrderBookBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // displayBooksControl1
            // 
            displayBooksControl1.BooksDataSource = null;
            displayBooksControl1.Location = new Point(381, 62);
            displayBooksControl1.Name = "displayBooksControl1";
            displayBooksControl1.Size = new Size(1086, 393);
            displayBooksControl1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(OrderedBookList);
            panel1.Controls.Add(AccountSettingBtn);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 598);
            panel1.TabIndex = 1;
            // 
            // OrderedBookList
            // 
            OrderedBookList.Location = new Point(0, 90);
            OrderedBookList.Margin = new Padding(4, 5, 4, 5);
            OrderedBookList.Name = "OrderedBookList";
            OrderedBookList.Size = new Size(333, 75);
            OrderedBookList.TabIndex = 22;
            OrderedBookList.Text = "Order Book List";
            OrderedBookList.UseVisualStyleBackColor = true;
            OrderedBookList.Click += OrderedBookList_Click;
            // 
            // AccountSettingBtn
            // 
            AccountSettingBtn.Location = new Point(1, 5);
            AccountSettingBtn.Margin = new Padding(4, 5, 4, 5);
            AccountSettingBtn.Name = "AccountSettingBtn";
            AccountSettingBtn.Size = new Size(333, 75);
            AccountSettingBtn.TabIndex = 21;
            AccountSettingBtn.Text = "Account Settings";
            AccountSettingBtn.UseVisualStyleBackColor = true;
            AccountSettingBtn.Click += AccountSettingBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.LightBlue;
            LogOutBtn.Location = new Point(13, 881);
            LogOutBtn.Margin = new Padding(4, 5, 4, 5);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(162, 75);
            LogOutBtn.TabIndex = 23;
            LogOutBtn.Text = "Log Out";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // OrderBookBtn
            // 
            OrderBookBtn.Location = new Point(738, 502);
            OrderBookBtn.Margin = new Padding(4, 5, 4, 5);
            OrderBookBtn.Name = "OrderBookBtn";
            OrderBookBtn.Size = new Size(333, 75);
            OrderBookBtn.TabIndex = 24;
            OrderBookBtn.Text = "Order Book";
            OrderBookBtn.UseVisualStyleBackColor = true;
            OrderBookBtn.Click += OrderBookBtn_Click;
            // 
            // ReaderHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 952);
            Controls.Add(OrderBookBtn);
            Controls.Add(LogOutBtn);
            Controls.Add(panel1);
            Controls.Add(displayBooksControl1);
            Name = "ReaderHomePage";
            Text = "ReaderHomePage";
            Load += ReaderHomePage_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DisplayBooksControl displayBooksControl1;
        private Panel panel1;
        private Button LogOutBtn;
        private Button AccountSettingBtn;
        private Button OrderBookBtn;
        private Button OrderedBookList;
    }
}