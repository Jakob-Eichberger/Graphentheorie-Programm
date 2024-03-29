﻿using GrafenProgramm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafenProgramm
{
    public partial class Settings : Form
    {
        int size = 0;

        public Settings()
        {
            InitializeComponent();
            numericUpDown1.Value = Convert.ToDecimal(Properties.Settings.Default["size"]);
        }

        public int Size
        {
            get { return size; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(numericUpDown1.Value);
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default["size"] = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default.Save();
        }
    }
}
