namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.playStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.believe = new System.Windows.Forms.Button();
            this.noBelieve = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // playStart
            // 
            this.playStart.Location = new System.Drawing.Point(238, 12);
            this.playStart.Name = "playStart";
            this.playStart.Size = new System.Drawing.Size(75, 23);
            this.playStart.TabIndex = 0;
            this.playStart.Text = "Играть";
            this.playStart.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(584, 76);
            this.textBox1.TabIndex = 1;
            // 
            // believe
            // 
            this.believe.Location = new System.Drawing.Point(114, 160);
            this.believe.Name = "believe";
            this.believe.Size = new System.Drawing.Size(75, 23);
            this.believe.TabIndex = 2;
            this.believe.Text = "Верю";
            this.believe.UseVisualStyleBackColor = true;
            // 
            // noBelieve
            // 
            this.noBelieve.Location = new System.Drawing.Point(395, 160);
            this.noBelieve.Name = "noBelieve";
            this.noBelieve.Size = new System.Drawing.Size(75, 23);
            this.noBelieve.TabIndex = 3;
            this.noBelieve.Text = "Не верю";
            this.noBelieve.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(297, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(209, 43);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(82, 13);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Вопрос номер:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 319);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.noBelieve);
            this.Controls.Add(this.believe);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.playStart);
            this.Name = "Form1";
            this.Text = "Верю - Не Верю";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button believe;
        private System.Windows.Forms.Button noBelieve;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblQuestion;
    }
}

