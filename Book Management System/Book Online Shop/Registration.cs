using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using BookOnlineShopEnums;
namespace Book_Online_Shop
{
    public class Registration
    {
        bool _registered = false;
        UserRepository userRepository;
        public Registration() 
        {
            userRepository = new UserRepository();

        }
        public bool SignUp(Reader reader )
        { 
            return userRepository.InsertReader(reader);
        }
        public bool SignUp(Admin admin)
        {

            return userRepository.InsertAdmin(admin);
        }

        public bool CheckUserNameValidity(string userName,UserType usertype) 
        {
            
            bool validityCheck;
            validityCheck = userRepository.checkUserNameExistence(userName, usertype);

            return validityCheck;                

        }

        
    }
}
