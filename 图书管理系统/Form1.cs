using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInlinkLabel.LinkVisited = true;
            Form logIn = new LogIn(this);
            logIn.Show();
            //this.Hide();
            
        }

        private void SignInlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInlinkLabel.LinkVisited = true;
            Form signIn = new SignIn(this);
            signIn.Show();
            //this.Hide();
        }

        private void UnsubscribelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UnsubscribelinkLabel.LinkVisited = true;
            Form unsubscribe = new Unsubscribe(this);
            unsubscribe.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
