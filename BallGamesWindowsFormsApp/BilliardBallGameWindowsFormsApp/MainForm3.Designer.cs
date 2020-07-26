namespace BilliardBallGameWindowsFormsApp
{
    partial class MainForm3
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
            this.startMovingButton = new System.Windows.Forms.Button();
            this.stopMovingButton = new System.Windows.Forms.Button();
            this.leftCounterLabel = new System.Windows.Forms.Label();
            this.topCounterLabel = new System.Windows.Forms.Label();
            this.rightCounterLabel = new System.Windows.Forms.Label();
            this.downCounterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startMovingButton
            // 
            this.startMovingButton.Location = new System.Drawing.Point(670, 9);
            this.startMovingButton.Name = "startMovingButton";
            this.startMovingButton.Size = new System.Drawing.Size(118, 26);
            this.startMovingButton.TabIndex = 11;
            this.startMovingButton.Text = "Запустить шарики";
            this.startMovingButton.UseVisualStyleBackColor = true;
            this.startMovingButton.Click += new System.EventHandler(this.startMovingButton_Click_1);
            // 
            // stopMovingButton
            // 
            this.stopMovingButton.Location = new System.Drawing.Point(670, 41);
            this.stopMovingButton.Name = "stopMovingButton";
            this.stopMovingButton.Size = new System.Drawing.Size(118, 26);
            this.stopMovingButton.TabIndex = 10;
            this.stopMovingButton.Text = "Стоп";
            this.stopMovingButton.UseVisualStyleBackColor = true;
            this.stopMovingButton.Click += new System.EventHandler(this.stopMovingButton_Click_1);
            // 
            // leftCounterLabel
            // 
            this.leftCounterLabel.AutoSize = true;
            this.leftCounterLabel.Location = new System.Drawing.Point(2, 203);
            this.leftCounterLabel.Name = "leftCounterLabel";
            this.leftCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.leftCounterLabel.TabIndex = 12;
            this.leftCounterLabel.Text = "0";
            // 
            // topCounterLabel
            // 
            this.topCounterLabel.AutoSize = true;
            this.topCounterLabel.Location = new System.Drawing.Point(364, 9);
            this.topCounterLabel.Name = "topCounterLabel";
            this.topCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.topCounterLabel.TabIndex = 13;
            this.topCounterLabel.Text = "0";
            // 
            // rightCounterLabel
            // 
            this.rightCounterLabel.AutoSize = true;
            this.rightCounterLabel.Location = new System.Drawing.Point(764, 203);
            this.rightCounterLabel.Name = "rightCounterLabel";
            this.rightCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.rightCounterLabel.TabIndex = 14;
            this.rightCounterLabel.Text = "0";
            // 
            // downCounterLabel
            // 
            this.downCounterLabel.AutoSize = true;
            this.downCounterLabel.Location = new System.Drawing.Point(364, 428);
            this.downCounterLabel.Name = "downCounterLabel";
            this.downCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.downCounterLabel.TabIndex = 15;
            this.downCounterLabel.Text = "0";
            // 
            // MainForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.downCounterLabel);
            this.Controls.Add(this.rightCounterLabel);
            this.Controls.Add(this.topCounterLabel);
            this.Controls.Add(this.leftCounterLabel);
            this.Controls.Add(this.startMovingButton);
            this.Controls.Add(this.stopMovingButton);
            this.Name = "MainForm3";
            this.Text = "Бильярд";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startMovingButton;
        private System.Windows.Forms.Button stopMovingButton;
        private System.Windows.Forms.Label leftCounterLabel;
        private System.Windows.Forms.Label topCounterLabel;
        private System.Windows.Forms.Label rightCounterLabel;
        private System.Windows.Forms.Label downCounterLabel;
    }
}

