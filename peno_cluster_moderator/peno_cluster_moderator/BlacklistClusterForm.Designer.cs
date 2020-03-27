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
            this.txtRemoveWord = new System.Windows.Forms.TextBox();
            this.btnRemoveWord = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // blacklistListView
            // 
            this.blacklistListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.offensiveWords});
            this.blacklistListView.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistListView.HideSelection = false;
            this.blacklistListView.Location = new System.Drawing.Point(12, 12);
            this.blacklistListView.MultiSelect = false;
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
            // txtRemoveWord
            // 
            this.txtRemoveWord.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveWord.Location = new System.Drawing.Point(315, 12);
            this.txtRemoveWord.Multiline = true;
            this.txtRemoveWord.Name = "txtRemoveWord";
            this.txtRemoveWord.Size = new System.Drawing.Size(473, 28);
            this.txtRemoveWord.TabIndex = 1;
            // 
            // btnRemoveWord
            // 
            this.btnRemoveWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveWord.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveWord.Location = new System.Drawing.Point(193, 12);
            this.btnRemoveWord.Name = "btnRemoveWord";
            this.btnRemoveWord.Size = new System.Drawing.Size(116, 28);
            this.btnRemoveWord.TabIndex = 2;
            this.btnRemoveWord.Text = "Remove";
            this.btnRemoveWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveWord.UseVisualStyleBackColor = true;
            this.btnRemoveWord.Click += new System.EventHandler(this.btnRemoveWord_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(193, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddWord
            // 
            this.txtAddWord.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddWord.Location = new System.Drawing.Point(315, 46);
            this.txtAddWord.Multiline = true;
            this.txtAddWord.Name = "txtAddWord";
            this.txtAddWord.Size = new System.Drawing.Size(473, 28);
            this.txtAddWord.TabIndex = 3;
            // 
            // BlacklistClusterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddWord);
            this.Controls.Add(this.btnRemoveWord);
            this.Controls.Add(this.txtRemoveWord);
            this.Controls.Add(this.blacklistListView);
            this.Name = "BlacklistClusterForm";
            this.Text = "Blacklist";
            this.Load += new System.EventHandler(this.BlacklistClusterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView blacklistListView;
        private System.Windows.Forms.ColumnHeader offensiveWords;
        private System.Windows.Forms.TextBox txtRemoveWord;
        private System.Windows.Forms.Button btnRemoveWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddWord;
    }
}