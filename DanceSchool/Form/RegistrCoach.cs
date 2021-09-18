using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceSchool
{
    public partial class RegistrCoach : Form
    {
        public RegistrCoach(Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoinOrRegistr gor = new GoinOrRegistr(2, this.Size);
            FormAction.Open(this, gor);
        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text != passwordBox1.Text)
            {
                MessageBox.Show("Password mismatch!", "Error");
                return;
            }
            if (DB.CheckCoachLogin(loginBox.Text) != -1)
            {
                MessageBox.Show("This login already exists!", "Error");
                return;
            }
            int res = DB.InsertCoach(loginBox.Text, passwordBox.Text, nameBox.Text, surnameBox.Text,aboutBox.Text);
            int id = DB.CheckCoachLogin(loginBox.Text);
            if (res == 1) DB.InsertLoging(2, id, 26);
            else DB.InsertLoging(2, id, 27);

            SchoolMain schoolMain = new SchoolMain(2, id, this.Size);
            FormAction.Open(this, schoolMain);
        }
    }
}
