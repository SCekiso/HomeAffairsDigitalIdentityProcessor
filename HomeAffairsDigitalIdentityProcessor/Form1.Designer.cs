namespace HomeAffairsDigitalIdentityProcessor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.cmbCitizenship = new System.Windows.Forms.ComboBox();
            this.btnValidateID = new System.Windows.Forms.Button();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is your Name and Surname?";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(378, 100);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(162, 27);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please put in your ID number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pick your citizenship: ";
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(363, 160);
            this.txtIDNumber.Multiline = true;
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(165, 33);
            this.txtIDNumber.TabIndex = 4;
            // 
            // cmbCitizenship
            // 
            this.cmbCitizenship.FormattingEnabled = true;
            this.cmbCitizenship.Items.AddRange(new object[] {
            "South Africa",
            "Canada",
            "Poland",
            "Italy",
            "USA",
            "St.Lucia"});
            this.cmbCitizenship.Location = new System.Drawing.Point(314, 236);
            this.cmbCitizenship.Name = "cmbCitizenship";
            this.cmbCitizenship.Size = new System.Drawing.Size(121, 24);
            this.cmbCitizenship.TabIndex = 5;
            this.cmbCitizenship.SelectedIndexChanged += new System.EventHandler(this.cmbCitizenship_SelectedIndexChanged);
            // 
            // btnValidateID
            // 
            this.btnValidateID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnValidateID.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateID.Location = new System.Drawing.Point(59, 322);
            this.btnValidateID.Name = "btnValidateID";
            this.btnValidateID.Size = new System.Drawing.Size(161, 31);
            this.btnValidateID.TabIndex = 6;
            this.btnValidateID.Text = "Validate your ID";
            this.btnValidateID.UseVisualStyleBackColor = false;
            this.btnValidateID.Click += new System.EventHandler(this.btnValidateID_Click);
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateProfile.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProfile.Location = new System.Drawing.Point(314, 321);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(113, 32);
            this.btnCreateProfile.TabIndex = 7;
            this.btnCreateProfile.Text = "Create Profile";
            this.btnCreateProfile.UseVisualStyleBackColor = false;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.BackColor = System.Drawing.Color.White;
            this.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummary.Location = new System.Drawing.Point(608, 84);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(180, 210);
            this.lblSummary.TabIndex = 8;
            this.lblSummary.Text = "Citizen Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "South African Home Affairs Digital Indentity Processer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.btnCreateProfile);
            this.Controls.Add(this.btnValidateID);
            this.Controls.Add(this.cmbCitizenship);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "South African Home Affairs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.ComboBox cmbCitizenship;
        private System.Windows.Forms.Button btnValidateID;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label label4;
    }
}

