namespace MilitaryRecruitment
{
    partial class Enrol
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblappF = new System.Windows.Forms.Label();
            this.lblappS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtEnrolSec = new System.Windows.Forms.TextBox();
            this.txtEnrolThr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(82, 249);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 42);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 42);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblappF
            // 
            this.lblappF.AutoSize = true;
            this.lblappF.Location = new System.Drawing.Point(31, 56);
            this.lblappF.Name = "lblappF";
            this.lblappF.Size = new System.Drawing.Size(104, 13);
            this.lblappF.TabIndex = 2;
            this.lblappF.Text = "Applicant First Name";
            // 
            // lblappS
            // 
            this.lblappS.AutoSize = true;
            this.lblappS.Location = new System.Drawing.Point(31, 103);
            this.lblappS.Name = "lblappS";
            this.lblappS.Size = new System.Drawing.Size(96, 13);
            this.lblappS.TabIndex = 3;
            this.lblappS.Text = "Applicant Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Applicant ForceSrevice Enrolled On";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(238, 38);
            this.txtFirst.Multiline = true;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(159, 31);
            this.txtFirst.TabIndex = 5;
            // 
            // txtEnrolSec
            // 
            this.txtEnrolSec.Location = new System.Drawing.Point(238, 87);
            this.txtEnrolSec.Multiline = true;
            this.txtEnrolSec.Name = "txtEnrolSec";
            this.txtEnrolSec.Size = new System.Drawing.Size(159, 29);
            this.txtEnrolSec.TabIndex = 6;
            // 
            // txtEnrolThr
            // 
            this.txtEnrolThr.Location = new System.Drawing.Point(238, 141);
            this.txtEnrolThr.Multiline = true;
            this.txtEnrolThr.Name = "txtEnrolThr";
            this.txtEnrolThr.Size = new System.Drawing.Size(159, 30);
            this.txtEnrolThr.TabIndex = 7;
            // 
            // Enrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 315);
            this.Controls.Add(this.txtEnrolThr);
            this.Controls.Add(this.txtEnrolSec);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblappS);
            this.Controls.Add(this.lblappF);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "Enrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblappF;
        private System.Windows.Forms.Label lblappS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtEnrolSec;
        private System.Windows.Forms.TextBox txtEnrolThr;
    }
}