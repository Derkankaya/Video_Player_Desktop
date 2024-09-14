using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WidWin
{
    public partial class FormMainMenu : Form
    {
        private videpUser loggedInUser;
        private DataTable videoDataTable;

        // FormMainMenu constructor içinde
        public FormMainMenu(videpUser user)
        {
            int targetWidth = 50; 
            int targetHeight = 50;
            int maxWidth =50; 
            int initialMaxHeight = 50;
            InitializeComponent();
            loggedInUser = user;


            VideoUpdateVisibilite();

            // DataTable'ı oluştur
            videoDataTable = CreateVideoDataTable();
            CheckAndAddDesignerColumns();

            // DataGridView'e DataTable'ı bağla
            dgVideoList.DataSource = videoDataTable;

            // Video listesini güncelle
            ListVideos();

            // AutoGenerateColumns özelliğini devre dışı bırak
            dgVideoList.AutoGenerateColumns = false;

            // DataGridView'e sütunları ekle
            AddColumnToDataGridView("VideoImage", "Video Görseli",200);
            AddColumnToDataGridView("VideoTitle", "Video Başlık", 50) ;
            AddColumnToDataGridView("VideoProducer", "Video Yapımcı", 50);
            AddColumnToDataGridView("VideoDescription", "Video Açıklama", 50);
            AddColumnToDataGridView("VideoDate", "Video Tarihi", 50);
            AddColumnToDataGridView("VideoID", "Video ID", 0);  // "VideoID" sütununu ekleyin

            // Hücre boyutlarını ayarla
            dgVideoList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgVideoList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgVideoList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgVideoList.Columns["VideoID"].Visible = false; // VideoID sütununu gizle

            // CellFormatting olayını ekleyin
            dgVideoList.CellFormatting += dgVideoList_CellFormatting;
        }

        private void CheckAndAddDesignerColumns()
        {
            string[] designerColumnNames = { /* ... */ };

            foreach (string columnName in designerColumnNames)
            {
                // DataGridView'de sütun adıyla aynı isimde başka bir sütun var mı kontrol et
                if (!dgVideoList.Columns.Cast<DataGridViewColumn>().Any(col => col.Name == columnName))
                {
                    // Yeni bir DataGridViewTextBoxColumn oluştur
                    DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn
                    {
                        Name = columnName,
                        HeaderText = columnName, // Sütun adıyla aynı başlık (opsiyonel)
                        DataPropertyName = columnName, // İlgili sütun adıyla eşleşen veri bağlantısını ayarla (opsiyonel)
                    };

                    // DataGridView'e sütunu ekle
                    dgVideoList.Columns.Add(newColumn);
                }
            }
        }

        private void dgVideoList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Eğer satır indeksi 0'dan büyük ve sütun indeksi "VideoImage" sütunu ise
            if (e.RowIndex >= 0 && e.ColumnIndex == dgVideoList.Columns["VideoImage"].Index)
            {
                // İlgili hücredeki değeri alın
                object cellValue = e.Value;

                // Eğer hücre değeri DBNull ise, resmi null olarak ayarla
                if (cellValue == DBNull.Value)
                {
                    e.Value = null;
                    return;
                }

                // İlgili hücredeki görüntüyü alın
                Image image = (Image)cellValue;

                if (image != null)
                {
                    // Hücre boyutlarını alın
                    int cellWidth = dgVideoList.Columns[e.ColumnIndex].Width;
                    int cellHeight = dgVideoList.Rows[e.RowIndex].Height;

                    // Görüntüyü belirli bir sınıra ölçekleyin
                    Image resizedImage = ResizeImage(image, cellWidth, cellHeight, 150, 150); // Maksimum genişlik ve yükseklik: 150

                    // Hücredeki görüntüyü güncelleyin
                    e.Value = resizedImage;
                }
            }
        }

        private Image ResizeImage(Image originalImage, int targetWidth, int targetHeight, int maxWidth, int maxHeight)
        {
            // Görüntünün orijinal boyutları
            int originalWidth = originalImage.Width;
            int originalHeight = originalImage.Height;

            // Boyutları kontrol et
            // Eğer görüntü hedef genişlik ve yükseklik sınırlarında ise orijinal görüntüyü döndür
            if (originalWidth <= targetWidth && originalHeight <= targetHeight)
            {
                return new Bitmap(originalImage);
            }

            // Orijinal boyutları koruyarak boyutları hesapla
            double aspectRatio = (double)originalWidth / originalHeight;

            // Hedef genişliği ve yüksekliği kontrol et
            int newWidth = Math.Min(targetWidth, Math.Min(originalWidth, maxWidth));
            int newHeight = (int)(newWidth / aspectRatio);

            // Hedef yüksekliği kontrol et
            // Eğer yeni yükseklik sınırdan büyükse, yeni yüksekliği sınıra çek ve buna uygun genişlik hesapla
            /*if (newHeight > maxHeight)
            {
                newHeight = Math.Min(targetHeight, maxHeight);
                newWidth = (int)(newHeight * aspectRatio);
            }*/

            // Yeni boyutlarda bir Bitmap oluştur
            Bitmap result = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(result))
            {
                // Yeni boyutlara ölçeklenmiş görüntüyü çiz
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return result;
        }






        private DataTable CreateVideoDataTable()
        {
            DataTable dataTable = new DataTable();

            // Sütunları ekleyin
            dataTable.Columns.Add("VideoImage", typeof(Image));
            dataTable.Columns.Add("VideoTitle", typeof(string));
            dataTable.Columns.Add("VideoProducer", typeof(string));
            dataTable.Columns.Add("VideoDescription", typeof(string));
            dataTable.Columns.Add("VideoDate", typeof(DateTime));
            dataTable.Columns.Add("VideoID", typeof(int));

            return dataTable;
        }

        private void AddColumnToDataGridView(string columnName, string headerText, int width)
        {
            // DataGridView'de sütun adıyla aynı isimde başka bir sütun var mı kontrol et
            if (dgVideoList.Columns.Cast<DataGridViewColumn>().Any(col => col.Name == columnName))
            {
                return; // Sütun zaten varsa ekleme işlemi yapma
            }

            // Yeni bir DataGridViewTextBoxColumn oluştur
            DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn
            {
                Name = columnName,
                HeaderText = headerText,
                DataPropertyName = columnName, // İlgili sütun adıyla eşleşen veri bağlantısını ayarla (opsiyonel)
                Width = width, // Sütun genişliğini belirli bir değere ayarla
            };

            // Sütunun hücrelerindeki stil özelliklerini belirle
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle
            {
                WrapMode = DataGridViewTriState.True, // Hücre içeriğini otomatik olarak satıra sığdır
                Alignment = DataGridViewContentAlignment.MiddleCenter, // Hücre içeriğini ortala
            };
            newColumn.DefaultCellStyle = cellStyle;

            // DataGridView'e sütunu ekle
            dgVideoList.Columns.Add(newColumn);
        }


        private void ListVideos()
        {
            videpManagerEntities vt = new videpManagerEntities();
            List<videpProducerVideo> videos = vt.videpProducerVideos.ToList();

            // Önce mevcut satırları temizle
            videoDataTable.Rows.Clear();

            foreach (var video in videos)
            {
                DataRow row = videoDataTable.NewRow();
                row["VideoImage"] = GetImageFromByteArray(video.VideoTitlePhoto);
                row["VideoTitle"] = video.VideoTitle;
                row["VideoProducer"] = video.videpUser.UserUserName;
                row["VideoDescription"] = video.VideoDescription;
                row["VideoDate"] = video.VideoDateTime;
                row["VideoID"] = video.VideoID;

                videoDataTable.Rows.Add(row);
            }

        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                if (byteArrayIn == null || byteArrayIn.Length == 0)
                {
                    return null;
                }

                using (MemoryStream ms = new MemoryStream(byteArrayIn))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: Byte dizisi Image'a dönüştürülürken bir hata oluştu - {ex.Message}");
                return null;
            }
        }

        private Image GetImageFromByteArray(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null;
            }

            return ByteArrayToImage(byteArrayIn);
        }


        private void VideoUpdateVisibilite()
        {
            if (String.Equals(loggedInUser.UserMemberType, "2", StringComparison.OrdinalIgnoreCase))
            {
                videoYükleToolStripMenuItem.Visible = false;
            }
            else
            {
                videoYükleToolStripMenuItem.Visible = true;
            }
        }

        private void dgVideoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int videoID = (int)dgVideoList.Rows[e.RowIndex].Cells["VideoID"].Value;
                videpProducerVideo selectedVideo = GetVideoFromDatabase(videoID);

                if (selectedVideo != null)
                {
                    FormVideoPlayer formVideoPlayer = new FormVideoPlayer(selectedVideo,loggedInUser);
                    formVideoPlayer.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Seçilen video veritabanında bulunamadı.");
                }
            }
        }

        private videpProducerVideo GetVideoFromDatabase(int videoID)
        {
            videpManagerEntities vt = new videpManagerEntities();
            videpProducerVideo video = vt.videpProducerVideos.FirstOrDefault(v => v.VideoID == videoID);

            return video;
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
            this.Hide();
        }

        private void videoYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVideoUpload formVideoUpload = new FormVideoUpload(loggedInUser);
            formVideoUpload.Show();
            this.Hide();
        }

        private void bilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountInfo FormAccountInfo = new FormAccountInfo(loggedInUser);
            FormAccountInfo.Show();
            this.Hide();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void kullanıcıAktivitesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGraphic formGraphic = new FormGraphic(loggedInUser);
            formGraphic.Show();
            this.Hide();
        }


        private void Quit()
        {

            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }
    }
}
