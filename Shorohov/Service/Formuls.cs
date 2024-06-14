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
        /// <param name="Vin_nom">Номинальное входное напряжение</param>
        /// <param name="Vout">Выходное напряжение</param>
        /// <returns>Коэффициент трансформации трансформатора</returns>
        public static double NpNs(double Vin_max, double Vout)
        {
            return Vin_max / Vout;
        }

        public static double Rn(double Vout, double Iout)
        {
            return Vout / Iout;
        }

        public static double Rac(double NpNs, double Rn)
        {
            return (8 * Math.Pow(NpNs, 2) * Rn) / Math.Pow(Math.PI, 2);
        }

        public static double Q(double NpNs, double Vout, double Vin_min, double m)
        {
            double temp = Math.Pow((2 * NpNs * (Vout / Vin_min)), 2);

            return (1 / m) * Math.Sqrt((1 + m * (1 - (1 / temp))) / (temp - 1));
        }

        public static double Lr(double Q, double Rac, double f)
        {
            return (Q * Rac) / (2 * Math.PI * f);
        }

        public static double Cr(double f, double Q, double Rac)
        {
            return 1 / (2 * Math.PI * f * Q * Rac);
        }

        public static double Lm(double Lr, double m)
        {
            return Lr * m;
        }
    }
}
