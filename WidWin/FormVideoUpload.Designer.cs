namespace WidWin
{
    partial class FormVideoUpload
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
            this.btnVideoUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rTxtVideoInfo = new System.Windows.Forms.RichTextBox();
            this.txtVideoTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbVideoUpdate = new System.Windows.Forms.PictureBox();
            this.pbVideoPhotos = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSelectedPhoto = new System.Windows.Forms.RadioButton();
            this.rbSelectedVideo = new System.Windows.Forms.RadioButton();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideoUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideoPhotos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVideoUpload
            // 
            this.btnVideoUpload.Location = new System.Drawing.Point(681, 342);
            this.btnVideoUpload.Name = "btnVideoUpload";
            this.btnVideoUpload.Size = new System.Drawing.Size(107, 96);
            this.btnVideoUpload.TabIndex = 0;
            this.btnVideoUpload.Text = "Yükle";
            this.btnVideoUpload.UseVisualStyleBackColor = true;
            this.btnVideoUpload.Click += new System.EventHandler(this.btnVideoUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video Başlığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Video Açıklaması";
            // 
            // rTxtVideoInfo
            // 
            this.rTxtVideoInfo.Location = new System.Drawing.Point(198, 340);
            this.rTxtVideoInfo.Name = "rTxtVideoInfo";
            this.rTxtVideoInfo.Size = new System.Drawing.Size(453, 96);
            this.rTxtVideoInfo.TabIndex = 3;
            this.rTxtVideoInfo.Text = "";
            // 
            // txtVideoTitle
            // 
            this.txtVideoTitle.Location = new System.Drawing.Point(198, 297);
            this.txtVideoTitle.Name = "txtVideoTitle";
            this.txtVideoTitle.Size = new System.Drawing.Size(453, 22);
            this.txtVideoTitle.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Video Kapak Fotoğrafı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Video";
            // 
            // pbVideoUpdate
            // 
            this.pbVideoUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbVideoUpdate.Location = new System.Drawing.Point(36, 36);
            this.pbVideoUpdate.Name = "pbVideoUpdate";
            this.pbVideoUpdate.Size = new System.Drawing.Size(356, 211);
            this.pbVideoUpdate.TabIndex = 8;
            this.pbVideoUpdate.TabStop = false;
            this.pbVideoUpdate.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbVideoUpdate_DragDrop);
            this.pbVideoUpdate.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbVideoUpdate_DragEnter);
            // 
            // pbVideoPhotos
            // 
            this.pbVideoPhotos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbVideoPhotos.Location = new System.Drawing.Point(432, 36);
            this.pbVideoPhotos.Name = "pbVideoPhotos";
            this.pbVideoPhotos.Size = new System.Drawing.Size(356, 211);
            this.pbVideoPhotos.TabIndex = 9;
            this.pbVideoPhotos.TabStop = false;
            this.pbVideoPhotos.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbVideoPhotos_DragDrop);
            this.pbVideoPhotos.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbVideoPhotos_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSelectedPhoto);
            this.groupBox1.Controls.Add(this.rbSelectedVideo);
            this.groupBox1.Location = new System.Drawing.Point(145, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 22);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbSelectedPhoto
            // 
            this.rbSelectedPhoto.AutoSize = true;
            this.rbSelectedPhoto.Location = new System.Drawing.Point(444, 6);
            this.rbSelectedPhoto.Name = "rbSelectedPhoto";
            this.rbSelectedPhoto.Size = new System.Drawing.Size(17, 16);
            this.rbSelectedPhoto.TabIndex = 1;
            this.rbSelectedPhoto.TabStop = true;
            this.rbSelectedPhoto.UseVisualStyleBackColor = true;
            // 
            // rbSelectedVideo
            // 
            this.rbSelectedVideo.AutoSize = true;
            this.rbSelectedVideo.Location = new System.Drawing.Point(38, 6);
            this.rbSelectedVideo.Name = "rbSelectedVideo";
            this.rbSelectedVideo.Size = new System.Drawing.Size(17, 16);
            this.rbSelectedVideo.TabIndex = 0;
            this.rbSelectedVideo.TabStop = true;
            this.rbSelectedVideo.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(681, 303);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 33);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Ana menü";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormVideoUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbVideoPhotos);
            this.Controls.Add(this.pbVideoUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVideoTitle);
            this.Controls.Add(this.rTxtVideoInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVideoUpload);
            this.Name = "FormVideoUpload";
            this.Load += new System.EventHandler(this.FormVideoUpload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVideoUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideoPhotos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVideoUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rTxtVideoInfo;
        private System.Windows.Forms.TextBox txtVideoTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbVideoUpdate;
        private System.Windows.Forms.PictureBox pbVideoPhotos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSelectedVideo;
        private System.Windows.Forms.RadioButton rbSelectedPhoto;
        private System.Windows.Forms.Button btnHome;
    }
}