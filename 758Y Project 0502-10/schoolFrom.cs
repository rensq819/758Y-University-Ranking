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
    public partial class SchoolFrom : Form
    {
        public SchoolFrom()
        {
            InitializeComponent();
        }

        private void schoolFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bUDT758Y_ProjectDataSet.MSP_School' table. You can move, or remove it, as needed.
            this.mSP_SchoolTableAdapter1.Fill(this.bUDT758Y_ProjectDataSet.MSP_School);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
