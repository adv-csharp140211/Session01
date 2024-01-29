using App01.Model;
using App01.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01.UI
{
    public partial class FormUser : Form
    {
        private int currentIndex = 0;
        UserService userService = new UserService();

        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //new
            //update?
            var user = new User { Email = textBoxEmail.Text, FirstName = textBoxFirstName.Text, LastName = textBoxLastName.Text, Tel = textBoxTel.Text };
            if(string.IsNullOrWhiteSpace(textBoxId.Text)) {
                //new
                user.Id = userService.UserCount + 1;
                userService.Add(user);
            }
            else
            {
                //update
                user.Id = Convert.ToInt32(textBoxId.Text);
                userService.Update(user, currentIndex);
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            loadUser();
        }

        private void loadUser()
        {

            var user = userService.GetByIndex(currentIndex);
            textBoxId.Text = user.Id.ToString();
            textBoxFirstName.Text = user.FirstName;
            textBoxLastName.Text = user.LastName;
            textBoxEmail.Text = user.Email;
            textBoxTel.Text = user.Tel;

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentIndex >= userService.UserCount - 1) return;
            currentIndex = currentIndex + 1;
            loadUser();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            currentIndex = userService.UserCount - 1;
            loadUser();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex == 0) return;
            currentIndex = currentIndex - 1;
            loadUser();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            loadUser();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxTel.Clear();
        }
    }
}
