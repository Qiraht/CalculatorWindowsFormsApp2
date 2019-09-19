using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);
            if (comboBox1.Text=="Penambahan")
            {
                textBox3.Text=Penambahan(a, b).ToString();
            }
            else if (comboBox1.Text == "Pengurangan")
            {
                textBox3.Text = Pengurangan(a, b).ToString();
            }
            else if (comboBox1.Text == "Perkalian")
            {
                textBox3.Text = Perkalian(a, b).ToString();
            }
            else if (comboBox1.Text == "Pembagian")
            {
                textBox3.Text = Pembagian(a, b).ToString();
            }
            else
            {
                textBox3.Text = "Error";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
