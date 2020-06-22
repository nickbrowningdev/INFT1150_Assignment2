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
    public partial class CourseResults_Form : Form
    {
        public CourseResults_Form()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int index;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            table.Rows.Add();
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

            if (dataGridView1.Rows.Count > 0)
            {
                index = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow newDataRow = dataGridView1.Rows[index];
                newDataRow.Cells[0].Value = txtAttempts.Text;
                newDataRow.Cells[1].Value = txtResults.Text;
                newDataRow.Cells[2].Value = txtCourse.Text;
                newDataRow.Cells[3].Value = txtGroup.Text;
                newDataRow.Cells[4].Value = txtDrive.Text;
                newDataRow.Cells[5].Value = txtTrainer.Text;
                newDataRow.Cells[6].Value = txtDriver.Text;
            }
            else
            {
                MessageBox.Show("There are no rows to update", "Prototype");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("There are no rows to delete", "Prototype");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txtAttempts.Text = selectedRow.Cells[0].Value.ToString();
            txtResults.Text = selectedRow.Cells[1].Value.ToString();
            txtCourse.Text = selectedRow.Cells[2].Value.ToString();
            txtGroup.Text = selectedRow.Cells[3].Value.ToString();
            txtDrive.Text = selectedRow.Cells[4].Value.ToString();
            txtTrainer.Text = selectedRow.Cells[5].Value.ToString();
            txtDriver.Text = selectedRow.Cells[6].Value.ToString();
        }
    }
}
