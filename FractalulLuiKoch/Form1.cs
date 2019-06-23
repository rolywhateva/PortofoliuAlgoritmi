using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalulLuiKoch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
        }
     
        private void ButtonDesenare_Click(object sender, EventArgs e)
        {
            pictureBox.BackColor = Color.Black;
            float startX1, startY, startX3;
            startY = pictureBox.Height * 2 / 3;
            startX1 = pictureBox.Width * 1 / 3;
            startX3 = pictureBox.Width * 2 / 3;
            PointF startPoint1, startPoint2, startPoint3;
            startPoint1 = new PointF(startX1, startY);
            startPoint3 = new PointF(startX3, startY);
            startPoint2 = RotirePunct(startPoint3, startPoint1, 60f);
           
            grp.DrawPolygon(p, new PointF[] { startPoint1, startPoint2, startPoint3 });
            grp.FillPolygon(new SolidBrush(Color.LightBlue) , new PointF[]{ startPoint1, startPoint2, startPoint3 });
            Koch(startPoint1, startPoint2, startPoint3);
            PointF mij = PunctRaport(startPoint1, startPoint2, 0.5f);
            PointF mij2 = PunctRaport(startPoint1, startPoint2, 2);
           
            pictureBox.Image = bmp;
        }

        public  PointF RotirePunct(PointF O, PointF P , float v)
        {
            float newx, newy;
           double  angle = v * (Math.PI / 180.0);
            newx =(float)( O.X + (P.X - O.X) * Math.Cos(angle) - (P.Y - O.Y) * Math.Sin(angle));
            newy = (float)(O.Y + (P.X - O.X) * Math.Sin(angle) + (P.Y - O.Y) * Math.Cos(angle));
            return new PointF(newx, newy);
        }
        public  double Distance(PointF A, PointF B)
        {
            return Math.Sqrt((B.Y - A.Y) * (B.Y - A.Y) + (B.X - A.X) * (B.X - A.X));
        }
        public void Koch(PointF A, PointF B, PointF C)
        {
            CurbaKoch(A, B,1);
          CurbaKoch(A, C,-1);
           CurbaKoch(B, C,1);
        }
        public PointF PunctRaport(PointF A,  PointF B, float teta=1)
        {
            return new PointF((A.X + teta * B.X) / (1 + teta), (A.Y + teta * B.Y) / (1 + teta));

        }
        Pen p = new Pen(Color.LightBlue);
        public void CurbaKoch(PointF A, PointF B,int semn)
        {
            if (Distance(A, B) > 0.1f)
            {
                PointF C = PunctRaport(A, B, 0.5f);
                PointF D = PunctRaport(A, B, 2);
            
                PointF E = RotirePunct(C, D,-60f*semn);
              
              grp.DrawLine(p, C, E);
              grp.DrawLine(p, D, E);
                grp.FillPolygon(new SolidBrush(Color.LightBlue), new PointF[] { C, D, E });
                grp.DrawLine(new Pen(Color.LightBlue), C, D);

                CurbaKoch(C, E,semn);
                CurbaKoch(D, E,-semn);
                CurbaKoch(A, C,semn);
                CurbaKoch(D, B,semn);


            }

        }
    }
}
