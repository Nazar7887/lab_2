using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double z = double.Parse(textBox3.Text);

                double numerator = (2 * Math.Cos(Math.Pow(x, 2))) - (1 / Math.Sqrt(2)) + Math.Pow(Math.E, 2);
                double denominator = (2.0 / 3) + Math.Sin(Math.Pow(y, 2) - z);

                if (Math.Abs(denominator) < 1e-9) 
                {
                    MessageBox.Show("Error: Division by zero.");
                    return;
                }

                double s = numerator / denominator;

                label4.Text = $"Result (s): {s:F3}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers for x, y, and z.");
            }
        }
    }
}
