namespace Mindbox_lib.Models
{
    public abstract class Shape
    {
        // Базовый класс фигуры, определяющий общий набор методов, которые они должны реализовать

        public object InputParam { get; init; }

        public Shape(object inputParam)
        {
            InputParam = inputParam;

            if (!IsInputDataValid())
            {
                throw new ArgumentException("Получены некорретные входные параметры");
            }
        }

        /// <summary>
        /// Рассчитывает площадь фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateArea();

        /// <summary>
        /// Проверяет входные данные на корректность
        /// </summary>
        /// <returns></returns>
        public abstract bool IsInputDataValid();
    }
}