using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Threading;

namespace 多国语言界面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void InitLang()
        {
            this.Text = LangSet.Lang.RM.GetString("Muti Language Interface");
            this.button1.Text = LangSet.Lang.RM.GetString("Options");
            this.radioButton1.Text = LangSet.Lang.RM.GetString("Chinese");
            this.radioButton2.Text = LangSet.Lang.RM.GetString("English");
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            }
            if (radioButton2.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            }
            InitLang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            调试字符串.Test test = new 调试字符串.Test();
            MessageBox.Show(test.GetDebug(), LangSet.Lang.RM.GetString("Prompt"), 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
