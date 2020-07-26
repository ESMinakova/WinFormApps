namespace GeniyIdiotWinForms
{
    partial class AddQuestionForm
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
            this.saveQustionButton = new System.Windows.Forms.Button();
            this.textQuestionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.questionTextTextBox = new System.Windows.Forms.TextBox();
            this.questionAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveQustionButton
            // 
            this.saveQustionButton.Location = new System.Drawing.Point(112, 264);
            this.saveQustionButton.Name = "saveQustionButton";
            this.saveQustionButton.Size = new System.Drawing.Size(75, 23);
            this.saveQustionButton.TabIndex = 0;
            this.saveQustionButton.Text = "Сохранить";
            this.saveQustionButton.UseVisualStyleBackColor = true;
            this.saveQustionButton.Click += new System.EventHandler(this.saveQustionButton_Click);
            // 
            // textQuestionLabel
            // 
            this.textQuestionLabel.AutoSize = true;
            this.textQuestionLabel.Location = new System.Drawing.Point(84, 75);
            this.textQuestionLabel.Name = "textQuestionLabel";
            this.textQuestionLabel.Size = new System.Drawing.Size(125, 13);
            this.textQuestionLabel.TabIndex = 1;
            this.textQuestionLabel.Text = "Введите текст вопроса";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(109, 170);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(80, 13);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.Text = "Введите ответ";
            // 
            // questionTextTextBox
            // 
            this.questionTextTextBox.Location = new System.Drawing.Point(41, 122);
            this.questionTextTextBox.Name = "questionTextTextBox";
            this.questionTextTextBox.Size = new System.Drawing.Size(235, 20);
            this.questionTextTextBox.TabIndex = 3;
            // 
            // questionAnswerTextBox
            // 
            this.questionAnswerTextBox.Location = new System.Drawing.Point(41, 209);
            this.questionAnswerTextBox.Name = "questionAnswerTextBox";
            this.questionAnswerTextBox.Size = new System.Drawing.Size(224, 20);
            this.questionAnswerTextBox.TabIndex = 4;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 331);
            this.Controls.Add(this.questionAnswerTextBox);
            this.Controls.Add(this.questionTextTextBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.textQuestionLabel);
            this.Controls.Add(this.saveQustionButton);
            this.Name = "AddQuestionForm";
            this.Text = "Добавление своего вопроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveQustionButton;
        private System.Windows.Forms.Label textQuestionLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox questionTextTextBox;
        private System.Windows.Forms.TextBox questionAnswerTextBox;
    }
}