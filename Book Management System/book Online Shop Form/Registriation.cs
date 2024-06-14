using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Book_Online_Shop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Reflection.PortableExecutable;
using BookOnlineShopEnums;
namespace book_Online_Shop_Form
{
    public partial class Registriation : Form
    {
        public Registriation()
        {
            InitializeComponent();

            AdminRadioButon.Checked = true;
        }

        private void ReaderRadioButon_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            label5.Visible = true;
            textBox7.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            textBox5.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Visible = false;
            label5.Visible = false;
            textBox7.Visible = false;
            label6.Visible = false;
            textBox6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            textBox5.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (AdminRadioButon.Checked)
            {

                checkUserNameValidity();

                if (checkUserNameValidity() == true)
                    AdminSignUp();


            }

            else if (ReaderRadioButon.Checked)
            {

                checkUserNameValidity();

                if (checkUserNameValidity() == true)
                    ReaderSignUp();

            }
        }

        private void ReaderSignUp()
        {
            Reader reader = new Reader();

            FillReaderData(reader);
           
           Registration registration = new Registration();
            
           if( registration.SignUp(reader)==true)
            {
                MessageBox.Show("regestration Done Succesfully");
                LoginPage loginForm = new LoginPage();
                loginForm.textBox2.Text = reader.UserName;
                loginForm.textBox1.Text = reader.Password;

                loginForm.Show();
                this.Close();
            }

            else MessageBox.Show("regestration Fail");

        }

       
        private void AdminSignUp()
        {
            Admin admin = new Admin();
            FillAdminData(admin);
          
            bool RegistraionFinished;
            Registration registration = new Registration();

            if (registration.SignUp(admin) == true)
            {
                MessageBox.Show("regestration Done Succesfully");
                LoginPage loginForm = new LoginPage();
                loginForm.textBox2.Text = admin.UserName;
                loginForm.textBox1.Text = admin.Password;

                loginForm.Show();
                this.Close();
            }
            else   MessageBox.Show("regestration Fail");
        }

        private void FillAdminData(Admin admin)
        {
            admin.Email = textBox1.Text;
            admin.UserName = textBox2.Text;
            admin.Password = textBox3.Text;
            admin.EnumUserType = UserType.Admin;
        }   

        private void FillReaderData(Reader reader)
        {
            reader.Email = textBox1.Text;
            reader.UserName = textBox2.Text;
            reader.Password = textBox3.Text;
            reader.NationalID = textBox4.Text;
            reader.adress.State = textBox8.Text;
            reader.adress.City = textBox7.Text;
            reader.adress.Street = textBox6.Text;
            reader.adress.Building = textBox5.Text;
            reader.EnumUserType = UserType.Reader;
        }

        private bool checkUserNameValidity()
        {

            //check Username Valid or not 
            Registration reg = new Registration();
            bool valid;
            valid = reg.CheckUserNameValidity(textBox2.Text, UserType.Admin);
            if (valid == false)
            {
                MessageBox.Show("This Username is taken Try again");
                return false;

            }
            return true;
            /////////////////////


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registriation_Load(object sender, EventArgs e)
        {

        }





    }



}
