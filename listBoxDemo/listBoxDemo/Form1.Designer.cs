namespace listBoxDemo
{
    partial class Form1
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
            this.lstSections = new System.Windows.Forms.ListBox();
            this.lblClassAdviser = new System.Windows.Forms.Label();
            this.lblG12Adviser = new System.Windows.Forms.Label();
            this.lstG12Adviser = new System.Windows.Forms.ListBox();
            this.lblNumStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSections
            // 
            this.lstSections.FormattingEnabled = true;
            this.lstSections.Items.AddRange(new object[] {
            "Ipil Ipil",
            "Tindalo",
            "kamagong",
            "Yakal",
            "Narra",
            "Mahonganny",
            "Ilang Ilang"});
            this.lstSections.Location = new System.Drawing.Point(75, 39);
            this.lstSections.Name = "lstSections";
            this.lstSections.Size = new System.Drawing.Size(120, 95);
            this.lstSections.TabIndex = 0;
            this.lstSections.SelectedIndexChanged += new System.EventHandler(this.lstSections_SelectedIndexChanged);
            // 
            // lblClassAdviser
            // 
            this.lblClassAdviser.AutoSize = true;
            this.lblClassAdviser.Location = new System.Drawing.Point(100, 137);
            this.lblClassAdviser.Name = "lblClassAdviser";
            this.lblClassAdviser.Size = new System.Drawing.Size(70, 13);
            this.lblClassAdviser.TabIndex = 1;
            this.lblClassAdviser.Text = "Class Adviser";
            // 
            // lblG12Adviser
            // 
            this.lblG12Adviser.AutoSize = true;
            this.lblG12Adviser.Location = new System.Drawing.Point(235, 84);
            this.lblG12Adviser.Name = "lblG12Adviser";
            this.lblG12Adviser.Size = new System.Drawing.Size(117, 13);
            this.lblG12Adviser.TabIndex = 2;
            this.lblG12Adviser.Text = "Grade 12 Class Adviser";
            // 
            // lstG12Adviser
            // 
            this.lstG12Adviser.FormattingEnabled = true;
            this.lstG12Adviser.Location = new System.Drawing.Point(232, 51);
            this.lstG12Adviser.Name = "lstG12Adviser";
            this.lstG12Adviser.Size = new System.Drawing.Size(120, 30);
            this.lstG12Adviser.TabIndex = 3;
            this.lstG12Adviser.SelectedIndexChanged += new System.EventHandler(this.lstG12Adviser_SelectedIndexChanged);
            // 
            // lblNumStudent
            // 
            this.lblNumStudent.AutoSize = true;
            this.lblNumStudent.Location = new System.Drawing.Point(235, 110);
            this.lblNumStudent.Name = "lblNumStudent";
            this.lblNumStudent.Size = new System.Drawing.Size(96, 13);
            this.lblNumStudent.TabIndex = 4;
            this.lblNumStudent.Text = "Number of Student";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumStudent);
            this.Controls.Add(this.lstG12Adviser);
            this.Controls.Add(this.lblG12Adviser);
            this.Controls.Add(this.lblClassAdviser);
            this.Controls.Add(this.lstSections);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSections;
        private System.Windows.Forms.Label lblClassAdviser;
        private System.Windows.Forms.Label lblG12Adviser;
        private System.Windows.Forms.ListBox lstG12Adviser;
        private System.Windows.Forms.Label lblNumStudent;
    }
}

