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
    public partial class User : Form
    {
        public int Type { get; }
        public int Id { get; }
        public User(int type, int id, Size size)
        {
            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
            Type = type;
            Id = id;
        }

        private void User_Load(object sender, EventArgs e)
        {
            object user = DB.SelectAllFromUser(Type, Id);
            if (Type == 1)
            {
                nameBox.Visible = false;
                nameLabel.Visible = false;
                surnameLabel.Visible = false;
                surnameBox.Visible = false;
                aboutLable.Visible = false;
                richTextBox1.Visible = false;
                Admin admin = (Admin)user;
                loginBox.Text = admin.Login;
            }
            if (Type == 2)
            {
                CoachU coach = (CoachU)user;
                nameBox.Text = coach.Name;
                surnameBox.Text = coach.Surname;
                richTextBox1.Text = coach.About;
                loginBox.Text = coach.Login;
            }
            if (Type == 3)
            {
                Dancer dancer = (Dancer)user;
                nameBox.Text = dancer.Name;
                surnameBox.Text = dancer.Surname;

                aboutLable.Visible = false;
                richTextBox1.Visible = false;
                loginBox.Text = dancer.Login;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SchoolMain school = new SchoolMain(Type, Id, this.Size);
            FormAction.Open(this, school);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            int res = -1;
            if (Type == 1){ res =DB.UpdateAdmin(Id, loginBox.Text); }
            if (Type == 2) { res = DB.UpdateCoach(Id, loginBox.Text, nameBox.Text, surnameBox.Text, richTextBox1.Text); }
            if (Type == 3) { res = DB.UpdateDancer(Id, loginBox.Text, nameBox.Text, surnameBox.Text); }
            if (res == 1) DB.InsertLoging(Type, Id, 30);
            else DB.InsertLoging(Type, Id, 31);

        }

        private void LoginLable_Click(object sender, EventArgs e)
        {

        }
    }
}
