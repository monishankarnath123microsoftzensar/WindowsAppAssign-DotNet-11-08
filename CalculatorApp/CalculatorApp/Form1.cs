using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLib;
namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClassCal obj;
        private void button3_Click(object sender, EventArgs e)
        {
            obj = new ClassCal();
            obj.Num1 = Convert.ToDouble(textBox1.Text);
            obj.Num2 = Convert.ToDouble(textBox2.Text);
            lblDisplay.Text = "Multiplication of two Num: "+obj.CalMul().ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new ClassCal();
            obj.Num1 = Convert.ToDouble(textBox1.Text);
            obj.Num2 = Convert.ToDouble(textBox2.Text);
            lblDisplay.Text = "Addition of two Num: " + obj.CalAdd().ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = new ClassCal();
            obj.Num1 = Convert.ToDouble(textBox1.Text);
            obj.Num2 = Convert.ToDouble(textBox2.Text);
            lblDisplay.Text = "Substraction of two Num: " + obj.CalSub().ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj = new ClassCal();
            obj.Num1 = Convert.ToDouble(textBox1.Text);
            obj.Num2 = Convert.ToDouble(textBox2.Text);
            lblDisplay.Text = "Division of two Num: " + obj.CalDiv().ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
