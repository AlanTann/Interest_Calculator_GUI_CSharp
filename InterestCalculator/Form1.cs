﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterestCalculator
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

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal principal;
            double rate;
            int year;
            decimal amount;
            string output;

            principal = Convert.ToDecimal( principalTextBox.Text );
            rate = Convert.ToDouble( interestTextBox.Text );
            year = Convert.ToInt32(yearUpDown.Value);

            output = "Year     Amounto on Deposit\r\n";

            for (int yearCounter = 1; yearCounter <= year; yearCounter++)
            {
                amount = principal *((decimal)
                    Math.Pow(( 1 + rate/100),yearCounter));
                output += ( yearCounter + "\t" +
                    string.Format("{0:C}",amount) + "\r\n");
            }

            displayTextBox.Text = output;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        } 
    }
}
