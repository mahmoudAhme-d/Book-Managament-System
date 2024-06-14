using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Reflection.PortableExecutable;
using Book_Online_Shop;
using BookOnlineShopEnums;
namespace Book_Online_Shop
{
    internal class UserRepository
    {
        private readonly DBAccess dbAccess;
        
        public UserRepository()
        {
            dbAccess = new DBAccess();
        }
        

        public User AuthenticateUser(string username, string password, UserType userType)
        {
          
            string query;
            SqlParameter[] parameters = {
            new SqlParameter("@Username", username),
            new SqlParameter("@Password", password)
            };

            if (userType == UserType.Admin)
            {
                query = @"
                SELECT u.UserID, u.Username, u.Password, u.Email, u.UserType
                FROM [User] u
                JOIN Admin a ON u.UserID = a.UserID
                WHERE u.Username = @Username AND u.Password = @Password";
            }
            else if (userType == UserType.Reader)
            {
                query = @"
                SELECT u.UserID, u.Username, u.Password, u.Email, u.UserType,
                       r.NationalID, r.Building, r.State, r.City, r.Street
                FROM [User] u
                JOIN Reader r ON u.UserID = r.UserID
                WHERE u.Username = @Username AND u.Password = @Password";
            }
            else
            {
                return null; 
            }

            
            //This function retrun User After UpCasting it from Admin OR Reader 
             User user= SearchForUser(query, parameters, userType);
            return user;
        }


        internal bool checkUserNameExistence(string userName, UserType usertype)
        {
            bool NotExists = false;
            string query = "SELECT * FROM [User] WHERE Username = @Username AND UserType = @UserType";

            // Construct the SqlParameter array
            SqlParameter[] parameters = {
               new SqlParameter("@Username", SqlDbType.VarChar) { Value = userName },
                new SqlParameter("@UserType", SqlDbType.VarChar) { Value =usertype.ToString() }
            };

            User user = SearchForUser(query, parameters, UserType.Admin);
            if (user == null)
                NotExists = true;


                return NotExists;
            
           
        }

        internal bool InsertReader(Reader reader)
        {

            int RowInsertedInUserTable;
            RowInsertedInUserTable = InsertIntoUserTable(reader);

            int ReferenceKey= GetLastPrimaryKey(); // the userID of the last rowAdded

            int RowInsertedInReaderTable;
            RowInsertedInReaderTable= InsertIntoReaderTable(ReferenceKey,reader);

            if (RowInsertedInUserTable == 1 && RowInsertedInReaderTable == 1)
                return true;
            else return false;


        }
        internal bool InsertAdmin(Admin admin)
        {
            int RowInsertedInUserTable;
            RowInsertedInUserTable =InsertIntoUserTable(admin);

            int ReferenceKey = GetLastPrimaryKey();

            int RowInsertedInAdminTable;
            RowInsertedInAdminTable = InsertIntoAdminTable(ReferenceKey, admin);

            if (RowInsertedInUserTable == 1 && RowInsertedInAdminTable == 1)
                return true;
            else return false;
        }





        private User SearchForUser(string query, SqlParameter[] parameters, UserType userType)
        {
            DataTable result = dbAccess.ExecuteQuery(query, parameters);


            if (result.Rows.Count == 1)
            {
                if (userType == UserType.Admin)
                    return MapAdminUser(result.Rows[0]);

                else if (userType == UserType.Reader)
                    return MapReaderUser(result.Rows[0]); //Upcasting Reader to be User  

            }

            return null;
        }

        private User MapAdminUser(DataRow row)
        {
            return new Admin
            {
                UserID = Convert.ToInt32(row["UserID"]),
                UserName = row["Username"].ToString(),
                Password = row["Password"].ToString(),
                Email = row["Email"].ToString(),
            };


        }

        private User MapReaderUser(DataRow row)
        {

            return new Reader
            {
                UserID = Convert.ToInt32(row["UserID"]),
                UserName = row["Username"].ToString(),
                Password = row["Password"].ToString(),
                Email = row["Email"].ToString(),
                NationalID = row["NationalID"].ToString(),
                adress = new Adress
                {
                    Building = row["Building"].ToString(),
                    State = row["State"].ToString(),
                    City = row["City"].ToString(),
                    Street = row["Street"].ToString()
                }
            };



        }

        private int InsertIntoAdminTable(int referenceKey, Admin admin)
        {
            string query = @"INSERT INTO Admin (UserID) 
                             VALUES (@UserID)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", SqlDbType.Int) { Value = referenceKey }
                
            };

           return dbAccess.ExecuteNonQuery(query, parameters);
        }
        private int InsertIntoReaderTable(int referenceKey,Reader reader)
        {
            string query = @"INSERT INTO Reader (UserID, NationalID, Building, State, City, Street) 
                             VALUES (@UserID,@NationalID, @Building, @State, @City, @Street)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", SqlDbType.Int) { Value = referenceKey },
                new SqlParameter("@NationalID", SqlDbType.NVarChar) { Value = reader.NationalID },
                new SqlParameter("@Building", SqlDbType.NVarChar) { Value =reader.adress.Building },
                new SqlParameter("@State", SqlDbType.NVarChar) { Value = reader.adress.State },
                new SqlParameter("@City", SqlDbType.NVarChar) { Value = reader.adress.City },
                new SqlParameter("@Street", SqlDbType.NVarChar) { Value = reader.adress.Street }
            };

            return dbAccess.ExecuteNonQuery(query, parameters);
        }

        private int GetLastPrimaryKey()
        {
            string query = "SELECT ISNULL(MAX(UserID), 0) FROM [User]";

            DataTable result =dbAccess.ExecuteQuery(query, new SqlParameter[0]);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0][0]);
            }
            else
            {
                return 0; // Default value if no rows are found
            }
        }

        private int InsertIntoUserTable(User user)
        {
            
          
            string query = "INSERT INTO [User] (UserName, Password, Email,UserType) VALUES (@UserName, @Password, @Email,@UserType)";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@UserName", SqlDbType.NVarChar) { Value = user.UserName },
            new SqlParameter("@Password", SqlDbType.NVarChar) { Value = user.Password },
            new SqlParameter("@Email", SqlDbType.NVarChar) { Value = user.Email },
              new SqlParameter("@UserType", SqlDbType.NVarChar) { Value = user.EnumUserType.ToString()}
            };

            return dbAccess.ExecuteNonQuery(query, parameters);

        }

        internal int UpdateUserCell(int UserId, string columnName, string? newValue)
        {
            string query = $"UPDATE [User] SET [{columnName}] = @NewValue WHERE UserID = @UserId";

            // Parameters
            SqlParameter[] parameters =
            {
            new SqlParameter("@NewValue", SqlDbType.NVarChar) { Value = newValue },
            new SqlParameter("@UserId", SqlDbType.Int) { Value = UserId }
            };

            // Execute the query
            return dbAccess.ExecuteNonQuery(query, parameters);
        }

        internal int UpdateReaderCell(int ReaderID, string columnName, string? newValue)
        {
            string query = $"UPDATE [Reader] SET [{columnName}] = @NewValue WHERE UserID = @ReaderID";

            // Parameters
            SqlParameter[] parameters =
            {
            new SqlParameter("@NewValue", SqlDbType.NVarChar) { Value = newValue },
            new SqlParameter("@ReaderID", SqlDbType.Int) { Value = ReaderID }
            };

            // Execute the query
            return dbAccess.ExecuteNonQuery(query, parameters);
        }
    }









}



