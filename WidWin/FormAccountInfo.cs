using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidWin
{
    public partial class FormAccountInfo : Form
    {
        private videpUser loggedInUser;
        public FormAccountInfo(videpUser loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void FormAccountInfo_Load(object sender, EventArgs e)
        {
            lblAccountFirstName.Text = loggedInUser.UserFirstName;
            lblAccountLastName.Text = loggedInUser.UserLastName ;
            lblAccountUserName.Text =loggedInUser.UserUserName;
            lblAccountEmail.Text = loggedInUser.UserEmail ;
            lblAccountBirthday.Text = loggedInUser.UserBirthday.ToString();
            if (loggedInUser.UserFaculty == null)
            {
                lblAccountFaculty.Visible = false;
            }
            else
            {
                lblAccountFaculty.Text = loggedInUser.UserFaculty;
            }
            if (loggedInUser.UserUniversity == null)
            {
                lblAccountUniversity.Visible = false;
            }
            else
            {
                lblAccountUniversity.Text = loggedInUser.UserUniversity;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormInfoUpdate formInfoUpdate = new FormInfoUpdate(loggedInUser);
            formInfoUpdate.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = new FormMainMenu(loggedInUser);
            formMainMenu.Show();
            this.Hide();
        }
    }
}
