using Book_Online_Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using BookOnlineShopEnums;
using System.Reflection.Emit;

namespace book_Online_Shop_Form
{
    public partial class AdminHomePage : Form
    {
        Admin admin;
        public AdminHomePage(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;

            //initilize my User Control by the books list
            List<Book> MyBooks = admin.GetBooks();
            DisplayBooksControl.books = MyBooks;
        }



        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {

            Book SelectedBookByUser;
            SelectedBookByUser = displayBooksControl1.GetSelectedBook();

            if (SelectedBookByUser == null)
            {
                MessageBox.Show("Please Select Book First");
                return;
            }

            //if the user select book 

            int IsBookDeleted = admin.removeBook(SelectedBookByUser); //delete the book

            if (IsBookDeleted == 1)
            {
                MessageBox.Show("Deleted Succefully");
                // Update the DataGridView by reloading the book list
                RefreshDataGridView();
            }

        }

        private void UpdateBookBTn_Click(object sender, EventArgs e)
        {
            HideAddBookControls();

            Book SelectedBookByUser;
            SelectedBookByUser = displayBooksControl1.GetSelectedBook();

            if (SelectedBookByUser == null && bookControl1.SelectedBookByUser == null)
            {
                MessageBox.Show("Select Book to Update");
                return;
            }

            else
            {

                // show the selected book data in the user control 
                bookControl1.SelectedBookByUser = SelectedBookByUser;
                bookControl1.ShowBookData();


                //Show controls of updating book
                bookControl1.Visible = !(bookControl1.Visible);
                SaveUpdates.Visible = !(SaveUpdates.Visible);
                label1.Visible = !label1.Visible;
            }


        }




        private void SaveUpdates_Click(object sender, EventArgs e)
        {
            UpdateDataBase();
            MessageBox.Show("Succesfuly Updated");

            HideUpdateBookControl();
            RefreshDataGridView();
        }

        private void HideUpdateBookControl()
        {
            label1.Visible = false;
            bookControl1.Visible = false;
            SaveUpdates.Visible = false;

        }


        private void UpdateDataBase()
        {
            int bookID = bookControl1.SelectedBookByUser.bookID;

            UpdateDatabaseIfChanged(bookID, "Name", bookControl1.BookNameText, bookControl1.SelectedBookByUser.Name);
            UpdateDatabaseIfChanged(bookID, "Author", bookControl1.AuthorText, bookControl1.SelectedBookByUser.Author);
            UpdateDatabaseIfChanged(bookID, "Category", bookControl1.CategoryText, bookControl1.SelectedBookByUser.Category);
            UpdateDatabaseIfChanged(bookID, "AvailableCopy", bookControl1.AvailableCopyText, bookControl1.SelectedBookByUser.availableCopy.ToString());
            UpdateDatabaseIfChanged(bookID, "Price", bookControl1.PriceText, bookControl1.SelectedBookByUser.price.ToString());
        }

        private void UpdateDatabaseIfChanged(int bookID, string columnName, string newValue, string oldValue)
        {
            if (newValue != oldValue)
            {
                admin.UpdateCellInbookDatabase(bookID, columnName, newValue);
            }
        }

        private void RefreshDataGridView()
        {
            List<Book> updatedBookList = admin.GetBooks();
            displayBooksControl1.BooksDataSource = updatedBookList;
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(bookControl2.BookNameText) ||
            string.IsNullOrWhiteSpace(bookControl2.AuthorText) ||
            string.IsNullOrWhiteSpace(bookControl2.CategoryText) ||
            string.IsNullOrWhiteSpace(bookControl2.AvailableCopyText) ||
            string.IsNullOrWhiteSpace(bookControl2.PriceText))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }



            Book newBook = new Book
            {
                Name = bookControl2.BookNameText,
                Author = bookControl2.AuthorText,
                Category = bookControl2.CategoryText,
                availableCopy = int.Parse(bookControl2.AvailableCopyText),
                price = decimal.Parse(bookControl2.PriceText)
            };

            admin.addBook(newBook);

            MessageBox.Show("Added succesfully");

            RefreshDataGridView();



        }

        private void AccountSettingBtn_Click(object sender, EventArgs e)
        {
            AdminAcountSettings adminAcountSettings = new AdminAcountSettings(admin);

            adminAcountSettings.Show();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            HideUpdateBookControl();

            label2.Visible = !label2.Visible;
            bookControl2.Visible = !bookControl2.Visible;
            AddBtn.Visible = !AddBtn.Visible;
        }

        private void HideAddBookControls()
        {

            label2.Visible = false;
            bookControl2.Visible = false;
            AddBtn.Visible = false;

        }
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bookControl2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayBooksControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void updateBookControl1_Load(object sender, EventArgs e)
        {

        }
        private void AdminHomePage_Load(object sender, EventArgs e)
        {


        }


        private void manageBooks1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
