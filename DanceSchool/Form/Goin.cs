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

namespace DanceSchool
{
    public partial class Goin : Form
    {
        public int Type { get; }
        private int id = -1;
        public Goin(int type, Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
            Type = type;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoinOrRegistr gor = new GoinOrRegistr(Type, this.Size);
            FormAction.Open(this, gor);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            int logT = 0, logF = 0;
            if (Type == 1)
            {
                logT = 8;
                logF = 5;
            }
            else if (Type == 2)
            {
                logT = 6;
                logF = 9;
            }
            else if (Type == 3)
            {
                logT = 7;
                logF = 21;
            }

            id = DB.GoIn(Type, loginBox.Text, passwordBox.Text);
            if (id == -1)
            {
                MessageBox.Show("Login or password entered incorrectly!", "Error");
                DB.InsertLoging(Type, id, logF);
                return;
            }
            DB.InsertLoging(Type, id, logT);
            SchoolMain schoolMain = new SchoolMain(Type,id, this.Size);
            FormAction.Open(this, schoolMain);

        }

        private void Goin_Load(object sender, EventArgs e)
        {

        }
    }
}
