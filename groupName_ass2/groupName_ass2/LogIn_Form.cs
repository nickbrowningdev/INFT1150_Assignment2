using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace groupName_ass2
{
    public partial class LogIn_Form : Form
    {
        public LogIn_Form()
        {
            InitializeComponent();
        }

        //Array to store username and password
        string[] usernames = { "username1", "username2" };
        string[] passwords = { "password1", "password2" };


        //Application closing
        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Prototype", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

                //this.Close();
            }

        }

        //If both of the usernames and passwords match, the main menu is displayed
        private void logBtn_Click(object sender, EventArgs e)
        {
            if (usernames.Contains(txtUsername.Text) && passwords.Contains(txtPassword.Text) && Array.IndexOf(usernames, txtUsername.Text) == Array.IndexOf(passwords, txtPassword.Text))
            {
                MainMenu_Form menu = new MainMenu_Form();
                menu.ShowDialog();
            }
            else
                MessageBox.Show("The username and/or password is invalid", "Prototype");

        }

        //Resets the text when clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        //The text in the textboxes will clear when loaded
        private void LogIn_Form_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        //Code: LogIn_Form created by Nicholas Browning
        //Design: LogIn_Form created by Nicholas Browning


    }
}
