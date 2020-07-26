namespace BallGamesWindowsFormsApp
{
    partial class MainForm
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
            this.stopMovingButton = new System.Windows.Forms.Button();
            this.startMovingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stopMovingButton
            // 
            this.stopMovingButton.Location = new System.Drawing.Point(670, 44);
            this.stopMovingButton.Name = "stopMovingButton";
            this.stopMovingButton.Size = new System.Drawing.Size(118, 26);
            this.stopMovingButton.TabIndex = 0;
            this.stopMovingButton.Text = "Стоп";
            this.stopMovingButton.UseVisualStyleBackColor = true;
            this.stopMovingButton.Click += new System.EventHandler(this.stopMovingButton_Click);
            // 
            // startMovingButton
            // 
            this.startMovingButton.Location = new System.Drawing.Point(670, 12);
            this.startMovingButton.Name = "startMovingButton";
            this.startMovingButton.Size = new System.Drawing.Size(118, 26);
            this.startMovingButton.TabIndex = 3;
            this.startMovingButton.Text = "Запустить шарики";
            this.startMovingButton.UseVisualStyleBackColor = true;
            this.startMovingButton.Click += new System.EventHandler(this.startMovingButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startMovingButton);
            this.Controls.Add(this.stopMovingButton);
            this.Name = "MainForm";
            this.Text = "Поймай меня - 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stopMovingButton;
        private System.Windows.Forms.Button startMovingButton;
    }
}

