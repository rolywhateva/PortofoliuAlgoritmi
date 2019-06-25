using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Intersectia_a_doua_drepte
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        PointF A, B, C, D;
        private void ReadPoints(float v)
        {
            using (StreamReader reader = new StreamReader(@"../../date.in"))
            {
                string[] tokens = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                A = new PointF(float.Parse(tokens[0]), float.Parse(tokens[1]));
                B = new PointF(float.Parse(tokens[2]), float.Parse(tokens[3]));
                tokens = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                C= new PointF(float.Parse(tokens[0]), float.Parse(tokens[1]));
                D = new PointF(float.Parse(tokens[2]), float.Parse(tokens[3]));


            }
        }
        Graphics grp;
        Bitmap bmp;
        public float Panta(PointF A, PointF B)
        {
            return (B.Y - A.Y) / (B.X - A.X);
        }
        public int Sign(float f)
        {
            if (f < 0) return -1;
            else
                return 1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            ReadPoints(1);
            grp.TranslateTransform(pictureBox.Width / 2, pictureBox.Height / 2);
            PointF inter = DrawIntersection(A, B, C, D);

            PointF p1 = new PointF();
            float AB = Panta(A, B);
            p1.X = 1000 * Sign(AB);
            p1.Y = AB  * p1.X - AB*A.X + A.Y;
            PointF p2 = new PointF();
            p2.X = 1000 * Sign(AB);
            p2.Y = AB * p2.X -AB* A.X + A.Y;
         
            grp.DrawLine(new Pen(Color.Black,5), A, inter);


           p1 = new PointF();
            float CD = Panta(C, D);
            p1.X = 1000;
            p1.Y = CD* p1.X -CD * C.X + C.Y;
   
            p2.X = 1000 * Sign(CD);
            p2.Y = CD * p2.X - CD * C.X + C.Y;
            grp.DrawLine(new Pen(Color.Black, 5),C,inter);
      




            grp.FillEllipse(new SolidBrush(Color.Red), inter.X, inter.Y, 10, 10);
            pictureBox.Image = bmp;

        }
       /// <summary>
       ///  solutia! 
       /// </summary>
       /// <param name="A"></param>
       /// <param name="B"></param>
       /// <param name="C"></param>
       /// <param name="D"></param>
       /// <returns></returns>
        public  PointF DrawIntersection(PointF A, PointF B,PointF C,PointF D)
        {
            float a = A.X - D.X;
            float b = A.Y - D.Y;
            float c = C.X - B.X;
            float d = C.Y - B.Y;
            float t1 = b * D.X - a * D.Y;
            float t2 = d * B.X - c * B.Y;
            float det = -b * c + d * a;
            if (det == 0)
            {
                throw new Exception();
            }
            float dx = -t1 * c + t2 * a;
            float dy = b * t2 - d * t1;
            float x = dx / det;
            float y = dy / det;
            return new PointF(x, y);
        }

    }
}
