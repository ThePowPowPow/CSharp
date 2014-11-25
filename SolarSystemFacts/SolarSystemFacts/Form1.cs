using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystemFacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Black;
            richTextBox1.AppendText("Solar System Facts\n");
        }
        //SUN
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("// Sun\n");
            richTextBox1.AppendText("   > AGE: 4.5 billion years \n");
        }
        //MERCURY
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("// Mercury\n");
            richTextBox1.AppendText("   > AGE: 4.5 billion years \n");
        }
        //VENUS
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("// Venus\n");
            richTextBox1.AppendText("   > AGE: 4.5 billion years \n");
        }
        //EARTH
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("// Earth\n");
            richTextBox1.AppendText("   > AGE: 4,540 million years \n");
        }
        //MARS
        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("// Mars\n");
            richTextBox1.AppendText("   > AGE: 4,500 million years \n");
        }
        //JUPITER
        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("// Jupiter\n");
            richTextBox1.AppendText("   > AGE: 4.5 billion years \n");

        }
        //SATURN
        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("// Saturn\n");
            richTextBox1.AppendText("   > AGE: 4.5 billion years\n");
        }
        //URANUS
        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("// Uranus\n");
            richTextBox1.AppendText("   > AGE: 4.5 billion years \n");
        }
        //NEPTUNE
        private void button9_Click(object sender, EventArgs e)
        {   
            //name
            richTextBox1.AppendText("// Neptune\n");
            richTextBox1.AppendText("   > AGE: 4.5 billion years \n");
        }
    }
}
