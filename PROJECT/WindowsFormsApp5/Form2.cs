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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form4 f1 = new Form4();
            f1.Show();
             
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f3 = new Form4();
            f3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 f5 = new Form4();
            f5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form4 f6 = new Form4();
            f6.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form4 f7 = new Form4();
            f7.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form4 f8 = new Form4();
            f8.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form4 f9 = new Form4();
            f9.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form4 f10 = new Form4();
            f10.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form4 f11 = new Form4();
            f11.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form4 f12 = new Form4();
            f12.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime m = DateTime.Now;
            textBox5.Text = m.ToString("hh:mm:ss dd/MM/yyyy");
            TimeSpan c1_1 = new TimeSpan(12, 0, 0);
            TimeSpan c1_2 = new TimeSpan(14, 0, 0);
            TimeSpan c1_3 = new TimeSpan(18, 0, 0);
            TimeSpan c2_1 = new TimeSpan(10, 30, 0);
            TimeSpan c2_2 = new TimeSpan(13, 0, 0);
            TimeSpan c2_3 = new TimeSpan(14, 45, 0);
            TimeSpan c3_1 = new TimeSpan(13, 0, 0);
            TimeSpan c3_2 = new TimeSpan(14, 30, 0);
            TimeSpan c3_3 = new TimeSpan(19, 0, 0);
            TimeSpan c4_1 = new TimeSpan(12, 0, 0);
            TimeSpan c4_2 = new TimeSpan(14, 15, 0);
            TimeSpan c4_3 = new TimeSpan(17, 0, 0);
            TimeSpan now = DateTime.Now.TimeOfDay;

            if (now<c1_1)
            {

                button5.BackColor = Color.Red;
            }
            else
            {
              
                button5.BackColor = Color.White;
                button5.Enabled = false;
            }
            if(now < c1_2)
            {
                button6.BackColor = Color.Red;
            }
            else
            {

                button6.BackColor = Color.White;
                button6.Enabled = false;
            }
            if (now < c1_3)
            {
                button7.BackColor = Color.Red;
            }
            else
            {

                button7.BackColor = Color.White;
                button7.Enabled = false;
            }
            if (now < c2_1)
            {
                button8.BackColor = Color.Red;
            }
            else
            {

                button8.BackColor = Color.White;
                button8.Enabled = false;
            }
            if (now < c2_2)
            {
                button9.BackColor = Color.Red;
            }
            else
            {

                button9.BackColor = Color.White;
                button9.Enabled = false;
            }
            if (now < c2_3)
            {
                button10.BackColor = Color.Red;
            }
            else
            {

                button10.BackColor = Color.White;
                button10.Enabled = false;
            }
            if (now < c3_1)
            {
                button11.BackColor = Color.Red;
            }
            else
            {

                button11.BackColor = Color.White;
                button11.Enabled = false;
            }
            if (now < c3_2)
            {
                button12.BackColor = Color.Red;
            }
            else
            {

                button12.BackColor = Color.White;
                button12.Enabled = false;
            }
            if (now < c3_3)
            {
                button13.BackColor = Color.Red;
            }
            else
            {

                button13.BackColor = Color.White;
                button13.Enabled = false;
            }
            if (now < c4_1)
            {
                button14.BackColor = Color.Red;
            }
            else
            {

                button14.BackColor = Color.White;
                button14.Enabled = false;
            }
            if (now < c4_2)
            {
                button15.BackColor = Color.Red;
            }
            else
            {

                button15.BackColor = Color.White;
                button15.Enabled = false;
            }
            if (now < c4_3)
            {
                button16.BackColor = Color.Red;
            }
            else
            {

                button16.BackColor = Color.White;
                button16.Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime m = DateTime.Now;
            textBox5.Text = m.ToString("hh:mm:ss dd/MM/yyyy");
            timer1.Start();

        }
    }
}
