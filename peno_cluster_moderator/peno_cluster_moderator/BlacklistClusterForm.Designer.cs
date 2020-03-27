namespace peno_cluster_moderator
{
    partial class BlacklistClusterForm
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
            this.blacklistListView = new System.Windows.Forms.ListView();
            this.offensiveWords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // blacklistListView
            // 
            this.blacklistListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.offensiveWords});
            this.blacklistListView.HideSelection = false;
            this.blacklistListView.Location = new System.Drawing.Point(0, 0);
            this.blacklistListView.Name = "blacklistListView";
            this.blacklistListView.Size = new System.Drawing.Size(175, 400);
            this.blacklistListView.TabIndex = 0;
            this.blacklistListView.UseCompatibleStateImageBehavior = false;
            this.blacklistListView.View = System.Windows.Forms.View.List;
            this.blacklistListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // offensiveWords
            // 
            this.offensiveWords.Text = "Offensive Words";
            this.offensiveWords.Width = 150;
            // 
            // BlacklistClusterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blacklistListView);
            this.Name = "BlacklistClusterForm";
            this.Text = "BlacklistClusterForm";
            this.Load += new System.EventHandler(this.BlacklistClusterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView blacklistListView;
        private System.Windows.Forms.ColumnHeader offensiveWords;
    }
}