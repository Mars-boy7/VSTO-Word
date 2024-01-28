namespace WordAddIn2
{
    partial class LoginForm
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
            this.loginpanel = new System.Windows.Forms.Panel();
            this.passwordcheckBox = new System.Windows.Forms.CheckBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.logintableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.loginpanel.SuspendLayout();
            this.logintableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.passwordcheckBox);
            this.loginpanel.Controls.Add(this.loginbutton);
            this.loginpanel.Controls.Add(this.logintableLayoutPanel);
            this.loginpanel.Location = new System.Drawing.Point(0, 0);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(535, 206);
            this.loginpanel.TabIndex = 0;
            // 
            // passwordcheckBox
            // 
            this.passwordcheckBox.AutoSize = true;
            this.passwordcheckBox.Location = new System.Drawing.Point(247, 129);
            this.passwordcheckBox.Name = "passwordcheckBox";
            this.passwordcheckBox.Size = new System.Drawing.Size(106, 22);
            this.passwordcheckBox.TabIndex = 2;
            this.passwordcheckBox.Text = "显示密码";
            this.passwordcheckBox.UseVisualStyleBackColor = true;
            this.passwordcheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(220, 159);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(111, 35);
            this.loginbutton.TabIndex = 1;
            this.loginbutton.Text = "登录";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // logintableLayoutPanel
            // 
            this.logintableLayoutPanel.ColumnCount = 2;
            this.logintableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.logintableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.logintableLayoutPanel.Controls.Add(this.username, 0, 0);
            this.logintableLayoutPanel.Controls.Add(this.password, 0, 1);
            this.logintableLayoutPanel.Controls.Add(this.usernametextBox, 1, 0);
            this.logintableLayoutPanel.Controls.Add(this.passwordtextBox, 1, 1);
            this.logintableLayoutPanel.Location = new System.Drawing.Point(-121, 30);
            this.logintableLayoutPanel.Name = "logintableLayoutPanel";
            this.logintableLayoutPanel.RowCount = 2;
            this.logintableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.logintableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.logintableLayoutPanel.Size = new System.Drawing.Size(642, 106);
            this.logintableLayoutPanel.TabIndex = 0;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(238, 17);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(80, 18);
            this.username.TabIndex = 0;
            this.username.Text = "用户名：";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(238, 70);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(80, 18);
            this.password.TabIndex = 1;
            this.password.Text = "密  码：";
            // 
            // usernametextBox
            // 
            this.usernametextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usernametextBox.Location = new System.Drawing.Point(324, 12);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(221, 28);
            this.usernametextBox.TabIndex = 2;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordtextBox.Location = new System.Drawing.Point(324, 65);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(221, 28);
            this.passwordtextBox.TabIndex = 3;
            this.passwordtextBox.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 208);
            this.Controls.Add(this.loginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.logintableLayoutPanel.ResumeLayout(false);
            this.logintableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.CheckBox passwordcheckBox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TableLayoutPanel logintableLayoutPanel;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
    }
}