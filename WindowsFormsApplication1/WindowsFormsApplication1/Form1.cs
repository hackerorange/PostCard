using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("欢迎使用");
            if (result == DialogResult.OK)
            {
                MessageBox.Show("你点击了确定按钮");
                MessageBox.Show("HelloWorld");
            }
        }
    }
}
