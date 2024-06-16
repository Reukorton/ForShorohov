using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shorohov.Service
{
    /// <summary>
    /// Класс с методами для расчетов значений.
    /// </summary>
    public static class Formuls
    {
        /// <summary>
        /// Формула расчета коэффициента трансформации трансформатора
        /// </summary>
        /// <param name="Vin_max">Максимальное входное напряжение</param>
        /// <param name="Vout">Выходное напряжение</param>
        /// <returns>Коэффициент трансформации трансформатора</returns>
        public static double NpNs(double Vin_max, double Vout)
        {
            return Vin_max / Vout;
        }

        /// <summary>
        /// Формула расчета сопротивления нагрузки
        /// </summary>
        /// <param name="Vout">Выходное напряжение</param>
        /// <param name="Iout">Выходной ток</param>
        /// <returns>Сопротивление нагрузки</returns>
        public static double Rn(double Vout, double Iout)
        {
            return Vout / Iout;
        }

        /// <summary>
        /// Формула расчета сопротивления нагрузки по переменному току
        /// </summary>
        /// <param name="NpNs">Коэффициент трансформации</param>
        /// <param name="Rn">Сопротивление нагрузки</param>
        /// <returns>Сопротивление нагрузки по переменному току</returns>
        public static double Rac(double NpNs, double Rn)
        {
            return (8 * Math.Pow(NpNs, 2) * Rn) / Math.Pow(Math.PI, 2);
        }

        /// <summary>
        /// Формула расчета коэффициента добротности
        /// </summary>
        /// <param name="NpNs">Коэффициент трансформации</param>
        /// <param name="Vout">Выходное напряжение</param>
        /// <param name="Vin_min">Минимальное входное напряжение</param>
        /// <param name="m">Коэффициент m</param>
        /// <returns>Коэффициент добротности</returns>
        public static double Q(double NpNs, double Vout, double Vin_min, double m)
        {
            double temp = Math.Pow((2 * NpNs * (Vout / Vin_min)), 2);

            return (1 / m) * Math.Sqrt((1 + m * (1 - (1 / temp))) / (temp - 1));
        }

        /// <summary>
        /// Формула расчета резонансной индуктинвости
        /// </summary>
        /// <param name="Cr">Резонансная емкость</param>
        /// <param name="f">Резонансная частота</param>
        /// <returns>Резонансная индуктинвость</returns>
        public static double Lr(double Cr, double f)
        {
            return 1 / (4 * Math.Pow(Math.PI, 2) * Cr * Math.Pow(10, -9) * Math.Pow(f, 2));
        }

        /// <summary>
        /// Формула расчета резонансной емкости
        /// </summary>
        /// <param name="f">Резонансная частота</param>
        /// <param name="Q">Коэффициент добротности</param>
        /// <param name="Rac">Сопротивление нагрузки по переменному току</param>
        /// <returns>Резонансная емкость</returns>
        public static double Cr(double f, double Q, double Rac)
        {
            return 1 / (2 * Math.PI * f * Q * Rac);
        }

        /// <summary>
        /// Формула расчета индуктивности намагничивания
        /// </summary>
        /// <param name="Lr">Резонансная индуктинвость</param>
        /// <param name="m">Коэффициент m</param>
        /// <returns>Индуктивность намагничивания</returns>
        public static double Lm(double Lr, double m)
        {
            return Lr * m;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NpNs"></param>
        /// <param name="Vout"></param>
        /// <param name="Iout"></param>
        /// <param name="f"></param>
        /// <param name="Cr"></param>
        /// <returns></returns>
        public static double Vcr_max(double NpNs, double Vout, double Iout, double f, double Cr)
        {
            return NpNs * Vout + Iout / (4 * NpNs * f * Cr);
        }
    }
}
