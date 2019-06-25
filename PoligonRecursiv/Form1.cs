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
namespace PoligonRecursiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        PointF[] pointArr;
        int n;
        private void ReadPoints(float v)
        {
            using (StreamReader reader = new StreamReader(@"../../date.in"))
            {
                string text = reader.ReadToEnd();
                string[] tokens = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                pointArr = new PointF[tokens.Length];
                for(int i=0;i<tokens.Length;i++)
                {
                    string[] pointTokens = tokens[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    float x = float.Parse(pointTokens[0]);
                    float y = float.Parse(pointTokens[1]);
                    pointArr[i] = new PointF(x*v, y*v);
                }

            }
        }
      
        Pen p = new Pen(Color.Black);
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            
            ReadPoints(4.5f);
          
            n = pointArr.Length;
            Poligon(pointArr);



            pictureBox.Image = bmp;
        }
        public PointF Mij(PointF A, PointF B)
        {
            float newX = (A.X + B.X) / 2;
            float newY = (A.Y + B.Y) / 2;
            return new PointF(newX, newY);
        }
        public float SqDist(PointF A,PointF B)
        {
            return (B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y);
        }
        public void Poligon(PointF[] pointArr)
        {
            if (SqDist(pointArr[0], pointArr[n - 1]) == 0)
            {
                MessageBox.Show(pointArr[0].ToString());
                return;
            }
            else
            {
                grp.DrawPolygon(p, pointArr);
                PointF[] newArray = new PointF[n];
                for (int i = 0; i < n - 1; i++)
                    newArray[i] = Mij(pointArr[i], pointArr[i + 1]);
                newArray[n - 1] = Mij(pointArr[0], pointArr[n - 1]);
                Poligon(newArray);
            }
        }

    }
}
