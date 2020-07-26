namespace _2048WindowsFormsApp
{
    partial class ChooseMapSizeForm
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
            this.choiceMapSizeLabel = new System.Windows.Forms.Label();
            this.fourToFourMapSizeButton = new System.Windows.Forms.Button();
            this.fiveToFiveMapSizeButton = new System.Windows.Forms.Button();
            this.sixToSixMapSizeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.размерПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // choiceMapSizeLabel
            // 
            this.choiceMapSizeLabel.AutoSize = true;
            this.choiceMapSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choiceMapSizeLabel.Location = new System.Drawing.Point(64, 77);
            this.choiceMapSizeLabel.Name = "choiceMapSizeLabel";
            this.choiceMapSizeLabel.Size = new System.Drawing.Size(257, 20);
            this.choiceMapSizeLabel.TabIndex = 0;
            this.choiceMapSizeLabel.Text = "Выберите размер игрового поля";
            // 
            // fourToFourMapSizeButton
            // 
            this.fourToFourMapSizeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.fourToFourMapSizeButton.Location = new System.Drawing.Point(104, 120);
            this.fourToFourMapSizeButton.Name = "fourToFourMapSizeButton";
            this.fourToFourMapSizeButton.Size = new System.Drawing.Size(157, 26);
            this.fourToFourMapSizeButton.TabIndex = 1;
            this.fourToFourMapSizeButton.Text = "Поле 4 х 4";
            this.fourToFourMapSizeButton.UseVisualStyleBackColor = true;
            this.fourToFourMapSizeButton.Click += new System.EventHandler(this.fourToFourMapSizeButton_Click);
            // 
            // fiveToFiveMapSizeButton
            // 
            this.fiveToFiveMapSizeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.fiveToFiveMapSizeButton.Location = new System.Drawing.Point(104, 169);
            this.fiveToFiveMapSizeButton.Name = "fiveToFiveMapSizeButton";
            this.fiveToFiveMapSizeButton.Size = new System.Drawing.Size(157, 26);
            this.fiveToFiveMapSizeButton.TabIndex = 2;
            this.fiveToFiveMapSizeButton.Text = "Поле 5 x 5";
            this.fiveToFiveMapSizeButton.UseVisualStyleBackColor = true;
            this.fiveToFiveMapSizeButton.Click += new System.EventHandler(this.fiveToFiveMapSizeButton_Click);
            // 
            // sixToSixMapSizeButton
            // 
            this.sixToSixMapSizeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sixToSixMapSizeButton.Location = new System.Drawing.Point(104, 217);
            this.sixToSixMapSizeButton.Name = "sixToSixMapSizeButton";
            this.sixToSixMapSizeButton.Size = new System.Drawing.Size(157, 26);
            this.sixToSixMapSizeButton.TabIndex = 3;
            this.sixToSixMapSizeButton.Text = "Поле 6 х 6";
            this.sixToSixMapSizeButton.UseVisualStyleBackColor = true;
            this.sixToSixMapSizeButton.Click += new System.EventHandler(this.sixToSixMapSizeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерПоляToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 5;
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
            this.выходИзИгрыToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // выходИзИгрыToolStripMenuItem
            // 
            this.выходИзИгрыToolStripMenuItem.Name = "выходИзИгрыToolStripMenuItem";
            this.выходИзИгрыToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выходИзИгрыToolStripMenuItem.Text = "Выход из игры";
            this.выходИзИгрыToolStripMenuItem.Click += new System.EventHandler(this.выходИзИгрыToolStripMenuItem_Click);
            // 
            // ChooseMapSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 313);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.sixToSixMapSizeButton);
            this.Controls.Add(this.fiveToFiveMapSizeButton);
            this.Controls.Add(this.fourToFourMapSizeButton);
            this.Controls.Add(this.choiceMapSizeLabel);
            this.Name = "ChooseMapSizeForm";
            this.Text = "ChooseMapSizeForm";
            this.Load += new System.EventHandler(this.ChooseMapSizeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choiceMapSizeLabel;
        private System.Windows.Forms.Button fourToFourMapSizeButton;
        private System.Windows.Forms.Button fiveToFiveMapSizeButton;
        private System.Windows.Forms.Button sixToSixMapSizeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem размерПоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзИгрыToolStripMenuItem;
    }
}