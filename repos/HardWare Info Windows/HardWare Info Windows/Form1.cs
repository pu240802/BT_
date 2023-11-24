﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardWare_Info_Windows
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fCPU = pCpu.NextValue();
            float fRAM = pRam.NextValue();

            metroProgressBarCPU.Value = (int)fCPU;
            metroProgressBarRAM.Value = (int)fRAM;

            lbICPU.Text = string.Format("{0:0.00}%", fCPU);
            lbIRAM.Text = string.Format("{0:0.00}%", fRAM);

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
