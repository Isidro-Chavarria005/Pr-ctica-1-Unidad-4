using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Práctica_1__Unidad_4
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            sum = num1 - num2;
            textBox3.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            sum = num1 * num2;
            textBox3.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, num2, sum;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            sum = num1 / num2;
            textBox3.Text = sum.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "40 ";
        }
        struct cliente
        {
            public string nombre;
            public string apellidos;
            public string telefono;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cliente cliente1;
            cliente1.nombre = "Brandon Osiel";
            cliente1.apellidos = "Isidro Chavarria";
            cliente1.telefono = "89933333";
            textBox4.Text = cliente1.nombre;
            textBox5.Text = cliente1.apellidos;
            textBox6.Text = cliente1.telefono;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

