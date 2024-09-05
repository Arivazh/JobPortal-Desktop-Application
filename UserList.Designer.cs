
namespace Job_Portal
{
    partial class UserList
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
            this.User_List_Panel = new System.Windows.Forms.Panel();
            this.User_List_DGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_List_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_List_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // User_List_Panel
            // 
            this.User_List_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User_List_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_List_Panel.Controls.Add(this.User_List_DGV);
            this.User_List_Panel.Controls.Add(this.label7);
            this.User_List_Panel.Location = new System.Drawing.Point(27, 82);
            this.User_List_Panel.Name = "User_List_Panel";
            this.User_List_Panel.Size = new System.Drawing.Size(900, 446);
            this.User_List_Panel.TabIndex = 0;
            // 
            // User_List_DGV
            // 
            this.User_List_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.User_List_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.MailId,
            this.PhoneNumber});
            this.User_List_DGV.Location = new System.Drawing.Point(16, 82);
            this.User_List_DGV.Name = "User_List_DGV";
            this.User_List_DGV.RowHeadersWidth = 51;
            this.User_List_DGV.RowTemplate.Height = 24;
            this.User_List_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.User_List_DGV.Size = new System.Drawing.Size(856, 316);
            this.User_List_DGV.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "User List";
            // 
            // UserId
            // 
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.Width = 125;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // MailId
            // 
            this.MailId.HeaderText = "MailId";
            this.MailId.MinimumWidth = 6;
            this.MailId.Name = "MailId";
            this.MailId.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 125;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.User_List_Panel);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(1045, 694);
            this.Load += new System.EventHandler(this.UserList_Load);
            this.User_List_Panel.ResumeLayout(false);
            this.User_List_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_List_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel User_List_Panel;
        private System.Windows.Forms.DataGridView User_List_DGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
    }
}
