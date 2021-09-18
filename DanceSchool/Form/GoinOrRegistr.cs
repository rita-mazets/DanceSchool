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
    public partial class GoinOrRegistr : Form
    {
        public int Type { get; }
        public GoinOrRegistr(int type, Size size)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Size = size;
            Type = type;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            beginForm begF = new beginForm(this.Size);
            FormAction.Open(this, begF);
        }

        private void GoinButton_Click(object sender, EventArgs e)
        {
            Goin goin = new Goin(Type, Size);
            FormAction.Open(this, goin);
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (Type == 1)
            {
                RegistrAdmin regA = new RegistrAdmin(Size);
                FormAction.Open(this, regA);
            }
            if (Type == 2)
            {
                RegistrCoach regC = new RegistrCoach(Size);
                FormAction.Open(this, regC);
            }
            if (Type == 3)
            {
                RegistrDancer regD = new RegistrDancer(Size);
                FormAction.Open(this, regD);
            }
        }
    }
}
