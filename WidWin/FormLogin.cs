using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidWin
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (videpManagerEntities vt = new videpManagerEntities())
            {
                try
                {
                    string userEmail = txtLoginEmail.Text;
                    string userPassword = txtLoginPassword.Text;

                    
                    var user = vt.videpUsers
                        .Where(u => u.UserEmail == userEmail && u.UserPassword == userPassword)
                        .FirstOrDefault();

                    if (user != null)
                    {
                        MessageBox.Show("Oturum açma başarılı!");
                        
                        FormMainMenu formMainMenu = new FormMainMenu(user);
                        formMainMenu.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Oturum açma başarısız! Email veya şifre hatalı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oturum açma sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnToSingUp_Click(object sender, EventArgs e)
        {
            FormSingUpUser FormSingUpUser = new FormSingUpUser();
            FormSingUpUser.Show();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
