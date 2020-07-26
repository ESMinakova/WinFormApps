namespace CatchMe_2BallGameWindowsFormsApp
{
    partial class MainForm2
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
            this.clearFieldButton = new System.Windows.Forms.Button();
            this.numberOfCatchedBallsLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startMovingButton
            // 
            this.startMovingButton.Location = new System.Drawing.Point(670, 12);
            this.startMovingButton.Name = "startMovingButton";
            this.startMovingButton.Size = new System.Drawing.Size(118, 26);
            this.startMovingButton.TabIndex = 9;
            this.startMovingButton.Text = "Запустить шарики";
            this.startMovingButton.UseVisualStyleBackColor = true;
            this.startMovingButton.Click += new System.EventHandler(this.startMovingButton_Click_1);
            // 
            // clearFieldButton
            // 
            this.clearFieldButton.Location = new System.Drawing.Point(670, 44);
            this.clearFieldButton.Name = "clearFieldButton";
            this.clearFieldButton.Size = new System.Drawing.Size(118, 26);
            this.clearFieldButton.TabIndex = 8;
            this.clearFieldButton.Text = "Очистить";
            this.clearFieldButton.UseVisualStyleBackColor = true;
            this.clearFieldButton.Click += new System.EventHandler(this.clearFieldButton_Click_1);
            // 
            // numberOfCatchedBallsLabel
            // 
            this.numberOfCatchedBallsLabel.Location = new System.Drawing.Point(162, 14);
            this.numberOfCatchedBallsLabel.Name = "numberOfCatchedBallsLabel";
            this.numberOfCatchedBallsLabel.Size = new System.Drawing.Size(58, 14);
            this.numberOfCatchedBallsLabel.TabIndex = 11;
            this.numberOfCatchedBallsLabel.Text = "0";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(12, 12);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(144, 16);
            this.textLabel.TabIndex = 10;
            this.textLabel.Text = "Пойманных шариков:";
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberOfCatchedBallsLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.startMovingButton);
            this.Controls.Add(this.clearFieldButton);
            this.Name = "MainForm2";
            this.Text = "Поймай меня - 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startMovingButton;
        private System.Windows.Forms.Button clearFieldButton;
        private System.Windows.Forms.Label numberOfCatchedBallsLabel;
        private System.Windows.Forms.Label textLabel;
    }
}

