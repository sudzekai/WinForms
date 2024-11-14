using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text.Contains(" ")) {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("Некорректный логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text != textBox3.Text) {
                textBox3.BackColor = Color.Red;
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"{textBox1.Text}, вы успешно зарегистрировались", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthdate = dateTimePicker1.Value;
            int age = DateTime.Today.Year - birthdate.Year;
            label7.Text = $"{age}";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label8.Text = $"Температура в помещении: {trackBar1.Value} C";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                label10.Text = "Area = 0,00";
                label11.Text = "Volume = 0,00";
            }
            else
            {
                label10.Text = $"Area = {4 * Math.PI * Math.Pow(double.Parse(textBox5.Text), 2):F2}";
                label11.Text = $"Volume = {(4.0 / 3.0) * Math.PI * Math.Pow(double.Parse(textBox5.Text), 3):F2}";
            }

            

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;   
            }
        }

    }
}
