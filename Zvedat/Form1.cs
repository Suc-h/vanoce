using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zvedat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pacient David;
        private void Form1_Load(object sender, EventArgs e)
        {
            David = new Pacient((double)numericUpDown2.Value,textBox1.Text,textBox2.Text,(int)numericUpDown3.Value,(double)numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            David = new Pacient((double)numericUpDown2.Value, textBox1.Text, textBox2.Text, (int)numericUpDown3.Value, (double)numericUpDown1.Value);
          
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BMI osoby je: " + David.BMI());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ABSI osoby je: " + David.ABSI());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = David.ToString();
        }
    }
}
