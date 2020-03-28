namespace peno_cluster_moderator
{
    partial class BlockedUsersControl
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUnblock = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.blockedListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastViolation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLastViolation = new System.Windows.Forms.Label();
            this.txtNbViolations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserID.Location = new System.Drawing.Point(224, 8);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(54, 17);
            this.lblUserID.TabIndex = 22;
            this.lblUserID.Text = "User ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.Location = new System.Drawing.Point(227, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 25);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnUnblock
            // 
            this.btnUnblock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnUnblock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnblock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUnblock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnUnblock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnUnblock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnUnblock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnblock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnblock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUnblock.Location = new System.Drawing.Point(305, 107);
            this.btnUnblock.Name = "btnUnblock";
            this.btnUnblock.Size = new System.Drawing.Size(72, 28);
            this.btnUnblock.TabIndex = 4;
            this.btnUnblock.Text = "Unblock";
            this.btnUnblock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnblock.UseVisualStyleBackColor = false;
            this.btnUnblock.Click += new System.EventHandler(this.btnUnblock_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBlock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnBlock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnBlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBlock.Location = new System.Drawing.Point(227, 107);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(72, 28);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // blockedListView
            // 
            this.blockedListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.blockedListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.LastViolation});
            this.blockedListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockedListView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.blockedListView.FullRowSelect = true;
            this.blockedListView.HideSelection = false;
            this.blockedListView.Location = new System.Drawing.Point(8, 8);
            this.blockedListView.MultiSelect = false;
            this.blockedListView.Name = "blockedListView";
            this.blockedListView.Size = new System.Drawing.Size(210, 400);
            this.blockedListView.TabIndex = 0;
            this.blockedListView.UseCompatibleStateImageBehavior = false;
            this.blockedListView.View = System.Windows.Forms.View.Details;
            this.blockedListView.SelectedIndexChanged += new System.EventHandler(this.blockedListView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "User ID";
            // 
            // LastViolation
            // 
            this.LastViolation.Text = "Last Violation";
            this.LastViolation.Width = 250;
            // 
            // lblLastViolation
            // 
            this.lblLastViolation.AutoSize = true;
            this.lblLastViolation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLastViolation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastViolation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLastViolation.Location = new System.Drawing.Point(224, 56);
            this.lblLastViolation.Name = "lblLastViolation";
            this.lblLastViolation.Size = new System.Drawing.Size(89, 17);
            this.lblLastViolation.TabIndex = 24;
            this.lblLastViolation.Text = "Last Violation:";
            // 
            // txtNbViolations
            // 
            this.txtNbViolations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtNbViolations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNbViolations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbViolations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNbViolations.Location = new System.Drawing.Point(227, 76);
            this.txtNbViolations.Name = "txtNbViolations";
            this.txtNbViolations.ReadOnly = true;
            this.txtNbViolations.Size = new System.Drawing.Size(150, 25);
            this.txtNbViolations.TabIndex = 2;
            // 
            // BlockedUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.lblLastViolation);
            this.Controls.Add(this.txtNbViolations);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnUnblock);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.blockedListView);
            this.Name = "BlockedUsersControl";
            this.Size = new System.Drawing.Size(471, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUnblock;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.ListView blockedListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader LastViolation;
        private System.Windows.Forms.Label lblLastViolation;
        private System.Windows.Forms.TextBox txtNbViolations;
    }
}
