using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace webdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                i = int.Parse(textBox1.Text);
                textBox1.Enabled = false;
                button1.Enabled = false;
                label2.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;
            }
            catch
            {
                MessageBox.Show("Introduceti un numar !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "[";
                string[] valori = textBox2.Text.Split(',', '_', '[', ']');
                label3.Visible = true;
                label4.Visible = true;
                for (int i = 1; i < valori.Length - 1; i++)
                {
                    if (valori[i] == "add" || valori[i] == " add")
                        add(int.Parse(valori[i + 1]));
                    if (valori[i] == "subtract" || valori[i] == " subtract")
                        subtract(int.Parse(valori[i + 1]));
                    if (valori[i] == "multiply" || valori[i] == " multiply")
                        multiply(int.Parse(valori[i + 1]));
                    if (valori[i] == "divide" || valori[i] == " divide")
                        divide(int.Parse(valori[i + 1]));
                }
                label3.Text = label3.Text.Remove(label3.Text.Length - 2);
                label3.Text = label3.Text + "]";
            }
            catch
            {
                MessageBox.Show("Nu ati introdus ca in exemplul prezentat mai sus !");
            }
        }

        void add(int x)
        {
            label3.Text=label3.Text+(i+x).ToString()+", ";
        }
        void subtract(int x)
        {
            label3.Text = label3.Text + (i - x).ToString()+", ";
        }

        void multiply(int x)
        {
            label3.Text = label3.Text + (i * x).ToString() + ", ";
        }

        void divide(int x)
        {
            label3.Text = label3.Text + ((float)i / x).ToString() + ", ";
        }
    }
}
