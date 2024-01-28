using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProgressBar = System.Windows.Forms.ProgressBar;
using Task = System.Threading.Tasks.Task;

namespace WordAddIn2
{
    public partial class progressForm : Form
    {
        private ProgressBar progressBar; // 添加这一行
        private bool isEscPressed = false;
        public progressForm()
        {
            InitializeComponent();
            progressBar = new ProgressBar();
        }

        private void progressForm_Load(object sender, EventArgs e)
        {
            // 初始化进度条等工作
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            // 启动异步任务
            System.Threading.Tasks.Task.Run(() => ProgressAsyncMethod());
            // 启用键盘事件
            this.KeyPreview = true;
        }

        private async void ProgressAsyncMethod()
        {
            try
            {
                // 在这里执行需要耗时的任务
                for (int i = 0; i <= 100; i++)
                {
                    // 检查 Esc 键是否被按下
                    if (isEscPressed)
                        break;

                    // 更新进度条
                    UpdateProgressBar(i);

                    // 模拟耗时操作，不会阻塞UI线程
                    await Task.Delay(100);
                }
            }
            catch (Exception ex)
            {
                // 处理异常
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 关闭进度条
                CloseProgressBar();
            }
        }


        private void UpdateProgressBar(int value)
        {
            // 使用委托确保在 UI 线程上更新进度条
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action<int>(UpdateProgressBar), value);
                return;
            }

            progressBar.Value = value;
        }

        private void CloseProgressBar()
        {
            // 使用委托确保在 UI 线程上关闭窗体
            if (InvokeRequired)
            {
                Invoke(new Action(CloseProgressBar));
                return;
            }

            Close();
        }


        private void progressForm_KeyDown(object sender, KeyEventArgs e)
        {
            // 监听按键事件
            if (e.KeyCode == Keys.Escape)
            {
                // 按下 Esc 键时设置标志
                isEscPressed = true;

                // 在这里可以添加其他处理逻辑
            }
        }

        private void progressbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
