﻿using Shorohov.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shorohov.View
{
    public partial class ChartWindow : Form
    {
        private double a, b, d;
        private double x, y;

        private double _NpNs;
        private double _Vout;
        private double _Iout;
        private double _f;
        private double _Cr;

        public ChartWindow(double NpNs, double Vout, double Iout, double f, double Cr)
        {
            InitializeComponent();
            _NpNs = NpNs;
            _Vout = Vout;
            _Iout = Iout;
            _f = f;
            _Cr = Cr;

            this.chart1.ChartAreas[0].AxisX.Title = "Емкость резонанского контура (нф)";
            this.chart1.ChartAreas[0].AxisY.Title = "Напряжение на резонансном конденсаторе Vcr (max) (B)";
            this.chart1.ChartAreas[0].AxisX.Interval = 1000;
            this.chart1.ChartAreas[0].AxisY.Interval = 5;
        }

        private void BuildingChartButton_Click(object sender, EventArgs e)
        {

            a = 1010;
            b = 10010;
            d = 10;
            x = a;

            while (x <= b)
            {
                y = Formuls.Vcr_max(_NpNs, _Vout, _Iout, _f, x * Math.Pow(10, -9));
                this.chart1.Series[0].Points.AddXY(x, y);
                x += d;
            }
        }
    }
}