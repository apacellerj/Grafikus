using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafikus
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        private object textBox1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Lenght < textBox1.Text.Lenght > 4)
            {
                MessageBox.Show("Legalább négy karakter beütésével működik!")
            }
            int birhtyear = 0;
            bool retVal = int.TryParse(textBox1.Text, out birhtyear);
            if (!retVal)
            {
                MessageBox.Show("Hibás adat!");
            }
            DateTime currentDAteTime = DateTime.Now;
            label12.Text = $"{currentDAteTimeDateTime.Year - birhtyear} éves vagy";
        }
    }
}
