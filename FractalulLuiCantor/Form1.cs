using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalulLuiCantor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        PointF A, B;
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
           

        }

        private void ButtonDesenare_Click(object sender, EventArgs e)
        {
            grp.Clear(pictureBox.BackColor);
            int length = int.Parse(textBoxLinitial.Text);
            A = new PointF(25, 25);
            B = new PointF(A.X + length, 25);
          //  grp.DrawLine(new Pen(Color.Red, 5), A, B);

            Cantor(A, B, (float)length, 50);

        }

        private  void Cantor(PointF A, PointF B, float  length,  int gap)
        {
            if (length < 1)
                return;
            grp.DrawLine(new Pen(Color.Red, 5), A, B);
            pictureBox.Image = bmp;
            Cantor(new PointF(A.X,A.Y+gap), new PointF(A.X + length / 3, A.Y + gap), length / 3, gap);
            Cantor(new PointF(B.X - length / 3, B.Y + gap), new PointF(B.X, B.Y + gap), length / 3, gap);
        }

    }
}
