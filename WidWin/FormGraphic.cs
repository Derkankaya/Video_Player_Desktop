using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WidWin
{
    public partial class FormGraphic : Form
    {
        private videpManagerEntities dbContext;
        private videpUser loggedInUser;

        public FormGraphic(videpUser user)
        {
            InitializeComponent();
            dbContext = new videpManagerEntities();
            loggedInUser = user;
        }

        private void btnGetVideoChart_Click(object sender, EventArgs e)
        {
            string userName = txtGetUserName.Text;

            var user = dbContext.videpUsers.FirstOrDefault(u => u.UserUserName == userName);

            if (user != null)
            {
                int userID = user.UserID;

                // Kullanıcının yüklediği tüm videoları al
                var userVideos = dbContext.videpProducerVideos
                    .Where(video => video.VideoProducerNO == userID)
                    .ToList();

                // Chart kontrolünü temizle
                chartVideo.Series.Clear();
                chartVideo.ChartAreas.Clear();
                chartVideo.Legends.Clear();

                // Yeni bir ChartArea ekle
                ChartArea chartArea = new ChartArea();
                chartVideo.ChartAreas.Add(chartArea);

                // Yeni bir Series ekle
                Series series = new Series("Video Sayısı");
                series.ChartType = SeriesChartType.Column;
                chartVideo.Series.Add(series);

                // Her bir gün için yüklenen video sayısını hesapla
                var dailyVideoCounts = userVideos
                    .GroupBy(video => video.VideoDateTime.Date)
                    .Select(group => new { Date = group.Key, Count = group.Count() })
                    .OrderBy(item => item.Date)
                    .ToList();

                // Videoların sayısını ekleyerek grafiği güncelle
                foreach (var dailyVideoCount in dailyVideoCounts)
                {
                    chartVideo.Series["Video Sayısı"].Points.AddXY(dailyVideoCount.Date, dailyVideoCount.Count);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
        }

        private void btnReturnMainMenu_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu(loggedInUser);
            formMainMenu.Show();
            this.Hide();
        }
    }
}
