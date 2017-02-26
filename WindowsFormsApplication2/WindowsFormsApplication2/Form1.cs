using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = string.Format(@"http://webservice.36wu.com/DimensionalCodeService.asmx/GetCodeImgByString?size={0}&content={1}", 5, 123456);
            System.Net.WebRequest request = System.Net.WebRequest.Create(url);
            System.Net.WebResponse response = request.GetResponse();

            try {
                pictureBox1.Image = Image.FromStream(response.GetResponseStream());
            }catch(Exception){
            }
        }
    }
}
