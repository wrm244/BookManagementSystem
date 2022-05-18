using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class UserManagement : Form
    {
        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();

        public UserManagement(Form form)
        {
            InitializeComponent();
            this.form = form;
            showUsers();
            usersClassComboBox.SelectedIndex = 0;
            


        }

        private void back_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        public void showUsers()
        {
            usersDGV.DataSource = dataBaseConection.commonUser();
        }

        private void seekUserButtom_Click(object sender, EventArgs e)
        {
            string userClass="";
            string value = "";

            if (usersClassComboBox.SelectedItem.ToString() == "用户名")
            {
                userClass = "UserName";
                value= userNameTextBox.Text;
            }
            if (usersClassComboBox.SelectedItem.ToString() == "姓名")
            {
                userClass = "StudentName";
                value = nametextBox2.Text;
            }
            if (usersClassComboBox.SelectedItem.ToString() == "性别")
            {
                userClass = "Sex";
                value=  sexTextBox.Text;
            }
            
            if (usersClassComboBox.SelectedItem.ToString() == "学院")
            {
                userClass = "WorkUnit";
                value= workUnitTextBox.Text;

            }
            if (usersClassComboBox.SelectedItem.ToString() == "注册日期")
            {
                userClass = "SigninTime";
                value= signinDateTimePicker.Value.ToString("yyyy年M月dd日 0:00:00");

            }

            usersDGV.DataSource= dataBaseConection.seekUser(userClass, value);
        }

        private void userDelteButton_Click(object sender, EventArgs e)
        {
            string name = usersDGV.CurrentRow.Cells[1].Value.ToString();
            dataBaseConection.deleteUser(name);
            MessageBox.Show("用户删除成功", "操作成功");
            showUsers();
        }

        private void usersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idCardNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = usersDGV.CurrentRow.Cells[1].Value.ToString();
            if (dataBaseConection.GRANT(name))
            {
                MessageBox.Show("已经授予过用户" + usersDGV.CurrentRow.Cells[2].Value.ToString() + "管理权限了，", "注意哦");
            }
            else
            {
                MessageBox.Show("授予用户" + usersDGV.CurrentRow.Cells[2].Value.ToString() + "管理权限，", "权限授予");
            }
            showUsers();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = usersDGV.CurrentRow.Cells[1].Value.ToString();
            if (dataBaseConection.rollGRANT(name))
            {
                MessageBox.Show("用户" + usersDGV.CurrentRow.Cells[2].Value.ToString() + "还不是管理员无法回收，", "注意哦");
            }
            else
            {
                MessageBox.Show("收回用户" + usersDGV.CurrentRow.Cells[2].Value.ToString() + "管理权限，", "权限收回");
            }
            showUsers();
        }
    }
}
