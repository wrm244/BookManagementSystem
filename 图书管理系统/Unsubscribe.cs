using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 图书管理系统
{
    public partial class Unsubscribe : Form,InfoInterface
    {
        const string nameLinmit = @"^[a-zA-Z0-9]*$";
        const string passwordLinmit = @"^[a-zA-Z0-9]*$";
        private string name;
        private string password;


        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();

        public string CommonName { get { return name; } }
        public string Password { get { return password; } }

        public Unsubscribe(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void infoConfirm()
        {
            if (nameTextBox.Text == String.Empty|| passwordTextBox.Text == String.Empty)
            {
                hintLabel.Text = "用户名称或用户密码不能为空";
                Clear();
                return;
            }
            else if (!Regex.IsMatch(nameTextBox.Text, nameLinmit ) ||
                !Regex.IsMatch(passwordTextBox.Text, passwordLinmit ))
            {
                hintLabel.Text = "用户名称和用户密码只能由字母和数字组成";
                Clear();
                return;
            }
            else
            {
                name = nameTextBox.Text;
                password = passwordTextBox.Text;

                if (dataBaseConection.userLogout(name, password))
                    MessageBox.Show("您已成功注销本账户，感谢您的使用", "注销成功");
                else
                    MessageBox.Show("没有这个账户或者账户信息有误", "操作失败");
            }
        }

        public void Clear()
        {
            nameTextBox.Clear();
            passwordTextBox.Clear();
            passwordTextBox.Focus();
        }

        private void cancelButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void confirmButtom_Click(object sender, EventArgs e)
        {
            infoConfirm();
        }
    }
}
