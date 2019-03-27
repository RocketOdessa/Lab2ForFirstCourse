using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МОЯПОПЫТКАНОМЕР
{
    class Rectangle
    {
        private double width;
        private double height;

        public double Height { get => height; set => height = value >= 0 ? value : 0;}
        public double Width { get => width; set => width = value >= 0 ? value : 0; }
        
        public Rectangle()
        {
        }

        public Rectangle(double width)
        {
            Width = width;
        }
        public Rectangle(double width, double height)
        {
            Height = height;
            Width = width;
        }

        public virtual double Get_Square()
        {
            double square = (width * height);
            return square;
        }

        public double Get_Perimeter()
        {
            double perimeter = ((width + height) * 2);           
            return perimeter;
        }

        public double Get_Diag()
        {
            double diagonal = Math.Sqrt(width * width + height * height);
            return diagonal;
        }

        public override string ToString()
        {
            return $"Your width {Width}, your height {Height}, your perimeter {Get_Perimeter()}, your square {Get_Square()}," +
                $" your diagonal {Get_Diag()}";
        }

    }
}
