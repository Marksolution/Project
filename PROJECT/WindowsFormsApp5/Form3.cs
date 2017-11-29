﻿using System;
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
    public partial class Form4 : Form
    {
        CheckBox[] ok,l,k,j,h,g,f,e0,d,c,b,a0;
        string[] lines;
        public static int num = 0;
        public Form4()
        {
            InitializeComponent();
        }
        public string[] run_file(string name)
        {
            lines = System.IO.File.ReadAllLines(@"E:\"+name+"1.txt");
            return lines;
        }
        public void run(string name,CheckBox[] b)
        {
            lines = run_file(name); //System.IO.File.ReadAllLines(@"E:\1.txt");
            int i = 0;
            while (i < b.Length)
            {
                if (lines[i].Equals("1"))
                {
                   b[i].Enabled = false;
                }
                else
                {
                    b[i].Enabled = true;
                }
                i++;

            }
        }
        public void save_db(string name,CheckBox[] cb)
        {
            lines = run_file(name);
            int i = 0;
            while (i < cb.Length)
            {
                if (cb[i].Checked)
                {
                    lines[i] = "1";
                    num++;
                }
                i++;
            }
            num1.Text = num.ToString();
            string txt = string.Join("\r\n", lines);
            System.IO.File.WriteAllText(@"E:\"+name+"1.txt", txt);
            run(name,cb);
        }
        private void button222_Click(object sender, EventArgs e)
        {
            num = 0;
            save_db("l", l);
            save_db("k", k);
            save_db("j", j);
            save_db("h", h);
            save_db("g", g);
            save_db("f", f);
            save_db("e0", e0);
            save_db("d", d);
            save_db("c", c);
            save_db("b", b);
            save_db("a0", a0);
            Form f5 = new Form3();
            f5.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            l = new CheckBox[] { l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17, l18, l19, l20 };
            k = new CheckBox[] { k1, k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, k16, k17, k18, k19, k20 };
            j = new CheckBox[] { j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12, j13, j14, j15, j16, j17, j18, j19, j20 };
            h = new CheckBox[] { h1, h2, h3, h4, h5, h6, h7, h8, h9, h10, h11, h12, h13, h14, h15, h16, h17, h18, h19, h20 };
            g = new CheckBox[] { g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20 };
            f = new CheckBox[] { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, f18, f19, f20 };
            e0 = new CheckBox[] { e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15, e16, e17, e18, e19, e20 };
            d = new CheckBox[] { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20 };
            c = new CheckBox[] { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20 };
            b = new CheckBox[] { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16, b17, b18, b19, b20 };
            a0 = new CheckBox[] { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a15, a17, a18, a19, a20 };

            run("l",l);
            run("k", k);
            run("j", j);
            run("h", h);
            run("g", g);
            run("f", f);
            run("e0", e0);
            run("d", d);
            run("c", c);
            run("b", b);
            run("a0", a0);
            //run();

        }
    }
}
