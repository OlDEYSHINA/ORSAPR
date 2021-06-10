using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ModelParameters;

namespace UnitTestNightstandParameters
{
    [TestFixture]
    public class NightstandParametersTests
    {
        /// <summary>
        /// Словарь для хранения сведения о параметров лампы
        /// </summary>
        private Dictionary<string, Parameter> TestingParameter
        {
            get
            {
                var nightstand = new NightstandParameters { };
                return new Dictionary<string, Parameter>
                {
                    {nameof(nightstand.BoxWidth), nightstand.BoxWidth},
                    {nameof(nightstand.BoxHeight), nightstand.TopLength},
                    {nameof(nightstand.BoxLength), nightstand.FootLength},
                    {nameof(nightstand.FootLength), nightstand.ShelfWidth},
                    {nameof(nightstand.ShelfHeight), nightstand.ShelfHeight},
                    {nameof(nightstand.ShelfWidth), nightstand.ShelfWidth},
                    {nameof(nightstand.TopLength), nightstand.TopLength},
                    {nameof(nightstand.TopThickness), nightstand.TopThickness},
                    {nameof(nightstand.TopWidth), nightstand.TopWidth},
                };
            }
        }

        /// <summary>
        /// Лист с назаванием параметров
        /// </summary>
        /// <param name="nightstand">Экземпляр класса NightstandParameters</param>
        /// <returns></returns>
        private List<Parameter> InitializeParameters(NightstandParameters nightstand)
        {
            var parameters = new List<Parameter>
            {
                nightstand.BoxWidth,
                nightstand.BoxHeight,
                nightstand.BoxLength,
                nightstand.FootLength,
                nightstand.ShelfHeight,
                nightstand.ShelfWidth,
                nightstand.TopLength,
                nightstand.TopThickness,
                nightstand.TopWidth
        };
            return parameters;
        }

        [TestCase("BoxWidth", TestName = "Позитивный метод для BoxWidth, производится ввод и " +
                                             "считывание параметров")]
        [TestCase("BoxHeight", TestName = "Позитивный метод для BoxHeight, производится ввод и " +
                                          "считывание параметров")]
        [TestCase("BoxLength", TestName = "Позитивный метод для BoxLength," +
                                                       " производится ввод и считывание параметров")]
        [TestCase("FootLength", TestName = "Позитивный метод для FootLength, " +
                                                     "производится ввод и считывание параметров")]
        [TestCase("ShelfHeight", TestName = "Позитивный метод для ShelfHeight, производится ввод и" +
                                             " считывание параметров")]
        [TestCase("ShelfWidth", TestName = "Позитивный метод для ShelfWidth, производится ввод и" +
                                           " считывание параметров")]
        [TestCase("TopLength", TestName = "Позитивный метод для TopLength, производится ввод и" +
                                           " считывание параметров")]
        [TestCase("TopWidth", TestName = "Позитивный метод для TopWidth, производится ввод и" +
                                           " считывание параметров")]
        public void Test_GoodParameter_ReturnSameParameter(string nameParameter)
        {
            // Setup
            Parameter myParameter;
            if (TestingParameter.TryGetValue(nameParameter, out myParameter))
            {
                Parameter sourceParameter = new Parameter(
                    "Testing Parameter",
                    20,
                    150,
                    80);
                var expectedParameter = sourceParameter;

                // Act
                myParameter = sourceParameter;
                var actualParameter = myParameter;

                //Assert
                NUnit.Framework.Assert.AreEqual(expectedParameter, actualParameter);
            }
            else
            {
                throw new ArgumentException("Параметр не найден");
            }
        }
        
        [TestCase(TestName = "Позитивный метод для MaxValue, производится ввод и считывание " +
                             "параметров")]
        public void MaxValue_GoodNightstandParameters_MaximumValueEqualValue()
        {
            // Setup
            var nightstand = new NightstandParameters();
            var parameters = InitializeParameters(nightstand);
            nightstand.MaxValue();
            foreach (var currentParameter in parameters)
            {

                var expectedValue = currentParameter.MaximumValue;

                // Act
                var actualValue = currentParameter.Value;

                // Assert
                NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
            }
        }

        [TestCase(TestName = "Позитивный метод для MinValue, производится ввод и считывание " +
                             "параметров")]
        public void MinValue_GoodNightstandParameters_MinimumValueEqualValue()
        {
            // Setup
            var nightstand = new NightstandParameters();
            var parameters = InitializeParameters(nightstand);
            nightstand.MinValue();
            foreach (var currentParameter in parameters)
            {

                var expectedValue = currentParameter.MinimumValue;

                // Act
                var actualValue = currentParameter.Value;

                // Assert
                NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
            }
        }

        [TestCase(TestName = "Позитивный метод для DefaultValue, производится ввод и " +
                             "считывание параметров")]
        public void DefaultValue_GoodNightstandParameters_DefaultValueEqualValue()
        {
            // Setup
            var nightstand = new NightstandParameters();
            var parameters = InitializeParameters(nightstand);
            nightstand.DefaultValue();
            foreach (var currentParameter in parameters)
            {

                var expectedValue = currentParameter.DefaultValue;

                // Act
                var actualValue = currentParameter.Value;

                // Assert
                NUnit.Framework.Assert.AreEqual(expectedValue, actualValue);
            }
        }
        

    }
}