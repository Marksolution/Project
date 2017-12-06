using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // public int num;
        }
 
      
        private void Form3_Load(object sender, EventArgs e)
        {
            num1.Text = Form4.num.ToString();
            tb1.Text = Form4.num0.ToString();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(tb2.Text) - int.Parse(tb1.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt = textBox3.Text;
            System.IO.File.WriteAllText(@"E:\"  + "print.txt", txt);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(@"E:\" + "print.txt");
            psi.Verb = "PRINT";

            Process.Start(psi);
        }
    }
}
