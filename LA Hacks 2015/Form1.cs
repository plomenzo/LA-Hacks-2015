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

            tabControl1.SelectTab("t2");

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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            sol1.DoDragDrop(sol1.Image, DragDropEffects.Copy);
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            sol1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.AllowDrop = true;
            pictureBox2.AllowDrop = true;

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
