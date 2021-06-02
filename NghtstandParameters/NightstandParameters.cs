using System.Collections.Generic;

namespace ModelParameters
{
    public class NightstandParameters
    {
        /// <summary>
        /// Лист параметров
        /// </summary>
        private readonly List<Parameter> _parameters;


        private Parameter _topLength;
        /// <summary>
        /// Поле, содержащее высоту столешницы 
        /// </summary>
        public Parameter TopLength
        {
            get => _topLength;
            set => _topLength = value;
            /*  {
                _topLength = value;
                BoxLength.MaximumValue = _topLength.Value;
                if (BoxLength.Value > BoxLength.MaximumValue) BoxLength.Value = BoxLength.MaximumValue;
            }*/
        }

        /// <summary>
        /// Поле, содержащее ширину столешницы
        /// </summary>
        public Parameter TopWidth { get; set; }

        /// <summary>
        /// Поле, содержащее глубину столешницы
        /// </summary>
        public Parameter TopThickness { get; set; }

        /// <summary>
        /// Поле, содержащее высота "туловища"
        /// </summary>
        public Parameter BoxHeight { get; set; }

        private Parameter _boxLegnth;

        /// <summary>
        /// Поле, содержащее ширину "туловища"
        /// </summary>
        public Parameter BoxLength
        {
            get => _boxLegnth; set => _boxLegnth = value;
        }

        /// <summary>
        /// Поле, содержащее глубину "туловища"
        /// </summary>
        public Parameter BoxWidth { get; set; }

        /// <summary>
        /// Поле, содержащее высоту ящика
        /// </summary>
        public Parameter ShelfHeight { get; set; }

        /// <summary>
        /// Поле, содержащее ширину ящика
        /// </summary>
        public Parameter ShelfWidth { get; set; }

        /// <summary>
        /// Поле, содержащее длину ножек
        /// </summary>
        public Parameter FootLength { get; set; }

        /// <summary>
        /// Свойство, присваивающе максимальное
        /// значение для зависимых параметров
        /// </summary>
        public void MaxValue()
        {
            foreach (var currentParameter in _parameters)
            {
                currentParameter.Value = currentParameter.MaximumValue;
            }
        }

        /// <summary>
        /// Свойство, присваивающее минимальное
        /// значение для зависимых параметров
        /// </summary>
        public void MinValue()
        {
            foreach (var currentParameter in _parameters)
            {
                currentParameter.Value = currentParameter.MinimumValue;
            }
        }

        /// <summary>
        /// Свойство, присваивающее значение по умолчанию
        /// для зависимых параметров
        /// </summary>
        public void DefaultValue()
        {
            foreach (var carrentParameter in _parameters)
            {
                carrentParameter.Value = carrentParameter.DefaultValue;
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public NightstandParameters()
        {
            this.BoxLength = new Parameter("Длина ящика",
                200, 800, 400);
            this.BoxWidth = new Parameter("Ширина ящика",
                200, 800, 400);
            this.TopLength = new Parameter("Длина столешницы", 200,
                1000, 500);
            this.FootLength = new Parameter("Длина ножек",
                50, 800, 400);
            this.BoxHeight = new Parameter("Высота ящика",
                200, 800, 400);
            this.ShelfWidth = new Parameter("Ширина полки",
                50, (this.BoxWidth.DefaultValue - 20), 200);
            this.ShelfHeight = new Parameter(
                "Высота полки", 100, (this.BoxHeight.DefaultValue - 20), 200);
            this.TopWidth = new Parameter("Ширина столешницы",
                250, 800, 500);
            this.TopThickness = new Parameter("Толщина столешницы",
                10, 100, 40);

            _parameters = new List<Parameter>
            {
                 BoxWidth,
                 TopLength,
                 FootLength,
                 ShelfWidth,
                 ShelfHeight,
                 BoxLength,
                 TopWidth,
                 BoxHeight,
                 TopThickness
        };

        }
    }
}
