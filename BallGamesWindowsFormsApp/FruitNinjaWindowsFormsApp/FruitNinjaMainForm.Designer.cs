namespace FruitNinjaWindowsFormsApp
{
    partial class fruitNinjaForm
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
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.Textlabel = new System.Windows.Forms.Label();
            this.numberOfCatchedBallsLabel = new System.Windows.Forms.Label();
            this.startMovingButton = new System.Windows.Forms.Button();
            this.stopMovingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 2000;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // Textlabel
            // 
            this.Textlabel.AutoSize = true;
            this.Textlabel.Location = new System.Drawing.Point(12, 9);
            this.Textlabel.Name = "Textlabel";
            this.Textlabel.Size = new System.Drawing.Size(114, 13);
            this.Textlabel.TabIndex = 1;
            this.Textlabel.Text = "Пойманных фруктов:";
            // 
            // numberOfCatchedBallsLabel
            // 
            this.numberOfCatchedBallsLabel.AutoSize = true;
            this.numberOfCatchedBallsLabel.Location = new System.Drawing.Point(129, 9);
            this.numberOfCatchedBallsLabel.Name = "numberOfCatchedBallsLabel";
            this.numberOfCatchedBallsLabel.Size = new System.Drawing.Size(13, 13);
            this.numberOfCatchedBallsLabel.TabIndex = 2;
            this.numberOfCatchedBallsLabel.Text = "0";
            // 
            // startMovingButton
            // 
            this.startMovingButton.Location = new System.Drawing.Point(704, 12);
            this.startMovingButton.Name = "startMovingButton";
            this.startMovingButton.Size = new System.Drawing.Size(75, 23);
            this.startMovingButton.TabIndex = 3;
            this.startMovingButton.Text = "Старт";
            this.startMovingButton.UseVisualStyleBackColor = true;
            this.startMovingButton.Click += new System.EventHandler(this.startMovingButton_Click);
            // 
            // stopMovingButton
            // 
            this.stopMovingButton.Location = new System.Drawing.Point(704, 51);
            this.stopMovingButton.Name = "stopMovingButton";
            this.stopMovingButton.Size = new System.Drawing.Size(75, 23);
            this.stopMovingButton.TabIndex = 4;
            this.stopMovingButton.Text = "Стоп";
            this.stopMovingButton.UseVisualStyleBackColor = true;
            this.stopMovingButton.Click += new System.EventHandler(this.stopMovingButton_Click);
            // 
            // fruitNinjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.stopMovingButton);
            this.Controls.Add(this.startMovingButton);
            this.Controls.Add(this.numberOfCatchedBallsLabel);
            this.Controls.Add(this.Textlabel);
            this.Name = "fruitNinjaForm";
            this.Text = "Fruit Ninja";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label Textlabel;
        private System.Windows.Forms.Label numberOfCatchedBallsLabel;
        private System.Windows.Forms.Button startMovingButton;
        private System.Windows.Forms.Button stopMovingButton;
    }
}

