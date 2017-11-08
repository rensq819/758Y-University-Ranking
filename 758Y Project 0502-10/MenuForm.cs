using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _758Y_Project_0502_10
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void usNews15MBAButton_Click(object sender, EventArgs e)
        {
            RankingForm theRankingForm = new RankingForm();
            theRankingForm.viewUSN15MBA();
            theRankingForm.Text = "U.S.News 2015 MBA Top 10";
            theRankingForm.ShowDialog();            
        }

        private void usNews16MBAButton_Click(object sender, EventArgs e)
        {
            RankingForm theRankingForm = new RankingForm();
            theRankingForm.viewUSN16MBA();
            theRankingForm.ShowDialog();
        }

        private void qs15MBAButton_Click(object sender, EventArgs e)
        {
            RankingForm theRankingForm = new RankingForm();
            theRankingForm.viewQS15MBA();
            theRankingForm.ShowDialog();
        }

        private void qs16MBAButton_Click(object sender, EventArgs e)
        {
            RankingForm theRankingForm = new RankingForm();
            theRankingForm.viewQS16MBA();
            theRankingForm.ShowDialog();
        }

        private void usNews15MSISButton_Click(object sender, EventArgs e)
        {
            RankingForm theRankingForm = new RankingForm();
            theRankingForm.viewUSN15MSIS();
            theRankingForm.ShowDialog();
        }

        private void usNews16MSISButton_Click(object sender, EventArgs e)
        {
            RankingForm theRankingForm = new RankingForm();
            theRankingForm.viewUSN16MSIS();
            theRankingForm.ShowDialog();
        }

        private void qs15MSISButton_Click(object sender, EventArgs e)
        {
            RankingForm theRankingForm = new RankingForm();
            theRankingForm.viewQS15MSIS();
            theRankingForm.ShowDialog();
        }

        private void qs16MSISButton_Click(object sender, EventArgs e)
        {
            RankingForm theRankingForm = new RankingForm();
            theRankingForm.viewQS16MSIS();
            theRankingForm.ShowDialog();
        }

        private void tfe15MSBAButton_Click(object sender, EventArgs e)
        {
            RankingForm theRankingForm = new RankingForm();
            theRankingForm.viewTFE15MSBA();
            theRankingForm.ShowDialog();
        }

        private void tfe16MSBAButton_Click(object sender, EventArgs e)
        {
            RankingForm theRankingForm = new RankingForm();
            theRankingForm.viewTFE16MSBA();
            theRankingForm.ShowDialog();
        }
    }
}
