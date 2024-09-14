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

namespace WidWin
{
    public partial class FormPasswordChange : Form
    {
        private videpUser loggedInUser;
        public FormPasswordChange(videpUser loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void FormPasswordChange_Load(object sender, EventArgs e)
        {

        }

        private void btnPasswordSave_Click(object sender, EventArgs e)
        {
            using (videpManagerEntities vt = new videpManagerEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        if (loggedInUser.UserPassword.Equals(txtOldPassword))
                        {
                            if (txtNewPassword.Text != txtNewPasswordControl.Text)
                            {
                                MessageBox.Show("Oluşturmak istediğiniz yeni şifreler uyuşmuyor!");
                            }
                            else
                            {
                                loggedInUser.UserPassword = txtNewPasswordControl.Text;
                            }

                            vt.Entry(loggedInUser).State = EntityState.Modified;
                            vt.SaveChanges();
                            MessageBox.Show("Parola Başarıyla Değiştirildi!");
                            
                        }
                        else
                        {
                            MessageBox.Show("Hatalı şifre" + "\n" + "Bilgiler Güncellenemedi!");
                        }
                    }

                    catch (Exception hata)
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        transaction.Commit();
                    }
                }
            }
        }

        private void btnToInfoUser_Click(object sender, EventArgs e)
        {
            FormAccountInfo formAccountInfo = new FormAccountInfo(loggedInUser);
            formAccountInfo.Show();
            this.Hide();
        }
    }
}
