#region

using System;
using System.ComponentModel;
using System.Windows.Forms;
using FuelCalculation;

#endregion

namespace TravelingSuccessCalculationView.Controls
{
    /// <summary>
    ///     Контрол, предназначеный для работы с объектом вертолёта, его добавлением или изменением.
    /// </summary>
    public partial class HelicopterControl : UserControl
    {
        #region - Private fields -

        /// <summary>
        ///     Переменная для передачи объекта вертолёта на контрол и обратно.
        /// </summary>
        private Helicopter _helicopter = new Helicopter();

        /// <summary>
        ///     Переменная, определяющая свойство ReadOnly у элементов на форме.
        /// </summary>
        private bool _readonly;

        #endregion

        #region - Properties -

        /// <summary>
        ///     Аксессор, для получения передаваемого объекта.
        /// </summary>
        [DefaultValue(null)]
        public Helicopter Helicopter
        {
            set
            {
                if (value == null)
                    return;
                _helicopter = value;
                TNameTextBox.Text = Convert.ToString(_helicopter.TransportName);
                WearRateTextBox.Text = Convert.ToString(_helicopter.WearRate);
                FuelWasteTextBox.Text = Convert.ToString(_helicopter.FuelWaste);
                SpeedTextBox.Text = Convert.ToString(_helicopter.Speed);
                TankVolumeTextBox.Text = Convert.ToString(_helicopter.TankVolume);
                MassTextBox.Text = Convert.ToString(_helicopter.Mass);
            }
            get
            {
                if (TNameTextBox.Text != "" && WearRateTextBox.Text != "" && FuelWasteTextBox.Text != "" &&
                    SpeedTextBox.Text != "" && TankVolumeTextBox.Text != "" && MassTextBox.Text != "")
                {
                    _helicopter.TransportName = TNameTextBox.Text;
                    _helicopter.WearRate = ConvertToDouble(WearRateTextBox.Text, "WearRate");
                    _helicopter.FuelWaste = ConvertToDouble(FuelWasteTextBox.Text, "FuelWaste");
                    _helicopter.Speed = ConvertToDouble(SpeedTextBox.Text, "Speed");
                    _helicopter.TankVolume = ConvertToDouble(TankVolumeTextBox.Text, "TankVolume");
                    _helicopter.Mass = ConvertToDouble(MassTextBox.Text, "Mass");
                }
                return _helicopter;
            }
        }

        /// <summary>
        ///     Аксессор, устанавливающий и возвращающий значение свойства ReadOnly у элементов формы.
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                _readonly = value;
                TNameTextBox.ReadOnly = value;
                WearRateTextBox.ReadOnly = value;
                FuelWasteTextBox.ReadOnly = value;
                SpeedTextBox.ReadOnly = value;
                TankVolumeTextBox.ReadOnly = value;
                MassTextBox.ReadOnly = value;
            }
            get { return _readonly; }
        }

        /// <summary>
        ///     Метод, указывающий на то, пустые ли поля на форме при добавлении объекта, или же нет.
        /// </summary>
        public bool IsHelicopterFieldEmpty =>
            TNameTextBox.Text == string.Empty || WearRateTextBox.Text == string.Empty ||
            FuelWasteTextBox.Text == string.Empty || SpeedTextBox.Text == string.Empty ||
            TankVolumeTextBox.Text == string.Empty || MassTextBox.Text == string.Empty;

        #endregion

        /// <summary>
        ///     Конструктор класса HelicopterControl.
        /// </summary>
        public HelicopterControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Метод, конвертирующий входные значения в тип double.
        /// </summary>
        /// <param name="value">Значение, необходимое для конвертации</param>
        /// <param name="fieldname">Имя поля, для указания в случае ошибки</param>
        /// <returns>Ковертированное значение типа double</returns>
        private double ConvertToDouble(string value, string fieldname)
        {
            double setting_value;
            try
            {
                setting_value = Convert.ToDouble(value);
            }
            catch (FormatException)
            {
                throw new FormatException(fieldname + " have to contain digits only");
            }
            return setting_value;
        }

        #region  - Error Provider -

        private void TNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TNameTextBox.Text))
                errorProvider.SetError(TNameTextBox, "Please enter your transport name using only a-z letters");
            else
                errorProvider.SetError(TNameTextBox, null);
            if (TNameTextBox.ReadOnly)
                errorProvider.Clear();
        }

        private void WearRateTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(WearRateTextBox.Text))
                errorProvider.SetError(WearRateTextBox,
                    "Please enter your transport wear rate. Value have to vary from 0 to 1");
            else
                errorProvider.SetError(WearRateTextBox, null);
            if (WearRateTextBox.ReadOnly)
                errorProvider.Clear();
        }

        private void FuelWasteTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TNameTextBox.Text))
                errorProvider.SetError(FuelWasteTextBox,
                    "Please enter your transport fuel waste. Value have to vary from 20 to 50 (l/h)");
            else
                errorProvider.SetError(FuelWasteTextBox, null);
            if (FuelWasteTextBox.ReadOnly)
                errorProvider.Clear();
        }

        private void SpeedTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SpeedTextBox.Text))
                errorProvider.SetError(SpeedTextBox, "Please enter speed value. Value have to vary from 1 to 400");
            else
                errorProvider.SetError(SpeedTextBox, null);
            if (SpeedTextBox.ReadOnly)
                errorProvider.Clear();
        }

        private void TankVolumeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TankVolumeTextBox.Text))
                errorProvider.SetError(TankVolumeTextBox,
                    "Please enter transport tank volume. Value have to vary from 50 to 200");
            else
                errorProvider.SetError(TankVolumeTextBox, null);
            if (TankVolumeTextBox.ReadOnly)
                errorProvider.Clear();
        }

        private void MassTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MassTextBox.Text))
                errorProvider.SetError(MassTextBox, "Please enter the mass transported (1-1000 kg)");
            else
                errorProvider.SetError(MassTextBox, null);
            if (MassTextBox.ReadOnly)
                errorProvider.Clear();
        }

        #endregion
    }
}