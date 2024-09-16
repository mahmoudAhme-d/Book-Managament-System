using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using BookOnlineShopEnums;

namespace Book_Online_Shop
{
    internal class BookRepository
    {
        DBAccess dbAccess;
        public BookRepository()
        {
            dbAccess = new DBAccess(); 
        }

        internal void DecreaseAvailableCopy(int bookID)
        {
           
                string query = "UPDATE Book SET AvailableCopy = AvailableCopy - 1 WHERE BookID = @BookID AND AvailableCopy > 0";

                SqlParameter[] parameters =
                {
                     new SqlParameter("@BookID", SqlDbType.Int) { Value = bookID }
                };

                dbAccess.ExecuteNonQuery(query, parameters);
            
        }

        internal int DeleteBook(Book book)
        {
           string deleteQuery = "DELETE FROM Book WHERE BookID = @BookID";
           int  bookIdToDelete = book.bookID;
           SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@BookID", bookIdToDelete)
           };

            int affectedRows = dbAccess.ExecuteNonQuery(deleteQuery, parameters);
            return affectedRows;
        }

        internal int  InsertBook(Book book)
        {
            string query = "INSERT INTO Book (Name, Author, Category, AvailableCopy, Price) VALUES (@Name, @Author, @Category, @AvailableCopy, @Price)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", book.Name),
                new SqlParameter("@Author", book.Author),
                new SqlParameter("@Category", book.Category),
                new SqlParameter("@AvailableCopy", book.availableCopy),
                new SqlParameter("@Price", book.price)
            };

          return  dbAccess.ExecuteNonQuery(query, parameters);
        }

        internal List<Book> selectAllBooks()
        {
            string query = "SELECT * FROM Book ";
            DataTable dataTable = dbAccess.ExecuteQuery(query, new SqlParameter[0]);

            List<Book> books = new List<Book>();

            foreach (DataRow row in dataTable.Rows)
            {
                Book book = new Book
                {
                    bookID = Convert.ToInt32(row[BookColumns.BookID.ToString()]),
                    Author = row[BookColumns.Author.ToString()].ToString(),
                    Category = row[BookColumns.Category.ToString()].ToString(),
                    Name = row[BookColumns.Name.ToString()].ToString(),
                    price = Convert.ToDecimal(row[BookColumns.Price.ToString()]),
                    availableCopy = Convert.ToInt32(row[BookColumns.AvailableCopy.ToString()])
                };
                books.Add(book);
            }

            return books;


        }

        internal List<Book> selectAvailableBooks()
        {
            string query = "SELECT * FROM Book where AvailableCopy>0";
            DataTable dataTable = dbAccess.ExecuteQuery(query, new SqlParameter[0]);

            List<Book> books = new List<Book>();

            foreach (DataRow row in dataTable.Rows)
            {
                Book book = new Book
                {
                    bookID = Convert.ToInt32(row[BookColumns.BookID.ToString()]),
                    Author = row[BookColumns.Author.ToString()].ToString(),
                    Category = row[BookColumns.Category.ToString()].ToString(),
                    Name = row[BookColumns.Name.ToString()].ToString(),
                    price = Convert.ToDecimal(row[BookColumns.Price.ToString()]),
                    availableCopy = Convert.ToInt32(row[BookColumns.AvailableCopy.ToString()])
                };
                books.Add(book);
            }

            return books;
        }

        internal List<OrderedBooks> selectOrderedBooks(int userID)
        {
            List<OrderedBooks> orderedBooks = new List<OrderedBooks>();

            string query = @"
        SELECT b.Name AS BookName, rb.NumberOfCopies
        FROM ReadersOrderedBooks rb
        INNER JOIN Book b ON rb.BookID = b.BookID
        WHERE rb.UserID = @UserID";

            SqlParameter[] parameters =
            {
        new SqlParameter("@UserID", SqlDbType.Int) { Value = userID }
    };

            DataTable dataTable = dbAccess.ExecuteQuery(query, parameters);

            foreach (DataRow row in dataTable.Rows)
            {
                OrderedBooks book = new OrderedBooks
                {
                    Name = row["BookName"].ToString(),
                    NumberOfCopies = Convert.ToInt32(row["NumberOfCopies"])
                };
                orderedBooks.Add(book);
            }

            return orderedBooks;
        }

        internal int UpdateBookCell(int bookID, string columnName, string? newValue)
        {
            string query = $"UPDATE Book SET [{columnName}] = @NewValue WHERE BookID = @BookID";

            // Parameters
            SqlParameter[] parameters =
            {
                new SqlParameter("@NewValue", SqlDbType.NVarChar) { Value = newValue },
                new SqlParameter("@BookID", SqlDbType.Int) { Value = bookID }
              };

            // Execute the query
            return dbAccess.ExecuteNonQuery(query, parameters);
        }

        internal void UpdateReadersOrderdBooks(int bookID, int userID)
        {
            // Check if the record exists
            string selectQuery = "SELECT * FROM ReadersOrderedBooks WHERE BookID = @BookID AND UserID = @UserID";
            SqlParameter[] selectParameters =
            {
              new SqlParameter("@BookID", SqlDbType.Int) { Value = bookID },
               new SqlParameter("@UserID", SqlDbType.Int) { Value = userID }
             };

            DataTable resultTable = dbAccess.ExecuteQuery(selectQuery, selectParameters);

            if (resultTable.Rows.Count > 0)
            {
                // Record exists, update the NumberOfCopies
                string updateQuery = "UPDATE ReadersOrderedBooks SET NumberOfCopies = NumberOfCopies + 1 WHERE BookID = @BookID AND UserID = @UserID";
                SqlParameter[] updateParameters =
                {
                 new SqlParameter("@BookID", SqlDbType.Int) { Value = bookID },
                 new SqlParameter("@UserID", SqlDbType.Int) { Value = userID }
                 };
                dbAccess.ExecuteNonQuery(updateQuery, updateParameters);
            }
            else
            {
                // Record does not exist, insert a new row
                string insertQuery = "INSERT INTO ReadersOrderedBooks (UserID, BookID, NumberOfCopies) VALUES (@UserID, @BookID, 1)";
                SqlParameter[] insertParameters =
                {
                  new SqlParameter("@BookID", SqlDbType.Int) { Value = bookID },
                    new SqlParameter("@UserID", SqlDbType.Int) { Value = userID }
                  };
                dbAccess.ExecuteNonQuery(insertQuery, insertParameters);
            }


        }






    }
}
