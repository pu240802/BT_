﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Width = 250;
            txtInput.Height = 50;
            txtInput.Multiline = true;
            txtInput.BackColor = Color.Blue;
            txtInput.ForeColor = Color.White;
            txtInput.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string var;
            var = txtInput.Text;
            MessageBox.Show(var);

        }
    }
}
