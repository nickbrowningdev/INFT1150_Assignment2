namespace groupName_ass2
{
    partial class MainMenu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enrolmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrolmentsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.trainersToolStripMenuItem,
            this.courseResultsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enrolmentsToolStripMenuItem
            // 
            this.enrolmentsToolStripMenuItem.Name = "enrolmentsToolStripMenuItem";
            this.enrolmentsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.enrolmentsToolStripMenuItem.Text = "Enrolments";
            this.enrolmentsToolStripMenuItem.Click += new System.EventHandler(this.enrolmentsToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // trainersToolStripMenuItem
            // 
            this.trainersToolStripMenuItem.Name = "trainersToolStripMenuItem";
            this.trainersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.trainersToolStripMenuItem.Text = "Trainers";
            this.trainersToolStripMenuItem.Click += new System.EventHandler(this.trainersToolStripMenuItem_Click);
            // 
            // courseResultsToolStripMenuItem
            // 
            this.courseResultsToolStripMenuItem.Name = "courseResultsToolStripMenuItem";
            this.courseResultsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.courseResultsToolStripMenuItem.Text = "Course Results";
            this.courseResultsToolStripMenuItem.Click += new System.EventHandler(this.courseResultsToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(596, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainMenu_Form";
            this.Text = "MainMenu_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enrolmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseResultsToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
    }
}