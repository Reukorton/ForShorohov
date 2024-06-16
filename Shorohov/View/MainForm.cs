using Shorohov.Service;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms.DataVisualization.Charting;
using Shorohov.View;

namespace Shorohov
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        // Все переменные в программе
        // Технические параметры
        private double Vout;
        private double Vin_min;
        private double Vin_max;
        private double Iout;
        private double f;
        private double m;
        //-----------------------
        // Рассчитанные параметры
        private double NpNs;
        private double Rn;
        private double Rac;
        private double Q;
        private double Lr;
        private double Cr;
        private double Lm;


        public MainForm()
        {
            InitializeComponent();

            NULL_Labels();
        }

        /// <summary>
        /// Делает labels пустыми в рассчитываемых параметрах
        /// </summary>
        public void NULL_Labels()
        {
            NpNs_Label.Text = "";
            Q_Label.Text = "";
            Rn_Label.Text = "";
            Rac_Label.Text = "";
            Lr_Label.Text = "";
            Lm_Label.Text = "";
        }

        /// <summary>
        /// Проверка на правильность ввода данных
        /// </summary>
        /// <returns>true если все данные введены верно <br/>
        ///          false если данные введены неверно</returns>
        public bool CheckingAllValues()
        {
            if (
                Vout_TextBox.BackColor == _correctColor &&
                VinMin_TextBox.BackColor == _correctColor &&
                VinMax_TextBox.BackColor == _correctColor &&
                Iout_TextBox.BackColor == _correctColor &&
                F_TextBox.BackColor == _correctColor &&
                M_TextBox.BackColor == _correctColor
                )
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Считывание данных из полей технических характеристик
        /// </summary>
        public void ReadingData()
        {
            Vout = double.Parse(Vout_TextBox.Text);
            Vin_min = double.Parse(VinMin_TextBox.Text);
            Vin_max = double.Parse(VinMax_TextBox.Text);
            Iout = double.Parse(Iout_TextBox.Text);
            f = double.Parse(F_TextBox.Text);
            m = double.Parse(M_TextBox.Text);
            Cr = double.Parse(Cr_TextBox.Text);
        }

        public void ReadingDataForChart()
        {
            Vout = double.Parse(Vout_TextBox.Text);
            Vin_min = double.Parse(VinMin_TextBox.Text);
            Vin_max = double.Parse(VinMax_TextBox.Text);
            Iout = double.Parse(Iout_TextBox.Text);
            f = double.Parse(F_TextBox.Text);
        }

        /// <summary>
        /// Расчет выходных параметров
        /// </summary>
        public void CalculationValues()
        {
            NpNs = Formuls.NpNs(Vin_max, Vout);
            Q = Formuls.Q(NpNs, Vout, Vin_min, m);
            Rn = Formuls.Rn(Vout, Iout);
            Rac = Formuls.Rac(NpNs, Rn);
            Lr = Formuls.Lr(Cr, f);
            Lm = Formuls.Lm(Lr, m);
        }

        /// <summary>
        /// Обновление лэйблов выходных параметров
        /// </summary>
        public void UpdatingLabels()
        {
            NpNs_Label.Text = Math.Round(NpNs, 2).ToString();
            Q_Label.Text = Math.Round(Q, 2).ToString();
            Rn_Label.Text = Math.Round(Rn, 2).ToString() + " Ом";
            Rac_Label.Text = Math.Round(Rac, 2).ToString() + " Ом";
            Lr_Label.Text = Math.Round(Lr * Math.Pow(10, 6), 2).ToString() + " мкГн";
            Lm_Label.Text = Math.Round(Lm * Math.Pow(10, 6), 2).ToString() + " мкГн";
        }

        /// <summary>
        /// Перекраска textbox в зависимости от введенных данных
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private new void TextChanged(object sender, EventArgs e)
        {
            TextBox thisTextBox = (TextBox)sender;
            string textThisElementForm = thisTextBox.Text;

            try
            {
                Validator.AssertStringIsNumber(textThisElementForm, $"{thisTextBox.Name}");
                Validator.AssertNumberIsNotNegative(double.Parse(textThisElementForm), $"{thisTextBox.Name}");
            }
            catch
            {
                thisTextBox.BackColor = _errorColor;
                return;
            }

            thisTextBox.BackColor = _correctColor;
        }

        /// <summary>
        /// Логика кнопки "Расчитать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            if (CheckingAllValues())
            {
                ReadingData();
                CalculationValues();
                UpdatingLabels();
            }
            else
            {
                NULL_Labels();
                MessageBox.Show("Введены некоректные значения или не введены совсем.");
            }
        }

        private void ChartOpenWindowButton_Click(object sender, EventArgs e)
        {
            ReadingDataForChart();

            ChartWindow chart = new ChartWindow(Formuls.NpNs(Vin_max, Vout), this.Vout, this.Iout, this.f);

            Calculate_Button.Enabled = true;

            chart.Show();
        }
    }
}
