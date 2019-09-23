using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            checkNumber.Text = "Проверить";
            this.Text = "Ввод числа";
        }

        private void checkNumber_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int numb;
            bool flag;
            flag = int.TryParse(text, out numb);
            if (!flag)
            {
                MessageBox.Show("Некорретный формат ввода. Введите целое число");
            }
            else {
                Form1.number = numb;
                Activate();
                this.Close();
            }
        }
    }
}
