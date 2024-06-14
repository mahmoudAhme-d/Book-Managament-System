using Book_Online_Shop;
using BookOnlineShopEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_Online_Shop_Form
{
    public partial class AdminAcountSettings : Form
    {
        Admin admin;
        public AdminAcountSettings(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void AdminAcountSettings_Load(object sender, EventArgs e)
        {
            UsernameLabel.Text = admin.UserName;
            EmailTextBox.Text = admin.Email;
            passwordTextBox.Text = admin.Password;


        }
        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            bool changesMade = false;

            if (UsernameLabel.Text != admin.UserName)
            {
               admin.UpdateCellInUserDatabase(admin.UserID, UserColumns.Username.ToString(), UsernameLabel.Text);
                changesMade = true;
            }

            if (EmailTextBox.Text != admin.Email)
            {
                admin.UpdateCellInUserDatabase(admin.UserID, UserColumns.Email.ToString(), EmailTextBox.Text);
                changesMade = true;
            }

            if (passwordTextBox.Text != admin.Password)
            {
                admin.UpdateCellInUserDatabase(admin.UserID, UserColumns.Password.ToString(), passwordTextBox.Text);
                changesMade = true;
            }

            if (!changesMade)
            {
                MessageBox.Show("Nothing has changed.");
            }
            else
            {
                MessageBox.Show("Changes saved successfully.");
                
            }

        }


        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
