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
    public partial class SchoolMain : Form
    {
        public int Type { get; }
        public int Id { get; }
        public SchoolMain(int type, int id, Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
            Type = type;
            Id = id;
            
        }

        private void SchoolMain_Load(object sender, EventArgs e)
        {
            loginLabel.Text = DB.SelectLogin(Type, Id);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            User user = new User(Type, Id, this.Size);
            FormAction.Open(this, user);
        }

        private void coachButton_Click(object sender, EventArgs e)
        {
            Coach coach = new Coach(Type, Id, this.Size);
            FormAction.Open(this, coach);

        }

        private void TeamButton_Click(object sender, EventArgs e)
        {
            Team team = new Team(Type, Id, this.Size);
            FormAction.Open(this, team);
        }

        private void subscriptionButton_Click(object sender, EventArgs e)
        {
            Subscription subscription = new Subscription(Type, Id, this.Size);
            FormAction.Open(this, subscription);
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule(Type, Id, this.Size);
            FormAction.Open(this, schedule);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            beginForm b = new beginForm(this.Size);
            FormAction.Open(this, b);
        }
    }
}
