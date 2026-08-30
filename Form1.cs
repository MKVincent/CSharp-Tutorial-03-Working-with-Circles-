using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_prac3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declare a constant for pi
        // Use the 'm' suffix to indicate that this is a decimal literal
        // Use the 'const' keyword to declare a constant
        // Declare a global variable for pi so that it can be used in multiple methods
        const decimal pi = 3.14m;
        private void radCircumference_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the circumference radio button is checked
            // If it is, calculate the circumference of the circle using the formula C = 2 * pi * r
            // Use the Convert.ToDecimal method to convert the text in the txtRadius textbox to a decimal
            // Use the MessageBox.Show method to display the result in a message box
            if (radCircumference.Checked)
            {
                decimal radius = Convert.ToDecimal(txtRadius.Text);

                decimal circumference = 2 * pi * radius;

                MessageBox.Show("The circumference of the circle is: " + circumference.ToString());
            }
        }

        private void radArea_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the area radio button is checked
            // If it is, calculate the area of the circle using the formula A = pi * r^2
            // Use the Convert.ToDecimal method to convert the text in the txtRadius textbox to a decimal
            if (radArea.Checked)
            {
                decimal radius = Convert.ToDecimal(txtRadius.Text);
                decimal area = pi * radius * radius;
                MessageBox.Show("The area of the circle is: " + area.ToString());
            }
        }

        private void radNoCalculation_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the no calculation radio button is checked
            // If it is, display a message box indicating that no calculation will be performed
            if (radNoCalculation.Checked)
            {
                MessageBox.Show("No calculation will be performed.");
            }
        }
    }
}