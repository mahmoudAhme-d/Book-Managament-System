using Book_Online_Shop;
using BookOnlineShopEnums;
using Enums;
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
    public partial class ReaderAcoountSettings : Form
    {
        Reader reader;
        
        public ReaderAcoountSettings(Reader reader)
        {
            InitializeComponent();
            this.reader = reader;
        }

        private void ReaderAcoountSettings_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = reader.UserName;
            EmailTextBox.Text = reader.Email;
            passwordTextBox.Text = reader.Password;
            StateTextBox.Text = reader.adress.State;
            CityTextBox.Text = reader.adress.City;
            BuildingTextBox.Text = reader.adress.Building;
            StreetTextBox.Text = reader.adress.Street;
            NationalIDTextBox.Text = reader.NationalID;

        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            bool changesMade = false;

            if (UserNameLabel.Text != reader.UserName)
            {
                reader.UpdateCellInUserDatabase(reader.UserID, UserColumns.Username.ToString(), UserNameLabel.Text);
                changesMade = true;
            }

            if (EmailTextBox.Text != reader.Email)
            {
                reader.UpdateCellInUserDatabase(reader.UserID, UserColumns.Email.ToString(), EmailTextBox.Text);
                changesMade = true;
            }

            if (passwordTextBox.Text != reader.Password)
            {
                reader.UpdateCellInUserDatabase(reader.UserID, UserColumns.Password.ToString(), passwordTextBox.Text);
                changesMade = true;
            }
            if (NationalIDTextBox.Text != reader.NationalID)
            {
                reader.UpdateCellInReaderDatabase(reader.UserID,ReaderColumns.NationalID.ToString(),NationalIDTextBox.Text);
                changesMade = true;
            }
            if (StateTextBox.Text != reader.adress.State)
            {
                reader.UpdateCellInReaderDatabase(reader.UserID, ReaderColumns.State.ToString(), StateTextBox.Text);
                changesMade = true;
            }

            if (CityTextBox.Text != reader.adress.City)
            {
                reader.UpdateCellInReaderDatabase(reader.UserID, ReaderColumns.City.ToString(), CityTextBox.Text);
                changesMade = true;
            }

            if (BuildingTextBox.Text != reader.adress.Building)
            {
                reader.UpdateCellInReaderDatabase(reader.UserID, ReaderColumns.Building.ToString(), BuildingTextBox.Text);
                changesMade = true;
            }

            if (StreetTextBox.Text != reader.adress.Street)
            {
                reader.UpdateCellInReaderDatabase(reader.UserID, ReaderColumns.Street.ToString(), StreetTextBox.Text);
                changesMade = true;
            }
           
            if (!changesMade)
            {
                MessageBox.Show("Nothing has changed.");
            }
            else
            {
                MessageBox.Show("Changes saved successfully.");

                reader.UserName = UserNameLabel.Text;
                reader.Email = EmailTextBox.Text;
                reader.Password = passwordTextBox.Text;
                reader.adress.State = StateTextBox.Text;
                reader.adress.City = CityTextBox.Text;
                reader.adress.Building = BuildingTextBox.Text;
                reader.adress.Street = StreetTextBox.Text;
                reader.NationalID = NationalIDTextBox.Text;
            }
        }
    }
}
