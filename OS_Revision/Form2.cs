using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Revision
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Console.Write("hello");
            FileStream fs = new FileStream("formdata.txt", FileMode.Open, FileAccess.Read);
            StreamReader readData = new StreamReader(fs);
            readData.BaseStream.Seek(0, SeekOrigin.Begin);
            string line;
            while ((line = readData.ReadLine()) != null)
            {
                rchshow.AppendText(line + "\n");
            }

            readData.Close();
            fs.Close();

        }


    }
}
