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
            this.txtAddWord = new System.Windows.Forms.TextBox();
            this.txtRemoveWord = new System.Windows.Forms.TextBox();
            this.blacklistListView = new System.Windows.Forms.ListView();
            this.offensiveWords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddWord
            // 
            this.txtAddWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtAddWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddWord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAddWord.Location = new System.Drawing.Point(227, 76);
            this.txtAddWord.Name = "txtAddWord";
            this.txtAddWord.Size = new System.Drawing.Size(473, 25);
            this.txtAddWord.TabIndex = 2;
            this.txtAddWord.TextChanged += new System.EventHandler(this.txtAddWord_TextChanged);
            // 
            // txtRemoveWord
            // 
            this.txtRemoveWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtRemoveWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemoveWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveWord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRemoveWord.Location = new System.Drawing.Point(227, 28);
            this.txtRemoveWord.Name = "txtRemoveWord";
            this.txtRemoveWord.Size = new System.Drawing.Size(473, 25);
            this.txtRemoveWord.TabIndex = 1;
            this.txtRemoveWord.TextChanged += new System.EventHandler(this.txtRemoveWord_TextChanged);
            // 
            // blacklistListView
            // 
            this.blacklistListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.blacklistListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blacklistListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.offensiveWords});
            this.blacklistListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blacklistListView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.blacklistListView.FullRowSelect = true;
            this.blacklistListView.HideSelection = false;
            this.blacklistListView.Location = new System.Drawing.Point(8, 8);
            this.blacklistListView.MultiSelect = false;
            this.blacklistListView.Name = "blacklistListView";
            this.blacklistListView.Size = new System.Drawing.Size(210, 400);
            this.blacklistListView.TabIndex = 0;
            this.blacklistListView.UseCompatibleStateImageBehavior = false;
            this.blacklistListView.View = System.Windows.Forms.View.Details;
            this.blacklistListView.SelectedIndexChanged += new System.EventHandler(this.blacklistListView_SelectedIndexChanged);
            // 
            // offensiveWords
            // 
            this.offensiveWords.Text = "Offensive Words";
            this.offensiveWords.Width = 400;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemove.Location = new System.Drawing.Point(224, 8);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(58, 17);
            this.lblRemove.TabIndex = 19;
            this.lblRemove.Text = "Remove:";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdd.Location = new System.Drawing.Point(224, 56);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(35, 17);
            this.lblAdd.TabIndex = 20;
            this.lblAdd.Text = "Add:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(227, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(61, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // BlacklistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.txtAddWord);
            this.Controls.Add(this.txtRemoveWord);
            this.Controls.Add(this.blacklistListView);
            this.Name = "BlacklistControl";
            this.Size = new System.Drawing.Size(798, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddWord;
        private System.Windows.Forms.TextBox txtRemoveWord;
        private System.Windows.Forms.ListView blacklistListView;
        private System.Windows.Forms.ColumnHeader offensiveWords;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}
