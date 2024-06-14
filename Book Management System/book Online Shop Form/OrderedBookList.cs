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
    public partial class OrderedBookList : Form
    {
        List<OrderedBooks> orderedBookList;
        public OrderedBookList(List<OrderedBooks> orderedBookList)
        {

            InitializeComponent();
            this.orderedBookList = orderedBookList;
        }

        private void OrderedBookList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orderedBookList;
        }
    }
}
