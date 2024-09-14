namespace WidWin
{
    partial class FormGraphic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartVideo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGetUserName = new System.Windows.Forms.TextBox();
            this.btnGetVideoChart = new System.Windows.Forms.Button();
            this.btnReturnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // chartVideo
            // 
            this.chartVideo.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartVideo.ChartAreas.Add(chartArea1);
            this.chartVideo.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chartVideo.Legends.Add(legend1);
            this.chartVideo.Location = new System.Drawing.Point(250, 12);
            this.chartVideo.Name = "chartVideo";
            this.chartVideo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVideo.Series.Add(series1);
            this.chartVideo.Size = new System.Drawing.Size(434, 332);
            this.chartVideo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtGetUserName
            // 
            this.txtGetUserName.Location = new System.Drawing.Point(12, 73);
            this.txtGetUserName.Name = "txtGetUserName";
            this.txtGetUserName.Size = new System.Drawing.Size(182, 22);
            this.txtGetUserName.TabIndex = 2;
            // 
            // btnGetVideoChart
            // 
            this.btnGetVideoChart.Location = new System.Drawing.Point(66, 129);
            this.btnGetVideoChart.Name = "btnGetVideoChart";
            this.btnGetVideoChart.Size = new System.Drawing.Size(102, 43);
            this.btnGetVideoChart.TabIndex = 3;
            this.btnGetVideoChart.Text = "Getir";
            this.btnGetVideoChart.UseVisualStyleBackColor = true;
            this.btnGetVideoChart.Click += new System.EventHandler(this.btnGetVideoChart_Click);
            // 
            // btnReturnMainMenu
            // 
            this.btnReturnMainMenu.Location = new System.Drawing.Point(66, 222);
            this.btnReturnMainMenu.Name = "btnReturnMainMenu";
            this.btnReturnMainMenu.Size = new System.Drawing.Size(102, 43);
            this.btnReturnMainMenu.TabIndex = 4;
            this.btnReturnMainMenu.Text = "Anasayfa";
            this.btnReturnMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnMainMenu.Click += new System.EventHandler(this.btnReturnMainMenu_Click);
            // 
            // FormGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 356);
            this.Controls.Add(this.btnReturnMainMenu);
            this.Controls.Add(this.btnGetVideoChart);
            this.Controls.Add(this.txtGetUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartVideo);
            this.Name = "FormGraphic";
            ((System.ComponentModel.ISupportInitialize)(this.chartVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGetUserName;
        private System.Windows.Forms.Button btnGetVideoChart;
        private System.Windows.Forms.Button btnReturnMainMenu;
    }
}