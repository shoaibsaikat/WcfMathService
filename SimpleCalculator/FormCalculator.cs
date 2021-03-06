﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCalculator.WcfMathServiceReference;

namespace SimpleCalculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private async void buttonCalculate_Click(object sender, EventArgs e)
        {
            MathServiceClient mathClient = new MathServiceClient();
            int first = Int32.Parse(textBoxFirst.Text);
            int second = Int32.Parse(textBoxSecond.Text);
            Task<CompositeType> result = null;


            if (radioButtonAdd.Checked)
            {
                result = mathClient.AddAsync(first, second);
            }
            else if (radioButtonSubstract.Checked)
            {
                result = mathClient.SubstractAsync(first, second);
            }
            if (result != null)
            {
                var tmpResult = await result;
                labelResultText.Text = tmpResult.Result.ToString();
            }
        }
    }
}
