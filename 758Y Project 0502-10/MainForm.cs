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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // show all the top 10 options
        private void menuButton_Click(object sender, EventArgs e)
        {
            MenuForm theMenuFrom = new MenuForm();
            theMenuFrom.ShowDialog();
        }

        private void viewSchoolButton_Click(object sender, EventArgs e)
        {
            SchoolFrom theSchoolForm = new SchoolFrom();
            theSchoolForm.ShowDialog();
        }

        private void viewProgramButton_Click(object sender, EventArgs e)
        {
            ProgramForm theProgramForm = new ProgramForm();
            theProgramForm.ShowDialog();
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            CustomSelectionForm theCustomSelectionForm = new CustomSelectionForm();
            theCustomSelectionForm.ShowDialog();
        }
    }
}
