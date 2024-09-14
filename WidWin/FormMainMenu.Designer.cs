namespace WidWin
{
    partial class FormMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hesabımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgilerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıAktivitesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgVideoList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVideoList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.hesabımToolStripMenuItem,
            this.videoYükleToolStripMenuItem,
            this.kullanıcıAktivitesiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.toolStripMenuItem1.Text = "Ana Menü";
            // 
            // hesabımToolStripMenuItem
            // 
            this.hesabımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgilerimToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.hesabımToolStripMenuItem.Name = "hesabımToolStripMenuItem";
            this.hesabımToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.hesabımToolStripMenuItem.Text = "Hesabım";
            // 
            // bilgilerimToolStripMenuItem
            // 
            this.bilgilerimToolStripMenuItem.Name = "bilgilerimToolStripMenuItem";
            this.bilgilerimToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.bilgilerimToolStripMenuItem.Text = "Bilgilerim";
            this.bilgilerimToolStripMenuItem.Click += new System.EventHandler(this.bilgilerimToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // videoYükleToolStripMenuItem
            // 
            this.videoYükleToolStripMenuItem.Name = "videoYükleToolStripMenuItem";
            this.videoYükleToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.videoYükleToolStripMenuItem.Text = "Video Yükle";
            this.videoYükleToolStripMenuItem.Click += new System.EventHandler(this.videoYükleToolStripMenuItem_Click);
            // 
            // kullanıcıAktivitesiToolStripMenuItem
            // 
            this.kullanıcıAktivitesiToolStripMenuItem.Name = "kullanıcıAktivitesiToolStripMenuItem";
            this.kullanıcıAktivitesiToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.kullanıcıAktivitesiToolStripMenuItem.Text = "Kullanıcı Aktivitesi";
            this.kullanıcıAktivitesiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıAktivitesiToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.çıkışToolStripMenuItem.Text = "Uygulamayı Kapat";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // dgVideoList
            // 
            this.dgVideoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVideoList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgVideoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVideoList.Location = new System.Drawing.Point(0, 28);
            this.dgVideoList.Name = "dgVideoList";
            this.dgVideoList.RowHeadersWidth = 51;
            this.dgVideoList.RowTemplate.Height = 24;
            this.dgVideoList.Size = new System.Drawing.Size(671, 370);
            this.dgVideoList.TabIndex = 1;
            this.dgVideoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVideoList_CellContentClick);
            this.dgVideoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVideoList_CellContentClick);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 410);
            this.Controls.Add(this.dgVideoList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVideoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hesabımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgilerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoYükleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgVideoList;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıAktivitesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}