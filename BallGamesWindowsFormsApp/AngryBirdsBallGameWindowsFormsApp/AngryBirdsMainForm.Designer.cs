namespace AngryBirdsBallGameWindowsFormsApp
{
    partial class angryBirdsMainForm
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
            this.nextTryingButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nextPigButton = new System.Windows.Forms.Button();
            this.crushingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // nextTryingButton
            // 
            this.nextTryingButton.Location = new System.Drawing.Point(16, 14);
            this.nextTryingButton.Name = "nextTryingButton";
            this.nextTryingButton.Size = new System.Drawing.Size(139, 31);
            this.nextTryingButton.TabIndex = 0;
            this.nextTryingButton.Text = "Следующая попытка";
            this.nextTryingButton.UseVisualStyleBackColor = true;
            this.nextTryingButton.Click += new System.EventHandler(this.nextTryingButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // nextPigButton
            // 
            this.nextPigButton.Location = new System.Drawing.Point(16, 51);
            this.nextPigButton.Name = "nextPigButton";
            this.nextPigButton.Size = new System.Drawing.Size(139, 30);
            this.nextPigButton.TabIndex = 1;
            this.nextPigButton.Text = "Следующая свинка";
            this.nextPigButton.UseVisualStyleBackColor = true;
            this.nextPigButton.Click += new System.EventHandler(this.nextPigButton_Click);
            // 
            // crushingTimer
            // 
            this.crushingTimer.Interval = 1000;
            this.crushingTimer.Tick += new System.EventHandler(this.crushingTimer_Tick);
            // 
            // angryBirdsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 515);
            this.Controls.Add(this.nextPigButton);
            this.Controls.Add(this.nextTryingButton);
            this.Name = "angryBirdsMainForm";
            this.Text = "Angry Birds";
            this.Load += new System.EventHandler(this.angryBirdsMainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.angryBirdsMainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextTryingButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button nextPigButton;
        private System.Windows.Forms.Timer crushingTimer;
    }
}

