using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Online_Shop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using BookOnlineShopEnums;
namespace book_Online_Shop_Form
{
    public partial class LoginPage : Form
    {

        public delegate void ReturnValidUser(object sender, User user);
        public event ReturnValidUser Validuser;

        private   UserType LoggingUserType;
        public LoginPage(UserType LoggingUserType)
        {
            this.LoggingUserType = LoggingUserType;
            InitializeComponent();
            textBox1.Text = "password2";
            textBox2.Text = "User2";
        }

        public LoginPage()
        {
           
            InitializeComponent();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
           
            string userName = textBox2.Text;
            string password = textBox1.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Enter Username and Password");
                return;
            }

            login login= new login();
            User UserSuccesfullLoggedIn = login.Authentication(userName, password, LoggingUserType); 


            if (UserSuccesfullLoggedIn == null)
            {
                MessageBox.Show("Invalid username or password Try agian");
                return;
            }

            if (LoggingUserType==UserType.Admin)
            {
                //downcasting
                Admin admin = (Admin)UserSuccesfullLoggedIn;

                AdminHomePage adminHomePage = new AdminHomePage(admin);
                adminHomePage.WindowState = FormWindowState.Maximized;
                adminHomePage.Show();
                this.Close();

            }

         
            if (LoggingUserType == UserType.Reader)
            {
                //downcasting
                Reader reader = (Reader)UserSuccesfullLoggedIn;
                ReaderHomePage readerHomePage = new ReaderHomePage(reader);
                readerHomePage.WindowState = FormWindowState.Maximized;
                readerHomePage.Show();
                this.Close();
            }

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
