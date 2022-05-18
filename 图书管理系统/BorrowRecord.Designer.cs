namespace 图书管理系统
{
    partial class BorrowRecord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowRecord));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateBtuttom = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.returnBookButtom = new System.Windows.Forms.Button();
            this.libraryRecordDGV = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryRecordDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updateBtuttom);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.returnBookButtom);
            this.groupBox1.Controls.Add(this.libraryRecordDGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1748, 852);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "借书信息查阅";
            // 
            // updateBtuttom
            // 
            this.updateBtuttom.Location = new System.Drawing.Point(743, 710);
            this.updateBtuttom.Margin = new System.Windows.Forms.Padding(6);
            this.updateBtuttom.Name = "updateBtuttom";
            this.updateBtuttom.Size = new System.Drawing.Size(232, 86);
            this.updateBtuttom.TabIndex = 25;
            this.updateBtuttom.Text = "刷新";
            this.updateBtuttom.UseVisualStyleBackColor = true;
            this.updateBtuttom.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1251, 710);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(232, 86);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // returnBookButtom
            // 
            this.returnBookButtom.Location = new System.Drawing.Point(176, 710);
            this.returnBookButtom.Margin = new System.Windows.Forms.Padding(6);
            this.returnBookButtom.Name = "returnBookButtom";
            this.returnBookButtom.Size = new System.Drawing.Size(232, 86);
            this.returnBookButtom.TabIndex = 23;
            this.returnBookButtom.Text = "还书";
            this.returnBookButtom.UseVisualStyleBackColor = true;
            this.returnBookButtom.Click += new System.EventHandler(this.returnBookButtom_Click);
            // 
            // libraryRecordDGV
            // 
            this.libraryRecordDGV.AllowUserToAddRows = false;
            this.libraryRecordDGV.AllowUserToDeleteRows = false;
            this.libraryRecordDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.libraryRecordDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.libraryRecordDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryRecordDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.libraryRecordDGV.Location = new System.Drawing.Point(20, 40);
            this.libraryRecordDGV.Margin = new System.Windows.Forms.Padding(6);
            this.libraryRecordDGV.Name = "libraryRecordDGV";
            this.libraryRecordDGV.ReadOnly = true;
            this.libraryRecordDGV.RowHeadersWidth = 82;
            this.libraryRecordDGV.RowTemplate.Height = 23;
            this.libraryRecordDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.libraryRecordDGV.Size = new System.Drawing.Size(1713, 618);
            this.libraryRecordDGV.TabIndex = 22;
            // 
            // BorrowRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 852);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BorrowRecord";
            this.Text = "借书记录";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryRecordDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button updateBtuttom;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button returnBookButtom;
        private System.Windows.Forms.DataGridView libraryRecordDGV;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}