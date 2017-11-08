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
    public partial class RankingForm : Form
    {
        public RankingForm()
        {
            InitializeComponent();
        }

        private void RankingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bUDT758Y_ProjectDataSet.MSP_Ranking' table. You can move, or remove it, as needed.
            // this.mSP_RankingTableAdapter.Fill(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }

        public void viewUSN15MBA()
        {
            this.mSP_RankingTableAdapter.FillByUSNews2015MBA(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }

        public void viewUSN16MBA()
        {
            this.mSP_RankingTableAdapter.FillByUSNews2016MBA(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }

        public void viewUSN15MSIS()
        {
            this.mSP_RankingTableAdapter.FillByUSNews2015MSIS(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }

        public void viewUSN16MSIS()
        {
            this.mSP_RankingTableAdapter.FillByUSNews2016MSIS(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }

        public void viewQS15MBA()
        {
            this.mSP_RankingTableAdapter.FillByQS2015MBA(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }

        public void viewQS16MBA()
        {
            this.mSP_RankingTableAdapter.FillByQS2016MBA(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }

        public void viewQS15MSIS()
        {
            this.mSP_RankingTableAdapter.FillByQS2015MSIS(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }

        public void viewQS16MSIS()
        {
            this.mSP_RankingTableAdapter.FillByQS2016MSIS(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }

        public void viewTFE15MSBA()
        {
            this.mSP_RankingTableAdapter.FillByTFE2015MSBA(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }

        public void viewTFE16MSBA()
        {
            this.mSP_RankingTableAdapter.FillByTFE2016MSBA(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
        }
    }
}
