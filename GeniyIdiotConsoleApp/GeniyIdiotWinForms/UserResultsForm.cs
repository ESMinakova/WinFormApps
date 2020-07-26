using GeniyIdiotCommon;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GeniyIdiotWinForms
{
    public partial class UserResultsForm : Form
    {
        public List<UserResult> UserResults;
        
        public UserResultsForm(List<UserResult> UserResults)
        {
            InitializeComponent();
            this.UserResults = UserResults;
            ResultsShow();
        }

        private void ResultsShow()
        {
            foreach (var userResults in UserResults)
            {
                userResultsDataGridView.Rows.Add(userResults.Name, userResults.NumberOfRightAnswers, userResults.DiagnoseName);
            }
        }
    }
}
