﻿using System;
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
            this.Controls.Clear();
            //this.set
            //this.InitializeComponent();    
            //mainMenu();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void introButton_Click(object sender, EventArgs e)
        {
            level_1_Button.Enabled = true; 
        }

        private void level_1_Button_Click(object sender, EventArgs e)
        {
            level_2_Button.Enabled = true; 
        }
    }
}
