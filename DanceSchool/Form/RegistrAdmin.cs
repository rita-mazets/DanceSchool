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
    public partial class RegistrAdmin : Form
    {
        public RegistrAdmin(Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoinOrRegistr gor = new GoinOrRegistr(1, this.Size);
            FormAction.Open(this, gor);
        }

        private void registrButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text != passwordBox1.Text)
            {
                MessageBox.Show("Password mismatch!", "Error");
                return;
            }
            if (DB.CheckAdminLogin(loginBox.Text) != -1)
            {
                MessageBox.Show("This login already exists!", "Error");
                return;
            }
            int res = DB.InsertAdmin(loginBox.Text, passwordBox.Text);
            int id = DB.CheckAdminLogin(loginBox.Text);
            if (res == 1) DB.InsertLoging(1, id, 23);
            else DB.InsertLoging(1, id, 24);

            SchoolMain schoolMain = new SchoolMain(1, id, this.Size);
            FormAction.Open(this, schoolMain);
        }
    }
}
