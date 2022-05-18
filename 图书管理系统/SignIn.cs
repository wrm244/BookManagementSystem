using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 图书管理系统
{
    public partial class SignIn : Form,InfoInterface
    {

        const string nameLimit = @"^[a-zA-Z0-9]*$";
        const string passwordLimit = @"^[a-zA-Z0-9]*$";
        const string phoneNumberLimit = @"^(13[0-9]|14[579]|15[0-3,5-9]|16[6]|17[0135678]|18[0-9]|19[89])\d{8}$";
        private string name;
        private string Studentname;
        private string password;
        private string phoneNumber;
        private string sex;
        private string workUnit;
        private string userID;
        private string signinTime;

        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();

        public string CommonName { get { return name; } }

        public string StudentName { get { return name; } }
        public string Password { get { return password; } }
        
        public string Sex { get { return sex; } }
        public string PhoneNumber { get { return phoneNumber; } }
        public string WorkUnit { get { return workUnit; } }
        public string UserId { get { return userID; } }
        public string  SigninTime { get { return signinTime; } }

        public SignIn(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void SignInfo()
        {

            if (nameTextBox.Text ==String.Empty)
            {
                hintNameLabel.Text = "用户名不能为空";             
            }
            if (!Regex.IsMatch(nameTextBox.Text, nameLimit ))
            {
                hintNameLabel.Text = "用户名应由字母或数字组成";
                nameTextBox.Clear();
                nameTextBox.Focus();
                return;
            }
            if (nametextBox2.Text == String.Empty)
            {
                hintnametextBox2.Text = "姓名不能为空";
            }
            if (workUnitTextBox.Text == String.Empty)
            {
                hintWorkUnitLabel.Text = "单位不能为空";
            }
            if (phoneNumberTextBox.Text == String.Empty)
            {
                hintPhoneNumberLabel.Text = "联系手机不能为空";
            }
            if (!Regex.IsMatch(phoneNumberTextBox.Text, phoneNumberLimit))
            {
                hintPhoneNumberLabel.Text = "请输入正确手机号码";
                phoneNumberTextBox.Clear();
                phoneNumberTextBox.Focus();
                return;
            }

            if (passwordTextBox.Text == String.Empty)
            {
                hintPasswordLabel.Text = "用户密码不能为空";
               
            }
            if (!Regex.IsMatch(passwordTextBox.Text, passwordLimit ))
            {
                hintPasswordLabel.Text = "用户密码只能由字母和数字组成";
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return;
            }
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                hintConfirmPasswordLabel.Text = "前后密码不相同";
                passwordTextBox.Clear();
                confirmPasswordTextBox.Clear();
                passwordTextBox.Focus();
                return;
            }
            else
            {
                name = nameTextBox.Text;
                if (manRadioButton.Checked )
                    sex = manRadioButton.Text;
                else
                    sex = womanRadioButton.Text;
                Studentname = nametextBox2.Text;
                phoneNumber = phoneNumberTextBox.Text;
                password = passwordTextBox.Text;
                workUnit = workUnitTextBox.Text;
                userID = name;
                signinTime = DateTime.Today.ToString("F");


                if (dataBaseConection.userAdd(CommonName, Studentname,Password, Sex,
                    WorkUnit, PhoneNumber, UserId, SigninTime))
                    MessageBox.Show("感谢您的注册", "消息提示");
                else
                    MessageBox.Show("用户已经存在", "注册终止");
                Clear();
            }
        }

        public void hintClear()
        {
            hintConfirmPasswordLabel.Text = "";
            hintPasswordLabel.Text = "";
            hintWorkUnitLabel.Text = "";
            hintPhoneNumberLabel.Text = "";
            hintnametextBox2.Text = "";
            hintNameLabel.Text = "";
        }
        public void Clear()
        {
            nameTextBox.Clear();
            nametextBox2.Clear();
            workUnitTextBox.Clear();
            phoneNumberTextBox.Clear();
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
            this.Close();
            form.Show();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void signInButtom_Click(object sender, EventArgs e)
        {
            hintClear();
            SignInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
