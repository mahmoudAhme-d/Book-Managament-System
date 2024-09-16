namespace book_Online_Shop_Form
{
    partial class BookControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            BookName = new TextBox();
            Auther = new TextBox();
            Category = new TextBox();
            AvailableCopy = new TextBox();
            Price = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(748, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 16;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(533, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 15;
            label5.Text = "AvailableCopy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 14;
            label4.Text = "Auther";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 13;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // BookName
            // 
            BookName.Location = new Point(3, 38);
            BookName.Name = "BookName";
            BookName.Size = new Size(125, 27);
            BookName.TabIndex = 17;
            BookName.TextChanged += BookName_TextChanged;
            // 
            // Auther
            // 
            Auther.Location = new Point(148, 38);
            Auther.Name = "Auther";
            Auther.Size = new Size(169, 27);
            Auther.TabIndex = 18;
            Auther.TextChanged += Auther_TextChanged;
            // 
            // Category
            // 
            Category.Location = new Point(343, 38);
            Category.Name = "Category";
            Category.Size = new Size(159, 27);
            Category.TabIndex = 19;
            Category.TextChanged += Category_TextChanged;
            // 
            // AvailableCopy
            // 
            AvailableCopy.Location = new Point(524, 38);
            AvailableCopy.Name = "AvailableCopy";
            AvailableCopy.Size = new Size(125, 27);
            AvailableCopy.TabIndex = 20;
            AvailableCopy.TextChanged += AvailableCopy_TextChanged;
            // 
            // Price
            // 
            Price.Location = new Point(706, 38);
            Price.Name = "Price";
            Price.Size = new Size(125, 27);
            Price.TabIndex = 21;
            Price.TextChanged += Price_TextChanged;
            // 
            // BookControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Price);
            Controls.Add(AvailableCopy);
            Controls.Add(Category);
            Controls.Add(Auther);
            Controls.Add(BookName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookControl";
            Size = new Size(849, 87);
            Load += BookControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox BookName;
        private TextBox Auther;
        private TextBox Category;
        private TextBox AvailableCopy;
        private TextBox Price;
    }
}
