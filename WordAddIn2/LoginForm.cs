using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace WordAddIn2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // 添加事件处理程序
            this.usernametextBox.TextChanged += UsernameTextBox_TextChanged;
            this.passwordtextBox.TextChanged += PasswordTextBox_TextChanged;
        }
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox != null)
            {
                // 检查用户名是否只包含字母和数字，且长度不超过16
                if (!textBox.Text.All(char.IsLetterOrDigit) || textBox.Text.Length > 16)
                {
                    // 显示错误消息
                    MessageBox.Show("用户名只能包含字母和数字，且长度不能超过16");

                    // 移除事件处理程序，以防止在改变文本时再次触发事件
                    textBox.TextChanged -= UsernameTextBox_TextChanged;

                    // 删除最后输入的字符
                    if (textBox.Text.Length > 0)
                    {
                        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                    }

                    // 将光标移动到文本的末尾
                    textBox.SelectionStart = textBox.Text.Length;

                    // 重新添加事件处理程序
                    textBox.TextChanged += UsernameTextBox_TextChanged;
                }
            }
        }
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox != null)
            {
                // 检查密码长度是否超过16
                if (textBox.Text.Length > 16)
                {
                    // 显示错误消息
                    MessageBox.Show("密码长度不能超过16");

                    // 移除事件处理程序，以防止在改变文本时再次触发事件
                    textBox.TextChanged -= PasswordTextBox_TextChanged;

                    // 删除最后输入的字符
                    if (textBox.Text.Length > 0)
                    {
                        textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                    }

                    // 将光标移动到文本的末尾
                    textBox.SelectionStart = textBox.Text.Length;

                    // 重新添加事件处理程序
                    textBox.TextChanged += PasswordTextBox_TextChanged;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 根据复选框状态切换密码可见性
            this.passwordtextBox.UseSystemPasswordChar = !passwordcheckBox.Checked;
        }

        public string Username { get { return usernametextBox.Text; } }
        public string Password { get { return passwordtextBox.Text; } }


        private void button1_Click(object sender, EventArgs e)
        {
            // No need to call AuthenticateUser here. Just set the DialogResult to OK.
            this.DialogResult = DialogResult.OK;
            this.Close(); // Close the login window
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
