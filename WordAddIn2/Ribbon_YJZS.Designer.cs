namespace WordAddIn2
{
    partial class Ribbon_YJZS : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon_YJZS()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon_YJZS));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.comboBox1 = this.Factory.CreateRibbonComboBox();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.checkBox1 = this.Factory.CreateRibbonCheckBox();
            this.checkBox2 = this.Factory.CreateRibbonCheckBox();
            this.checkBox3 = this.Factory.CreateRibbonCheckBox();
            this.checkBox4 = this.Factory.CreateRibbonCheckBox();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.checkBox5 = this.Factory.CreateRibbonCheckBox();
            this.checkBox6 = this.Factory.CreateRibbonCheckBox();
            this.checkBox7 = this.Factory.CreateRibbonCheckBox();
            this.group6 = this.Factory.CreateRibbonGroup();
            this.group7 = this.Factory.CreateRibbonGroup();
            this.checkBox16 = this.Factory.CreateRibbonCheckBox();
            this.checkBox17 = this.Factory.CreateRibbonCheckBox();
            this.checkBox19 = this.Factory.CreateRibbonCheckBox();
            this.checkBox18 = this.Factory.CreateRibbonCheckBox();
            this.checkBox20 = this.Factory.CreateRibbonCheckBox();
            this.group8 = this.Factory.CreateRibbonGroup();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.toggleButton1 = this.Factory.CreateRibbonToggleButton();
            this.toggleButton2 = this.Factory.CreateRibbonToggleButton();
            this.toggleButton3 = this.Factory.CreateRibbonToggleButton();
            this.toggleButton4 = this.Factory.CreateRibbonToggleButton();
            this.toggleButton5 = this.Factory.CreateRibbonToggleButton();
            this.button10 = this.Factory.CreateRibbonButton();
            this.button6 = this.Factory.CreateRibbonButton();
            this.button11 = this.Factory.CreateRibbonButton();
            this.menu1 = this.Factory.CreateRibbonMenu();
            this.checkBox8 = this.Factory.CreateRibbonCheckBox();
            this.checkBox9 = this.Factory.CreateRibbonCheckBox();
            this.checkBox11 = this.Factory.CreateRibbonCheckBox();
            this.checkBox10 = this.Factory.CreateRibbonCheckBox();
            this.checkBox12 = this.Factory.CreateRibbonCheckBox();
            this.checkBox13 = this.Factory.CreateRibbonCheckBox();
            this.checkBox14 = this.Factory.CreateRibbonCheckBox();
            this.checkBox15 = this.Factory.CreateRibbonCheckBox();
            this.checkBox21 = this.Factory.CreateRibbonCheckBox();
            this.checkBox22 = this.Factory.CreateRibbonCheckBox();
            this.button12 = this.Factory.CreateRibbonButton();
            this.button13 = this.Factory.CreateRibbonButton();
            this.button14 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
            this.box1.SuspendLayout();
            this.group4.SuspendLayout();
            this.group5.SuspendLayout();
            this.group6.SuspendLayout();
            this.group7.SuspendLayout();
            this.group8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Groups.Add(this.group5);
            this.tab1.Groups.Add(this.group6);
            this.tab1.Groups.Add(this.group7);
            this.tab1.Groups.Add(this.group8);
            this.tab1.Label = "有解助手";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Label = "登录";
            this.group1.Name = "group1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.button2);
            this.group2.Items.Add(this.button3);
            this.group2.Items.Add(this.button4);
            this.group2.Items.Add(this.button5);
            this.group2.Label = "通用功能";
            this.group2.Name = "group2";
            // 
            // group3
            // 
            this.group3.Items.Add(this.comboBox1);
            this.group3.Items.Add(this.buttonGroup1);
            this.group3.Items.Add(this.box1);
            this.group3.Items.Add(this.separator1);
            this.group3.Items.Add(this.button10);
            this.group3.Items.Add(this.button6);
            this.group3.Items.Add(this.button11);
            this.group3.Label = "主功能";
            this.group3.Name = "group3";
            // 
            // comboBox1
            // 
            ribbonDropDownItemImpl1.Label = "可研报告1";
            ribbonDropDownItemImpl2.Label = "可研报告2";
            ribbonDropDownItemImpl3.Label = "可研报告3";
            ribbonDropDownItemImpl4.Label = "可研报告4,这一条用来测试显示的长度";
            this.comboBox1.Items.Add(ribbonDropDownItemImpl1);
            this.comboBox1.Items.Add(ribbonDropDownItemImpl2);
            this.comboBox1.Items.Add(ribbonDropDownItemImpl3);
            this.comboBox1.Items.Add(ribbonDropDownItemImpl4);
            this.comboBox1.Label = "可研报告名称";
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Text = "可研报告名称";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.toggleButton1);
            this.buttonGroup1.Items.Add(this.toggleButton2);
            this.buttonGroup1.Name = "buttonGroup1";
            // 
            // box1
            // 
            this.box1.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical;
            this.box1.Items.Add(this.toggleButton3);
            this.box1.Items.Add(this.toggleButton4);
            this.box1.Items.Add(this.toggleButton5);
            this.box1.Name = "box1";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // group4
            // 
            this.group4.Items.Add(this.checkBox1);
            this.group4.Items.Add(this.checkBox2);
            this.group4.Items.Add(this.checkBox3);
            this.group4.Items.Add(this.checkBox4);
            this.group4.Label = "概述";
            this.group4.Name = "group4";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.Label = "项目背景";
            this.checkBox1.Name = "checkBox1";
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.Label = "项目依据";
            this.checkBox2.Name = "checkBox2";
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.Label = "项目目标";
            this.checkBox3.Name = "checkBox3";
            // 
            // checkBox4
            // 
            this.checkBox4.Checked = true;
            this.checkBox4.Label = "项目范围";
            this.checkBox4.Name = "checkBox4";
            // 
            // group5
            // 
            this.group5.Items.Add(this.checkBox5);
            this.group5.Items.Add(this.checkBox6);
            this.group5.Items.Add(this.checkBox7);
            this.group5.Label = "现状分析";
            this.group5.Name = "group5";
            // 
            // checkBox5
            // 
            this.checkBox5.Checked = true;
            this.checkBox5.Label = "现状分析";
            this.checkBox5.Name = "checkBox5";
            // 
            // checkBox6
            // 
            this.checkBox6.Checked = true;
            this.checkBox6.Label = "需求分析";
            this.checkBox6.Name = "checkBox6";
            // 
            // checkBox7
            // 
            this.checkBox7.Checked = true;
            this.checkBox7.Label = "必要性结论";
            this.checkBox7.Name = "checkBox7";
            // 
            // group6
            // 
            this.group6.Items.Add(this.menu1);
            this.group6.Label = "项目总体方案";
            this.group6.Name = "group6";
            // 
            // group7
            // 
            this.group7.Items.Add(this.checkBox16);
            this.group7.Items.Add(this.checkBox17);
            this.group7.Items.Add(this.checkBox19);
            this.group7.Items.Add(this.checkBox18);
            this.group7.Items.Add(this.checkBox20);
            this.group7.Label = "其他";
            this.group7.Name = "group7";
            // 
            // checkBox16
            // 
            this.checkBox16.Checked = true;
            this.checkBox16.Label = "项目投资估算";
            this.checkBox16.Name = "checkBox16";
            // 
            // checkBox17
            // 
            this.checkBox17.Checked = true;
            this.checkBox17.Label = "项目效益分析";
            this.checkBox17.Name = "checkBox17";
            // 
            // checkBox19
            // 
            this.checkBox19.Checked = true;
            this.checkBox19.Label = "项目风险分析";
            this.checkBox19.Name = "checkBox19";
            // 
            // checkBox18
            // 
            this.checkBox18.Checked = true;
            this.checkBox18.Label = "项目可研结论";
            this.checkBox18.Name = "checkBox18";
            // 
            // checkBox20
            // 
            this.checkBox20.Checked = true;
            this.checkBox20.Label = "预期应用前景";
            this.checkBox20.Name = "checkBox20";
            // 
            // group8
            // 
            this.group8.Items.Add(this.button12);
            this.group8.Items.Add(this.button13);
            this.group8.Items.Add(this.button14);
            this.group8.Label = "更多";
            this.group8.Name = "group8";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "XXX可研报告";
            this.openFileDialog1.Title = "上传参考文件";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Label = "登录";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Label = "智能生成";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Label = "优化";
            this.button3.Name = "button3";
            this.button3.ShowImage = true;
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Label = "扩写";
            this.button4.Name = "button4";
            this.button4.ShowImage = true;
            this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Label = "精简";
            this.button5.Name = "button5";
            this.button5.ShowImage = true;
            this.button5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button5_Click);
            // 
            // toggleButton1
            // 
            this.toggleButton1.Checked = true;
            this.toggleButton1.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton1.Image")));
            this.toggleButton1.Label = "可研-咨询";
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.ShowImage = true;
            this.toggleButton1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButton1_Click);
            // 
            // toggleButton2
            // 
            this.toggleButton2.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton2.Image")));
            this.toggleButton2.Label = "可研-设计";
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.ShowImage = true;
            this.toggleButton2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButton2_Click);
            // 
            // toggleButton3
            // 
            this.toggleButton3.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton3.Image")));
            this.toggleButton3.Label = "规划";
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.ShowImage = true;
            this.toggleButton3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButton3_Click);
            // 
            // toggleButton4
            // 
            this.toggleButton4.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton4.Image")));
            this.toggleButton4.Label = "估算书";
            this.toggleButton4.Name = "toggleButton4";
            this.toggleButton4.ShowImage = true;
            this.toggleButton4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButton4_Click);
            // 
            // toggleButton5
            // 
            this.toggleButton5.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton5.Image")));
            this.toggleButton5.Label = "PPT";
            this.toggleButton5.Name = "toggleButton5";
            this.toggleButton5.ShowImage = true;
            this.toggleButton5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ToggleButton5_Click);
            // 
            // button10
            // 
            this.button10.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Label = "上传";
            this.button10.Name = "button10";
            this.button10.ShowImage = true;
            this.button10.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button10_Click);
            // 
            // button6
            // 
            this.button6.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Label = "已上传文件";
            this.button6.Name = "button6";
            this.button6.ShowImage = true;
            this.button6.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button6_Click);
            // 
            // button11
            // 
            this.button11.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Label = "整篇生成";
            this.button11.Name = "button11";
            this.button11.ShowImage = true;
            this.button11.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button11_Click);
            // 
            // menu1
            // 
            this.menu1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.menu1.Image = ((System.Drawing.Image)(resources.GetObject("menu1.Image")));
            this.menu1.Items.Add(this.checkBox8);
            this.menu1.Items.Add(this.checkBox9);
            this.menu1.Items.Add(this.checkBox11);
            this.menu1.Items.Add(this.checkBox10);
            this.menu1.Items.Add(this.checkBox12);
            this.menu1.Items.Add(this.checkBox13);
            this.menu1.Items.Add(this.checkBox14);
            this.menu1.Items.Add(this.checkBox15);
            this.menu1.Items.Add(this.checkBox21);
            this.menu1.Items.Add(this.checkBox22);
            this.menu1.Label = "项目总体方案";
            this.menu1.Name = "menu1";
            this.menu1.ShowImage = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Checked = true;
            this.checkBox8.Label = "业务架构";
            this.checkBox8.Name = "checkBox8";
            // 
            // checkBox9
            // 
            this.checkBox9.Checked = true;
            this.checkBox9.Label = "应用架构";
            this.checkBox9.Name = "checkBox9";
            // 
            // checkBox11
            // 
            this.checkBox11.Checked = true;
            this.checkBox11.Label = "技术架构";
            this.checkBox11.Name = "checkBox11";
            // 
            // checkBox10
            // 
            this.checkBox10.Checked = true;
            this.checkBox10.Label = "数据要求";
            this.checkBox10.Name = "checkBox10";
            // 
            // checkBox12
            // 
            this.checkBox12.Checked = true;
            this.checkBox12.Label = "自主可控要求";
            this.checkBox12.Name = "checkBox12";
            // 
            // checkBox13
            // 
            this.checkBox13.Checked = true;
            this.checkBox13.Label = "项目交付成果要求";
            this.checkBox13.Name = "checkBox13";
            // 
            // checkBox14
            // 
            this.checkBox14.Checked = true;
            this.checkBox14.Label = "系统部署方式及软硬件资源需求";
            this.checkBox14.Name = "checkBox14";
            // 
            // checkBox15
            // 
            this.checkBox15.Checked = true;
            this.checkBox15.Label = "安全方案";
            this.checkBox15.Name = "checkBox15";
            // 
            // checkBox21
            // 
            this.checkBox21.Checked = true;
            this.checkBox21.Label = "运维管理建议";
            this.checkBox21.Name = "checkBox21";
            // 
            // checkBox22
            // 
            this.checkBox22.Checked = true;
            this.checkBox22.Label = "项目实施方案";
            this.checkBox22.Name = "checkBox22";
            // 
            // button12
            // 
            this.button12.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Label = "设置";
            this.button12.Name = "button12";
            this.button12.ShowImage = true;
            this.button12.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button12_Click);
            // 
            // button13
            // 
            this.button13.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Label = "虚拟顾问";
            this.button13.Name = "button13";
            this.button13.ShowImage = true;
            this.button13.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button13_Click);
            // 
            // button14
            // 
            this.button14.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Label = "关于";
            this.button14.Name = "button14";
            this.button14.ShowImage = true;
            this.button14.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button14_Click);
            // 
            // Ribbon_YJZS
            // 
            this.Name = "Ribbon_YJZS";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.group5.ResumeLayout(false);
            this.group5.PerformLayout();
            this.group6.ResumeLayout(false);
            this.group6.PerformLayout();
            this.group7.ResumeLayout(false);
            this.group7.PerformLayout();
            this.group8.ResumeLayout(false);
            this.group8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button5;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button10;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button11;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox2;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox3;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox4;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox5;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox6;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox7;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group6;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox8;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox9;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox10;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox11;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox12;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox13;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group7;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group8;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox14;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox15;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox16;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox17;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox19;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox18;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button12;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button13;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button14;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox20;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton1;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton2;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton3;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton4;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleButton5;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button6;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox21;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox22;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon_YJZS Ribbon1
        {
            get { return this.GetRibbon<Ribbon_YJZS>(); }
        }
    }
}
