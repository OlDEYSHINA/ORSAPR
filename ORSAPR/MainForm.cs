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
        /// Поле хранящее данные о тумбе
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

        /// <summary>
        /// Лист c текстбоксами
        /// </summary>
        private readonly List<string> _sizeParameters;

        public MainForm()
        {
            InitializeComponent();
            _textBoxDictionary = new Dictionary<TextBox, Action<NightstandParameters, string>>() 
            {
                {
                    textBoxBoxWidth,
                    (NightstandParameters nightstand, string text) =>
                    {
                        nightstand.BoxWidth.Value = double.Parse(text);
                        nightstand.ShelfWidth.MaximumValue = nightstand.BoxWidth.Value - 20;
                    }
                },
                {
                    textBoxBoxHeight,
                    (NightstandParameters nightstand, string text) =>
                    {
                        nightstand.BoxHeight.Value = double.Parse(text);
                           nightstand.ShelfHeight.MaximumValue = nightstand.BoxHeight.Value - 20;
                    }
                },
                {
                    textBoxBoxLength,
                    (NightstandParameters nightstand, string text) =>
                    {
                        nightstand.BoxLength.Value = double.Parse(text);
                    }
                },
                {
                    textBoxShelfHeight,
                    (NightstandParameters nightstand, string text) =>
                    {
                        nightstand.ShelfHeight.Value = double.Parse(text);
                    }
                },
                {
                    textBoxShelfWidth,
                    (NightstandParameters nightstand, string text) =>
                    {
                        nightstand.ShelfWidth.Value = double.Parse(text);
                    }
                },
                {
                    textBoxFootLength,
                    (NightstandParameters nightstand, string text) =>
                    {
                        nightstand.FootLength.Value = double.Parse(text);
                    }
                },
                {
                    textBoxTopThickness,
                    (NightstandParameters nightstand, string text) =>
                    {
                        nightstand.TopThickness.Value = double.Parse(text);
                    }
                },
                {
                    textBoxTopLength,
                    (NightstandParameters nightstand, string text) =>
                    {
                        nightstand.TopLength.Value = double.Parse(text);
                    }
                },
                {
                    textBoxTopWidth,
                    (NightstandParameters nightstand, string text) =>
                    {
                        nightstand.TopWidth.Value = double.Parse(text);
                    }
                }
             };

            
            _parameters = new List<Parameter>
            {
                _nightstand.BoxWidth,
                _nightstand.BoxHeight,
                _nightstand.BoxLength,
                _nightstand.FootLength,
                _nightstand.ShelfHeight,
                _nightstand.ShelfWidth,
                _nightstand.TopLength,
                _nightstand.TopThickness,
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
                labelBoxWidth,
                labelBoxHeight,
                labelBoxLength,
                labelFootLength,
                labelShelfHeight,
                labelShelfWidth,
                labelTopLength,
                labelTopThickness,
                labelTopWedth
            };

            _sizeParameters = new List<string>
            {
                "Maximum value",
                "Minimum value",
                "Default value"
            };
            comboBoxSize.Items.AddRange(_sizeParameters.ToArray());
            comboBoxSize.SelectedItem = "Default value";
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
                    SetLimits();
                    UpdateFormFields();
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
        /// Кнопка подтверждения установки предустановленных параметров
        /// </summary>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (comboBoxSize.SelectedIndex == -1)
            {
                return;
            }

            var tmpDictionary = new Dictionary<string, Action>()
            {
                {_sizeParameters[0], () => _nightstand.MaxValue()},
                {_sizeParameters[1], () => _nightstand.MinValue()},
                {_sizeParameters[2], () => _nightstand.DefaultValue()},
            };

            tmpDictionary[comboBoxSize.SelectedItem.ToString()].Invoke();

            UpdateFormFields();
            WhiteColorTextBox();
            SetLimits();            
            buttonBuild.Enabled = true;
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
          _build.BuildNightstand(_nightstand);
        }
    }
}
