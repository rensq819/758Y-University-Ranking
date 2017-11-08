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
    public partial class ProgramForm : Form
    {
        public ProgramForm()
        {
            InitializeComponent();
        }

        private void ProgramForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bUDT758Y_ProjectDataSet.MSP_OfferedBy' table. You can move, or remove it, as needed.
            this.mSP_OfferedByTableAdapter.FillByOfferedPrograms(this.bUDT758Y_ProjectDataSet.MSP_OfferedBy);

        }
    }
}
