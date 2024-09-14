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
    public partial class FormInfoUpdate : Form
    {
        private videpUser loggedInUser;
        public FormInfoUpdate(videpUser loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void FormInfoUpdate_Load(object sender, EventArgs e)
        {

            lblUpdateFirstName.Text = loggedInUser.UserFirstName;
            lblUpdateLastName.Text = loggedInUser.UserLastName;
            lblUpdateUserName.Text = loggedInUser.UserUserName;
            lblUpdateEmail.Text = loggedInUser.UserEmail;
            lblUpdateBirthday.Text = loggedInUser.UserBirthday.ToString();
            if (loggedInUser.UserFaculty == null)
            {
                lblUpdateFaculty.Visible = false;
            }
            else
            {
                lblUpdateFaculty.Text = loggedInUser.UserFaculty;
            }
            if (loggedInUser.UserUniversity == null)
            {
                lblUpdateUniversity.Visible = false;
            }
            else
            {
                lblUpdateUniversity.Text = loggedInUser.UserUniversity;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (videpManagerEntities vt = new videpManagerEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        if (loggedInUser.UserPassword.Equals(txtCheckedPassword.Text))
                        {
                            if (txtUpdateFirstName != null)
                            {
                                loggedInUser.UserFirstName = txtUpdateFirstName.Text;
                            }
                            if (txtUpdateLastName != null)
                            {
                                loggedInUser.UserLastName = txtUpdateLastName.Text;
                            }
                            if (txtUpdateUserName != null)
                            {
                                loggedInUser.UserUserName = txtUpdateUserName.Text;
                            }
                            if (txtUpdateEmail != null)
                            {
                                loggedInUser.UserEmail = txtUpdateEmail.Text;
                            }
                            if (txtUpdateFaculty != null)
                            {
                                loggedInUser.UserFaculty = txtUpdateFaculty.Text;
                            }
                            if (txtUpdateUniversity != null)
                            {
                                loggedInUser.UserUniversity = txtUpdateUniversity.Text;
                            }

                            vt.Entry(loggedInUser).State = EntityState.Modified;
                            vt.SaveChanges();
                            MessageBox.Show("Güncelleme Başarılı!");
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
        


        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            FormPasswordChange formPasswordChange = new FormPasswordChange(loggedInUser);
            formPasswordChange.Show();
            this.Hide();
        }

        private void btnReturnMainMenu_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu(loggedInUser);
            formMainMenu.Show();
            this.Hide();
        }

        private void FormInfoUpdate_Load_1(object sender, EventArgs e)
        {
            lblUpdateFirstName.Text = loggedInUser.UserFirstName;
            lblUpdateLastName.Text = loggedInUser.UserLastName;
            lblUpdateUserName.Text = loggedInUser.UserUserName;
            lblUpdateEmail.Text = loggedInUser.UserEmail;
            lblUpdateBirthday.Text = loggedInUser.UserBirthday.ToString();
            if (loggedInUser.UserFaculty == null)
            {
                lblUpdateFaculty.Visible = false;
            }
            else
            {
                lblUpdateFaculty.Text = loggedInUser.UserFaculty;
            }
            if (loggedInUser.UserUniversity == null)
            {
                lblUpdateUniversity.Visible = false;
            }
            else
            {
                lblUpdateUniversity.Text = loggedInUser.UserUniversity;
            }
        }
    }
}
