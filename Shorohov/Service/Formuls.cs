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
        /// Коэффициент усиления напряжения, const
        /// </summary>
        private const double Mnom = 1;

        /// <summary>
        /// Формула расчета коэффициента трансформации трансформатора
        /// </summary>
        /// <param name="Vin_nom">Номинальное входное напряжение</param>
        /// <param name="Vout">Выходное напряжение</param>
        /// <returns>Коэффициент трансформации трансформатора</returns>
        public static double NpNs(double Vin_nom, double Vout)
        {
            return Vin_nom / Vout * Mnom;
        }

        /// <summary>
        /// Формула расчета коэффициента усиления напряжения
        /// </summary>
        /// <param name="Vin_nom">Номинальное входное напряжение</param>
        /// <param name="Vin">Входное напряжение</param>
        /// <returns>Коэффициент усиления напряжения</returns>
        public static double M(double Vin_nom, double Vin)
        {
            return (Vin_nom / Vin) * Mnom;
        }

        /// <summary>
        /// Формула расчета сопротивления отраженной нагрузки
        /// </summary>
        /// <param name="NpNs">Коэффициент трансформации трансформатора</param>
        /// <param name="Vout">Выходное напряжение</param>
        /// <param name="Pout">Выходная мощность</param>
        /// <returns>Сопротивление отраженной нагрузки</returns>
        public static double Rac_min(double NpNs, double Vout, double Pout)
        {
            return (8 / Math.Pow(Math.PI, 2) * Math.Pow(NpNs, 2) * (Math.Pow(Vout, 2) / Pout));
        }
    }
}
