using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        int count = 0;
        static Random rnd = new Random();
        int random = rnd.Next(1, 100);

        public Form1()
        {
            InitializeComponent();
            lblNumber.Text = "0";
            player.Text = "Играть";
            check.Text = "Проверить";
            this.Text = "Угадай число";

        }

        private void player_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Загадано число от 1 до 100. Угадайте его за минимальное количество попыток");
            count++;
        }

        private void checkNumber(int number) {
            if (number == random) {
                MessageBox.Show($"Вы угадали! Число {random}");
                this.Close();
            }            
            else if (number < random) {
                MessageBox.Show($"Неверно! Указанное Вами число {number} меньше загаданного.");
                lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            }
            else if (number > random) {
                MessageBox.Show($"Неверно! Указанное Вами число {number} больше загаданного.");
                lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            }
        }

        private void check_Click_1(object sender, EventArgs e)
        {
            if (count > 0)
            {
                string text = textBox1.Text;
                int number;
                bool flag;
                flag = int.TryParse(text, out number);
                if (!flag)
                {
                    MessageBox.Show("Некорретный формат ввода. Введите целое число");
                    lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
                }
                else {
                    checkNumber(number);
                }
            }
        }
    }
}
