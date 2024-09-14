namespace WidWin
{
    partial class FormAccountInfo
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
            this.lblAccountFirstName = new System.Windows.Forms.Label();
            this.lblAccountLastName = new System.Windows.Forms.Label();
            this.lblAccountUserName = new System.Windows.Forms.Label();
            this.lblAccountEmail = new System.Windows.Forms.Label();
            this.lblAccountBirthday = new System.Windows.Forms.Label();
            this.lblAccountFaculty = new System.Windows.Forms.Label();
            this.lblAccountUniversity = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccountFirstName
            // 
            this.lblAccountFirstName.AutoSize = true;
            this.lblAccountFirstName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountFirstName.Location = new System.Drawing.Point(101, 31);
            this.lblAccountFirstName.Name = "lblAccountFirstName";
            this.lblAccountFirstName.Size = new System.Drawing.Size(45, 24);
            this.lblAccountFirstName.TabIndex = 0;
            this.lblAccountFirstName.Text = "-----";
            // 
            // lblAccountLastName
            // 
            this.lblAccountLastName.AutoSize = true;
            this.lblAccountLastName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountLastName.Location = new System.Drawing.Point(101, 80);
            this.lblAccountLastName.Name = "lblAccountLastName";
            this.lblAccountLastName.Size = new System.Drawing.Size(45, 24);
            this.lblAccountLastName.TabIndex = 1;
            this.lblAccountLastName.Text = "-----";
            // 
            // lblAccountUserName
            // 
            this.lblAccountUserName.AutoSize = true;
            this.lblAccountUserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountUserName.Location = new System.Drawing.Point(101, 123);
            this.lblAccountUserName.Name = "lblAccountUserName";
            this.lblAccountUserName.Size = new System.Drawing.Size(45, 24);
            this.lblAccountUserName.TabIndex = 2;
            this.lblAccountUserName.Text = "-----";
            // 
            // lblAccountEmail
            // 
            this.lblAccountEmail.AutoSize = true;
            this.lblAccountEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountEmail.Location = new System.Drawing.Point(101, 165);
            this.lblAccountEmail.Name = "lblAccountEmail";
            this.lblAccountEmail.Size = new System.Drawing.Size(61, 24);
            this.lblAccountEmail.TabIndex = 3;
            this.lblAccountEmail.Text = "label3";
            // 
            // lblAccountBirthday
            // 
            this.lblAccountBirthday.AutoSize = true;
            this.lblAccountBirthday.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBirthday.Location = new System.Drawing.Point(101, 208);
            this.lblAccountBirthday.Name = "lblAccountBirthday";
            this.lblAccountBirthday.Size = new System.Drawing.Size(61, 24);
            this.lblAccountBirthday.TabIndex = 4;
            this.lblAccountBirthday.Text = "label3";
            // 
            // lblAccountFaculty
            // 
            this.lblAccountFaculty.AutoSize = true;
            this.lblAccountFaculty.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountFaculty.Location = new System.Drawing.Point(101, 254);
            this.lblAccountFaculty.Name = "lblAccountFaculty";
            this.lblAccountFaculty.Size = new System.Drawing.Size(61, 24);
            this.lblAccountFaculty.TabIndex = 5;
            this.lblAccountFaculty.Text = "label3";
            // 
            // lblAccountUniversity
            // 
            this.lblAccountUniversity.AutoSize = true;
            this.lblAccountUniversity.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountUniversity.Location = new System.Drawing.Point(101, 294);
            this.lblAccountUniversity.Name = "lblAccountUniversity";
            this.lblAccountUniversity.Size = new System.Drawing.Size(61, 24);
            this.lblAccountUniversity.TabIndex = 6;
            this.lblAccountUniversity.Text = "label3";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(155, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 66);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Bigilerimi Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(33, 345);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(102, 66);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAccountUniversity);
            this.Controls.Add(this.lblAccountFaculty);
            this.Controls.Add(this.lblAccountBirthday);
            this.Controls.Add(this.lblAccountEmail);
            this.Controls.Add(this.lblAccountUserName);
            this.Controls.Add(this.lblAccountLastName);
            this.Controls.Add(this.lblAccountFirstName);
            this.Name = "FormAccountInfo";
            this.Load += new System.EventHandler(this.FormAccountInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountFirstName;
        private System.Windows.Forms.Label lblAccountLastName;
        private System.Windows.Forms.Label lblAccountUserName;
        private System.Windows.Forms.Label lblAccountEmail;
        private System.Windows.Forms.Label lblAccountBirthday;
        private System.Windows.Forms.Label lblAccountFaculty;
        private System.Windows.Forms.Label lblAccountUniversity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHome;
    }
}