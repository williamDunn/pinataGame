//William Dunn - 275 - Assignment 9 / Pinata Game

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Bat
    {
        public Point Middle { get; private set; }
        public double Angle { get; private set; }
        public double Length { get; private set; }

        private Pen pen;
        private Pen eraserPen;

        private double angle_change = 0.5;
        private double originalAngle;
        private double maxAngle = -21.5;

        public Bat(Point middle, double angle)
        {
            Middle = middle;
            Angle = angle;
            Length = 210;

            originalAngle = angle;

            pen = new Pen(Color.Maroon, 5);
            eraserPen = new Pen(SystemColors.Control, 5);
        }

        PointF endPoint;

        public void draw(Graphics grp)
        {
            float width = (float)(Length * Math.Cos(Angle));
            float height = (float)(Length * Math.Sin(Angle));

            endPoint = new PointF(Middle.X + width, Middle.Y + height);

            grp.DrawLine(pen, Middle, endPoint);
        }

        private bool forward = true;

        private bool swing = false;
        public void move()
        {
            if (swing == false)
            {
                Angle -= angle_change;
                if (Angle <= maxAngle)
                {
                    swing = true;
                }
            }
            else if(swing == true && Angle == maxAngle)
            {
                Angle = originalAngle;
                swing = false;
            }     
        }

        private bool collision = false;

        public bool swinging()
        {
            if(Angle != originalAngle)
            {
                return true;
            }
            else
            {
                collision = false;
                return false;
            }
        }

        public bool isCollision(Pinata pinata)
        {
            float distance = (float)Math.Sqrt((Math.Pow(endPoint.X - pinata.EndPoint.X, 2)) + (Math.Pow(endPoint.Y - pinata.EndPoint.Y, 2)));
            float ellipse = 30;

            if (distance <= ellipse && forward && !collision)
            {
                collision = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
