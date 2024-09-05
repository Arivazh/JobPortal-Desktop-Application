
namespace Job_Portal
{
    partial class JobList
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
            this.Job_list_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Job_list_DGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollegeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomainArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Job_list_search = new System.Windows.Forms.TextBox();
            this.Job_list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Job_list_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Job_list_panel
            // 
            this.Job_list_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Job_list_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Job_list_panel.Controls.Add(this.Job_list_search);
            this.Job_list_panel.Controls.Add(this.label2);
            this.Job_list_panel.Controls.Add(this.label1);
            this.Job_list_panel.Controls.Add(this.Job_list_DGV);
            this.Job_list_panel.Location = new System.Drawing.Point(31, 34);
            this.Job_list_panel.Name = "Job_list_panel";
            this.Job_list_panel.Size = new System.Drawing.Size(981, 530);
            this.Job_list_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job List";
            // 
            // Job_list_DGV
            // 
            this.Job_list_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Job_list_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.JobId,
            this.CollegeName,
            this.JobTitle,
            this.Description,
            this.NoOfPost,
            this.Qualification,
            this.DomainArea,
            this.Salary,
            this.JobType,
            this.CompanyName,
            this.MailId,
            this.Address,
            this.Country,
            this.State});
            this.Job_list_DGV.Location = new System.Drawing.Point(44, 105);
            this.Job_list_DGV.Name = "Job_list_DGV";
            this.Job_list_DGV.RowHeadersWidth = 51;
            this.Job_list_DGV.RowTemplate.Height = 24;
            this.Job_list_DGV.Size = new System.Drawing.Size(859, 397);
            this.Job_list_DGV.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // JobId
            // 
            this.JobId.HeaderText = "JobId";
            this.JobId.MinimumWidth = 6;
            this.JobId.Name = "JobId";
            this.JobId.Width = 125;
            // 
            // CollegeName
            // 
            this.CollegeName.HeaderText = "CollegeName";
            this.CollegeName.MinimumWidth = 6;
            this.CollegeName.Name = "CollegeName";
            this.CollegeName.Width = 125;
            // 
            // JobTitle
            // 
            this.JobTitle.HeaderText = "JobTitle";
            this.JobTitle.MinimumWidth = 6;
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // NoOfPost
            // 
            this.NoOfPost.HeaderText = "NoOfPost";
            this.NoOfPost.MinimumWidth = 6;
            this.NoOfPost.Name = "NoOfPost";
            this.NoOfPost.Width = 125;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Qualification";
            this.Qualification.MinimumWidth = 6;
            this.Qualification.Name = "Qualification";
            this.Qualification.Width = 125;
            // 
            // DomainArea
            // 
            this.DomainArea.HeaderText = "DomainArea";
            this.DomainArea.MinimumWidth = 6;
            this.DomainArea.Name = "DomainArea";
            this.DomainArea.Width = 125;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.Width = 125;
            // 
            // JobType
            // 
            this.JobType.HeaderText = "JobType";
            this.JobType.MinimumWidth = 6;
            this.JobType.Name = "JobType";
            this.JobType.Width = 125;
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 125;
            // 
            // MailId
            // 
            this.MailId.HeaderText = "MailId";
            this.MailId.MinimumWidth = 6;
            this.MailId.Name = "MailId";
            this.MailId.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.Width = 125;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search:";
            // 
            // Job_list_search
            // 
            this.Job_list_search.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Job_list_search.Location = new System.Drawing.Point(507, 53);
            this.Job_list_search.Name = "Job_list_search";
            this.Job_list_search.Size = new System.Drawing.Size(227, 28);
            this.Job_list_search.TabIndex = 3;
            this.Job_list_search.TextChanged += new System.EventHandler(this.Job_list_search_TextChanged);
            // 
            // JobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Job_list_panel);
            this.Name = "JobList";
            this.Size = new System.Drawing.Size(1051, 698);
            this.Load += new System.EventHandler(this.JobList_Load);
            this.Job_list_panel.ResumeLayout(false);
            this.Job_list_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Job_list_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Job_list_panel;
        private System.Windows.Forms.DataGridView Job_list_DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollegeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomainArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.TextBox Job_list_search;
        private System.Windows.Forms.Label label2;
    }
}
