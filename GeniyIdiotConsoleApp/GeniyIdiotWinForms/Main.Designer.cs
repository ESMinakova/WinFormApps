namespace GeniyIdiotWinForms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionNextButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пройтиЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionNextButton
            // 
            this.questionNextButton.Location = new System.Drawing.Point(148, 182);
            this.questionNextButton.Name = "questionNextButton";
            this.questionNextButton.Size = new System.Drawing.Size(75, 23);
            this.questionNextButton.TabIndex = 0;
            this.questionNextButton.Text = "Далее";
            this.questionNextButton.UseVisualStyleBackColor = true;
            this.questionNextButton.Click += new System.EventHandler(this.questionNextButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumberLabel.Location = new System.Drawing.Point(145, 45);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(81, 16);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Вопрос №";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(97, 120);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(188, 20);
            this.userAnswerTextBox.TabIndex = 2;
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(33, 76);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(82, 13);
            this.questionTextLabel.TabIndex = 3;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьРезультатыToolStripMenuItem,
            this.добавитьВопросToolStripMenuItem,
            this.пройтиЗановоToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // показатьРезультатыToolStripMenuItem
            // 
            this.показатьРезультатыToolStripMenuItem.Name = "показатьРезультатыToolStripMenuItem";
            this.показатьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.показатьРезультатыToolStripMenuItem.Text = "Показать результаты";
            this.показатьРезультатыToolStripMenuItem.Click += new System.EventHandler(this.показатьРезультатыToolStripMenuItem_Click);
            // 
            // пройтиЗановоToolStripMenuItem
            // 
            this.пройтиЗановоToolStripMenuItem.Name = "пройтиЗановоToolStripMenuItem";
            this.пройтиЗановоToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.пройтиЗановоToolStripMenuItem.Text = "Пройти заново";
            this.пройтиЗановоToolStripMenuItem.Click += new System.EventHandler(this.пройтиЗановоToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // добавитьВопросToolStripMenuItem
            // 
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            this.добавитьВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.questionNextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 326);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.questionNextButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Тест \"Гений - Идиот\"";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button questionNextButton;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьРезультатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пройтиЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросToolStripMenuItem;
    }
}

