namespace ProjectWindow
{
    partial class NewProjectWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlProjectInfo = new System.Windows.Forms.Panel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtProjectUri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.cbCreator = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlProjectInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Description";
            // 
            // pnlProjectInfo
            // 
            this.pnlProjectInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProjectInfo.Controls.Add(this.btnBrowse);
            this.pnlProjectInfo.Controls.Add(this.txtProjectUri);
            this.pnlProjectInfo.Controls.Add(this.label3);
            this.pnlProjectInfo.Controls.Add(this.txtProjectDescription);
            this.pnlProjectInfo.Controls.Add(this.txtProjectName);
            this.pnlProjectInfo.Controls.Add(this.label2);
            this.pnlProjectInfo.Controls.Add(this.label1);
            this.pnlProjectInfo.Location = new System.Drawing.Point(22, 14);
            this.pnlProjectInfo.Name = "pnlProjectInfo";
            this.pnlProjectInfo.Size = new System.Drawing.Size(381, 362);
            this.pnlProjectInfo.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(332, 87);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtProjectUri
            // 
            this.txtProjectUri.Location = new System.Drawing.Point(19, 87);
            this.txtProjectUri.Name = "txtProjectUri";
            this.txtProjectUri.Size = new System.Drawing.Size(307, 22);
            this.txtProjectUri.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local root dir";
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(19, 145);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(341, 209);
            this.txtProjectDescription.TabIndex = 3;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(154, 30);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(206, 22);
            this.txtProjectName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRemoveMember);
            this.panel1.Controls.Add(this.btnAddMember);
            this.panel1.Controls.Add(this.lbMembers);
            this.panel1.Controls.Add(this.cbCreator);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(409, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 333);
            this.panel1.TabIndex = 3;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveMember.Location = new System.Drawing.Point(6, 298);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(75, 30);
            this.btnRemoveMember.TabIndex = 4;
            this.btnRemoveMember.Text = "Remove";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMember.Location = new System.Drawing.Point(295, 298);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(75, 30);
            this.btnAddMember.TabIndex = 3;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // lbMembers
            // 
            this.lbMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.ItemHeight = 16;
            this.lbMembers.Items.AddRange(new object[] {
            "Member 1 - Role 1",
            "Member 2 - Role 2",
            "Member 3 - Role 2"});
            this.lbMembers.Location = new System.Drawing.Point(6, 67);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(364, 228);
            this.lbMembers.TabIndex = 2;
            // 
            // cbCreator
            // 
            this.cbCreator.FormattingEnabled = true;
            this.cbCreator.Items.AddRange(new object[] {
            "<Create New>"});
            this.cbCreator.Location = new System.Drawing.Point(64, 27);
            this.cbCreator.Name = "cbCreator";
            this.cbCreator.Size = new System.Drawing.Size(306, 24);
            this.cbCreator.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Creator";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(723, 353);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 30);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // NewProjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 388);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlProjectInfo);
            this.Name = "NewProjectWindow";
            this.Text = "New Project";
            this.pnlProjectInfo.ResumeLayout(false);
            this.pnlProjectInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlProjectInfo;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProjectUri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCreator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBrowse;
    }
}