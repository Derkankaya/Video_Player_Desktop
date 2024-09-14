namespace WidWin
{
    partial class FormPasswordChange
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
            this.btnPasswordSave = new System.Windows.Forms.Button();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordControl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToInfoUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPasswordSave
            // 
            this.btnPasswordSave.Location = new System.Drawing.Point(184, 144);
            this.btnPasswordSave.Name = "btnPasswordSave";
            this.btnPasswordSave.Size = new System.Drawing.Size(140, 45);
            this.btnPasswordSave.TabIndex = 0;
            this.btnPasswordSave.Text = "Kaydet";
            this.btnPasswordSave.UseVisualStyleBackColor = true;
            this.btnPasswordSave.Click += new System.EventHandler(this.btnPasswordSave_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(184, 28);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(192, 22);
            this.txtOldPassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(184, 72);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(192, 22);
            this.txtNewPassword.TabIndex = 2;
            // 
            // txtNewPasswordControl
            // 
            this.txtNewPasswordControl.Location = new System.Drawing.Point(184, 116);
            this.txtNewPasswordControl.Name = "txtNewPasswordControl";
            this.txtNewPasswordControl.Size = new System.Drawing.Size(192, 22);
            this.txtNewPasswordControl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eski Parola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Parola (Tekrar)";
            // 
            // btnToInfoUser
            // 
            this.btnToInfoUser.Location = new System.Drawing.Point(16, 144);
            this.btnToInfoUser.Name = "btnToInfoUser";
            this.btnToInfoUser.Size = new System.Drawing.Size(125, 45);
            this.btnToInfoUser.TabIndex = 7;
            this.btnToInfoUser.Text = "Bilgilerimi Göster";
            this.btnToInfoUser.UseVisualStyleBackColor = true;
            this.btnToInfoUser.Click += new System.EventHandler(this.btnToInfoUser_Click);
            // 
            // FormPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 201);
            this.Controls.Add(this.btnToInfoUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPasswordControl);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.btnPasswordSave);
            this.Name = "FormPasswordChange";
            this.Load += new System.EventHandler(this.FormPasswordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPasswordSave;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPasswordControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToInfoUser;
    }
}