using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabContral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
 4             {
 5                 case 0:
 6                     break;
 7                 case 1:
 8                         //假设动态生成的TabControl有4个选项卡
 9                     for (int i = 0; i < 4; i++)
10                     {
11                         TabPage page = new TabPage();
12                         page.Name = "page" + i.ToString();
13                         page.Text = (i + 1).ToString();
14                         this.tabSub.Controls.Add(page);
15                     }
16                     this.tabSub.ItemSize = new System.Drawing.Size(80, 80);
17                     this.tabSub.Font = new System.Drawing.Font("宋体", 20);
18                     this.tabSub.Dock = DockStyle.Fill;
19                     this.tabMain.TabPages[1].Controls.Add(tabSub);
20                     break;
21                 case 2:
22                     break;
23                 case 3:
24                     break;
25             }
        }
    }
}
