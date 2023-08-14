using Mindbox_lib.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_lib.Models
{
    /// <summary>
    /// Реализация окружности
    /// </summary>
    public class Circle : Shape, ICircle
    {
        // Распаковываем аргумент, который передали в конструктор
        public double Radius { get => (double) base.InputParam; }

        public Circle(double radius) : base(radius) { }

        public override double CalculateArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override bool IsInputDataValid()
        {
            return Radius <= 0 ? false : true;
        }
    }
}
