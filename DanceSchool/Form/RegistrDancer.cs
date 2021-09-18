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
    public partial class RegistrDancer : Form
    {
        public RegistrDancer(Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoinOrRegistr gor = new GoinOrRegistr(3, this.Size);
            FormAction.Open(this, gor);
        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text != passwordBox1.Text)
            {
                MessageBox.Show("Password mismatch!", "Error");
                return;
            }
            if (DB.CheckDancerLogin(loginBox.Text) != -1)
            {
                MessageBox.Show("This login already exists!", "Error");
                return;
            }
            int res = DB.InsertDancer(loginBox.Text, passwordBox.Text, nameBox.Text, surnameBox.Text);
            int id = DB.CheckDancerLogin(loginBox.Text);
            if (res == 1) DB.InsertLoging(3, id, 28);
            else DB.InsertLoging(3, id, 29);

            SchoolMain schoolMain = new SchoolMain(3, id, this.Size);
            FormAction.Open(this, schoolMain);
        }
    }
}