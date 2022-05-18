namespace 图书管理系统
{
    partial class Unsubscribe
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
            this.hintLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButtom = new System.Windows.Forms.Button();
            this.confirmButtom = new System.Windows.Forms.Button();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hintLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cancelButtom);
            this.groupBox1.Controls.Add(this.confirmButtom);
            this.groupBox1.Controls.Add(this.lblPwd);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(644, 442);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账户注销";
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(212, 284);
            this.hintLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(22, 24);
            this.hintLabel.TabIndex = 26;
            this.hintLabel.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(140, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "提示：注销后账号的记录全部消失";
            // 
            // cancelButtom
            // 
            this.cancelButtom.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancelButtom.Location = new System.Drawing.Point(356, 314);
            this.cancelButtom.Margin = new System.Windows.Forms.Padding(6);
            this.cancelButtom.Name = "cancelButtom";
            this.cancelButtom.Size = new System.Drawing.Size(150, 46);
            this.cancelButtom.TabIndex = 24;
            this.cancelButtom.Text = "取消";
            this.cancelButtom.UseVisualStyleBackColor = true;
            this.cancelButtom.Click += new System.EventHandler(this.cancelButtom_Click);
            // 
            // confirmButtom
            // 
            this.confirmButtom.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmButtom.Location = new System.Drawing.Point(146, 314);
            this.confirmButtom.Margin = new System.Windows.Forms.Padding(6);
            this.confirmButtom.Name = "confirmButtom";
            this.confirmButtom.Size = new System.Drawing.Size(150, 46);
            this.confirmButtom.TabIndex = 23;
            this.confirmButtom.Text = "确认";
            this.confirmButtom.UseVisualStyleBackColor = true;
            this.confirmButtom.Click += new System.EventHandler(this.confirmButtom_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(140, 178);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(70, 24);
            this.lblPwd.TabIndex = 22;
            this.lblPwd.Text = "密码:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(140, 104);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 24);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "用户名:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(246, 172);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(254, 35);
            this.passwordTextBox.TabIndex = 20;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(246, 100);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(254, 35);
            this.nameTextBox.TabIndex = 19;
            // 
            // Unsubscribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 442);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Unsubscribe";
            this.Text = "账户注销系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button cancelButtom;
        private System.Windows.Forms.Button confirmButtom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hintLabel;
    }
}