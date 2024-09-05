
namespace Job_Portal
{
    partial class AddJob
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Add_job_Panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_job_Panel2 = new System.Windows.Forms.Panel();
            this.add_job_Qualification = new System.Windows.Forms.ComboBox();
            this.AddJob_Id = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Add_job_No_of_post = new System.Windows.Forms.NumericUpDown();
            this.Add_job_Clear_btn = new System.Windows.Forms.Button();
            this.Add_job_Delete_btn = new System.Windows.Forms.Button();
            this.Add_job_Update_btn = new System.Windows.Forms.Button();
            this.Add_job_add_btn = new System.Windows.Forms.Button();
            this.Add_job_Last_to_Apply = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.Add_job_State = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Add_job_Country = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Add_job_Address = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Add_job_Mail_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Add_job_company_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Add_job_Type = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Add_job_Salary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Add_job_domainarea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_Job_Description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_Job_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddJob_CollegeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_job_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Add_job_Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_job_No_of_post)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_job_Panel
            // 
            this.Add_job_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_job_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_job_Panel.Controls.Add(this.dataGridView1);
            this.Add_job_Panel.Controls.Add(this.label1);
            this.Add_job_Panel.Location = new System.Drawing.Point(3, 12);
            this.Add_job_Panel.Name = "Add_job_Panel";
            this.Add_job_Panel.Size = new System.Drawing.Size(1091, 243);
            this.Add_job_Panel.TabIndex = 0;
            this.Add_job_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Add_job_Panel_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(31, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 194);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Data";
            // 
            // Add_job_Panel2
            // 
            this.Add_job_Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_job_Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_job_Panel2.Controls.Add(this.add_job_Qualification);
            this.Add_job_Panel2.Controls.Add(this.AddJob_Id);
            this.Add_job_Panel2.Controls.Add(this.label16);
            this.Add_job_Panel2.Controls.Add(this.Add_job_No_of_post);
            this.Add_job_Panel2.Controls.Add(this.Add_job_Clear_btn);
            this.Add_job_Panel2.Controls.Add(this.Add_job_Delete_btn);
            this.Add_job_Panel2.Controls.Add(this.Add_job_Update_btn);
            this.Add_job_Panel2.Controls.Add(this.Add_job_add_btn);
            this.Add_job_Panel2.Controls.Add(this.Add_job_Last_to_Apply);
            this.Add_job_Panel2.Controls.Add(this.label15);
            this.Add_job_Panel2.Controls.Add(this.Add_job_State);
            this.Add_job_Panel2.Controls.Add(this.label14);
            this.Add_job_Panel2.Controls.Add(this.Add_job_Country);
            this.Add_job_Panel2.Controls.Add(this.label13);
            this.Add_job_Panel2.Controls.Add(this.Add_job_Address);
            this.Add_job_Panel2.Controls.Add(this.label12);
            this.Add_job_Panel2.Controls.Add(this.Add_job_Mail_id);
            this.Add_job_Panel2.Controls.Add(this.label11);
            this.Add_job_Panel2.Controls.Add(this.Add_job_company_name);
            this.Add_job_Panel2.Controls.Add(this.label10);
            this.Add_job_Panel2.Controls.Add(this.Add_job_Type);
            this.Add_job_Panel2.Controls.Add(this.label9);
            this.Add_job_Panel2.Controls.Add(this.Add_job_Salary);
            this.Add_job_Panel2.Controls.Add(this.label8);
            this.Add_job_Panel2.Controls.Add(this.Add_job_domainarea);
            this.Add_job_Panel2.Controls.Add(this.label7);
            this.Add_job_Panel2.Controls.Add(this.label6);
            this.Add_job_Panel2.Controls.Add(this.label5);
            this.Add_job_Panel2.Controls.Add(this.Add_Job_Description);
            this.Add_job_Panel2.Controls.Add(this.label4);
            this.Add_job_Panel2.Controls.Add(this.Add_Job_Title);
            this.Add_job_Panel2.Controls.Add(this.label3);
            this.Add_job_Panel2.Controls.Add(this.AddJob_CollegeName);
            this.Add_job_Panel2.Controls.Add(this.label2);
            this.Add_job_Panel2.Location = new System.Drawing.Point(11, 261);
            this.Add_job_Panel2.Name = "Add_job_Panel2";
            this.Add_job_Panel2.Size = new System.Drawing.Size(1083, 455);
            this.Add_job_Panel2.TabIndex = 1;
            this.Add_job_Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // add_job_Qualification
            // 
            this.add_job_Qualification.FormattingEnabled = true;
            this.add_job_Qualification.Items.AddRange(new object[] {
            "BE-CSE",
            "BE-IT",
            "BE-EEE",
            "BE-ECE"});
            this.add_job_Qualification.Location = new System.Drawing.Point(237, 291);
            this.add_job_Qualification.Name = "add_job_Qualification";
            this.add_job_Qualification.Size = new System.Drawing.Size(256, 24);
            this.add_job_Qualification.TabIndex = 34;
            // 
            // AddJob_Id
            // 
            this.AddJob_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddJob_Id.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJob_Id.Location = new System.Drawing.Point(182, 17);
            this.AddJob_Id.Name = "AddJob_Id";
            this.AddJob_Id.ReadOnly = true;
            this.AddJob_Id.Size = new System.Drawing.Size(330, 26);
            this.AddJob_Id.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 18);
            this.label16.TabIndex = 32;
            this.label16.Text = "JobId:";
            // 
            // Add_job_No_of_post
            // 
            this.Add_job_No_of_post.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_No_of_post.Location = new System.Drawing.Point(182, 251);
            this.Add_job_No_of_post.Name = "Add_job_No_of_post";
            this.Add_job_No_of_post.Size = new System.Drawing.Size(330, 26);
            this.Add_job_No_of_post.TabIndex = 31;
            // 
            // Add_job_Clear_btn
            // 
            this.Add_job_Clear_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Add_job_Clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_job_Clear_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_Clear_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_Clear_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_job_Clear_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_Clear_btn.ForeColor = System.Drawing.Color.White;
            this.Add_job_Clear_btn.Location = new System.Drawing.Point(832, 392);
            this.Add_job_Clear_btn.Name = "Add_job_Clear_btn";
            this.Add_job_Clear_btn.Size = new System.Drawing.Size(103, 43);
            this.Add_job_Clear_btn.TabIndex = 30;
            this.Add_job_Clear_btn.Text = "Clear";
            this.Add_job_Clear_btn.UseVisualStyleBackColor = false;
            this.Add_job_Clear_btn.Click += new System.EventHandler(this.Add_job_Clear_btn_Click);
            // 
            // Add_job_Delete_btn
            // 
            this.Add_job_Delete_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.Add_job_Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_job_Delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_Delete_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_Delete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_job_Delete_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_Delete_btn.ForeColor = System.Drawing.Color.White;
            this.Add_job_Delete_btn.Location = new System.Drawing.Point(677, 392);
            this.Add_job_Delete_btn.Name = "Add_job_Delete_btn";
            this.Add_job_Delete_btn.Size = new System.Drawing.Size(103, 43);
            this.Add_job_Delete_btn.TabIndex = 29;
            this.Add_job_Delete_btn.Text = "Delete";
            this.Add_job_Delete_btn.UseVisualStyleBackColor = false;
            this.Add_job_Delete_btn.Click += new System.EventHandler(this.Add_job_Delete_btn_Click);
            // 
            // Add_job_Update_btn
            // 
            this.Add_job_Update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(198)))));
            this.Add_job_Update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_job_Update_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_Update_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_Update_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_job_Update_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_Update_btn.ForeColor = System.Drawing.Color.White;
            this.Add_job_Update_btn.Location = new System.Drawing.Point(515, 392);
            this.Add_job_Update_btn.Name = "Add_job_Update_btn";
            this.Add_job_Update_btn.Size = new System.Drawing.Size(103, 43);
            this.Add_job_Update_btn.TabIndex = 28;
            this.Add_job_Update_btn.Text = "Update";
            this.Add_job_Update_btn.UseVisualStyleBackColor = false;
            this.Add_job_Update_btn.Click += new System.EventHandler(this.Add_job_Update_btn_Click);
            // 
            // Add_job_add_btn
            // 
            this.Add_job_add_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.Add_job_add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_job_add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_add_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_add_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Add_job_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_job_add_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_job_add_btn.Location = new System.Drawing.Point(353, 392);
            this.Add_job_add_btn.Name = "Add_job_add_btn";
            this.Add_job_add_btn.Size = new System.Drawing.Size(103, 43);
            this.Add_job_add_btn.TabIndex = 27;
            this.Add_job_add_btn.Text = "Add ";
            this.Add_job_add_btn.UseVisualStyleBackColor = false;
            this.Add_job_add_btn.Click += new System.EventHandler(this.Add_job_add_btn_Click);
            // 
            // Add_job_Last_to_Apply
            // 
            this.Add_job_Last_to_Apply.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_Last_to_Apply.Location = new System.Drawing.Point(756, 352);
            this.Add_job_Last_to_Apply.Name = "Add_job_Last_to_Apply";
            this.Add_job_Last_to_Apply.Size = new System.Drawing.Size(269, 26);
            this.Add_job_Last_to_Apply.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(580, 355);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 18);
            this.label15.TabIndex = 25;
            this.label15.Text = "Last To Apply:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Add_job_State
            // 
            this.Add_job_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_job_State.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_State.Location = new System.Drawing.Point(747, 298);
            this.Add_job_State.Name = "Add_job_State";
            this.Add_job_State.Size = new System.Drawing.Size(302, 26);
            this.Add_job_State.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(589, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "State:";
            // 
            // Add_job_Country
            // 
            this.Add_job_Country.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_Country.FormattingEnabled = true;
            this.Add_job_Country.Items.AddRange(new object[] {
            "India",
            "United States",
            "Bangladesh",
            "SriLanka",
            "Pakistan",
            "China",
            "Brazil",
            "Egypt",
            "South Africa",
            "Japan",
            "Canada",
            "Germany",
            "Australia",
            "Malaysia",
            "Philippines"});
            this.Add_job_Country.Location = new System.Drawing.Point(747, 251);
            this.Add_job_Country.Name = "Add_job_Country";
            this.Add_job_Country.Size = new System.Drawing.Size(302, 26);
            this.Add_job_Country.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(589, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "Country:";
            // 
            // Add_job_Address
            // 
            this.Add_job_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_job_Address.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_Address.Location = new System.Drawing.Point(748, 201);
            this.Add_job_Address.Multiline = true;
            this.Add_job_Address.Name = "Add_job_Address";
            this.Add_job_Address.Size = new System.Drawing.Size(313, 22);
            this.Add_job_Address.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(588, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Address:";
            // 
            // Add_job_Mail_id
            // 
            this.Add_job_Mail_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_job_Mail_id.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_Mail_id.Location = new System.Drawing.Point(747, 144);
            this.Add_job_Mail_id.Name = "Add_job_Mail_id";
            this.Add_job_Mail_id.Size = new System.Drawing.Size(313, 26);
            this.Add_job_Mail_id.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(580, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Mail Id:";
            // 
            // Add_job_company_name
            // 
            this.Add_job_company_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_job_company_name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_company_name.Location = new System.Drawing.Point(745, 95);
            this.Add_job_company_name.Name = "Add_job_company_name";
            this.Add_job_company_name.Size = new System.Drawing.Size(313, 26);
            this.Add_job_company_name.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(580, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Company Name:";
            // 
            // Add_job_Type
            // 
            this.Add_job_Type.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_Type.FormattingEnabled = true;
            this.Add_job_Type.Items.AddRange(new object[] {
            "Full Time",
            "Part Time",
            "Remote"});
            this.Add_job_Type.Location = new System.Drawing.Point(745, 46);
            this.Add_job_Type.Name = "Add_job_Type";
            this.Add_job_Type.Size = new System.Drawing.Size(302, 26);
            this.Add_job_Type.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(589, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Job Type:";
            // 
            // Add_job_Salary
            // 
            this.Add_job_Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_job_Salary.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_Salary.Location = new System.Drawing.Point(749, 2);
            this.Add_job_Salary.Name = "Add_job_Salary";
            this.Add_job_Salary.Size = new System.Drawing.Size(309, 26);
            this.Add_job_Salary.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(599, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Salary:";
            // 
            // Add_job_domainarea
            // 
            this.Add_job_domainarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_job_domainarea.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_job_domainarea.Location = new System.Drawing.Point(167, 341);
            this.Add_job_domainarea.Name = "Add_job_domainarea";
            this.Add_job_domainarea.Size = new System.Drawing.Size(345, 26);
            this.Add_job_domainarea.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "DomainArea:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Education Qualification:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "No.Of.Post:";
            // 
            // Add_Job_Description
            // 
            this.Add_Job_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_Job_Description.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Job_Description.Location = new System.Drawing.Point(182, 179);
            this.Add_Job_Description.Multiline = true;
            this.Add_Job_Description.Name = "Add_Job_Description";
            this.Add_Job_Description.Size = new System.Drawing.Size(330, 39);
            this.Add_Job_Description.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description:";
            // 
            // Add_Job_Title
            // 
            this.Add_Job_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_Job_Title.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Job_Title.Location = new System.Drawing.Point(182, 121);
            this.Add_Job_Title.Name = "Add_Job_Title";
            this.Add_Job_Title.Size = new System.Drawing.Size(330, 26);
            this.Add_Job_Title.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Job Title:";
            // 
            // AddJob_CollegeName
            // 
            this.AddJob_CollegeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddJob_CollegeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJob_CollegeName.Location = new System.Drawing.Point(182, 69);
            this.AddJob_CollegeName.Name = "AddJob_CollegeName";
            this.AddJob_CollegeName.Size = new System.Drawing.Size(330, 26);
            this.AddJob_CollegeName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "CollegeName:";
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Add_job_Panel2);
            this.Controls.Add(this.Add_job_Panel);
            this.Name = "AddJob";
            this.Size = new System.Drawing.Size(1107, 723);
            this.Load += new System.EventHandler(this.AddJob_Load);
            this.Add_job_Panel.ResumeLayout(false);
            this.Add_job_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Add_job_Panel2.ResumeLayout(false);
            this.Add_job_Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Add_job_No_of_post)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Add_job_Panel;
        private System.Windows.Forms.Panel Add_job_Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Add_job_company_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Add_job_Type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Add_job_Salary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Add_job_domainarea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Add_Job_Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Add_Job_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddJob_CollegeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Add_job_Address;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Add_job_Mail_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Add_job_Last_to_Apply;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Add_job_State;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Add_job_Country;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Add_job_Clear_btn;
        private System.Windows.Forms.Button Add_job_Delete_btn;
        private System.Windows.Forms.Button Add_job_Update_btn;
        private System.Windows.Forms.Button Add_job_add_btn;
        private System.Windows.Forms.NumericUpDown Add_job_No_of_post;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox add_job_Qualification;
        private System.Windows.Forms.TextBox AddJob_Id;
        private System.Windows.Forms.Label label16;
    }
}
