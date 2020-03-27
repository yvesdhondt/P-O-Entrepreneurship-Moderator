namespace peno_cluster_moderator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnReportedQA = new System.Windows.Forms.Button();
            this.btnBlacklist = new System.Windows.Forms.Button();
            this.btnFlaggedQA = new System.Windows.Forms.Button();
            this.btnBlockedUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportedQA
            // 
            this.btnReportedQA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportedQA.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportedQA.Location = new System.Drawing.Point(0, 26);
            this.btnReportedQA.Name = "btnReportedQA";
            this.btnReportedQA.Size = new System.Drawing.Size(124, 28);
            this.btnReportedQA.TabIndex = 2;
            this.btnReportedQA.Text = "Reported Q&&A";
            this.btnReportedQA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportedQA.UseVisualStyleBackColor = true;
            this.btnReportedQA.Click += new System.EventHandler(this.btnReportedQA_Click);
            // 
            // btnBlacklist
            // 
            this.btnBlacklist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlacklist.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlacklist.Location = new System.Drawing.Point(0, 0);
            this.btnBlacklist.Name = "btnBlacklist";
            this.btnBlacklist.Size = new System.Drawing.Size(124, 28);
            this.btnBlacklist.TabIndex = 1;
            this.btnBlacklist.Text = "Blacklist";
            this.btnBlacklist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlacklist.UseVisualStyleBackColor = true;
            this.btnBlacklist.Click += new System.EventHandler(this.btnBlacklist_Click);
            // 
            // btnFlaggedQA
            // 
            this.btnFlaggedQA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlaggedQA.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlaggedQA.Location = new System.Drawing.Point(0, 52);
            this.btnFlaggedQA.Name = "btnFlaggedQA";
            this.btnFlaggedQA.Size = new System.Drawing.Size(124, 28);
            this.btnFlaggedQA.TabIndex = 3;
            this.btnFlaggedQA.Text = "Flagged Q&&A";
            this.btnFlaggedQA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlaggedQA.UseVisualStyleBackColor = true;
            this.btnFlaggedQA.Click += new System.EventHandler(this.btnFlaggedQA_Click);
            // 
            // btnBlockedUsers
            // 
            this.btnBlockedUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlockedUsers.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockedUsers.Location = new System.Drawing.Point(0, 78);
            this.btnBlockedUsers.Name = "btnBlockedUsers";
            this.btnBlockedUsers.Size = new System.Drawing.Size(124, 28);
            this.btnBlockedUsers.TabIndex = 4;
            this.btnBlockedUsers.Text = "Blocked Users";
            this.btnBlockedUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlockedUsers.UseVisualStyleBackColor = true;
            this.btnBlockedUsers.Click += new System.EventHandler(this.btnBlockedUsers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(835, 591);
            this.Controls.Add(this.btnBlockedUsers);
            this.Controls.Add(this.btnFlaggedQA);
            this.Controls.Add(this.btnReportedQA);
            this.Controls.Add(this.btnBlacklist);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Cluster Moderator Panel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReportedQA;
        private System.Windows.Forms.Button btnBlacklist;
        private System.Windows.Forms.Button btnFlaggedQA;
        private System.Windows.Forms.Button btnBlockedUsers;
    }
}