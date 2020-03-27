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
            this.btnReportedQA = new System.Windows.Forms.Button();
            this.btnBlacklist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportedQA
            // 
            this.btnReportedQA.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportedQA.Location = new System.Drawing.Point(0, 61);
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
            this.btnBlacklist.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlacklist.Location = new System.Drawing.Point(0, 27);
            this.btnBlacklist.Name = "btnBlacklist";
            this.btnBlacklist.Size = new System.Drawing.Size(124, 28);
            this.btnBlacklist.TabIndex = 1;
            this.btnBlacklist.Text = "Blacklist";
            this.btnBlacklist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlacklist.UseVisualStyleBackColor = true;
            this.btnBlacklist.Click += new System.EventHandler(this.btnBlacklist_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 346);
            this.Controls.Add(this.btnBlacklist);
            this.Controls.Add(this.btnReportedQA);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReportedQA;
        private System.Windows.Forms.Button btnBlacklist;
    }
}