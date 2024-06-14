using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Book_Online_Shop
{

    public class Reader : User
    {
        public Adress adress { get; set; }
        private string nationalID;
        BookRepository bookRepository;

     public Reader()
        { 
            adress = new Adress();
            bookRepository = new BookRepository();
        }
      
        public string NationalID
        {
            get { return nationalID; }
            set
            {
               
                nationalID = value;
            }
        }

       

        

        public override List<Book> GetBooks()
        {
            List<Book> books = bookRepository.selectAvailableBooks();
            return books;
           
        }

       

        public override List<Book> getBook(string name)
        {
            DBAccess access = new DBAccess();

            //  return access.GetBookIfavailable(name);
            return null;

        }
        public int UpdateCellInReaderDatabase(int AdminID, string columnName, string? newValue)
        {
            UserRepository repository = new UserRepository();
            return repository.UpdateReaderCell(AdminID, columnName, newValue);
        }

        public void OrderBook(int bookID,int UserID)
        {

            bookRepository.UpdateReadersOrderdBooks(bookID, UserID);
            bookRepository.DecreaseAvailableCopy(bookID);


        }

        public List<OrderedBooks> GetOrderedBooks(int userID)
        {
           return bookRepository.selectOrderedBooks(userID);
        }
    }
}
