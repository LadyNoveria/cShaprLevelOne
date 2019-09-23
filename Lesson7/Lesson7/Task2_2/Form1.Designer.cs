namespace Task2_2
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
            this.player = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.enterNumber = new System.Windows.Forms.Button();
            this.checkAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(166, 41);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 0;
            this.player.Text = "Играть";
            this.player.UseVisualStyleBackColor = true;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(147, 166);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(112, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Количество попыток";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(197, 193);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "0";
            // 
            // enterNumber
            // 
            this.enterNumber.Location = new System.Drawing.Point(138, 79);
            this.enterNumber.Name = "enterNumber";
            this.enterNumber.Size = new System.Drawing.Size(136, 23);
            this.enterNumber.TabIndex = 3;
            this.enterNumber.Text = "Ввести число";
            this.enterNumber.UseVisualStyleBackColor = true;
            this.enterNumber.Click += new System.EventHandler(this.enterNumber_Click);
            // 
            // checkAnswer
            // 
            this.checkAnswer.Location = new System.Drawing.Point(151, 121);
            this.checkAnswer.Name = "checkAnswer";
            this.checkAnswer.Size = new System.Drawing.Size(108, 23);
            this.checkAnswer.TabIndex = 4;
            this.checkAnswer.Text = "Проверить ответ";
            this.checkAnswer.UseVisualStyleBackColor = true;
            this.checkAnswer.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 264);
            this.Controls.Add(this.checkAnswer);
            this.Controls.Add(this.enterNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.label);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button player;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button enterNumber;
        private System.Windows.Forms.Button checkAnswer;
    }
}

