namespace groupName_ass2
{
    partial class CourseResults_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseResults_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.attempt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driveBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDrive = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTrainer = new System.Windows.Forms.TextBox();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtAttempts = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(584, 391);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attempt,
            this.result,
            this.course,
            this.groupBooking,
            this.driveBooking,
            this.trainer,
            this.driver});
            this.dataGridView1.Location = new System.Drawing.Point(247, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 373);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // attempt
            // 
            this.attempt.HeaderText = "Attempts";
            this.attempt.Name = "attempt";
            // 
            // result
            // 
            this.result.HeaderText = "Results";
            this.result.Name = "result";
            // 
            // course
            // 
            this.course.HeaderText = "Course";
            this.course.Name = "course";
            // 
            // groupBooking
            // 
            this.groupBooking.HeaderText = "Group Booking";
            this.groupBooking.Name = "groupBooking";
            // 
            // driveBooking
            // 
            this.driveBooking.HeaderText = "Drive Booking";
            this.driveBooking.Name = "driveBooking";
            // 
            // trainer
            // 
            this.trainer.HeaderText = "Trainer";
            this.trainer.Name = "trainer";
            // 
            // driver
            // 
            this.driver.HeaderText = "Driver";
            this.driver.Name = "driver";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDrive);
            this.groupBox2.Controls.Add(this.txtGroup);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTrainer);
            this.groupBox2.Controls.Add(this.txtDriver);
            this.groupBox2.Controls.Add(this.txtResults);
            this.groupBox2.Controls.Add(this.txtAttempts);
            this.groupBox2.Controls.Add(this.txtCourse);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 245);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Information";
            // 
            // txtDrive
            // 
            this.txtDrive.Location = new System.Drawing.Point(85, 139);
            this.txtDrive.Name = "txtDrive";
            this.txtDrive.Size = new System.Drawing.Size(138, 20);
            this.txtDrive.TabIndex = 30;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(85, 113);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(138, 20);
            this.txtGroup.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "groupBooking";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "driveBooking";
            // 
            // txtTrainer
            // 
            this.txtTrainer.Location = new System.Drawing.Point(84, 165);
            this.txtTrainer.Name = "txtTrainer";
            this.txtTrainer.Size = new System.Drawing.Size(139, 20);
            this.txtTrainer.TabIndex = 26;
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(84, 191);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(139, 20);
            this.txtDriver.TabIndex = 25;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(84, 61);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(139, 20);
            this.txtResults.TabIndex = 21;
            // 
            // txtAttempts
            // 
            this.txtAttempts.Location = new System.Drawing.Point(84, 35);
            this.txtAttempts.Name = "txtAttempts";
            this.txtAttempts.Size = new System.Drawing.Size(139, 20);
            this.txtAttempts.TabIndex = 22;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(84, 87);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(139, 20);
            this.txtCourse.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Driver";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Attempts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Results";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Course";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Trainer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 175);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update/Delete";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 46);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 71);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 46);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 46);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CourseResults_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CourseResults_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseResults_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrainer;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtAttempts;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtDrive;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn attempt;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn course;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn driveBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
    }
}