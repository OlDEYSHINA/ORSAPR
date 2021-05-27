using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelParameters
{
    public class NightstandParameters
    {
        /// <summary>
        /// Лист параметров
        /// </summary>
        private List<Parameter> parameters = new List<Parameter>();

        private Parameter _topLength;
        /// <summary>
        /// Поле, содержащее высоту столешницы 
        /// </summary>
        public Parameter TopLength
        {
            get => _topLength;
            set
            {
                _topLength = value;
                BoxLength.MaximumValue = _topLength.Value-20;
                if (BoxLength.Value > BoxLength.MaximumValue) BoxLength.Value = BoxLength.MaximumValue;
            }
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
            get => _boxLegnth; set=>_boxLegnth=value;
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

        public void MaxValue()
        {
            BoxWidth.Value = BoxWidth.MaximumValue;
            TopLength.Value = TopThickness.MaximumValue;
            FootLength.Value = FootLength.MaximumValue;
            ShelfWidth.Value = ShelfWidth.MaximumValue;
            ShelfHeight.Value = ShelfHeight.MaximumValue;
            BoxLength.Value = BoxLength.MaximumValue;
            TopWidth.Value = TopWidth.MaximumValue;
            BoxHeight.Value = BoxHeight.MaximumValue;
            TopThickness.Value = TopThickness.MaximumValue;
        }
        public void MinValue()
        {
            BoxWidth.Value = BoxWidth.MinimumValue;
            TopLength.Value = TopThickness.MinimumValue;
            FootLength.Value = FootLength.MinimumValue;
            ShelfWidth.Value = ShelfWidth.MinimumValue;
            ShelfHeight.Value = ShelfHeight.MinimumValue;
            BoxLength.Value = BoxLength.MinimumValue;
            TopWidth.Value = TopWidth.MinimumValue;
            BoxHeight.Value = BoxHeight.MinimumValue;
            TopThickness.Value = TopThickness.MinimumValue;
        }
        /// <summary>
        /// Свойство, присваивающее значение по умолчанию для зависимых параметров
        /// </summary>
        public void DefaultValue()
        {
            BoxWidth.Value = BoxWidth.DefaultValue;
            TopLength.Value = TopLength.DefaultValue;
            FootLength.Value = FootLength.DefaultValue;
            ShelfWidth.Value = ShelfWidth.DefaultValue;
            ShelfHeight.Value = ShelfHeight.DefaultValue;
            BoxLength.Value = BoxLength.DefaultValue;
            TopWidth.Value = TopWidth.DefaultValue;
            BoxHeight.Value = BoxHeight.DefaultValue;
            TopThickness.Value = TopThickness.DefaultValue;
        }
        public NightstandParameters()
        {
            this.BoxLength = new Parameter("Длина ящика",
                200, 800, 400);
            this.BoxWidth = new Parameter("Ширина ящика",
                200, 800, 400);
            this.TopLength  = new Parameter{NameParameter = "Длина столешницы" , MinimumValue = 200,
                MaximumValue = 1000, DefaultValue = 500, Value = 500};
            this.FootLength = new Parameter("Длина ножек",
                50, 800, 400);
            this.BoxHeight = new Parameter("Высота ящика",
                200, 800, 400);
            this.ShelfWidth = new Parameter("Ширина полки",
                50, (this.BoxWidth.DefaultValue-20), 200);
            this.ShelfHeight = new Parameter(
                "Высота полки", 100, (this.BoxHeight.DefaultValue-20), 200);
            this.TopWidth = new Parameter("Ширина столешницы",
                250, 800, 500);
            this.TopThickness = new Parameter("Толщина столешницы",
                10, 100, 40);

            parameters.Add(BoxWidth);
            parameters.Add(TopLength);
            parameters.Add(FootLength);
            parameters.Add(ShelfWidth);
            parameters.Add(ShelfHeight);
            parameters.Add(BoxLength);
            parameters.Add(TopWidth);
            parameters.Add(BoxHeight);
            parameters.Add(TopThickness);
        }
    }
}
