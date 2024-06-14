using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Online_Shop
{
    public class Book
    {
        private  decimal Price=0;
        private int AvailableCopy = 0;
        private string name;
        private string author;
        private string category;
        private int BookID;
        
        
        public string Name
        {
            get { return name; }
            set
            {
                
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be null.");
                }
                name = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Author cannot be null.");
                }
                author = value;
            }
        }


        public string Category
        {
            get { return category; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Category cannot be null.");
                }
                category = value;
            }
        }



        public int availableCopy
        {
            get { return AvailableCopy; }
            set { AvailableCopy = value; }
        }


        public decimal price
        {
            get { return Price; }
            set { Price = value; }
        }
        public int bookID
        {
            get { return BookID; }
            set { BookID = value; }
        }

    }
}
