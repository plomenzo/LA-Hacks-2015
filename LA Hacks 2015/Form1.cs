using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LA_Hacks_2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
