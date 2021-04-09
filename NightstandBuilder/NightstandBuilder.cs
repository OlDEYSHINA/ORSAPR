using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kompas3DConnector;




namespace ModelBuilder
{
    public class NightstandBuilder
    {

        /// <summary>
        /// Метод для завершения компаса
        /// </summary>
        public void CloseKompas()
        {
            KompasConnector.Instance.UnloadKompas();
        }
    }
}
