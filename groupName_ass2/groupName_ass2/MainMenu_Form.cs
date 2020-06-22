using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupName_ass2
{
    public partial class MainMenu_Form : Form
    {
        public MainMenu_Form()
        {
            InitializeComponent();
        }

        private void enrolmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enrolments_Form enrolemts = new Enrolments_Form();
            enrolemts.ShowDialog();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Courses_Form courses = new Courses_Form();
            courses.ShowDialog();
        }

        private void trainersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseTrainers_Form trainers = new CourseTrainers_Form();
            trainers.ShowDialog();
        }

        private void courseResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseResults_Form results = new CourseResults_Form();
            results.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Prototype", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

                //this.Close();
            }
        }
    }
}
