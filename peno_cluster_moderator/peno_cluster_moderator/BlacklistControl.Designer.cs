namespace peno_cluster_moderator
{
    partial class BlacklistControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddWord = new System.Windows.Forms.TextBox();
            this.btnRemoveWord = new System.Windows.Forms.Button();
            this.txtRemoveWord = new System.Windows.Forms.TextBox();
            this.blacklistListView = new System.Windows.Forms.ListView();
            this.offensiveWords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(189, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 28);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddWord
            // 
            this.txtAddWord.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddWord.Location = new System.Drawing.Point(311, 42);
            this.txtAddWord.Multiline = true;
            this.txtAddWord.Name = "txtAddWord";
            this.txtAddWord.Size = new System.Drawing.Size(473, 28);
            this.txtAddWord.TabIndex = 8;
            this.txtAddWord.TextChanged += new System.EventHandler(this.txtAddWord_TextChanged);
            // 
            // btnRemoveWord
            // 
            this.btnRemoveWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveWord.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveWord.Location = new System.Drawing.Point(189, 8);
            this.btnRemoveWord.Name = "btnRemoveWord";
            this.btnRemoveWord.Size = new System.Drawing.Size(116, 28);
            this.btnRemoveWord.TabIndex = 7;
            this.btnRemoveWord.Text = "Remove";
            this.btnRemoveWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveWord.UseVisualStyleBackColor = true;
            this.btnRemoveWord.Click += new System.EventHandler(this.btnRemoveWord_Click);
            // 
            // txtRemoveWord
            // 
            this.txtRemoveWord.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveWord.Location = new System.Drawing.Point(311, 8);
            this.txtRemoveWord.Multiline = true;
            this.txtRemoveWord.Name = "txtRemoveWord";
            this.txtRemoveWord.Size = new System.Drawing.Size(473, 28);
            this.txtRemoveWord.TabIndex = 6;
            this.txtRemoveWord.TextChanged += new System.EventHandler(this.txtRemoveWord_TextChanged);
            // 
            // blacklistListView
            // 
            this.blacklistListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.offensiveWords});
            this.blacklistListView.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistListView.HideSelection = false;
            this.blacklistListView.Location = new System.Drawing.Point(8, 8);
            this.blacklistListView.MultiSelect = false;
            this.blacklistListView.Name = "blacklistListView";
            this.blacklistListView.Size = new System.Drawing.Size(175, 400);
            this.blacklistListView.TabIndex = 5;
            this.blacklistListView.UseCompatibleStateImageBehavior = false;
            this.blacklistListView.View = System.Windows.Forms.View.List;
            this.blacklistListView.SelectedIndexChanged += new System.EventHandler(this.blacklistListView_SelectedIndexChanged);
            // 
            // offensiveWords
            // 
            this.offensiveWords.Text = "Offensive Words";
            this.offensiveWords.Width = 150;
            // 
            // BlacklistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddWord);
            this.Controls.Add(this.btnRemoveWord);
            this.Controls.Add(this.txtRemoveWord);
            this.Controls.Add(this.blacklistListView);
            this.Name = "BlacklistControl";
            this.Size = new System.Drawing.Size(798, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddWord;
        private System.Windows.Forms.Button btnRemoveWord;
        private System.Windows.Forms.TextBox txtRemoveWord;
        private System.Windows.Forms.ListView blacklistListView;
        private System.Windows.Forms.ColumnHeader offensiveWords;
    }
}
