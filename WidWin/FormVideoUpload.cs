using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidWin
{
    public partial class FormVideoUpload : Form
    {
        private videpUser loggedInUser;
        private byte[] fileVideo;
        private byte[] filePhoto;

        public FormVideoUpload(videpUser user)
        {
            InitializeComponent();
            loggedInUser = user;
            rbSelectedVideo.CheckedChanged += rbSelected_CheckedChanged;
            rbSelectedPhoto.CheckedChanged += rbSelected_CheckedChanged;


        }

        private void rbSelected_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSelectedVideo.Checked)
            {
                pbVideoUpdate.AllowDrop = true;
                pbVideoPhotos.AllowDrop = false;
            }
            else if (rbSelectedPhoto.Checked)
            {
                pbVideoUpdate.AllowDrop = false;
                pbVideoPhotos.AllowDrop = true;
            }
        }



        private void pbVideoUpdate_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files != null && files.Length > 0)
            {
                fileVideo = File.ReadAllBytes(files[0]);
                // Video dosyasını veritabanına eklemek için gerekli işlemleri yapın.
            }
        }

        private void pbVideoUpdate_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pbVideoPhotos_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files != null && files.Length > 0)
            {
                filePhoto = File.ReadAllBytes(files[0]);
                // Fotoğraf dosyasını PictureBox'ta görüntülemek için gerekli işlemleri yapın.
                ShowPhoto(filePhoto);
            }
        }

        private void pbVideoPhotos_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ShowPhoto(byte[] photoBytes)
        {
            // Fotoğrafı PictureBox kontrolünde görüntüle
            try
            {
                using (MemoryStream ms = new MemoryStream(photoBytes))
                {
                    Image photo = Image.FromStream(ms);
                    pbVideoPhotos.Image = photo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fotoğraf görüntülenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnVideoUpload_Click(object sender, EventArgs e)
        {
            using (videpManagerEntities vt = new videpManagerEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        videpProducerVideo newvidepProducerVideo = new videpProducerVideo();
                        newvidepProducerVideo.VideoURL = fileVideo;
                        newvidepProducerVideo.VideoTitlePhoto = filePhoto;
                        newvidepProducerVideo.VideoTitle = txtVideoTitle.Text;
                        newvidepProducerVideo.VideoDescription = rTxtVideoInfo.Text;
                        newvidepProducerVideo.VideoDateTime = DateTime.Now;
                        newvidepProducerVideo.VideoProducerNO = loggedInUser.UserID;


                        vt.videpProducerVideos.Add(newvidepProducerVideo);
                        int sonuc = vt.SaveChanges();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("İşlem başarılı!");
                           
                        }

                        else
                        {
                            MessageBox.Show("İşlem başarısız!");
                        }

                    }
                    catch (Exception hata)
                    {
                        transaction.Rollback();
                        string errorMessage = $"İşlem sırasında bir hata oluştu: {hata.Message}";
                        MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(errorMessage);
                    }

                    finally
                    {
                        transaction.Commit();
                        FormMainMenu formMainMenu = new FormMainMenu(loggedInUser);
                        formMainMenu.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void FormVideoUpload_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu(loggedInUser);
            formMainMenu.Show();
            this.Hide();
        }
    }
}
