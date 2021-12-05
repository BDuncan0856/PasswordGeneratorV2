using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class PassGen : Form
    {

        int currentPasswordLength = 0;
        Random Character = new Random();


        private void PasswordGenerator(int PasswordLength)
        {
            String validChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$&?";
            String randomPassword = "";

            for(int i = 0; i < PasswordLength; i++)
            {
                int randomNum = Character.Next(0, validChars.Length);
                randomPassword += validChars[randomNum];
            }
            Password.Text = randomPassword;
        }

        public PassGen()
        {
            InitializeComponent();
            PasswordLengthSlider.Minimum = 5;
            PasswordLengthSlider.Maximum = 22;
            PasswordGenerator(5);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Password.Text);
        }

        private void PasswordLength_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLengthSlider_Scroll(object sender, EventArgs e)
        {
            PasswordLength.Text = "Password Length:" + " " + PasswordLengthSlider.Value.ToString();
            currentPasswordLength = PasswordLengthSlider.Value;
            PasswordGenerator(currentPasswordLength);

        }
    }
}
