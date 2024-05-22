using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shorohov.Service
{
    /// <summary>
    /// Статический класс с методами проверок
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверка, что число является неотрицательным
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="propertyName">Название переменной</param>
        /// <exception cref="ArgumentException">Ошибка</exception>
        public static void AssertNumberIsNotNegative(double value, string propertyName)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"{propertyName} не должно быть меньше 0");
            }
        }

        /// <summary>
        /// Провнерка, что строка является вещественным числом
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="propertyName">Название переменной</param>
        /// <exception cref="ArgumentException">Ошибка</exception>
        public static void AssertStringIsNumber(string value, string propertyName)
        {
            if (value.GetType() == typeof(double))
            {
                throw new ArgumentException(
                    $"{propertyName} не является числом");
            }
        }
    }
}
