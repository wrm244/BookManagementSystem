namespace 图书管理系统
{
    partial class BooksManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookClassComboBox = new System.Windows.Forms.ComboBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.bookDigestTextBox = new System.Windows.Forms.TextBox();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.booksDVG = new System.Windows.Forms.DataGridView();
            this.searchByKindButtom = new System.Windows.Forms.Button();
            this.lblKind = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exitButtom = new System.Windows.Forms.Button();
            this.borrowRwcordButtom = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.publishTimeText = new System.Windows.Forms.TextBox();
            this.pressText = new System.Windows.Forms.TextBox();
            this.bookKindText = new System.Windows.Forms.TextBox();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBookKind = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.alterButtom = new System.Windows.Forms.Button();
            this.deleteBook = new System.Windows.Forms.Button();
            this.bookAddButtom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookClassComboBox);
            this.groupBox1.Controls.Add(this.lblContent);
            this.groupBox1.Controls.Add(this.bookDigestTextBox);
            this.groupBox1.Controls.Add(this.searchBookButtom);
            this.groupBox1.Controls.Add(this.lblBookNameForSearch);
            this.groupBox1.Controls.Add(this.bookNameTextBox);
            this.groupBox1.Controls.Add(this.booksDVG);
            this.groupBox1.Controls.Add(this.searchByKindButtom);
            this.groupBox1.Controls.Add(this.lblKind);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1933, 1053);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书信息";
            // 
            // bookClassComboBox
            // 
            this.bookClassComboBox.FormattingEnabled = true;
            this.bookClassComboBox.Items.AddRange(new object[] {
            "IT",
            "科学",
            "文化"});
            this.bookClassComboBox.Location = new System.Drawing.Point(1023, 53);
            this.bookClassComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookClassComboBox.Name = "bookClassComboBox";
            this.bookClassComboBox.Size = new System.Drawing.Size(208, 32);
            this.bookClassComboBox.TabIndex = 52;
            this.bookClassComboBox.Text = "IT";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.Location = new System.Drawing.Point(70, 459);
            this.lblContent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(175, 33);
            this.lblContent.TabIndex = 38;
            this.lblContent.Text = "内容摘要：";
            // 
            // bookDigestTextBox
            // 
            this.bookDigestTextBox.Location = new System.Drawing.Point(76, 498);
            this.bookDigestTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.bookDigestTextBox.Multiline = true;
            this.bookDigestTextBox.Name = "bookDigestTextBox";
            this.bookDigestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bookDigestTextBox.Size = new System.Drawing.Size(1805, 254);
            this.bookDigestTextBox.TabIndex = 36;
            // 
            // searchBookButtom
            // 
            this.searchBookButtom.Location = new System.Drawing.Point(747, 48);
            this.searchBookButtom.Margin = new System.Windows.Forms.Padding(6);
            this.searchBookButtom.Name = "searchBookButtom";
            this.searchBookButtom.Size = new System.Drawing.Size(130, 42);
            this.searchBookButtom.TabIndex = 35;
            this.searchBookButtom.Text = "查找";
            this.searchBookButtom.UseVisualStyleBackColor = true;
            this.searchBookButtom.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(72, 58);
            this.lblBookNameForSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(130, 24);
            this.lblBookNameForSearch.TabIndex = 34;
            this.lblBookNameForSearch.Text = "图书书名：";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(214, 53);
            this.bookNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(518, 35);
            this.bookNameTextBox.TabIndex = 33;
            // 
            // booksDVG
            // 
            this.booksDVG.AllowUserToAddRows = false;
            this.booksDVG.AllowUserToDeleteRows = false;
            this.booksDVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDVG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.booksDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDVG.Location = new System.Drawing.Point(76, 120);
            this.booksDVG.Margin = new System.Windows.Forms.Padding(6);
            this.booksDVG.Name = "booksDVG";
            this.booksDVG.ReadOnly = true;
            this.booksDVG.RowHeadersWidth = 82;
            this.booksDVG.RowTemplate.Height = 23;
            this.booksDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDVG.Size = new System.Drawing.Size(1805, 334);
            this.booksDVG.TabIndex = 30;
            this.booksDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDVG_CellClick);
            // 
            // searchByKindButtom
            // 
            this.searchByKindButtom.Location = new System.Drawing.Point(1244, 50);
            this.searchByKindButtom.Margin = new System.Windows.Forms.Padding(6);
            this.searchByKindButtom.Name = "searchByKindButtom";
            this.searchByKindButtom.Size = new System.Drawing.Size(126, 40);
            this.searchByKindButtom.TabIndex = 29;
            this.searchByKindButtom.Text = "按类查找";
            this.searchByKindButtom.UseVisualStyleBackColor = true;
            this.searchByKindButtom.Click += new System.EventHandler(this.searchByKindButtom_Click);
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(890, 59);
            this.lblKind.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(130, 24);
            this.lblKind.TabIndex = 27;
            this.lblKind.Text = "书籍类别：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exitButtom);
            this.groupBox2.Controls.Add(this.borrowRwcordButtom);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.bookNameText);
            this.groupBox2.Controls.Add(this.authorText);
            this.groupBox2.Controls.Add(this.publishTimeText);
            this.groupBox2.Controls.Add(this.pressText);
            this.groupBox2.Controls.Add(this.bookKindText);
            this.groupBox2.Controls.Add(this.lblPress);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.lblBookKind);
            this.groupBox2.Controls.Add(this.lblAuthor);
            this.groupBox2.Controls.Add(this.lblBookName);
            this.groupBox2.Controls.Add(this.alterButtom);
            this.groupBox2.Controls.Add(this.deleteBook);
            this.groupBox2.Controls.Add(this.bookAddButtom);
            this.groupBox2.Location = new System.Drawing.Point(76, 765);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1805, 230);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可修改部分";
            // 
            // exitButtom
            // 
            this.exitButtom.Location = new System.Drawing.Point(1219, 155);
            this.exitButtom.Margin = new System.Windows.Forms.Padding(6);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(200, 64);
            this.exitButtom.TabIndex = 51;
            this.exitButtom.Text = "退出";
            this.exitButtom.UseVisualStyleBackColor = true;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // borrowRwcordButtom
            // 
            this.borrowRwcordButtom.Location = new System.Drawing.Point(1518, 88);
            this.borrowRwcordButtom.Margin = new System.Windows.Forms.Padding(6);
            this.borrowRwcordButtom.Name = "borrowRwcordButtom";
            this.borrowRwcordButtom.Size = new System.Drawing.Size(200, 64);
            this.borrowRwcordButtom.TabIndex = 50;
            this.borrowRwcordButtom.Text = "查看借书记录";
            this.borrowRwcordButtom.UseVisualStyleBackColor = true;
            this.borrowRwcordButtom.Click += new System.EventHandler(this.borrowRwcordButtom_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(936, 94);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 42);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(176, 35);
            this.bookNameText.Margin = new System.Windows.Forms.Padding(6);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(196, 35);
            this.bookNameText.TabIndex = 48;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(176, 88);
            this.authorText.Margin = new System.Windows.Forms.Padding(6);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(196, 35);
            this.authorText.TabIndex = 47;
            // 
            // publishTimeText
            // 
            this.publishTimeText.Location = new System.Drawing.Point(582, 85);
            this.publishTimeText.Margin = new System.Windows.Forms.Padding(6);
            this.publishTimeText.Name = "publishTimeText";
            this.publishTimeText.Size = new System.Drawing.Size(196, 35);
            this.publishTimeText.TabIndex = 46;
            // 
            // pressText
            // 
            this.pressText.Location = new System.Drawing.Point(938, 35);
            this.pressText.Margin = new System.Windows.Forms.Padding(6);
            this.pressText.Name = "pressText";
            this.pressText.Size = new System.Drawing.Size(196, 35);
            this.pressText.TabIndex = 45;
            // 
            // bookKindText
            // 
            this.bookKindText.Location = new System.Drawing.Point(582, 32);
            this.bookKindText.Margin = new System.Windows.Forms.Padding(6);
            this.bookKindText.Name = "bookKindText";
            this.bookKindText.Size = new System.Drawing.Size(196, 35);
            this.bookKindText.TabIndex = 44;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(825, 40);
            this.lblPress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(106, 24);
            this.lblPress.TabIndex = 43;
            this.lblPress.Text = "出版社：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(447, 94);
            this.lblTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(130, 24);
            this.lblTime.TabIndex = 42;
            this.lblTime.Text = "出版时间：";
            // 
            // lblBookKind
            // 
            this.lblBookKind.AutoSize = true;
            this.lblBookKind.Location = new System.Drawing.Point(447, 40);
            this.lblBookKind.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookKind.Name = "lblBookKind";
            this.lblBookKind.Size = new System.Drawing.Size(130, 24);
            this.lblBookKind.TabIndex = 41;
            this.lblBookKind.Text = "图书类别：";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(81, 93);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(82, 24);
            this.lblAuthor.TabIndex = 40;
            this.lblAuthor.Text = "作者：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(81, 40);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(82, 24);
            this.lblBookName.TabIndex = 39;
            this.lblBookName.Text = "书名：";
            // 
            // alterButtom
            // 
            this.alterButtom.Location = new System.Drawing.Point(1219, 35);
            this.alterButtom.Margin = new System.Windows.Forms.Padding(6);
            this.alterButtom.Name = "alterButtom";
            this.alterButtom.Size = new System.Drawing.Size(200, 42);
            this.alterButtom.TabIndex = 37;
            this.alterButtom.Text = "修改书目";
            this.alterButtom.UseVisualStyleBackColor = true;
            this.alterButtom.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // deleteBook
            // 
            this.deleteBook.Location = new System.Drawing.Point(1219, 94);
            this.deleteBook.Margin = new System.Windows.Forms.Padding(6);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(200, 42);
            this.deleteBook.TabIndex = 32;
            this.deleteBook.Text = "删除书目";
            this.deleteBook.UseVisualStyleBackColor = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // bookAddButtom
            // 
            this.bookAddButtom.Location = new System.Drawing.Point(936, 155);
            this.bookAddButtom.Margin = new System.Windows.Forms.Padding(6);
            this.bookAddButtom.Name = "bookAddButtom";
            this.bookAddButtom.Size = new System.Drawing.Size(200, 64);
            this.bookAddButtom.TabIndex = 31;
            this.bookAddButtom.Text = "新增书目";
            this.bookAddButtom.UseVisualStyleBackColor = true;
            this.bookAddButtom.Click += new System.EventHandler(this.bookAddButtom_Click);
            // 
            // BooksManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1933, 1053);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BooksManage";
            this.Text = "图书管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButtom;
        private System.Windows.Forms.Button borrowRwcordButtom;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox publishTimeText;
        private System.Windows.Forms.TextBox pressText;
        private System.Windows.Forms.TextBox bookKindText;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBookKind;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button alterButtom;
        private System.Windows.Forms.TextBox bookDigestTextBox;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Button bookAddButtom;
        private System.Windows.Forms.DataGridView booksDVG;
        private System.Windows.Forms.Button searchByKindButtom;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.ComboBox bookClassComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}