using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class 图书系统登录记录 : Form
    {
        DataBaseConection dataBaseConection = new DataBaseConection();
        public 图书系统登录记录()
        {
            InitializeComponent();

        }

        private void signinDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void seekUserButtom_Click(object sender, EventArgs e)
        {
            string userClass = "";
            string value = "";

            if (usersClassComboBox.SelectedItem.ToString() == "用户名")
            {
                userClass = "UserName";
                value = userNameTextBox.Text;
            }
            if (usersClassComboBox.SelectedItem.ToString() == "姓名")
            {
                userClass = "StudentName";
                value = nametextBox2.Text;
            }
            if (usersClassComboBox.SelectedItem.ToString() == "性别")
            {
                userClass = "Sex";
                value = sexTextBox.Text;
            }

            if (usersClassComboBox.SelectedItem.ToString() == "学院")
            {
                userClass = "WorkUnit";
                value = workUnitTextBox.Text;

            }
            if (usersClassComboBox.SelectedItem.ToString() == "注册日期")
            {
                userClass = "SigninTime";
                value = signinDateTimePicker.Value.ToString("yyyy年M月dd日 0:00:00");

            }

            dataGridView1.DataSource = dataBaseConection.seekUser(userClass, value);
        }
    }
}
