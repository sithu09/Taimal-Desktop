﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

namespace Projectm_I
{
    

    public partial class EPC_Report : Form
    {
        public ChromiumWebBrowser browser;

        public EPC_Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser("http://192.168.56.1:3000/epc");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
    }
}
