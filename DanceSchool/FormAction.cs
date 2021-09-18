using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanceSchool
{
    static public class FormAction
    {
        public static string picturePath = "C:\\Users\\mita_razets\\source\\repos\\DanceSchool\\DanceSchool\\picture\\";
        public static void Open(Form current, Form open)
        {
            current.Hide();
            open.ShowDialog();
            current.Close();
        }

        public static void SetPicture(string path, PictureBox pictureBox)
        {
            Bitmap image = new Bitmap(path);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Image = image;
        }
    }
}
