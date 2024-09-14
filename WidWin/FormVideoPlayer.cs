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
    public partial class FormVideoPlayer : Form
    {
        videpProducerVideo selectedVideo;
        private videpUser loggedInUser;
        public FormVideoPlayer(videpProducerVideo producerVideo, videpUser user)
        {
            selectedVideo = producerVideo;
            InitializeComponent();
            loggedInUser = user;
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void FormVideoPlayer_Load(object sender, EventArgs e)
        {
            string tempFilePath = Path.GetTempFileName();

 
            File.WriteAllBytes(tempFilePath, selectedVideo.VideoURL);

            axWindowsMediaPlayer.URL = tempFilePath;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = (int)axWindowsMediaPlayer.Ctlcontrols.currentItem.duration;
            progressBar1.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;
            lblVideoTime.Text = axWindowsMediaPlayer.Ctlcontrols.currentPosition.ToString();
            lblVideoTimeSize.Text = axWindowsMediaPlayer.Ctlcontrols.currentItem.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Quit()
        {

            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu(loggedInUser);
            formMainMenu.Show();
            this.Hide();
        }
    }
}
