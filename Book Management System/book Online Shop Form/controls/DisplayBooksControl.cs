using Book_Online_Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookOnlineShopEnums;
namespace book_Online_Shop_Form
{
    public partial class DisplayBooksControl : UserControl
    {
        public static List<Book> books;
        public object BooksDataSource
        {
            get { return dataGridView1.DataSource; }
            set { dataGridView1.DataSource = value; }
        }
        public DisplayBooksControl()
        {
            InitializeComponent();

        }

        private void DisplayBooksControl_Load(object sender, EventArgs e)
        {
            LoadColumnNamesIntoComboBox();
            DisplayBooks();

        }


        private void LoadColumnNamesIntoComboBox()
        {
            List<string> columnNames = new List<string>
            {
                BookColumns.Author.ToString(),
                BookColumns.Category.ToString(),
                BookColumns.Name.ToString()
            };

            comboBoxColumns.DataSource = columnNames;
            

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxColumns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DisplayBooks()
        {
            dataGridView1.DataSource = books;
            dataGridView1.Columns["BookID"].Visible = false;

        }


        private void PerformSearch()
        {

            if (books == null || books.Count == 0)
                return;

            string selectedColumn = comboBoxColumns.SelectedItem?.ToString();
            string searchText = textBoxSearch.Text.Trim();

            if (!string.IsNullOrEmpty(selectedColumn) && !string.IsNullOrEmpty(searchText))
            {
                List<Book> filteredBooks = new List<Book>();

                foreach (var book in books)
                {
                    string valueToCheck = "";
                    switch (selectedColumn)
                    {
                        case nameof(BookColumns.Author):
                            valueToCheck = book.Author;
                            break;
                        case nameof(BookColumns.Category):
                            valueToCheck = book.Category;
                            break;
                        case nameof(BookColumns.Name):
                            valueToCheck = book.Name;
                            break;
                    }

                    if (CustomStartsWith(valueToCheck, searchText))
                    {
                        filteredBooks.Add(book);
                    }
                }

                dataGridView1.DataSource = filteredBooks;
            }
            else
            {
                dataGridView1.DataSource = books;
            }
        }

        private bool CustomStartsWith(string valueToCheck, string searchText)
        {
            if (string.IsNullOrEmpty(valueToCheck) || string.IsNullOrEmpty(searchText))
                return false;

            if (valueToCheck.Length < searchText.Length)
                return false;

            for (int i = 0; i < searchText.Length; i++)
            {
                if (char.ToLower(valueToCheck[i]) != char.ToLower(searchText[i]))
                    return false;
            }

            return true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        internal Book GetSelectedBook()
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedBook = (Book)selectedRow.DataBoundItem;
                return selectedBook;
            }

            return null;
        }
    }

}
