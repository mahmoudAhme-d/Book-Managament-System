namespace book_Online_Shop_Form
{
    partial class DisplayBooksControl
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
            label3 = new Label();
            label2 = new Label();
            textBoxSearch = new TextBox();
            label1 = new Label();
            comboBoxColumns = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(456, 56);
            label3.Name = "label3";
            label3.Size = new Size(170, 39);
            label3.TabIndex = 12;
            label3.Text = "My Books ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 17);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 11;
            label2.Text = "Seearch";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(502, 14);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(528, 27);
            textBoxSearch.TabIndex = 10;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 17);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 9;
            label1.Text = "Find By :";
            // 
            // comboBoxColumns
            // 
            comboBoxColumns.FormattingEnabled = true;
            comboBoxColumns.Location = new Point(189, 14);
            comboBoxColumns.Name = "comboBoxColumns";
            comboBoxColumns.Size = new Size(151, 28);
            comboBoxColumns.TabIndex = 8;
            comboBoxColumns.SelectedIndexChanged += comboBoxColumns_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(72, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(999, 282);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DisplayBooksControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Controls.Add(comboBoxColumns);
            Controls.Add(dataGridView1);
            Name = "DisplayBooksControl";
            Size = new Size(1238, 383);
            Load += DisplayBooksControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox textBoxSearch;
        private Label label1;
        private ComboBox comboBoxColumns;
        private DataGridView dataGridView1;
    }
}
