using GeniyIdiotCommon;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinForms
{
    public partial class IntroductionForm : Form
    {
        public User user;
        public IntroductionForm()
        {
            InitializeComponent();
        }

        private void IntroductionForm_Load(object sender, EventArgs e)
        {
                                   
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
            var frm = new Main(userNameTextBox.Text);            
            frm.ShowDialog();
            Close();           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
