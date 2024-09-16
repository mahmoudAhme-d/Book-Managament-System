using System;

namespace Book_Online_Shop
{
    public class OrderedBooks
    {
        private string _name;
        private int _numberOfCopies;
     

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be null or empty.");
                }
                _name = value;
            }
        }

        public int NumberOfCopies
        {
            get { return _numberOfCopies; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Number of copies cannot be negative.");
                }
                _numberOfCopies = value;
            }
        }

       
        
    }
}
