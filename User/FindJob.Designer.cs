﻿
namespace Job_Portal.User
{
    partial class FindJob
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Find_PicBox = new System.Windows.Forms.PictureBox();
            this.lbl_JobTitle = new System.Windows.Forms.Label();
            this.lbl_JobType = new System.Windows.Forms.Label();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.Apply_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Find_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.Find_PicBox);
            this.panel1.Location = new System.Drawing.Point(22, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 200);
            this.panel1.TabIndex = 0;
            // 
            // Find_PicBox
            // 
            this.Find_PicBox.Location = new System.Drawing.Point(37, 62);
            this.Find_PicBox.Name = "Find_PicBox";
            this.Find_PicBox.Size = new System.Drawing.Size(81, 69);
            this.Find_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Find_PicBox.TabIndex = 0;
            this.Find_PicBox.TabStop = false;
            // 
            // lbl_JobTitle
            // 
            this.lbl_JobTitle.AutoEllipsis = true;
            this.lbl_JobTitle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JobTitle.Location = new System.Drawing.Point(229, 14);
            this.lbl_JobTitle.Name = "lbl_JobTitle";
            this.lbl_JobTitle.Size = new System.Drawing.Size(170, 23);
            this.lbl_JobTitle.TabIndex = 1;
            this.lbl_JobTitle.Text = "JobTitle";
            // 
            // lbl_JobType
            // 
            this.lbl_JobType.AutoEllipsis = true;
            this.lbl_JobType.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JobType.Location = new System.Drawing.Point(229, 65);
            this.lbl_JobType.Name = "lbl_JobType";
            this.lbl_JobType.Size = new System.Drawing.Size(138, 21);
            this.lbl_JobType.TabIndex = 2;
            this.lbl_JobType.Text = "JobType";
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoEllipsis = true;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompanyName.Location = new System.Drawing.Point(229, 113);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(138, 21);
            this.lbl_CompanyName.TabIndex = 3;
            this.lbl_CompanyName.Text = " CompanyName";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoEllipsis = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(444, 14);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(117, 23);
            this.lbl_Salary.TabIndex = 4;
            this.lbl_Salary.Text = " Salary";
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoEllipsis = true;
            this.lbl_Country.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.Location = new System.Drawing.Point(444, 65);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(95, 21);
            this.lbl_Country.TabIndex = 5;
            this.lbl_Country.Text = " Country";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoEllipsis = true;
            this.lbl_state.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.Location = new System.Drawing.Point(444, 113);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(68, 21);
            this.lbl_state.TabIndex = 6;
            this.lbl_state.Text = "State";
            this.lbl_state.Click += new System.EventHandler(this.label6_Click);
            // 
            // Apply_btn
            // 
            this.Apply_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply_btn.Location = new System.Drawing.Point(327, 163);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(91, 40);
            this.Apply_btn.TabIndex = 7;
            this.Apply_btn.Text = "Apply";
            this.Apply_btn.UseVisualStyleBackColor = true;
            // 
            // FindJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Apply_btn);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_CompanyName);
            this.Controls.Add(this.lbl_JobType);
            this.Controls.Add(this.lbl_JobTitle);
            this.Controls.Add(this.panel1);
            this.Name = "FindJob";
            this.Size = new System.Drawing.Size(682, 220);
            this.Load += new System.EventHandler(this.FindJob_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Find_PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Find_PicBox;
        private System.Windows.Forms.Label lbl_JobTitle;
        private System.Windows.Forms.Label lbl_JobType;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Button Apply_btn;
    }
}
