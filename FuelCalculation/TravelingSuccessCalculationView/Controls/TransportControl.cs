using System;
using System.ComponentModel;
using System.Windows.Forms;
using FuelCalculation;

namespace TravelingSuccessCalculationView.Controls
{
    /// <summary>
    /// Контрол, предназначеный для работы с транспортным средтвом, его добавлением или изменением.
    /// </summary>
    public partial class TransportControl : UserControl
    {
        /// <summary>
        /// Переменная для передачи объекта на контрол и обратно.
        /// </summary>
        private ITransport _transport;
        /// <summary>
        /// Переменная, определяющая свойство ReadOnly у элементов на форме.
        /// </summary>
        private bool _readonly;

        /// <summary>
        /// Конструктор класса TransportControl.
        /// </summary>
        public TransportControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Аксессор, для получения передаваемого объекта.
        /// </summary>
        [DefaultValue(null)]
        public ITransport Transport
        {
            set
            {
                _transport = value;
                if (value is Car)
                {
                    CarControl.Car = value as Car;
                    TransportTypeComboBox.SelectedIndex = 0;
                }
                else if (value is Helicopter)
                {
                    HelicopterControl.Helicopter = value as Helicopter;
                    TransportTypeComboBox.SelectedIndex = 1;
                }
            }
            get
            {
                if (TransportTypeComboBox.SelectedIndex == 0)
                {
                    _transport = CarControl.Car;
                }
                else if (TransportTypeComboBox.SelectedIndex == 1)
                {
                    _transport = HelicopterControl.Helicopter;
                }
                return _transport;
            }
        }

        /// <summary>
        /// Аксессор, для передачи значения ReadOnly элементам формы.
        /// </summary>
        public bool ReadOnly {
            set
            {
                _readonly = value;
                TransportTypeComboBox.Enabled = !value;
                if (TransportTypeComboBox.Text == "Car")
                {
                    CarControl.ReadOnly = value;
                }
                else if (TransportTypeComboBox.Text == "Helicopter")
                {
                    HelicopterControl.ReadOnly = value;
                }

            }
            get { return _readonly; } }

        private void TransportTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TransportTypeComboBox.Text == "Car")
            {
                CarControl.Visible = true;
                HelicopterControl.Visible = false;
            }
            else
            {
                HelicopterControl.Visible = true;
                CarControl.Visible = false;
            }
        }

        /// <summary>
        /// Метод, указывающий на то, пустые ли поля на дочернем контроле при добавлении объекта, или же нет.
        /// </summary>
        public bool IsFieldEmpty => 
            (TransportTypeComboBox.SelectedIndex == 0) ? CarControl.IsCarFieldEmpty :
            (TransportTypeComboBox.SelectedIndex == 1) ? HelicopterControl.IsHelicopterFieldEmpty : true;

        /// <summary>
        /// Аксессор, возращающий тип транспорта, установленного в ComboBox.
        /// </summary>
        public int TransportType
        {
            get { return TransportTypeComboBox.SelectedIndex; }
            set { TransportTypeComboBox.SelectedIndex = value; }
        }
    }
}
