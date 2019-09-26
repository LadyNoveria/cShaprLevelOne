namespace BelieveOrNotBelieve
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
            this.tboxQuestion = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveQuest = new System.Windows.Forms.Button();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cboxTrue = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxQuestion
            // 
            this.tboxQuestion.BackColor = System.Drawing.Color.Black;
            this.tboxQuestion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tboxQuestion.ForeColor = System.Drawing.SystemColors.Window;
            this.tboxQuestion.Location = new System.Drawing.Point(0, 27);
            this.tboxQuestion.Multiline = true;
            this.tboxQuestion.Name = "tboxQuestion";
            this.tboxQuestion.Size = new System.Drawing.Size(614, 157);
            this.tboxQuestion.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(12, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(160, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 25);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveQuest
            // 
            this.btnSaveQuest.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveQuest.Location = new System.Drawing.Point(284, 194);
            this.btnSaveQuest.Name = "btnSaveQuest";
            this.btnSaveQuest.Size = new System.Drawing.Size(109, 25);
            this.btnSaveQuest.TabIndex = 3;
            this.btnSaveQuest.Text = "Сохранить";
            this.btnSaveQuest.UseVisualStyleBackColor = true;
            this.btnSaveQuest.Click += new System.EventHandler(this.btnSaveQuest_Click);
            // 
            // nudNumber
            // 
            this.nudNumber.BackColor = System.Drawing.Color.White;
            this.nudNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudNumber.Location = new System.Drawing.Point(411, 197);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(92, 23);
            this.nudNumber.TabIndex = 4;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // cboxTrue
            // 
            this.cboxTrue.AutoSize = true;
            this.cboxTrue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxTrue.Location = new System.Drawing.Point(531, 201);
            this.cboxTrue.Name = "cboxTrue";
            this.cboxTrue.Size = new System.Drawing.Size(68, 19);
            this.cboxTrue.TabIndex = 5;
            this.cboxTrue.Text = "Правда";
            this.cboxTrue.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(611, 25);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miExit});
            this.ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.ToolStripMenuItem.Text = "File";
            // 
            // miNew
            // 
            this.miNew.BackColor = System.Drawing.Color.Black;
            this.miNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(180, 22);
            this.miNew.Text = "New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.BackColor = System.Drawing.SystemColors.ControlText;
            this.miOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(180, 22);
            this.miOpen.Text = "Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.BackColor = System.Drawing.SystemColors.ControlText;
            this.miSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(180, 22);
            this.miSave.Text = "Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(180, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(611, 230);
            this.Controls.Add(this.cboxTrue);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.btnSaveQuest);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tboxQuestion);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Верю - Не верю";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxQuestion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveQuest;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.CheckBox cboxTrue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miExit;
    }
}

