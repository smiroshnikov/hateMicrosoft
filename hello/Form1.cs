﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Greetings_ButtonClicked(object sender, EventArgs e)
        {
            textBox1.Text = "Greetings! ";
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (morbus_check.Checked is true)
            {
                morbusNotifier.Text = "Morbus Enabled ! ";
            }
            if (morbus_check.Checked is false)
            {
                morbusNotifier.Text = "Morbus Disabled ! ";
            }
                
        }

        private void userNotifications_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
