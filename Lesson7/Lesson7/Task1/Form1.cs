using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Task1
{
    public partial class Form1 : Form
    {
        //глобальный стэк
        Stack<int> numbers = new Stack<int>();
        //глобальная переменная, определяет, была ли нажата кнопка "Играть"
        bool stub = false; 

        /// <summary>
        /// Подсчет отданных команд
        /// </summary>
        private void CountCommand() {
            countCommand.Text = (int.Parse(countCommand.Text) + 1).ToString();
        }

        /// <summary>
        /// Возврат верхнего элемента стэка с последующим его удалением
        /// </summary>
        /// <returns></returns>
        private int revokeNumb()
        {
            return numbers.Pop();
        }
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            countCommand.Text = "0";
            //numbers.Push(0);
            this.Text = "Удвоитель";

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            //Если кнопка "Играть" была нажата, то обрабатывать события с других кнопок
            if (stub) 
            {
                numbers.Push(int.Parse(lblNumber.Text) + 1);
                lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
                CountCommand();
            }
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            //Если кнопка "Играть" была нажата, то обрабатывать события с других кнопок
            if (stub)
            {
                numbers.Push(int.Parse(lblNumber.Text) * 2);
                lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
                CountCommand();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Если кнопка "Играть" была нажата, то обрабатывать события с других кнопок
            if (stub) {
                lblNumber.Text = "1";
                CountCommand();
            }
        }

        private void player_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numb = rnd.Next(10, 10000);
            intTask.Text = numb.ToString();
            MessageBox.Show($"Необходимо получить число: {numb}");
            stub = true;
        }

        private void revoke_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
                lblNumber.Text = "0";
            else {
                int temp = revokeNumb();
                if (int.Parse(lblNumber.Text) == temp)
                    lblNumber.Text = numbers.Peek().ToString();
                else {
                    lblNumber.Text = temp.ToString();
                }
            }
        }

        private void intTask_Click(object sender, EventArgs e)
        {
           

        }

        private void countCommand_Click(object sender, EventArgs e)
        {

        }
    }
}
