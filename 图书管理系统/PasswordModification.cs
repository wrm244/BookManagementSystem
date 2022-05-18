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
    public partial class PasswordModification : Form,InfoInterface
    {
        const string nameLinmit = @"^[a-zA-Z0-9]*$";
        const string passwordLimit = @"^[a-zA-Z0-9]*$";
        private string name;
        private string password;
        private string newPassword;

        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();
        public string CommonName { get { return name; } }
        public string Password { get { return password; } }
        public string  NewPasswoord { get { return newPassword; } }

        public PasswordModification(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void PwdModificationInfo()
        {
            if (nameTextBox.Text ==String.Empty || passwordTextBox.Text == String.Empty)
            {
                hintLabel.Text = "用户名称或用户密码不能为空";
                Clear();
                return;
            }
            if (!Regex.IsMatch(nameTextBox.Text, nameLinmit) ||
                !Regex.IsMatch(passwordTextBox.Text, passwordLimit))
            {
                hintLabel.Text = "用户名称和用户密码只能由字母和数字组成";
                Clear();
                return;
            }
            if (newPasswordTextBox.Text == String.Empty || 
                !Regex.IsMatch(newPasswordTextBox.Text, passwordLimit))
            {
                hintLabel.Text = "新密码不能够为空，且密码又数字和字母组成";
                newPasswordTextBox.Clear();
                confirmNewPasswordTextBox.Clear();
                return;
            }
            if (newPasswordTextBox.Text != confirmNewPasswordTextBox.Text)
            {
                hintLabel.Text = "新密码前后不同";
                newPasswordTextBox.Clear();
                confirmNewPasswordTextBox.Clear();
                return;
            } 
            else
            {
                name = nameTextBox.Text;
                password = passwordTextBox.Text;
                newPassword = newPasswordTextBox.Text;
                if (dataBaseConection.passwordChange(CommonName, Password, NewPasswoord))
                {
                    MessageBox.Show("密码更改成功，下次登陆系统请使用新密码", "更改成功");
                }
                else
                    MessageBox.Show("密码更改失败,可能是密码错误或者账户不存在", "更改终止");
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
            this.Close();
            form.Show();
        }

        private void okButtom_Click(object sender, EventArgs e)
        {
            PwdModificationInfo();
        }
    }
}
