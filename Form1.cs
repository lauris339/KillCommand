﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = @"cmd.exe";
            cmd.StartInfo.Arguments = @"/K taskkill /IM " + textBox1.Text + " /F";
            cmd.Start();
            cmd.StartInfo.Arguments = @"/K taskkill /IM cmd.exe /F";
            cmd.Start();
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
