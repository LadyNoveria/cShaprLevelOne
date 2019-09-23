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
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        int random = rnd.Next(1, 100);
        public static int number;

        public Form1()
        {
            InitializeComponent();
            lblNumber.Text = "0";
            player.Text = "Играть";
            enterNumber.Text = "Ввести число";
            this.Text = "Угадай число";
        }

        private void player_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Загадано число от 1 до 100. Угадайте его за минимальное количество попыток");
        }

        private void enterNumber_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();

        }
        private void checkAnswer_Click(object sender, EventArgs e)
        {

            if (number == random)
            {
                MessageBox.Show($"Вы угадали! Число {random}");
                this.Close();
            }
            else if (number < random)
            {
                MessageBox.Show($"Неверно! Указанное Вами число {number} меньше загаданного.");
                lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            }
            else if (number > random)
            {
                MessageBox.Show($"Неверно! Указанное Вами число {number} больше загаданного.");
                lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            }
        }
    }
}
