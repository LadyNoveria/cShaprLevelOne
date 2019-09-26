using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
    public partial class Form1 : Form
    {
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
            nudNumber.Enabled = false;
            btnSaveQuest.Enabled = false;
            btnDelete.Enabled = false;
            cboxTrue.Enabled = false;
            //miSaveAs.Enabled = false;
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                availabilityChange();
            }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    database = new TrueFalse(ofd.FileName);
                    database.Load();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                    availabilityChange();
                }
                catch
                {
                    MessageBox.Show("Неверный формат данных", "Сообщение");
                }
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// "Сохранить как" с выбором файла для сохранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if (database == null) MessageBox.Show("База данных не создана");
            else {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK) database.SaveAs(sfd.FileName);
            } 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены, что хотите удалить этот элемент?";
            string caption = "Удаление элемента";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (nudNumber.Maximum == 1 || database == null) return;
                database.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum--;
                if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
            }
        }

        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
                database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
                database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
        }

        /// <summary>
        /// Изменение активности элементов формы
        /// </summary>
        private void availabilityChange() {
            nudNumber.Enabled = true;
            btnSaveQuest.Enabled = true;
            btnDelete.Enabled = true;
            cboxTrue.Enabled = true;
            //miSaveAs.Enabled = true;
        }

        private void description_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Замечтательная программа");
        }

        private void reference_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь должна быть инструкция, но я ее еще не придумала =)");
        }

        private void copyright_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор Вася Пупкин, mailto: vasyapupkin99@yandex.ru");
        }

        private void version_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия программы 0.0.1");
        }
    }
}
