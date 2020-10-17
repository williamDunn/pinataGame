//William Dunn - 275 - Assignment 9 / Pinata Game

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Pinata
    {

        public Point Middle { get; private set; }
        public double Angle { get; private set; }
        public double Length { get; private set; }

        private Pen pen;
        private Pen eraserPen;
        private Brush circleBrush;
        private double minAngle;
        private double maxAngle;
        private double originalAngle;


        public Pinata(Point middle, double angle)
        {
            Middle = middle;
            Angle = angle;
            Length = 200;

            this.minAngle = 0;
            this.maxAngle = Math.PI;
            originalAngle = angle;

            pen = new Pen(Color.Black, 5);
            eraserPen = new Pen(SystemColors.Control, 5);
            circleBrush = new SolidBrush(Color.Black);
        }
        PointF endPoint;
        public void Draw(Graphics grp)
        {
            float width = (float)(Length * Math.Cos(Angle));
            float height = (float)(Length * Math.Sin(Angle));

            endPoint = new PointF(Middle.X + width, Middle.Y + height);

            grp.FillEllipse(circleBrush, endPoint.X - 20, endPoint.Y - 20, 60, 60);

            grp.DrawLine(pen, Middle, endPoint);

        }
        private bool swing = false;
        private double angle_change = 0.2;
        public void Move()
        {
            if (swing == false)
            {
                Angle += angle_change;
                if (Angle >= maxAngle)
                    swing = true;
            }
            else if (swing == true)
            {
                Angle += -angle_change;
                if (Angle <= minAngle)
                    swing = false;
            }
        }

        public void hit()
        {
            angle_change = +0.175;
            swing = false;
            
        }

        public PointF EndPoint
        {
            get
            {
                return endPoint;
            }
        }

        public void reset()
        {
            Angle = originalAngle;
            angle_change = 0.2;
            
        }
    }
}
