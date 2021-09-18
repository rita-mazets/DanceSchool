using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceSchool
{
    public partial class Coach : Form
    {
        public int Type { get; }
        public int Id { get; }
        List<CoachU> Coaches = new List<CoachU>();
        private string picturePath = "C:\\Users\\mita_razets\\source\\repos\\DanceSchool\\DanceSchool\\picture\\";
        private int index = 0;
        public Coach(int type, int id, Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
            Type = type;
            Id = id;
            Coaches = DB.SelectAllCoach();
            if (Coaches is null)
            {
                DB.InsertLoging(Type, Id, 44);
            }
            else 
            {
                DB.InsertLoging(Type, Id, 42);
            }
        }

        public Coach( int id, Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
            Type = 2;
            Id = id;
            Coaches = DB.SelectOneCoachFullInformation(id);
            if (Coaches is null)
            {
                DB.InsertLoging(Type, Id, 44);
            }
            else
            {
                DB.InsertLoging(Type, Id, 42);
            }
        }

        private void Coach_Load(object sender, EventArgs e)
        {
            string path = picturePath + Coaches[index].Picture;
            FormAction.SetPicture(path, pictureBox1);
            SetParam();
        }

        private void prevBox_Click(object sender, EventArgs e)
        {
            if (index == 0) index = Coaches.Count - 1;
            else index--;
            string path = picturePath + Coaches[index].Picture;
            FormAction.SetPicture(path, pictureBox1);
            SetParam();
        }

        private void nextBox_Click(object sender, EventArgs e)
        {
            if (index == Coaches.Count - 1) index = 0;
            else index++;
            string path = picturePath + Coaches[index].Picture;
            FormAction.SetPicture(path, pictureBox1);
            SetParam();
        }

        private void SetParam()
        {
            LoginLable.Text = Coaches[index].Login;
            nameLabel.Text = Coaches[index].Name + " " + Coaches[index].Surname;
            aboutBox.Text = Coaches[index].About;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SchoolMain school = new SchoolMain(Type, Id, this.Size);
            FormAction.Open(this, school);
        }
    }
}
