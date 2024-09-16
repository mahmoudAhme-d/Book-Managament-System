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

namespace book_Online_Shop_Form
{
    public partial class ReaderHomePage : Form
    {
        Reader reader;
        public ReaderHomePage(Reader reader)
        {
            InitializeComponent();
            this.reader = reader;
            List<Book> myBooks = reader.GetBooks();
            DisplayBooksControl.books = myBooks;
        }

        private void ReaderHomePage_Load(object sender, EventArgs e)
        {



        }

        private void AccountSettingBtn_Click(object sender, EventArgs e)
        {
            ReaderAcoountSettings readerAcoountSettings = new ReaderAcoountSettings(reader);

            readerAcoountSettings.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderBookBtn_Click(object sender, EventArgs e)
        {
            Book SelectedBookByUser;
            SelectedBookByUser = displayBooksControl1.GetSelectedBook();

            if (SelectedBookByUser == null)
            {
                MessageBox.Show("Select Book to Order");
                return;
            }
            else
            {


                reader.OrderBook(SelectedBookByUser.bookID, reader.UserID);

                RefreshDataGridView();
                MessageBox.Show("Ordered succesfully");




            }



        }
        private void RefreshDataGridView()
        {
            List<Book> updatedBookList = reader.GetBooks();
            displayBooksControl1.BooksDataSource = updatedBookList;
        }

        private void OrderedBookList_Click(object sender, EventArgs e)
        {
            List<OrderedBooks> orderedBookList=new List<OrderedBooks>();

            orderedBookList = reader.GetOrderedBooks(reader.UserID);

            OrderedBookList bookList = new OrderedBookList(orderedBookList);
            bookList.Show();


        }
    }
}
