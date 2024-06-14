using BookOnlineShopEnums;
namespace Book_Online_Shop
{
    public class login
    {
        
        

        public login()
        {
        }

        public User Authentication(string username, string password, UserType userType)
        {           

          UserRepository userRepository=new UserRepository();

            User Authenticate;
            Authenticate = userRepository.AuthenticateUser(username, password, userType);

            return Authenticate;

        }


    }
}