using System;

namespace Exercise
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            this.X = x; this.Y = y;
        }
        public string Print()
        {
            string result = "x: " + this.X + "\r\ny: " + this.Y + "\r\nrho: " + Rho() + "\r\ntheta: " + Theta();

            string[] lines = result.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                result.ToString();
            }
            return result;
        }
        public double Rho()
        {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
        }
        public double Theta()
        {
            return Math.Atan2(this.Y, this.X);
        }
        public double Distance(Point p2)
        {
            return this.VectorTo(p2).Rho();
        }
        public Point VectorTo(Point p2)
        {
            return new Point(p2.X - this.X, p2.Y - this.Y);
        }
        public void Translate(double dx, double dy)
        {
            this.X += dx;
            this.Y += dy;
        }
        public void Scale(double factor)
        {
            this.X *= factor;
            this.Y *= factor;
        }
        public void CentreRotate(double angle)
        {
            Point origin = new Point(0,0);
            origin.X = this.Rho() * Math.Cos(this.Theta() + angle);
            origin.Y = this.Rho() * Math.Sin(this.Theta() + angle);
            this.X = origin.X;
            this.Y = origin.Y;
        }
        public void Rotate(Point p, double angle)
        {
            this.Translate(-p.X, -p.Y);
            this.CentreRotate(angle);
            this.Translate(p.X, p.Y);
        }
    }
}
