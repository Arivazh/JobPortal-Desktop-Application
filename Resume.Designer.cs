
namespace Job_Portal
{
    partial class Resume
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
            this.Resume_panel = new System.Windows.Forms.Panel();
            this.Resume_DGV = new System.Windows.Forms.DataGridView();
            this.Userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resume_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resume_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Resume_panel
            // 
            this.Resume_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Resume_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resume_panel.Controls.Add(this.Resume_DGV);
            this.Resume_panel.Location = new System.Drawing.Point(18, 29);
            this.Resume_panel.Name = "Resume_panel";
            this.Resume_panel.Size = new System.Drawing.Size(978, 477);
            this.Resume_panel.TabIndex = 0;
            // 
            // Resume_DGV
            // 
            this.Resume_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resume_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Userid,
            this.MailId,
            this.CV});
            this.Resume_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Resume_DGV.Location = new System.Drawing.Point(0, 0);
            this.Resume_DGV.Name = "Resume_DGV";
            this.Resume_DGV.RowHeadersWidth = 51;
            this.Resume_DGV.RowTemplate.Height = 24;
            this.Resume_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Resume_DGV.Size = new System.Drawing.Size(976, 475);
            this.Resume_DGV.TabIndex = 1;
            this.Resume_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Resume_DGV_CellContentClick);
            // 
            // Userid
            // 
            this.Userid.HeaderText = "Userid";
            this.Userid.MinimumWidth = 6;
            this.Userid.Name = "Userid";
            this.Userid.Width = 125;
            // 
            // MailId
            // 
            this.MailId.HeaderText = "MailId";
            this.MailId.MinimumWidth = 6;
            this.MailId.Name = "MailId";
            this.MailId.Width = 125;
            // 
            // CV
            // 
            this.CV.HeaderText = "Resume";
            this.CV.MinimumWidth = 6;
            this.CV.Name = "CV";
            this.CV.Width = 125;
            // 
            // Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Resume_panel);
            this.Name = "Resume";
            this.Size = new System.Drawing.Size(1046, 698);
            this.Load += new System.EventHandler(this.Resume_Load);
            this.Resume_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Resume_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Resume_panel;
        private System.Windows.Forms.DataGridView Resume_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CV;
    }
}
