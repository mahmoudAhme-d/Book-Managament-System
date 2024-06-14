using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookOnlineShopEnums;
namespace Book_Online_Shop
{
    public abstract class User
    {
        private string userName;
        private string password;
        private string email;
        private int userID;
        private UserType enumUserType;
       
        
        public UserType EnumUserType
        {
            get { return enumUserType; }
            set
            {
                
                enumUserType = value;
            }


        }


        public string UserName
        {
            get { return userName; }
            set
            {
               
                userName = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
               
                password = value;
            }
        }


        public string Email
        {
            get { return email; }
            set
            {
               
                email = value;
            }


        }

        public int UserID
        {
            get { return userID; }
            set
            {

                userID = value;
            }
        }
        //Helper function to know if their is at least one  english char or not 
        private bool ContainsAlphabet(string input)
        {
            return input.Any(char.IsLetter);
        }

        public int UpdateCellInUserDatabase(int AdminID, string columnName, string? newValue)
        {
            UserRepository repository=new UserRepository();
            return repository.UpdateUserCell(AdminID, columnName, newValue);
        }
        public abstract List<Book> getBook(string name);
        
        public abstract List<Book> GetBooks();
    }
}
