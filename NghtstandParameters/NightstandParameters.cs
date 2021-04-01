using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightstandParameters
{
    public class NightstandParameters
    {
        /// <summary>
        /// Поле, содержащее высоту столешницы 
        /// </summary>
        private Parameter _topHeight;

        /// <summary>
        /// Поле, содержащее ширину столешницы
        /// </summary>
        private Parameter _topWidth;

        /// <summary>
        /// Поле, содержащее глубину столешницы
        /// </summary>
        private Parameter _topDeep;

        /// <summary>
        /// Поле, содержащее высота "туловища"
        /// </summary>
        private Parameter _bodyHeight;

        /// <summary>
        /// Поле, содержащее ширину "туловища"
        /// </summary>
        private Parameter _bodyWidth;

        /// <summary>
        /// Поле, содержащее глубину "туловища"
        /// </summary>
        private Parameter _bodyDeep;

        /// <summary>
        /// Поле, содержащее высоту ящика
        /// </summary>
        private Parameter _boxHeight;

        /// <summary>
        /// Поле, содержащее ширину ящика
        /// </summary>
        private Parameter _boxWidth;

        /// <summary>
        /// Поле, содержащее длину ножек
        /// </summary>
        private Parameter _footLength;

        public Parameter TopHeight
        {
            get => _topHeight;
            set
            {
                _topHeight = value;
            }
        }

        public Parameter TopWidth
        {
            get => _topWidth;
            set
            {
                _topWidth = value;
            }
        }

        public Parameter TopDeep
        {
            get => _topDeep;
            set
            {
                _topDeep = value;
            }
        }

        public Parameter BodyHeight
        {
            get => _bodyHeight;
            set
            {
                _bodyHeight = value;
            }
        }
        public Parameter BodyWidth
        {
            get => _bodyWidth;
            set
            {
                _bodyWidth = value;
            }
        }
        public Parameter BodyDeep
        {
            get => _bodyDeep;
            set
            {
                _bodyDeep = value;
            }
        }
        public Parameter BoxHeight
        {
            get => _boxHeight;
            set
            {
                _boxHeight = value;
            }
        }
        public Parameter BoxWidth
        {
            get => _boxWidth;
            set
            {
                _boxWidth = value;
            }
        }
        public Parameter FootLength
        {
            get => _footLength;
            set
            {
                _footLength = value;
            }
        }

        public void MaxValue()
        {
            _bodyDeep.Value = _bodyDeep.MaximumValue;
            _topHeight.Value = _topDeep.MaximumValue;
            _footLength.Value = _footLength.MaximumValue;
            _boxWidth.Value = _boxWidth.MaximumValue;
            _boxHeight.Value = _boxHeight.MaximumValue;
            _bodyWidth.Value = _bodyWidth.MaximumValue;
            _topWidth.Value = _topWidth.MaximumValue;
            _bodyHeight.Value = _bodyHeight.MaximumValue;
            _topDeep.Value = _topDeep.MaximumValue;
        }
        public void MinValue()
        {
            _bodyDeep.Value = _bodyDeep.MinimumValue;
            _topHeight.Value = _topDeep.MinimumValue;
            _footLength.Value = _footLength.MinimumValue;
            _boxWidth.Value = _boxWidth.MinimumValue;
            _boxHeight.Value = _boxHeight.MinimumValue;
            _bodyWidth.Value = _bodyWidth.MinimumValue;
            _topWidth.Value = _topWidth.MinimumValue;
            _bodyHeight.Value = _bodyHeight.MinimumValue;
            _topDeep.Value = _topDeep.MinimumValue;
        }
    }
}
