namespace _2048WindowsFormsApp
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
            this.currentScoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bestScoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.размерПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьРезультатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рестартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentScoreLabel
            // 
            this.currentScoreLabel.AutoSize = true;
            this.currentScoreLabel.Location = new System.Drawing.Point(267, 24);
            this.currentScoreLabel.Name = "currentScoreLabel";
            this.currentScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.currentScoreLabel.TabIndex = 0;
            this.currentScoreLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ваш счёт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лучший";
            // 
            // bestScoreLabel
            // 
            this.bestScoreLabel.AutoSize = true;
            this.bestScoreLabel.Location = new System.Drawing.Point(267, 43);
            this.bestScoreLabel.Name = "bestScoreLabel";
            this.bestScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.bestScoreLabel.TabIndex = 3;
            this.bestScoreLabel.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерПоляToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(347, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // размерПоляToolStripMenuItem
            // 
            this.размерПоляToolStripMenuItem.Name = "размерПоляToolStripMenuItem";
            this.размерПоляToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаИгрыToolStripMenuItem,
            this.показатьРезультатыToolStripMenuItem,
            this.запуститьЗановоToolStripMenuItem,
            this.выходИзИгрыToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // показатьРезультатыToolStripMenuItem
            // 
            this.показатьРезультатыToolStripMenuItem.Name = "показатьРезультатыToolStripMenuItem";
            this.показатьРезультатыToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.показатьРезультатыToolStripMenuItem.Text = "Показать результаты";
            this.показатьРезультатыToolStripMenuItem.Click += new System.EventHandler(this.показатьРезультатыToolStripMenuItem_Click);
            // 
            // запуститьЗановоToolStripMenuItem
            // 
            this.запуститьЗановоToolStripMenuItem.Name = "запуститьЗановоToolStripMenuItem";
            this.запуститьЗановоToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.запуститьЗановоToolStripMenuItem.Text = "Запустить заново";
            this.запуститьЗановоToolStripMenuItem.Click += new System.EventHandler(this.запуститьЗановоToolStripMenuItem_Click);
            // 
            // выходИзИгрыToolStripMenuItem
            // 
            this.выходИзИгрыToolStripMenuItem.Name = "выходИзИгрыToolStripMenuItem";
            this.выходИзИгрыToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.выходИзИгрыToolStripMenuItem.Text = "Выход из игры";
            this.выходИзИгрыToolStripMenuItem.Click += new System.EventHandler(this.выходИзИгрыToolStripMenuItem_Click);
            // 
            // результатыИгрыToolStripMenuItem
            // 
            this.результатыИгрыToolStripMenuItem.Name = "результатыИгрыToolStripMenuItem";
            this.результатыИгрыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.результатыИгрыToolStripMenuItem.Text = "Результаты игры";
            // 
            // рестартToolStripMenuItem
            // 
            this.рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            this.рестартToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рестартToolStripMenuItem.Text = "Рестарт";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 411);
            this.Controls.Add(this.bestScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentScoreLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentScoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bestScoreLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem размерПоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рестартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьРезультатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзИгрыToolStripMenuItem;
    }
}

