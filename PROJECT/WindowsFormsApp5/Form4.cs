using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public int num;
        public Form3()
        {
            InitializeComponent();
            // public int num;
    }

        private void Form3_Load(object sender, EventArgs e)
        {
            num1.Text = Form4.num.ToString();
        }
    }
}
