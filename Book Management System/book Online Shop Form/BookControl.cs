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
    public partial class BookControl : UserControl
    {
       

        public string BookNameText
        {
            get { return BookName.Text; }
            set { BookName.Text = value; }
        }

        public string AuthorText
        {
            get { return Auther.Text; }
            set { Auther.Text = value; }
        }

        public string CategoryText
        {
            get { return Category.Text; }
            set { Category.Text = value; }
        }

        public string AvailableCopyText
        {
            get { return AvailableCopy.Text; }
            set { AvailableCopy.Text = value; }
        }

        public string PriceText
        {
            get { return Price.Text; }
            set { Price.Text = value; }
        }

        public Book SelectedBookByUser { get; internal set; }

        public BookControl()
        {
            InitializeComponent();
        }
        private void BookControl_Load(object sender, EventArgs e)
        {
            
        }

        public void ShowBookData()
        {
            if (SelectedBookByUser != null)
            {
                BookName.Text = SelectedBookByUser.Name;
                Auther.Text = SelectedBookByUser.Author;
                Category.Text = SelectedBookByUser.Category;
                AvailableCopy.Text = SelectedBookByUser.availableCopy.ToString();
                Price.Text = SelectedBookByUser.price.ToString(); 
            }
        }

        private void BookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Auther_TextChanged(object sender, EventArgs e)
        {

        }

        private void Category_TextChanged(object sender, EventArgs e)
        {

        }

        private void AvailableCopy_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
