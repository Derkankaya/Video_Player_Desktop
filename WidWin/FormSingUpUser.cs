using System;
using System.Windows.Forms;

namespace WidWin
{
    public partial class FormSingUpUser : Form
    {
        public FormSingUpUser()
        {
            InitializeComponent();
        }

        private void btnSingUpProducer_Click(object sender, EventArgs e)
        {
            using (videpManagerEntities vt = new videpManagerEntities())
            {
                using (var transaction = vt.Database.BeginTransaction())
                {
                    try
                    {
                        videpUser newVidepUser = new videpUser();
                        newVidepUser.UserFirstName = txtSingUpUserFirstName.Text;
                        newVidepUser.UserLastName = txtSingUpUserLastName.Text;
                        newVidepUser.UserUserName = txtSingUpUserUserName.Text;
                        newVidepUser.UserEmail = txtSingUpUserEmail.Text;
                        newVidepUser.UserPassword = txtSingUpUserPassword.Text;
                        newVidepUser.UserBirthday = txtSingUpUserBirthday.Text;

                        if (rbUser.Checked)
                        {
                            newVidepUser.UserMemberType = "2";
                        }
                        else if (rbProducer.Checked)
                        {
                            newVidepUser.UserMemberType = "1";

                            if (string.IsNullOrWhiteSpace(txtSingUpUserFaculty.Text) ||
                                string.IsNullOrWhiteSpace(txtSingUpUserUniversity.Text) ||
                                string.IsNullOrWhiteSpace(txtSingUpUserTCNO.Text))
                            {
                                MessageBox.Show("Üretici olarak kaydoluyorsanız, tüm alanları doldurmalısınız!");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen bir üyelik tipi seçiniz!");
                            return;
                        }

                        newVidepUser.UserFaculty = txtSingUpUserFaculty.Text;
                        newVidepUser.UserUniversity = txtSingUpUserUniversity.Text;

                        if (!string.IsNullOrWhiteSpace(txtSingUpUserTCNO.Text))
                        {
                            // TC Kimlik kontrolü yap
                            bool durum = TCNoControl(txtSingUpUserTCNO.Text, txtSingUpUserFirstName.Text, txtSingUpUserLastName.Text, txtSingUpUserBirthday.Text);
                            if (durum)
                            {
                                newVidepUser.UserTCNO = txtSingUpUserTCNO.Text;
                            }
                            else
                            {
                                MessageBox.Show("Girilen TC kimlik bilgileri hatalı!");
                                return;
                            }
                        }

                        vt.videpUsers.Add(newVidepUser);
                        int sonuc = vt.SaveChanges();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("İşlem başarılı!");
                            FormLoginLoad();
                        }
                        else
                        {
                            MessageBox.Show("İşlem başarısız!");
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

        private bool TCNoControl(string TCNO, string firstName, string lastName, string birthday)
        {

            try
            {
                long tc = long.Parse(TCNO);
                int birthYear = int.Parse(birthday);
                using (TCdogrula.KPSPublicSoapClient service = new TCdogrula.KPSPublicSoapClient { })
                {
                    return service.TCKimlikNoDogrula(tc, firstName, lastName, birthYear);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnSingUpProducerToLogin_Click(object sender, EventArgs e)
        {
            FormLoginLoad();
        }

        private void FormLoginLoad()
        {
            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
            this.Hide();
        }
    }
}
