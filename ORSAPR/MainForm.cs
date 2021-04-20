using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelBuilder;
using ModelParameters;


namespace ORSAPR
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Словарь для хранения сведений о TextBox
        /// </summary>
        private readonly Dictionary<TextBox, Action<ModelParameters.NightstandParameters, string>>
            _textBoxDictionary;

        /// <summary>
        /// Поле хранящее данные о лампе
        /// </summary>
        private NightstandParameters _nightstand = new NightstandParameters{ };

        /// <summary>
        /// Поле для хранения данных о билдере
        /// </summary>
        private NightstandBuilder _build = new NightstandBuilder();

        /// <summary>
        /// Лист параметров
        /// </summary>
        private readonly List<Parameter> _parameters;

        /// <summary>
        /// Лист c текстбоксами
        /// </summary>
        private readonly List<TextBox> _textBoxList;

        /// <summary>
        /// Лист c текстбоксами
        /// </summary>
        private readonly List<Label> _labelList;

        public MainForm()
        {
            InitializeComponent();
            _textBoxDictionary = new Dictionary<TextBox, Action<NightstandParameters, string>>()
            {
                
             };

            _parameters = new List<Parameter>
            {
                _nightstand.BoxWidth,
                _nightstand.BoxHeight,
                _nightstand.BoxLength,
                _nightstand.ShelfHeight,
                _nightstand.ShelfWidth,
                _nightstand.FootLength,
                _nightstand.TopThickness,
                _nightstand.TopLength,
                _nightstand.TopWidth
            };

            _textBoxList = new List<TextBox>()
            {
                textBoxBoxWidth,
                textBoxBoxHeight,
                textBoxBoxLength,
                textBoxFootLength,
                textBoxShelfHeight,
                textBoxShelfWidth,
                textBoxTopLength,
                textBoxTopThickness,
                textBoxTopWidth

            };

            _labelList = new List<Label>
            {
                labelBoxHeight,
                labelBoxLength,
                labelBoxWidth,
                labelFootLength,
                labelShelfHeight,
                labelShelfWidth,
                labelTopLength,
                labelTopThickness,
                labelTopWedth
            };

            _nightstand.DefaultValue();
            UpdateFormFields();
            SetLimits();
        }


        /// <summary>
        /// Обработчик для присваивания значений из TextBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxLeave(object sender, EventArgs e)
        {
            var currentTextBox = (TextBox)sender;
            var currentAction = _textBoxDictionary[currentTextBox];
            if (!String.IsNullOrEmpty(currentTextBox.Text))
            {
                try
                {
                    currentAction.Invoke(_nightstand, currentTextBox.Text);
                    currentTextBox.BackColor = Color.White;
                    if (Validate())
                    {
                        buttonBuild.Enabled = true;
                    }
                }
                catch (ArgumentException exception)
                {
                    currentTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show(exception.Message);
                    buttonBuild.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Метод для проверки на соответствие сохраненных и введенных параметров
        /// </summary>
        /// <returns></returns>
        private bool Validate()
        {
            var smallestUpperBound = Math.Min(_textBoxList.Count, _parameters.Count);
            for (var index = 0; index < smallestUpperBound; index++)
            {
                if (_textBoxList[index].Text.ToString() != _parameters[index].Value.ToString())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Метод, присваивающий значение предустановленных параметров в TextBox
        /// </summary>
        private void UpdateFormFields()
        {
            var smallestUpperBound = Math.Min(_textBoxList.Count, _parameters.Count);
            for (var index = 0; index < smallestUpperBound; index++)
            {
                _textBoxList[index].Text = _parameters[index].Value.ToString();
            }
        }

        /// <summary>
        /// Метод для проброса минимальных и максимальных параметров в label формы
        /// </summary>
        private void SetLimits()
        {
            var smallestUpperBound = Math.Min(_labelList.Count, _parameters.Count);
            for (var index = 0; index < smallestUpperBound; index++)
            {
                _labelList[index].Text = Convert.ToString($"{_parameters[index].NameParameter} " +
                                                          $"({_parameters[index].MinimumValue} - " +
                                                          $"{_parameters[index].MaximumValue}) mm");
            }
        }

        /// <summary>
        /// Метод, присваивающий белый цвет BackColor для TextBox
        /// </summary>
        private void WhiteColorTextBox()
        {
            foreach (var currentTextBox in _textBoxList)
            {
                currentTextBox.BackColor = Color.White;
            }
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
          // _build.BuildNightstand(_nightstand);
           textBoxBoxHeight.BackColor = Color.Red;
            //   MessageBox.Show("Введенное значение должно больше чем 200");
        }
    }
}
