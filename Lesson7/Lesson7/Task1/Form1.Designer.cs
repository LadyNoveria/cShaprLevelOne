namespace Task1
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.countCommand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Button();
            this.intTask = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.revoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(215, 114);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(215, 143);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(215, 172);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(90, 114);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // countCommand
            // 
            this.countCommand.AutoSize = true;
            this.countCommand.Location = new System.Drawing.Point(90, 194);
            this.countCommand.Name = "countCommand";
            this.countCommand.Size = new System.Drawing.Size(13, 13);
            this.countCommand.TabIndex = 4;
            this.countCommand.Text = "0";
            this.countCommand.Click += new System.EventHandler(this.countCommand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество отданных команд";
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(215, 66);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(75, 23);
            this.player.TabIndex = 6;
            this.player.Text = "Играть";
            this.player.UseVisualStyleBackColor = true;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // intTask
            // 
            this.intTask.AutoSize = true;
            this.intTask.Location = new System.Drawing.Point(90, 66);
            this.intTask.Name = "intTask";
            this.intTask.Size = new System.Drawing.Size(13, 13);
            this.intTask.TabIndex = 7;
            this.intTask.Text = "0";
            this.intTask.Click += new System.EventHandler(this.intTask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Необходимо получить";
            // 
            // revoke
            // 
            this.revoke.Location = new System.Drawing.Point(215, 202);
            this.revoke.Name = "revoke";
            this.revoke.Size = new System.Drawing.Size(75, 23);
            this.revoke.TabIndex = 9;
            this.revoke.Text = "Отменить";
            this.revoke.UseVisualStyleBackColor = true;
            this.revoke.Click += new System.EventHandler(this.revoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 296);
            this.Controls.Add(this.revoke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intTask);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countCommand);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label countCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button player;
        private System.Windows.Forms.Label intTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button revoke;
    }
}

