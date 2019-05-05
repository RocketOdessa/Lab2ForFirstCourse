using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МОЯПОПЫТКАНОМЕР
{
    class Parallelepiped : Rectangle
    {
        private double height_of_parallelepiped;
        private double heightBase;
        private double widthBase;

        public double Height_of_paralle
        {
            get => height_of_parallelepiped; set => height_of_parallelepiped = value;
        }
        public double HeightBase { get => heightBase; set => heightBase = value; }
        public double WidthBase { get => widthBase; set => widthBase = value; }

        public Parallelepiped()
        {
        }
        public Parallelepiped(double height_of_parallelepiped, double width)
        {
            base.Width = width;
            Height_of_paralle = height_of_parallelepiped;
        }
        public Parallelepiped(double height_of_parallelepiped, double width, double height)
        {
            base.Height = height;
            base.Width = width;
            Height_of_paralle = height_of_parallelepiped;
        }

        public double Get_Volume()
        {
            double volume = HeightBase * WidthBase * Height_of_paralle;

            return volume;
        }
        public override double Get_Square()
        {
            return HeightBase * WidthBase ;
        }

        new public string ToString()
        {
            return "Height of parallelepiped - " + Height_of_paralle + "\n Volume - " + Get_Volume() +
                "\nSquare of parallelepiped - " + Get_Square();
        }
    }
}
