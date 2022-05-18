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
    public partial class BooksManage : Form
    {
        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();

        private string bookID;
        

        public string BookID { get { return bookID; } }

        public BooksManage(Form form)
        {
            InitializeComponent();
            this.form = form;
            bookClassComboBox.SelectedIndex = 0;
            showBook();
        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void bookAddButtom_Click(object sender, EventArgs e)
        {
            NewBookAdd newBookAdd = new NewBookAdd(this);
            newBookAdd.Show();
            this.Hide();
        }

        private void borrowRwcordButtom_Click(object sender, EventArgs e)
        {
            BorrowList borrowRecord = new BorrowList(this);
            borrowRecord.Show();
            this.Hide();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string bookName = bookNameTextBox.Text;
            if (bookNameTextBox.Text == String.Empty)
                MessageBox.Show("书名不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekBookByName(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    booksDVG.DataSource = dataBaseConection.seekBookByName(bookName);
                    booksDVG.BackgroundColor = Color.White;
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (bookDigestTextBox.Text == String.Empty || bookNameText.Text == String.Empty || bookKindText.Text == String.Empty
                || pressText.Text == String.Empty || authorText.Text == String.Empty || publishTimeText.Text == String.Empty)
            {
                MessageBox.Show("所有项目数据不应该为空", "修改失败");
                return;
            }
            else
            {
                
                dataBaseConection.bookInfoChange(BookID, bookNameText.Text, bookKindText.Text,
                   pressText.Text, authorText.Text, publishTimeText.Text);
                showBook();
                MessageBox.Show("修改成功", "修改结果");

            }
        }

        private void searchByKindButtom_Click(object sender, EventArgs e)
        {
            string bookClass = bookClassComboBox.SelectedItem.ToString();
            booksDVG.DataSource = dataBaseConection.seekBookByClass(bookClass);
        }

        private void booksDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateInfo();
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            string bookName= booksDVG.CurrentRow.Cells[0].Value.ToString();
            dataBaseConection.bookDelete(bookName);
            showBook();
            MessageBox.Show("书籍删除成功", "消息提示");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            showBook();
        }

        public void updateInfo()
        {
            string bookName = booksDVG.CurrentRow.Cells[0].Value.ToString();
            string[] bookinfos = dataBaseConection.bookinfos(bookName);
            bookDigestTextBox.Text = bookinfos[0];
            bookNameText.Text = bookinfos[1];
            bookKindText.Text = bookinfos[2];
            pressText.Text = bookinfos[3];
            authorText.Text = bookinfos[4];
            publishTimeText.Text = bookinfos[5];
            bookID = bookinfos[6];
        }

        public void showBook()
        {
            
            booksDVG.DataSource = dataBaseConection.showBook();
            
        }
    }
}
