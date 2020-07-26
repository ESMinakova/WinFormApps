using _2048ClassLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
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
                userResultsDataGridView.Rows.Add(userResults.Name, userResults.Score);
            }
            this.userResultsDataGridView.Sort(this.userResultsDataGridView.Columns[1], ListSortDirection.Descending);

        }

    }
}
