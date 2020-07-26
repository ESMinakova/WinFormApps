namespace GeniyIdiotWinForms
{
    partial class UserResultsForm
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
            this.userResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberRightAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultsDataGridView
            // 
            this.userResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.NumberRightAnswers,
            this.Diagnose});
            this.userResultsDataGridView.Location = new System.Drawing.Point(45, 27);
            this.userResultsDataGridView.Name = "userResultsDataGridView";
            this.userResultsDataGridView.Size = new System.Drawing.Size(348, 262);
            this.userResultsDataGridView.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.HeaderText = "Имя";
            this.userName.Name = "userName";
            // 
            // NumberRightAnswers
            // 
            this.NumberRightAnswers.HeaderText = "Количество правильных ответов";
            this.NumberRightAnswers.Name = "NumberRightAnswers";
            // 
            // Diagnose
            // 
            this.Diagnose.HeaderText = "Диагноз";
            this.Diagnose.Name = "Diagnose";
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 332);
            this.Controls.Add(this.userResultsDataGridView);
            this.Name = "UserResultsForm";
            this.Text = "UserResultsForm";
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberRightAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnose;
    }
}