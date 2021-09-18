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
    public partial class Team : Form
    {
        public int Type { get; }
        public int Id { get; }
        private List<List<string>> ranks = new List<List<string>>();
        private int index = 0;
        public Team(int type, int id, Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
            Type = type;
            Id = id;
           
        }

        private void Team_Load(object sender, EventArgs e)
        {
            if (Type != 3)
            {
                button4.Visible = false;
                button4.Enabled = false;
            }
            ranks = DB.SelectAllRank();
            if (ranks is null) DB.InsertLoging(Type, Id, 33);
            else DB.InsertLoging(Type, Id, 32);
            SetParam();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SchoolMain school = new SchoolMain(Type, Id, this.Size);
            FormAction.Open(this, school);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SetParam()
        {
            rankLabel.Text = ranks[index][1];
            if (!string.IsNullOrEmpty(ranks[index][2]))
            {
                aboutBox.Text = ranks[index][2];
            }
            if (!string.IsNullOrEmpty(ranks[index][3]))
            {
                string path = FormAction.picturePath + ranks[index][3];
                FormAction.SetPicture(path, pictureBox1);
            }
            couchLabel.Text = ranks[index][4] + " " + ranks[index][5];
            if (!string.IsNullOrEmpty(ranks[index][6]))
            {
                string path = FormAction.picturePath + ranks[index][6];
                FormAction.SetPicture(path, pictureBox2);
            }
        }

        private void prevBox_Click(object sender, EventArgs e)
        {
            if (index == 0) index = ranks.Count - 1;
            else index--;
            SetParam();
        }

        private void nextBox_Click(object sender, EventArgs e)
        {
            if (index == ranks.Count - 1) index = 0;
            else index++;
            SetParam();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Type == 3)
            {
                if (beginerradioButton.Visible == false)
                {
                    beginerradioButton.Visible = true;
                    continueButton.Visible = true;
                    proradioButton.Visible = true;
                    MessageBox.Show("Choose level!");
                }
                else
                {
                    string level = string.Empty;
                    if (beginerradioButton.Checked) level = "Beginer";
                    else if (continueButton.Checked) level = "Continue";
                    else if (proradioButton.Checked) level = "Pro";

                    if (DB.InsertDancerTeam(rankLabel.Text + " " + level, Convert.ToInt32(ranks[index][7]), Id) == 1)
                    {
                        MessageBox.Show("Success!");
                        DB.InsertLoging(Type, Id, 34);
                    }

                    else
                    {
                        MessageBox.Show("Error!");
                        DB.InsertLoging(Type, Id, 35);
                    }
                }
            }
        }

        private void couchLabel_Click(object sender, EventArgs e)
        {
            string[] fullname = couchLabel.Text.Split();
            string name = fullname[0];
            string surname = fullname[1];
            int idCoach = DB.SelectOneCoach(name, surname);
            Coach coach = new Coach(idCoach, this.Size);
            FormAction.Open(this, coach);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string[] fullname = couchLabel.Text.Split();
            string name = fullname[0];
            string surname = fullname[1];
            int idCoach = DB.SelectOneCoach(name, surname);
            Coach coach = new Coach(idCoach, this.Size);
            FormAction.Open(this, coach);
        }
    }
}
