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
    public partial class beginForm : Form
    {
        public beginForm(Size size)
        {
            InitializeComponent();
            Size = size;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
           OpenGoinOrRegistr(1);
        }

        private void coachButton_Click(object sender, EventArgs e)
        {
            OpenGoinOrRegistr(2);
        }

        private void dancerButton_Click(object sender, EventArgs e)
        {
            OpenGoinOrRegistr(3);
        }

        private void OpenGoinOrRegistr(int typeUser)
        {
            GoinOrRegistr goinOrRegistr = new GoinOrRegistr(typeUser, this.Size);
            FormAction.Open(this, goinOrRegistr);
        }
    }
}
