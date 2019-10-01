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
            this.tboxQuestion = new System.Windows.Forms.TextBox();
            this.believe = new System.Windows.Forms.Button();
            this.noBelieve = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.numberQuestion = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playStart
            // 
            this.playStart.Location = new System.Drawing.Point(252, 26);
            this.playStart.Name = "playStart";
            this.playStart.Size = new System.Drawing.Size(75, 23);
            this.playStart.TabIndex = 0;
            this.playStart.Text = "Играть";
            this.playStart.UseVisualStyleBackColor = true;
            this.playStart.Click += new System.EventHandler(this.playStart_Click);
            // 
            // tboxQuestion
            // 
            this.tboxQuestion.Location = new System.Drawing.Point(-1, 87);
            this.tboxQuestion.Multiline = true;
            this.tboxQuestion.Name = "tboxQuestion";
            this.tboxQuestion.Size = new System.Drawing.Size(584, 76);
            this.tboxQuestion.TabIndex = 1;
            // 
            // believe
            // 
            this.believe.Location = new System.Drawing.Point(198, 184);
            this.believe.Name = "believe";
            this.believe.Size = new System.Drawing.Size(75, 23);
            this.believe.TabIndex = 2;
            this.believe.Text = "Верю";
            this.believe.UseVisualStyleBackColor = true;
            this.believe.Click += new System.EventHandler(this.believe_Click);
            // 
            // noBelieve
            // 
            this.noBelieve.Location = new System.Drawing.Point(308, 184);
            this.noBelieve.Name = "noBelieve";
            this.noBelieve.Size = new System.Drawing.Size(75, 23);
            this.noBelieve.TabIndex = 3;
            this.noBelieve.Text = "Не верю";
            this.noBelieve.UseVisualStyleBackColor = true;
            this.noBelieve.Click += new System.EventHandler(this.noBelieve_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 61);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(82, 13);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Вопрос номер:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewGame,
            this.miExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miNewGame
            // 
            this.miNewGame.Name = "miNewGame";
            this.miNewGame.Size = new System.Drawing.Size(180, 22);
            this.miNewGame.Text = "New Game";
            this.miNewGame.Click += new System.EventHandler(this.miNewGame_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(180, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // numberQuestion
            // 
            this.numberQuestion.Location = new System.Drawing.Point(100, 58);
            this.numberQuestion.Name = "numberQuestion";
            this.numberQuestion.Size = new System.Drawing.Size(34, 20);
            this.numberQuestion.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 319);
            this.Controls.Add(this.numberQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.noBelieve);
            this.Controls.Add(this.believe);
            this.Controls.Add(this.tboxQuestion);
            this.Controls.Add(this.playStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Верю - Не Верю";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playStart;
        private System.Windows.Forms.TextBox tboxQuestion;
        private System.Windows.Forms.Button believe;
        private System.Windows.Forms.Button noBelieve;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNewGame;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.TextBox numberQuestion;
    }
}

