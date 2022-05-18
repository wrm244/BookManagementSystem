using System;
using System.Drawing;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class BorrowList : Form
    {
        DataBaseConection dataBaseConection = new DataBaseConection();
        Form form;
        public BorrowList(Form form)
        {
            InitializeComponent();
            this.form = form;
            showborrow();
        }

        //图书查找
        private void searchBookButtom_Click(object sender, EventArgs e)
        {
            string bookName = bookNameTextBox.Text;
            if (bookNameTextBox.Text == String.Empty)
                MessageBox.Show("书名不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekBookByName_borrow(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView1.DataSource = dataBaseConection.seekBookByName_borrow(bookName);
                    dataGridView1.BackgroundColor = Color.White;
            }
        }

        //按用户名查找
        private void button1_Click(object sender, EventArgs e)
        {
            string bookName = textBox1.Text;
            if (textBox1.Text == String.Empty)
                MessageBox.Show("名字不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekBookByUserName_borrow(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView1.DataSource = dataBaseConection.seekBookByUserName_borrow(bookName);
                    dataGridView1.BackgroundColor = Color.White;
            }

        }
        public void showborrow()
        {

            dataGridView1.DataSource = dataBaseConection.showborrow();

        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }
    }
}
