using Mindbox_lib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_lib.Models
{
    /// <summary>
    /// Реализация треугольника в соответствии с базовым классом и интерфейсом
    /// </summary>
    public class Triangle : Shape, ITriangle
    {
        public List<double> Sides { get => (List<double>)base.InputParam; }

        public Triangle(List<double> sides) : base(sides) { }

        
        public override double CalculateArea()
        {
            //полупериметр
            var p = Sides.Sum() / 2;

            //площадь
            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }

        
        public override bool IsInputDataValid()
        {
            if (Sides.Count() != 3)
            {
                throw new ArgumentException("Фигура не может иметь количество сторон, отличное от трёх");
            }

            // Если сумма 2 сторон меньше, чем самая большая сторона, то это не треугольник
            var sortedSides = Sides.OrderByDescending(x => x).ToArray();

            if (sortedSides[1] + sortedSides[2] <= sortedSides[0])
            {
                throw new ArgumentException("Треугольник с данными сторонами не существует");
            }

            return true;

        }

        public bool IsRightTriangle()
        {
            return Sides.Distinct().Count() == 1 ? true : false;
        }

        public bool IsRectangular()
        {
            var sortedSides = Sides.OrderByDescending(x => x).ToArray();

            //По Пифагору
            return Math.Sqrt(Math.Pow(sortedSides[1], 2) + Math.Pow(sortedSides[2], 2)) == sortedSides[0] ? true : false;
        }
    }
}
