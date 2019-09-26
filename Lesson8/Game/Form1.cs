using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game
{
    public partial class Form1 : Form
    {
        TrueFalse database;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            believe.Enabled = false; //делает неактивной кнопку "Верю"
            noBelieve.Enabled = false; //делает неактивной кнопку "Не верю"
            miNewGame.Enabled = false; //делает неактивным меню Новая игра
            numberQuestion.Text = "0";
        }


        private void playStart_Click(object sender, EventArgs e)
        {
            int n = int.Parse(numberQuestion.Text);
            string fileName = getFileName();
            database = new TrueFalse(fileName);
            database.Load(fileName);
            numberQuestion.Text = (int.Parse(numberQuestion.Text) + 1).ToString();
            tboxQuestion.Text = database[(int)n].text;
            availabilityChange();
        }

        /// <summary>
        /// Получение пути к файлу с вопросами
        /// </summary>
        /// <returns></returns>
        public string getFileName()
        {
            Random rnd = new Random();
            int temp = rnd.Next(1, 10);

            //путь к файлу, где хранятся пути к файлам с разными вопросами
            StreamReader sr = new StreamReader(@"D:\Noveria\GeekBrains\Test\filenames.txt");
            int n = int.Parse(sr.ReadLine());
            string[] a = new string[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = sr.ReadLine();
            }
            sr.Close();

            //выбор пути до одного из файлов с вопросами
            string fileName = a[temp];
            return fileName;
        }


        private void believe_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(numberQuestion.Text);
                bool i = database[(int)n - 1].trueFalse;
                checkAnswer(i, n);
            }
            catch { }
        }

        private void noBelieve_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(numberQuestion.Text);
                bool i = database[(int)n - 1].trueFalse;
                checkAnswer(!i, n);
            }
            catch { }
        }

        /// <summary>
        /// Проверка ответов пользователя
        /// </summary>
        private void checkAnswer(bool i, int n)
        {
            if ((int)n == database.Count)
            {
                if (i) {
                    MessageBox.Show("Вы угадали!");
                    count++;
                } 
                else MessageBox.Show("Вы не угадали!");
                endGame();
            }
            else if (i)
            {
                MessageBox.Show("Вы угадали!");
                count++;
                numberQuestion.Text = (int.Parse(numberQuestion.Text) + 1).ToString();
                tboxQuestion.Text = database[(int)n].text;
            }
            else
            {
                MessageBox.Show("Вы не угадали!");
                numberQuestion.Text = (int.Parse(numberQuestion.Text) + 1).ToString();
                tboxQuestion.Text = database[(int)n].text;
            }
        }

        /// <summary>
        /// Окончание игры
        /// </summary>
        private void endGame() {
            MessageBox.Show($"Игра окончена. Вы ответили верно на {count} вопросов.");
            numberQuestion.Text = "0";
            tboxQuestion.Text = "";
        }

        /// <summary>
        /// Изменение активности элементов формы
        /// </summary>
        private void availabilityChange()
        {
            believe.Enabled = true;
            noBelieve.Enabled = true;
            miNewGame.Enabled = true;
        }

        private void miNewGame_Click(object sender, EventArgs e)
        {
            int n = int.Parse(numberQuestion.Text);
            string fileName = getFileName();
            database = new TrueFalse(fileName);
            database.Load(fileName);
            numberQuestion.Text = "1";
            tboxQuestion.Text = database[(int)n].text;
            count = 0;
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
