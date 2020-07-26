namespace _2048WindowsFormsApp
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
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultsDataGridView
            // 
            this.userResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameColumn,
            this.userScoreColumn});
            this.userResultsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.userResultsDataGridView.Name = "userResultsDataGridView";
            this.userResultsDataGridView.Size = new System.Drawing.Size(247, 260);
            this.userResultsDataGridView.TabIndex = 0;
           
            // 
            // userNameColumn
            // 
            this.userNameColumn.HeaderText = "Имя пользователя";
            this.userNameColumn.Name = "userNameColumn";
            // 
            // userScoreColumn
            // 
            this.userScoreColumn.HeaderText = "Количество очков";
            this.userScoreColumn.Name = "userScoreColumn";
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 286);
            this.Controls.Add(this.userResultsDataGridView);
            this.Name = "UserResultsForm";
            this.Text = "UserResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userScoreColumn;
    }
}