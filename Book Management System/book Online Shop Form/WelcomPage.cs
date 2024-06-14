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
using BookOnlineShopEnums;
namespace book_Online_Shop_Form
{
    public partial class WelcomPage : Form
    {
        public WelcomPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Registration_Click(object sender, EventArgs e)
        {
            /* Reader reader = new Reader();
             LoginPage loginPage = new LoginPage();
             loginPage.Validuser += ValidReaderLogin;
             loginPage.Show();*/

            Registriation registriation = new Registriation();
            registriation.Show();

        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage(UserType.Admin);
           
            loginForm.Show();
        }

        /* private void ValidReaderLogin(object sender, User user)
         {
             Reader reader = (Reader)user;
             Admin.Visible = false;

             Reader.Visible = false;

         }*/


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginPage loginForm = new LoginPage(UserType.Reader);
            loginForm.Show();
        }
    }
}
