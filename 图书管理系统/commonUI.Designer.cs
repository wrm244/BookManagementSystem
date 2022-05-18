namespace 图书管理系统
{
    partial class commonUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bookClassComboBox = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.borrowButtoom = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.bookDigestTextBox = new System.Windows.Forms.TextBox();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.booksDVG = new System.Windows.Forms.DataGridView();
            this.searchByKindButtom = new System.Windows.Forms.Button();
            this.lblKind = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookClassComboBox);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.borrowButtoom);
            this.groupBox1.Controls.Add(this.lblContent);
            this.groupBox1.Controls.Add(this.bookDigestTextBox);
            this.groupBox1.Controls.Add(this.searchBookButtom);
            this.groupBox1.Controls.Add(this.lblBookNameForSearch);
            this.groupBox1.Controls.Add(this.bookNameTextBox);
            this.groupBox1.Controls.Add(this.booksDVG);
            this.groupBox1.Controls.Add(this.searchByKindButtom);
            this.groupBox1.Controls.Add(this.lblKind);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1387, 886);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查书系统";
            // 
            // bookClassComboBox
            // 
            this.bookClassComboBox.FormattingEnabled = true;
            this.bookClassComboBox.Items.AddRange(new object[] {
            "IT",
            "文学",
            "科学"});
            this.bookClassComboBox.Location = new System.Drawing.Point(982, 62);
            this.bookClassComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookClassComboBox.Name = "bookClassComboBox";
            this.bookClassComboBox.Size = new System.Drawing.Size(217, 32);
            this.bookClassComboBox.TabIndex = 38;
            this.bookClassComboBox.Text = "IT";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(561, 763);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 74);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1077, 763);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(260, 74);
            this.btnQuery.TabIndex = 36;
            this.btnQuery.Text = "查看借书记录";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // borrowButtoom
            // 
            this.borrowButtoom.Location = new System.Drawing.Point(48, 763);
            this.borrowButtoom.Margin = new System.Windows.Forms.Padding(6);
            this.borrowButtoom.Name = "borrowButtoom";
            this.borrowButtoom.Size = new System.Drawing.Size(260, 74);
            this.borrowButtoom.TabIndex = 35;
            this.borrowButtoom.Text = "借书";
            this.borrowButtoom.UseVisualStyleBackColor = true;
            this.borrowButtoom.Click += new System.EventHandler(this.borrowButtoom_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.Location = new System.Drawing.Point(42, 456);
            this.lblContent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(175, 33);
            this.lblContent.TabIndex = 34;
            this.lblContent.Text = "内容摘要：";
            // 
            // bookDigestTextBox
            // 
            this.bookDigestTextBox.Location = new System.Drawing.Point(48, 493);
            this.bookDigestTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.bookDigestTextBox.Multiline = true;
            this.bookDigestTextBox.Name = "bookDigestTextBox";
            this.bookDigestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bookDigestTextBox.Size = new System.Drawing.Size(1286, 254);
            this.bookDigestTextBox.TabIndex = 33;
            // 
            // searchBookButtom
            // 
            this.searchBookButtom.Location = new System.Drawing.Point(729, 59);
            this.searchBookButtom.Margin = new System.Windows.Forms.Padding(6);
            this.searchBookButtom.Name = "searchBookButtom";
            this.searchBookButtom.Size = new System.Drawing.Size(130, 42);
            this.searchBookButtom.TabIndex = 32;
            this.searchBookButtom.Text = "查找";
            this.searchBookButtom.UseVisualStyleBackColor = true;
            this.searchBookButtom.Click += new System.EventHandler(this.searchBookButtom_Click);
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(54, 67);
            this.lblBookNameForSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(130, 24);
            this.lblBookNameForSearch.TabIndex = 31;
            this.lblBookNameForSearch.Text = "图书书名：";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(195, 59);
            this.bookNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(518, 35);
            this.bookNameTextBox.TabIndex = 30;
            // 
            // booksDVG
            // 
            this.booksDVG.AllowUserToAddRows = false;
            this.booksDVG.AllowUserToDeleteRows = false;
            this.booksDVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDVG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.booksDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDVG.Location = new System.Drawing.Point(48, 115);
            this.booksDVG.Margin = new System.Windows.Forms.Padding(6);
            this.booksDVG.Name = "booksDVG";
            this.booksDVG.ReadOnly = true;
            this.booksDVG.RowHeadersWidth = 82;
            this.booksDVG.RowTemplate.Height = 23;
            this.booksDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDVG.Size = new System.Drawing.Size(1290, 334);
            this.booksDVG.TabIndex = 29;
            this.booksDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDVG_CellClick);
            // 
            // searchByKindButtom
            // 
            this.searchByKindButtom.Location = new System.Drawing.Point(1212, 59);
            this.searchByKindButtom.Margin = new System.Windows.Forms.Padding(6);
            this.searchByKindButtom.Name = "searchByKindButtom";
            this.searchByKindButtom.Size = new System.Drawing.Size(126, 40);
            this.searchByKindButtom.TabIndex = 28;
            this.searchByKindButtom.Text = "按类查找";
            this.searchByKindButtom.UseVisualStyleBackColor = true;
            this.searchByKindButtom.Click += new System.EventHandler(this.searchByKindButtom_Click);
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(872, 67);
            this.lblKind.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(130, 24);
            this.lblKind.TabIndex = 26;
            this.lblKind.Text = "书籍类别：";
            // 
            // commonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1387, 886);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "commonUI";
            this.Text = "用户界面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button borrowButtoom;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox bookDigestTextBox;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.DataGridView booksDVG;
        private System.Windows.Forms.Button searchByKindButtom;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.ComboBox bookClassComboBox;
    }
}