﻿using System;
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
    public partial class Enrolments_Form : Form
    {
        public Enrolments_Form()
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
                newDataRow.Cells[0].Value = txtDriver.Text;
                newDataRow.Cells[1].Value = txtLogBook.Text;
                newDataRow.Cells[2].Value = txtLicenseNo.Text;
                newDataRow.Cells[3].Value = txtCourse.Text;
                newDataRow.Cells[4].Value = txtGroup.Text;
                newDataRow.Cells[5].Value = txtDrive.Text;
                newDataRow.Cells[6].Value = txtHealth.Text;
                newDataRow.Cells[7].Value = txtPension.Text;
                newDataRow.Cells[8].Value = txtTrainer.Text;
            }
            else
            {
                MessageBox.Show("There are no rows to update", "Prototype");
            }

            /*index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[index];
            newDataRow.Cells[0].Value = txtDriver.Text;
            newDataRow.Cells[1].Value = txtLogBook.Text;
            newDataRow.Cells[2].Value = txtLicenseNo.Text;
            newDataRow.Cells[3].Value = txtCourse.Text;
            newDataRow.Cells[4].Value = txtGroup.Text;
            newDataRow.Cells[5].Value = txtDrive.Text;
            newDataRow.Cells[6].Value = txtHealth.Text;
            newDataRow.Cells[7].Value = txtPension.Text;
            newDataRow.Cells[8].Value = txtTrainer.Text;*/
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
            txtDriver.Text = selectedRow.Cells[0].Value.ToString();
            txtLogBook.Text = selectedRow.Cells[1].Value.ToString();
            txtLicenseNo.Text = selectedRow.Cells[2].Value.ToString();
            txtCourse.Text = selectedRow.Cells[3].Value.ToString();
            txtGroup.Text = selectedRow.Cells[4].Value.ToString();
            txtDrive.Text = selectedRow.Cells[5].Value.ToString();
            txtHealth.Text = selectedRow.Cells[6].Value.ToString();
            txtPension.Text = selectedRow.Cells[7].Value.ToString();
            txtTrainer.Text = selectedRow.Cells[8].Value.ToString();
        }
    }
}
