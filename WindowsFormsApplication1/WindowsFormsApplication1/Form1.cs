using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

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
                Orange orange=new Orange();
                orange.Name = "王涛";
                orange.Age = "jasklfdj";
                String a = JsonConvert.SerializeObject(orange);
                JsonSerializer serializer = new JsonSerializer();
                StringReader stringReader = new StringReader(a);
                Orange o =serializer.Deserialize(new JsonTextReader(stringReader), typeof(Orange)) as Orange;
                MessageBox.Show(o.Name);
                MessageBox.Show(o.Age);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Orange
    {
        public Orange(String name, String age)
        {
            this.name = name;
            this.age = age;
        }
        public Orange()
        {

        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String age;

        public String Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
