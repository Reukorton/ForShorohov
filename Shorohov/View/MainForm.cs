using Shorohov.Service;
using System.ComponentModel.Design;

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
        private double Vout;
        private double Vin_min;
        private double Vin_max;
        private double Vin_nom;
        private double Pout;
        private double NpNs;
        private double M_max;
        private double M_min;
        private double Rac_min;

        public MainForm()
        {
            InitializeComponent();

            NpNs_Label.Text = "";
            MMax_Label.Text = "";
            MMin_Label.Text = "";
            RacMin_Label.Text = "";
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
                VinNom_TextBox.BackColor == _correctColor &&
                Pout_TextBox.BackColor == _correctColor
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
            Vin_nom = double.Parse(VinNom_TextBox.Text);
            Pout = double.Parse(Pout_TextBox.Text);
        }

        /// <summary>
        /// Расчет выходных параметров
        /// </summary>
        public void CalculationValues()
        {
            NpNs = Double.Round(Formuls.NpNs(Vin_nom, Vout), 4);
            M_max = Double.Round(Formuls.M(Vin_nom, Vin_max), 4);
            M_min = Double.Round(Formuls.M(Vin_nom, Vin_min), 4);
            Rac_min = Double.Round(Formuls.Rac_min(NpNs, Vout, Pout), 4);
        }

        /// <summary>
        /// Обновление лэйблов выходных параметров
        /// </summary>
        public void UpdatingLabels()
        {
            NpNs_Label.Text = NpNs.ToString();
            MMax_Label.Text = M_max.ToString();
            MMin_Label.Text = M_min.ToString();
            RacMin_Label.Text = Rac_min.ToString() + " Ом";
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
                Validator.AssertStringIsNumber(textThisElementForm, $"");
                Validator.AssertNumberIsNotNegative(double.Parse(textThisElementForm), $"");
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
            else MessageBox.Show("Введены некоректные значения или не введены совсем.");
        }
    }
}
