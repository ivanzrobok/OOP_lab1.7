using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1._7
{
    public class PointsTriangle
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Triangle
    {
        private double ab, bc, ca;
        PointsTriangle[] point;
        public bool InIt(PointsTriangle[] point)
        {
            if (point.Length != 3)
                throw new ArgumentException($"Трикуткик {point} містить більше чим три точки");
            else
            {
                this.point = point;
                return true;
            }
        }
        public double Area()
        {
            if (InIt(point))
                return Math.Abs(((point[2].Y - point[0].Y) * (point[1].X - point[0].X)) -
                    ((point[2].X - point[0].X) * (point[1].Y - point[0].Y))) / 2;
            throw new ArgumentException();
        }
        public double Perimetr()
        {
            if (InIt(point))
            {
                ab = Math.Pow(Math.Pow(point[1].X - point[0].X, 2) + Math.Pow(point[1].Y - point[0].Y, 2), 0.5);
                bc = Math.Pow(Math.Pow(point[1].X - point[2].X, 2) + Math.Pow(point[1].Y - point[2].Y, 2), 0.5);
                ca = Math.Pow(Math.Pow(point[2].X - point[0].X, 2) + Math.Pow(point[2].Y - point[0].Y, 2), 0.5);
                return ab + bc + ca;
            }
            throw new ArgumentException();
        }
        public string Type()
        {
            if (InIt(point))
            {
                Perimetr();
                if (ab == bc && bc == ca) return "Трикутник рівносторонній";
                if (ab == bc || bc == ca) return "Трикутник рівнобедрений";
                if (ca * ca == Math.Abs(bc * bc - ab * ab) ||
                    bc * bc == Math.Abs(ca * ca - ab * ab)
                    || ab * ab == Math.Abs(ca * ca - bc * bc))
                    return "Трикутник прямокутний";
                return "Ткикутник має різні кути";
            }
            throw new ArgumentException();
        }
        public void Display()
        {
            Console.WriteLine("Площа - " + Area());
            Console.WriteLine("Периметр - " + Perimetr());
            Console.WriteLine("Тип трикутника - " + Type());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            PointsTriangle[] point1 = new PointsTriangle[]
             {
                new PointsTriangle{X = 0, Y = 4},
                new PointsTriangle{X = 0, Y = 0},
                new PointsTriangle{X= 3, Y = 0}
            };
            Triangle triangle = new Triangle();
            triangle.InIt(point1);
            
            triangle.Display();
        }
    }
}
