namespace 图书管理系统
{
    partial class BorrowList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButtom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(40, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1678, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchBookButtom
            // 
            this.searchBookButtom.Location = new System.Drawing.Point(1024, 571);
            this.searchBookButtom.Margin = new System.Windows.Forms.Padding(6);
            this.searchBookButtom.Name = "searchBookButtom";
            this.searchBookButtom.Size = new System.Drawing.Size(130, 42);
            this.searchBookButtom.TabIndex = 38;
            this.searchBookButtom.Text = "查找";
            this.searchBookButtom.UseVisualStyleBackColor = true;
            this.searchBookButtom.Click += new System.EventHandler(this.searchBookButtom_Click);
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(426, 574);
            this.lblBookNameForSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(130, 24);
            this.lblBookNameForSearch.TabIndex = 37;
            this.lblBookNameForSearch.Text = "图书书名：";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(568, 571);
            this.bookNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(444, 35);
            this.bookNameTextBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 644);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "借阅人：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(568, 641);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 35);
            this.textBox1.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1024, 635);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 41;
            this.button1.Text = "查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButtom
            // 
            this.exitButtom.Location = new System.Drawing.Point(1369, 602);
            this.exitButtom.Margin = new System.Windows.Forms.Padding(6);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(200, 64);
            this.exitButtom.TabIndex = 52;
            this.exitButtom.Text = "退出";
            this.exitButtom.UseVisualStyleBackColor = true;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // BorrowList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 774);
            this.Controls.Add(this.exitButtom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBookButtom);
            this.Controls.Add(this.lblBookNameForSearch);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorrowList";
            this.Text = "借阅清单";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButtom;
    }
}