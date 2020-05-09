namespace peno_cluster_moderator
{
    partial class ReportedQAControl
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
            this.btnSafe = new System.Windows.Forms.Button();
            this.btnOffensive = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.reportedListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSafe
            // 
            this.btnSafe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnSafe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSafe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSafe.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnSafe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnSafe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnSafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSafe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSafe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSafe.Location = new System.Drawing.Point(498, 287);
            this.btnSafe.Name = "btnSafe";
            this.btnSafe.Size = new System.Drawing.Size(116, 28);
            this.btnSafe.TabIndex = 5;
            this.btnSafe.Text = "Good";
            this.btnSafe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSafe.UseVisualStyleBackColor = false;
            this.btnSafe.Click += new System.EventHandler(this.btnSafe_Click);
            // 
            // btnOffensive
            // 
            this.btnOffensive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnOffensive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOffensive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOffensive.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnOffensive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnOffensive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnOffensive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffensive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffensive.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOffensive.Location = new System.Drawing.Point(376, 287);
            this.btnOffensive.Name = "btnOffensive";
            this.btnOffensive.Size = new System.Drawing.Size(116, 28);
            this.btnOffensive.TabIndex = 4;
            this.btnOffensive.Text = "Bad";
            this.btnOffensive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffensive.UseVisualStyleBackColor = false;
            this.btnOffensive.Click += new System.EventHandler(this.btnOffensive_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAnswer.Location = new System.Drawing.Point(376, 190);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnswer.Size = new System.Drawing.Size(473, 91);
            this.txtAnswer.TabIndex = 3;
            // 
            // reportedListView
            // 
            this.reportedListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.reportedListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Question,
            this.Answer});
            this.reportedListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportedListView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportedListView.FullRowSelect = true;
            this.reportedListView.HideSelection = false;
            this.reportedListView.Location = new System.Drawing.Point(8, 8);
            this.reportedListView.MultiSelect = false;
            this.reportedListView.Name = "reportedListView";
            this.reportedListView.Size = new System.Drawing.Size(362, 400);
            this.reportedListView.TabIndex = 0;
            this.reportedListView.UseCompatibleStateImageBehavior = false;
            this.reportedListView.View = System.Windows.Forms.View.Details;
            this.reportedListView.SelectedIndexChanged += new System.EventHandler(this.reportedListView_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "User ID";
            // 
            // Question
            // 
            this.Question.Text = "Question";
            this.Question.Width = 150;
            // 
            // Answer
            // 
            this.Answer.Text = "Answer";
            this.Answer.Width = 300;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQuestion.Location = new System.Drawing.Point(376, 76);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestion.Size = new System.Drawing.Size(473, 91);
            this.txtQuestion.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtID.Location = new System.Drawing.Point(379, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(116, 25);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserID.Location = new System.Drawing.Point(376, 8);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(54, 17);
            this.lblUserID.TabIndex = 17;
            this.lblUserID.Text = "User ID:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestion.Location = new System.Drawing.Point(376, 56);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(63, 17);
            this.lblQuestion.TabIndex = 18;
            this.lblQuestion.Text = "Question:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAnswer.Location = new System.Drawing.Point(376, 170);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(53, 17);
            this.lblAnswer.TabIndex = 19;
            this.lblAnswer.Text = "Answer:";
            // 
            // ReportedQAControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnSafe);
            this.Controls.Add(this.btnOffensive);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.reportedListView);
            this.Name = "ReportedQAControl";
            this.Size = new System.Drawing.Size(854, 414);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSafe;
        private System.Windows.Forms.Button btnOffensive;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.ListView reportedListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Question;
        private System.Windows.Forms.ColumnHeader Answer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
    }
}
