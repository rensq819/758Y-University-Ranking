using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _758Y_Project_0502_10
{
    public partial class CustomSelectionForm : Form
    {
        public CustomSelectionForm()
        {
            InitializeComponent();
        }

        private void CustomSelectionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bUDT758Y_ProjectDataSet.MSP_Ranking' table. You can move, or remove it, as needed.
            this.mSP_RankingTableAdapter.Fill(this.bUDT758Y_ProjectDataSet.MSP_Ranking);

        }


        private void programCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (programCombobox.SelectedText == "Masters of Information System")
            {
                this.mSP_RankingTableAdapter.FillByMSISPrograms(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }

            if (programCombobox.SelectedText == "Masters of Business Analytics")
            {
                this.mSP_RankingTableAdapter.FillByMSBAProgram(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }

            if (programCombobox.SelectedText == "Masters of Business Administration")
            {
                this.mSP_RankingTableAdapter.FillByMBAProgram(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }
        }

        private void tuitionCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (tuitionCombobox.SelectedText == "<$20,000")
            {
                this.mSP_RankingTableAdapter.FillByTuition1(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }

            if (tuitionCombobox.SelectedText == "$20,000 - $40,000")
            {
                this.mSP_RankingTableAdapter.FillByTuition2(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }

            if (tuitionCombobox.SelectedText == "$40,000 - $60,000")
            {
                this.mSP_RankingTableAdapter.FillByTuition3(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }

            if (tuitionCombobox.SelectedText == ">$60,000")
            {
                this.mSP_RankingTableAdapter.FillByTuition4(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }
        }

        private void rateCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (rateCombobox.SelectedText == "< 20%")
            {
                this.mSP_RankingTableAdapter.FillByAdm1(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }

            if (rateCombobox.SelectedText == "20% - 40%")
            {
                this.mSP_RankingTableAdapter.FillByAdm2(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }

            if (rateCombobox.SelectedText == "40% - 60%")
            {
                this.mSP_RankingTableAdapter.FillByAdm3(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }

            if (rateCombobox.SelectedText == ">60%")
            {
                this.mSP_RankingTableAdapter.FillByAdm4(this.bUDT758Y_ProjectDataSet.MSP_Ranking);
            }
        }

    }
}
