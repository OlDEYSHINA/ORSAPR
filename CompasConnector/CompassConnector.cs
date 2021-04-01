using Kompas6API5;
using Kompas6Constants3D;
using System;
using System.Runtime.InteropServices;

namespace CompassConnector
{
    /// <summary>
    /// Класс для соединения с Компас 3D
    /// </summary>
    public class CompassConnector
    {
        /// <summary>
        /// Поле, хранящее данные о 3D детали
        /// </summary>
        private ksDocument3D _document3d;

        /// <summary>
        /// Поле предназназначено для связи с API Компас 
        /// </summary>
        private KompasObject _compassObject;

        /// <summary>
        /// Поле для создание интерфейса
        /// </summary>
        private static CompassConnector _instance;

        /// <summary>
        /// Поле, для работы с частями детали 
        /// </summary>
        private ksPart _compassPart;

        /// <summary>
        /// Свойство для реализации интерфейса API Компас 
        /// </summary>
        public static CompassConnector Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CompassConnector();
                //_instance.InitializationKompas();
                return _instance;
            }
        }

        /// <summary>
        /// Свойство для реализации связи с API Компас
        /// </summary>
        public KompasObject CompassObject
        {
            get { return _compassObject; }
            set { _compassObject = value; }
        }

        /// <summary>
        /// Сойство для реализации связи с частями детали
        /// </summary>
        public ksPart CompassPart
        {
            get { return _compassPart; }
            set { _compassPart = value; }
        }

        /// <summary>
        /// Сойство для реализации связи с 3D эскизом
        /// </summary>
        public ksDocument3D Document3D
        {
            get { return _document3d; }
            set { _document3d = value; }
        }

        /// <summary>
        /// Метод запуска Компас в режиме детали, инициализации свойств Document3D, CompassPart и CompassObject
        /// </summary>
        public void InitializationKompas()
        {
            if (_compassObject == null)
            {
#if __LIGHT_VERSION__
                Type t = Type.GetTypeFromProgID("KOMPASLT.Application.5");
#else
                Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
#endif
                _compassObject = (KompasObject)Activator.CreateInstance(t);
                _document3d = (Document3D)_compassObject.Document3D();
                _document3d.Create(false, true);
                _compassPart = (ksPart)_document3d.GetPart((short)Part_Type.pTop_Part);
            }
            if (_compassObject != null)
            {
                _compassObject.Visible = true;
                _compassObject.ActivateControllerAPI();
            }
        }

        /// <summary>
        /// Метод для выгрузки и выхода и компаса
        /// </summary>
        public void UnloadKompas()
        {
            if (_compassObject != null)
            {
                _compassObject.Quit();
                Marshal.ReleaseComObject(_compassObject);
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        private CompassConnector() { }
    }
}