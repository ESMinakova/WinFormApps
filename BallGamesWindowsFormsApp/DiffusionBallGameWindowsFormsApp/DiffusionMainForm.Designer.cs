namespace DiffusionBallGameWindowsFormsApp
{
    partial class diffusionMainForm
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
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 10;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // diffusionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 527);
            this.Name = "diffusionMainForm";
            this.Text = "Диффузия";
            this.Load += new System.EventHandler(this.diffusionMainForm_Load);
            //this.Paint += new System.Windows.Forms.PaintEventHandler(this.diffusionMainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.diffusionMainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MainTimer;
    }
}

