﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add Comment Here
            MessageBox.Show("This is message!");
            Utilities.GetTrue();
            // Add Comment End of Event
            Logger logger = new Logger();
            logger.Log("Form1_Load Complete");
        }
    }
}
