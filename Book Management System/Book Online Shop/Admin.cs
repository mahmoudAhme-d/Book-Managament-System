using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Online_Shop
{
    public class Admin : User
    {

        BookRepository bookRepository;
        UserRepository userRepository;
        public Admin() 
        {

            bookRepository = new BookRepository();
            userRepository=new UserRepository();
        }
        public override List<Book> GetBooks()
        {

            List<Book> books=  bookRepository.selectAllBooks();
            return books;
        }


        public int  addBook(Book book) 
        {
            bookRepository.InsertBook(book);
            return 0;
        }


        public int removeBook(Book book) 
        {
            return bookRepository.DeleteBook(book);
        }


        public override List<Book> getBook(string name)
        {
            DBAccess access = new DBAccess();

            // return access.GetBookAvailableOrNot(name);
            return null;
        }

        public int  UpdateCellInbookDatabase(int bookID, string columnName, string? newValue)
        {
            return bookRepository.UpdateBookCell(bookID, columnName, newValue);
        }


        

    }
}
