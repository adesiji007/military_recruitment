namespace MilitaryRecruitment
{
    partial class FormBasedUI
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.bntExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewForceServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllForceServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucessfulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucessfulApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsucessfulApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrolApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unenrolApplicantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicantReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceServiceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allApplicantsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allForceServiceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.marksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDisplaySucessful = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtDisplaySuccessful = new System.Windows.Forms.ListView();
            this.btbApplicantOrForceServices = new System.Windows.Forms.Button();
            this.cboApplicants = new System.Windows.Forms.ComboBox();
            this.cboForceServices = new System.Windows.Forms.ComboBox();
            this.cboSucApplicant = new System.Windows.Forms.ComboBox();
            this.btnEnrol = new System.Windows.Forms.Button();
            this.btnUnenrol = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(319, 123);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(410, 253);
            this.txtDisplay.TabIndex = 27;
            // 
            // bntExit
            // 
            this.bntExit.BackColor = System.Drawing.Color.Coral;
            this.bntExit.Font = new System.Drawing.Font("Harlow Solid Italic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Location = new System.Drawing.Point(607, 382);
            this.bntExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(122, 41);
            this.bntExit.TabIndex = 15;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = false;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.marksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.forceServiceToolStripMenuItem,
            this.sucessfulToolStripMenuItem,
            this.enrolToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.mainMenuToolStripMenuItem.Text = "DashBoard";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewApplicantToolStripMenuItem,
            this.addNewForceServiceToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addNewApplicantToolStripMenuItem
            // 
            this.addNewApplicantToolStripMenuItem.Name = "addNewApplicantToolStripMenuItem";
            this.addNewApplicantToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addNewApplicantToolStripMenuItem.Text = "Add New Applicant";
            this.addNewApplicantToolStripMenuItem.Click += new System.EventHandler(this.addNewApplicantToolStripMenuItem_Click_1);
            // 
            // addNewForceServiceToolStripMenuItem
            // 
            this.addNewForceServiceToolStripMenuItem.Name = "addNewForceServiceToolStripMenuItem";
            this.addNewForceServiceToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addNewForceServiceToolStripMenuItem.Text = "Add New ForceService";
            this.addNewForceServiceToolStripMenuItem.Click += new System.EventHandler(this.addNewForceServiceToolStripMenuItem_Click);
            // 
            // forceServiceToolStripMenuItem
            // 
            this.forceServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllForceServiceToolStripMenuItem,
            this.viewAllApplicantToolStripMenuItem});
            this.forceServiceToolStripMenuItem.Name = "forceServiceToolStripMenuItem";
            this.forceServiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.forceServiceToolStripMenuItem.Text = "View";
            // 
            // viewAllForceServiceToolStripMenuItem
            // 
            this.viewAllForceServiceToolStripMenuItem.Name = "viewAllForceServiceToolStripMenuItem";
            this.viewAllForceServiceToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewAllForceServiceToolStripMenuItem.Text = "View All ForceService";
            this.viewAllForceServiceToolStripMenuItem.Click += new System.EventHandler(this.viewAllForceServiceToolStripMenuItem_Click_1);
            // 
            // viewAllApplicantToolStripMenuItem
            // 
            this.viewAllApplicantToolStripMenuItem.Name = "viewAllApplicantToolStripMenuItem";
            this.viewAllApplicantToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewAllApplicantToolStripMenuItem.Text = "View All Applicant";
            this.viewAllApplicantToolStripMenuItem.Click += new System.EventHandler(this.viewAllApplicantToolStripMenuItem_Click_1);
            // 
            // sucessfulToolStripMenuItem
            // 
            this.sucessfulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sucessfulApplicantToolStripMenuItem,
            this.unsucessfulApplicantToolStripMenuItem});
            this.sucessfulToolStripMenuItem.Name = "sucessfulToolStripMenuItem";
            this.sucessfulToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sucessfulToolStripMenuItem.Text = "Sucessful";
            // 
            // sucessfulApplicantToolStripMenuItem
            // 
            this.sucessfulApplicantToolStripMenuItem.Name = "sucessfulApplicantToolStripMenuItem";
            this.sucessfulApplicantToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sucessfulApplicantToolStripMenuItem.Text = "Sucessful Applicant";
            // 
            // unsucessfulApplicantToolStripMenuItem
            // 
            this.unsucessfulApplicantToolStripMenuItem.Name = "unsucessfulApplicantToolStripMenuItem";
            this.unsucessfulApplicantToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.unsucessfulApplicantToolStripMenuItem.Text = "Unsucessful Applicant";
            // 
            // enrolToolStripMenuItem
            // 
            this.enrolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrolApplicantToolStripMenuItem,
            this.unenrolApplicantToolStripMenuItem});
            this.enrolToolStripMenuItem.Name = "enrolToolStripMenuItem";
            this.enrolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enrolToolStripMenuItem.Text = "Enrol";
            // 
            // enrolApplicantToolStripMenuItem
            // 
            this.enrolApplicantToolStripMenuItem.Name = "enrolApplicantToolStripMenuItem";
            this.enrolApplicantToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.enrolApplicantToolStripMenuItem.Text = "Enrol Applicant";
            this.enrolApplicantToolStripMenuItem.Click += new System.EventHandler(this.enrolApplicantToolStripMenuItem_Click);
            // 
            // unenrolApplicantToolStripMenuItem
            // 
            this.unenrolApplicantToolStripMenuItem.Name = "unenrolApplicantToolStripMenuItem";
            this.unenrolApplicantToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.unenrolApplicantToolStripMenuItem.Text = "Unenrol Applicant";
            this.unenrolApplicantToolStripMenuItem.Click += new System.EventHandler(this.unenrolApplicantToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicantReportToolStripMenuItem,
            this.forceServiceReportToolStripMenuItem,
            this.allApplicantsReportToolStripMenuItem,
            this.allForceServiceReportToolStripMenuItem,
            this.exitToolStripMenuItem2});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // applicantReportToolStripMenuItem
            // 
            this.applicantReportToolStripMenuItem.Name = "applicantReportToolStripMenuItem";
            this.applicantReportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.applicantReportToolStripMenuItem.Text = "Applicant Report";
            this.applicantReportToolStripMenuItem.Click += new System.EventHandler(this.applicantReportToolStripMenuItem_Click);
            // 
            // forceServiceReportToolStripMenuItem
            // 
            this.forceServiceReportToolStripMenuItem.Name = "forceServiceReportToolStripMenuItem";
            this.forceServiceReportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.forceServiceReportToolStripMenuItem.Text = "ForceService Report";
            // 
            // allApplicantsReportToolStripMenuItem
            // 
            this.allApplicantsReportToolStripMenuItem.Name = "allApplicantsReportToolStripMenuItem";
            this.allApplicantsReportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.allApplicantsReportToolStripMenuItem.Text = "All Applicants Report";
            this.allApplicantsReportToolStripMenuItem.Click += new System.EventHandler(this.allApplicantsReportToolStripMenuItem_Click);
            // 
            // allForceServiceReportToolStripMenuItem
            // 
            this.allForceServiceReportToolStripMenuItem.Name = "allForceServiceReportToolStripMenuItem";
            this.allForceServiceReportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.allForceServiceReportToolStripMenuItem.Text = "All ForceService Report";
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // marksToolStripMenuItem
            // 
            this.marksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markEntryToolStripMenuItem,
            this.closedToolStripMenuItem});
            this.marksToolStripMenuItem.Name = "marksToolStripMenuItem";
            this.marksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.marksToolStripMenuItem.Text = "Marks";
            // 
            // markEntryToolStripMenuItem
            // 
            this.markEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterMarkToolStripMenuItem,
            this.exitMarkToolStripMenuItem});
            this.markEntryToolStripMenuItem.Name = "markEntryToolStripMenuItem";
            this.markEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.markEntryToolStripMenuItem.Text = "Mark Entry";
            // 
            // enterMarkToolStripMenuItem
            // 
            this.enterMarkToolStripMenuItem.Name = "enterMarkToolStripMenuItem";
            this.enterMarkToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.enterMarkToolStripMenuItem.Text = "Enter ForceService Mark";
            this.enterMarkToolStripMenuItem.Click += new System.EventHandler(this.enterMarkToolStripMenuItem_Click);
            // 
            // exitMarkToolStripMenuItem
            // 
            this.exitMarkToolStripMenuItem.Name = "exitMarkToolStripMenuItem";
            this.exitMarkToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.exitMarkToolStripMenuItem.Text = "Close";
            this.exitMarkToolStripMenuItem.Click += new System.EventHandler(this.exitMarkToolStripMenuItem_Click_1);
            // 
            // closedToolStripMenuItem
            // 
            this.closedToolStripMenuItem.Name = "closedToolStripMenuItem";
            this.closedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closedToolStripMenuItem.Text = "Closed";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(962, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 494);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(33, 463);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(935, 31);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(0, 27);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 467);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnDisplaySucessful
            // 
            this.btnDisplaySucessful.BackColor = System.Drawing.Color.Tomato;
            this.btnDisplaySucessful.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplaySucessful.Location = new System.Drawing.Point(85, 123);
            this.btnDisplaySucessful.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDisplaySucessful.Name = "btnDisplaySucessful";
            this.btnDisplaySucessful.Size = new System.Drawing.Size(230, 36);
            this.btnDisplaySucessful.TabIndex = 26;
            this.btnDisplaySucessful.Text = "Click Sucessfull Applicants";
            this.btnDisplaySucessful.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.Font = new System.Drawing.Font("Wide Latin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(193, 27);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(698, 52);
            this.button5.TabIndex = 28;
            this.button5.Text = "MILITARY RECRUITMENT APPLICATION DATA";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // txtDisplaySuccessful
            // 
            this.txtDisplaySuccessful.Location = new System.Drawing.Point(85, 192);
            this.txtDisplaySuccessful.Name = "txtDisplaySuccessful";
            this.txtDisplaySuccessful.Size = new System.Drawing.Size(229, 116);
            this.txtDisplaySuccessful.TabIndex = 29;
            this.txtDisplaySuccessful.UseCompatibleStateImageBehavior = false;
            // 
            // btbApplicantOrForceServices
            // 
            this.btbApplicantOrForceServices.BackColor = System.Drawing.Color.Coral;
            this.btbApplicantOrForceServices.Font = new System.Drawing.Font("Harlow Solid Italic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbApplicantOrForceServices.Location = new System.Drawing.Point(319, 77);
            this.btbApplicantOrForceServices.Name = "btbApplicantOrForceServices";
            this.btbApplicantOrForceServices.Size = new System.Drawing.Size(410, 40);
            this.btbApplicantOrForceServices.TabIndex = 31;
            this.btbApplicantOrForceServices.Text = "Individual Applicant or ForceService Applicant";
            this.btbApplicantOrForceServices.UseVisualStyleBackColor = false;
            // 
            // cboApplicants
            // 
            this.cboApplicants.FormattingEnabled = true;
            this.cboApplicants.Location = new System.Drawing.Point(220, 3);
            this.cboApplicants.Name = "cboApplicants";
            this.cboApplicants.Size = new System.Drawing.Size(247, 21);
            this.cboApplicants.TabIndex = 32;
            this.cboApplicants.Text = "Use this drop box for the applicant data";
            // 
            // cboForceServices
            // 
            this.cboForceServices.AccessibleDescription = "ForceServices";
            this.cboForceServices.FormattingEnabled = true;
            this.cboForceServices.Location = new System.Drawing.Point(480, 3);
            this.cboForceServices.Name = "cboForceServices";
            this.cboForceServices.Size = new System.Drawing.Size(249, 21);
            this.cboForceServices.TabIndex = 33;
            this.cboForceServices.Text = "Use this drop box below for ForceServices data";
            // 
            // cboSucApplicant
            // 
            this.cboSucApplicant.FormattingEnabled = true;
            this.cboSucApplicant.Location = new System.Drawing.Point(85, 165);
            this.cboSucApplicant.Name = "cboSucApplicant";
            this.cboSucApplicant.Size = new System.Drawing.Size(229, 21);
            this.cboSucApplicant.TabIndex = 34;
            // 
            // btnEnrol
            // 
            this.btnEnrol.Location = new System.Drawing.Point(735, 3);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(75, 23);
            this.btnEnrol.TabIndex = 35;
            this.btnEnrol.Text = "Enrol";
            this.btnEnrol.UseVisualStyleBackColor = true;
            this.btnEnrol.Click += new System.EventHandler(this.btnEnrol_Click);
            // 
            // btnUnenrol
            // 
            this.btnUnenrol.Location = new System.Drawing.Point(816, 3);
            this.btnUnenrol.Name = "btnUnenrol";
            this.btnUnenrol.Size = new System.Drawing.Size(75, 23);
            this.btnUnenrol.TabIndex = 36;
            this.btnUnenrol.Text = "Unenrol";
            this.btnUnenrol.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Coral;
            this.btnClose.Location = new System.Drawing.Point(319, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 41);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormBasedUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1098, 493);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUnenrol);
            this.Controls.Add(this.btnEnrol);
            this.Controls.Add(this.cboSucApplicant);
            this.Controls.Add(this.cboForceServices);
            this.Controls.Add(this.cboApplicants);
            this.Controls.Add(this.btbApplicantOrForceServices);
            this.Controls.Add(this.txtDisplaySuccessful);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDisplaySucessful);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormBasedUI";
            this.Text = "MILITARY RECRUITMENT APPLICATION DATA";
            this.Load += new System.EventHandler(this.FormBasedUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicantReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceServiceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allApplicantsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allForceServiceReportToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDisplaySucessful;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ListView txtDisplaySuccessful;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem marksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterMarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllForceServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucessfulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucessfulApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsucessfulApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrolApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unenrolApplicantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btbApplicantOrForceServices;
        private System.Windows.Forms.ToolStripMenuItem viewAllApplicantToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboApplicants;
        private System.Windows.Forms.ComboBox cboForceServices;
        private System.Windows.Forms.ComboBox cboSucApplicant;
        private System.Windows.Forms.ToolStripMenuItem addNewForceServiceToolStripMenuItem;
        private System.Windows.Forms.Button btnEnrol;
        private System.Windows.Forms.Button btnUnenrol;
        private System.Windows.Forms.Button btnClose;
    }
}