using Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomTaskPane = Microsoft.Office.Tools.CustomTaskPane;
using Task = System.Threading.Tasks.Task;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using static WordAddIn2.LoginForm;
using static System.Net.Mime.MediaTypeNames;

namespace WordAddIn2
{
    public partial class Ribbon_YJZS
    {

        // 在 Ribbon1 类的成员中添加LoginManager,以调用 LoginManager 处理登录逻辑
        private LoginManager loginManager = new LoginManager();
        //上传逻辑
        private FileUploadManager fileUploadManager = new FileUploadManager();
        //初始设置未登录状态
        private bool isUserLoggedIn = false;
        private UserControl1 userControl;
        private CustomTaskPane myCustomTaskPane;
        //测试post,在button2
        private Test test;


        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            // 初始化时创建 UserControl1 的实例
            userControl = new UserControl1();
            //初始化Test
            test = new Test();

            // 初始化时禁用其他控件
            InitDisableControls();

        }

        //登录后启用所用功能区控件
        private void InitEnableControls()
        {
            // 在这里启用其他控件
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            //button7.Enabled = true;
            //button8.Enabled = true;
            //button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            comboBox1.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            checkBox10.Enabled = true;
            checkBox11.Enabled = true;
            checkBox12.Enabled = true;
            checkBox13.Enabled = true;
            checkBox14.Enabled = true;
            checkBox15.Enabled = true;
            checkBox16.Enabled = true;
            checkBox17.Enabled = true;
            checkBox18.Enabled = true;
            checkBox19.Enabled = true;
            checkBox20.Enabled = true;
            checkBox21.Enabled = true;
            checkBox22.Enabled = true;
            toggleButton1.Enabled = true;
            toggleButton2.Enabled = true;
            toggleButton3.Enabled = true;
            toggleButton4.Enabled = true;
            toggleButton5.Enabled = true;

        }

        //没有登录前，禁用所有功能区控件（除了登录）
        private void InitDisableControls()
        {
            // 在这里禁用其他控件
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            //button7.Enabled = false;
            //button8.Enabled = false;
            //button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            comboBox1.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;
            checkBox10.Enabled = false;
            checkBox11.Enabled = false;
            checkBox12.Enabled = false;
            checkBox13.Enabled = false;
            checkBox14.Enabled = false;
            checkBox15.Enabled = false;
            checkBox16.Enabled = false;
            checkBox17.Enabled = false;
            checkBox18.Enabled = false;
            checkBox19.Enabled = false;
            checkBox20.Enabled = false;
            checkBox21.Enabled = false;
            checkBox22.Enabled = false;
            toggleButton1.Enabled = false;
            toggleButton2.Enabled = false;
            toggleButton3.Enabled = false;
            toggleButton4.Enabled = false;
            toggleButton5.Enabled = false;
        }

        //登录验证
        private void Button1_Click(object sender, RibbonControlEventArgs e)
        {
            if (isUserLoggedIn)
            {
                MessageBox.Show("您已登录！");
            }
            else
            {
                // 调用 LoginManager 处理登录逻辑
                if (loginManager.AuthenticateUser(out string username))
                {
                    MessageBox.Show("登录成功！");
                    isUserLoggedIn = true;
                    button1.Label = username;
                    // 启用其他控件
                    InitEnableControls();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }

        }

        //智能生成:根据已有的word文档中的内容（将已经写入的内容交给LLM，并重新生成/继续书写？），智能生成出完整的可研报告
        private async void Button2_Click(object sender, RibbonControlEventArgs e)
        {
            // 获取当前选择的文本
            string selectedText = comboBox1.Text;

            // 检查是否选择了有效项目
            if (!string.IsNullOrEmpty(selectedText))
            {
                // 显示进度条窗体
                using (var progressForm = new progressForm())
                {
                    progressForm.Show();

                    // 在后台运行 Test.Main(selectedText)
                    await Task.Run(async () =>
                    {
                        await Test.Main(selectedText);
                    });

                    // 关闭进度条窗体
                    progressForm.Close();
                }
            }
            else
            {
                MessageBox.Show("在生成文本之前，请选择一个有效的项目。");
            }
        }


        //优化
        private void Button3_Click(object sender, RibbonControlEventArgs e)
        {
           
        }

        //扩写
        private void Button4_Click(object sender, RibbonControlEventArgs e)
        {

        }

        //精简
        private void Button5_Click(object sender, RibbonControlEventArgs e)
        {

        }

        //显示已上传的文件
        private void Button6_Click(object sender, RibbonControlEventArgs e)
        {

        }

        //上传参考文件
        private void Button10_Click(object sender, RibbonControlEventArgs e)
        {
            // 调用 FileUploadManager 处理文件上传逻辑
            fileUploadManager.UploadFile();

        }

        //根据前面的可研报告名称comboBox（text/items）和后面勾选的checkbox（checked？），整篇生成可研报告
        private void Button11_Click(object sender, RibbonControlEventArgs e)
        {

        }

        //设置
        private void Button12_Click(object sender, RibbonControlEventArgs e)
        {

        }

        //虚拟顾问的触发
        private void Button13_Click(object sender, RibbonControlEventArgs e)
        {
            // 如果任务面板不存在，则创建并显示
            if (myCustomTaskPane == null)
            {
                myCustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(userControl, "有解助手");
                myCustomTaskPane.Visible = true;
            }
            else
            {
                // 如果任务面板已存在，直接切换可见性
                myCustomTaskPane.Visible = !myCustomTaskPane.Visible;
            }

        }

        //关于
        private void Button14_Click(object sender, RibbonControlEventArgs e)
        {

        }
        
        //可研-咨询
        private void ToggleButton1_Click(object sender, RibbonControlEventArgs e)
        {
            //切换按钮的显式切换
            toggleButton1.Checked = true;
            toggleButton2.Checked = false;
            toggleButton3.Checked = false;
            toggleButton4.Checked = false;
            toggleButton5.Checked = false;
            //显示哪一些checkbox出来
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox9.Visible = true;
            checkBox10.Visible = true;
            checkBox11.Visible = true;
            checkBox12.Visible = true;
            checkBox13.Visible = true;
            checkBox14.Visible = true;
            checkBox15.Visible = true;
            checkBox16.Visible = true;
            checkBox17.Visible = true;
            checkBox18.Visible = true;
            checkBox19.Visible = true;
            checkBox20.Visible = true;
            checkBox21.Visible = true;
            checkBox22.Visible = true;
            //更换功能区label的显示
            group4.Label = "概述";
            group5.Label = "现状分析";
            group6.Label = "项目总体方案";
        }

        //可研-设计
        private void ToggleButton2_Click(object sender, RibbonControlEventArgs e)
        {
            //切换按钮的显式切换
            toggleButton1.Checked = false;
            toggleButton2.Checked = true;
            toggleButton3.Checked = false;
            toggleButton4.Checked = false;
            toggleButton5.Checked = false;
            //显示哪一些checkbox出来
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox9.Visible = true;
            checkBox10.Visible = true;
            checkBox11.Visible = true;
            checkBox12.Visible = true;
            checkBox13.Visible = true;
            checkBox14.Visible = true;
            checkBox15.Visible = false;
            checkBox16.Visible = false;
            checkBox17.Visible = false;
            checkBox18.Visible = false;
            checkBox19.Visible = false;
            checkBox20.Visible = false;
            checkBox21.Visible = false;
            checkBox22.Visible = false;
            //更换功能区label的显示
            group4.Label = "你想要";
            group5.Label = "改成什么";
            group6.Label = "其他的名字？";
        }

        //规划
        private void ToggleButton3_Click(object sender, RibbonControlEventArgs e)
        {
            toggleButton1.Checked = false;
            toggleButton2.Checked = false;
            toggleButton3.Checked = true;
            toggleButton4.Checked = false;
            toggleButton5.Checked = false;
        }

        //估算书
        private void ToggleButton4_Click(object sender, RibbonControlEventArgs e)
        {
            toggleButton1.Checked = false;
            toggleButton2.Checked = false;
            toggleButton3.Checked = false;
            toggleButton4.Checked = true;
            toggleButton5.Checked = false;
        }

        //PPT
        private void ToggleButton5_Click(object sender, RibbonControlEventArgs e)
        {
            toggleButton1.Checked = false;
            toggleButton2.Checked = false;
            toggleButton3.Checked = false;
            toggleButton4.Checked = false;
            toggleButton5.Checked = true;
        }

    }
}
