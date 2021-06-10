using Kompas3DConnector;
using Kompas6API5;
using Kompas6Constants3D;
using ModelParameters;




namespace ModelBuilder
{

    /// <summary>
    /// Класс постройки тумбочки
    /// </summary>
    public class NightstandBuilder
    {
        /// <summary>
        ///Метод построения тумбочки
        /// </summary>
        public void BuildNightstand(NightstandParameters nightstand)
        {
            KompasConnector.Instance.InitializationKompas();
            CreateRectangle(-nightstand.TopLength.Value / 2, -nightstand.TopWidth.Value / 2,
                nightstand.TopLength.Value, nightstand.TopWidth.Value,
                nightstand.TopThickness.Value, 0);
            CreateRectangle(-nightstand.BoxLength.Value / 2, -nightstand.BoxWidth.Value / 2,
                nightstand.BoxLength.Value, nightstand.BoxWidth.Value,
                nightstand.BoxHeight.Value, -nightstand.TopThickness.Value);

            //Legs
            var HeightLegsBuild = -nightstand.BoxHeight.Value - nightstand.TopThickness.Value;
            CreateRectangle(-nightstand.BoxLength.Value / 2, -nightstand.BoxWidth.Value / 2,
                50, 50, nightstand.FootLength.Value, HeightLegsBuild);
            CreateRectangle(-nightstand.BoxLength.Value / 2, nightstand.BoxWidth.Value / 2 - 50,
                50, 50, nightstand.FootLength.Value, HeightLegsBuild);
            CreateRectangle(nightstand.BoxLength.Value / 2 - 50, -nightstand.BoxWidth.Value / 2,
                50, 50, nightstand.FootLength.Value, HeightLegsBuild);
            CreateRectangle(nightstand.BoxLength.Value / 2 - 50, nightstand.BoxWidth.Value / 2 - 50,
                50, 50, nightstand.FootLength.Value, HeightLegsBuild);
            var HeightShelf = nightstand.TopThickness.Value +
                              (nightstand.BoxHeight.Value - nightstand.ShelfHeight.Value) / 2+nightstand.ShelfHeight.Value;
            CutRectangleShelf(nightstand.BoxLength.Value / 2, nightstand.BoxLength.Value - 20,
                nightstand.ShelfWidth.Value, nightstand.ShelfHeight.Value, -HeightShelf);

        }

        /// <summary>
        /// Вырезание выдавливанием
        /// </summary>
        /// <param name="xc">Х координата стенки</param>
        /// <param name="length">Длина полки</param>
        /// <param name="width">Ширина полки</param>
        /// <param name="deep">Глубина выдавливания</param>
        /// <param name="heightCut">Высота плоскости вырезания</param>
        private void CutRectangleShelf(double xc, double length, double width, double deep, double heightCut)
        {
            ksEntity currentPlane = (ksEntity)KompasConnector.Instance.
                KompasPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);

            ksEntity sketch = (ksEntity)KompasConnector.Instance.
                KompasPart.NewEntity((short)Obj3dType.o3d_sketch);
            var sketchDef = CreateSketch(heightCut);
            sketchDef.SetPlane(currentPlane);
            sketch.Create();
            ksDocument2D document2D = (ksDocument2D)sketchDef.BeginEdit();
            document2D.ksLineSeg(xc, -width / 2, xc, width / 2, 1);
            document2D.ksLineSeg(xc, -width / 2, xc - length+30, -width / 2, 1);
            document2D.ksLineSeg(xc, width / 2, xc-length+30,  width / 2, 1);
            document2D.ksLineSeg( xc - length+30, -width / 2, xc - length + 30, width / 2, 1);
            sketchDef.EndEdit();
            CutExtrusion(deep,sketchDef,false);
        }

        /// <summary>
        /// Метод создания прямоугольника с дальнейшим выдавливанием
        /// </summary>
        /// <param name="xc">Х координата начала</param>
        /// <param name="yc">У координата начала</param>
        /// <param name="length">Длина прямоугольника</param>
        /// <param name="width">Ширина прямоугольника</param>
        /// <param name="depth">Глубина выдавливания</param>
        /// <param name="heightBuild">Высота смещения рабочей плоскости</param>
        private void CreateRectangle(double xc, double yc, double length, double width,
            double depth, double heightBuild)
        {

            ksEntity currentPlane = (ksEntity)KompasConnector.Instance.
                KompasPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);

            ksEntity sketch = (ksEntity)KompasConnector.Instance.
                KompasPart.NewEntity((short)Obj3dType.o3d_sketch);
            var sketchDef = CreateSketch(heightBuild);
            //          ksSketchDefinition sketchDef = sketch.GetDefinition();
            sketchDef.SetPlane(currentPlane);
            sketch.Create();
            ksDocument2D document2D = (ksDocument2D)sketchDef.BeginEdit();
            document2D.ksLineSeg(xc, yc, xc + length, yc, 1);
            document2D.ksLineSeg(xc, yc, xc, yc + width, 1);
            document2D.ksLineSeg(xc + length, yc, xc + length, yc + width, 1);
            document2D.ksLineSeg(xc, yc + width, xc + length, yc + width, 1);
            sketchDef.EndEdit();
            BossExtrusion(depth, sketchDef, false);
        }

        /// <summary>
        /// Метод для завершения компаса
        /// </summary>
        public void CloseKompas()
        {
            KompasConnector.Instance.UnloadKompas();
        }

        /// <summary>
        /// Метод для создания эскиза
        /// </summary>
        /// <param name="heightPlane">Высота плоскости</param>
        /// <returns>Эскиз</returns>
        private ksSketchDefinition CreateSketch(double heightPlane)
        {
            ksEntity currentPlane = (ksEntity)KompasConnector
                .Instance.KompasPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            ksEntity newPlane = (ksEntity)KompasConnector
                .Instance.KompasPart.NewEntity((short)Obj3dType.o3d_planeOffset);
            // Интерфейс настроек смещенной плоскости
            ksPlaneOffsetDefinition newPlaneDefinition =
                (ksPlaneOffsetDefinition)newPlane.GetDefinition();

            // начальная позиция плоскости: от предыдущей
            newPlaneDefinition.SetPlane(currentPlane);
            // направление смещения: прямое
            newPlaneDefinition.direction = true;
            // расстояние смещения
            newPlaneDefinition.offset = heightPlane;
            // создать плоскость
            newPlane.Create();
            // установить последнюю созданную плоскость текущей
            currentPlane = newPlane;

            ksEntity Sketch = (ksEntity)KompasConnector
                .Instance.KompasPart.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition SketchDef = Sketch.GetDefinition();
            SketchDef.SetPlane(currentPlane);
            Sketch.Create();
            return SketchDef;
        }

        /// <summary>
        /// Метод для вырезания выдавливанием 
        /// </summary>
        /// <param name="depth">Глубина выреза</param>
        /// <param name="sketchDef">Эскиз</param>
        ///  <param name="forward">Направление выдавливания</param>
        private void CutExtrusion(double depth, ksSketchDefinition sketchDef, bool forward)
        {
            var iBaseExtrusionEntity1 = (ksEntity)KompasConnector
                .Instance.KompasPart.NewEntity((short)ksObj3dTypeEnum.o3d_cutExtrusion);
            //интерфейс свойств базовой операции выдавливания
            var iBaseExtrusionDef1 = (ksCutExtrusionDefinition)iBaseExtrusionEntity1.GetDefinition();
            //толщина выдавливания
            iBaseExtrusionDef1.SetSideParam(forward, 0, depth);
            if (forward == false)
            {
                iBaseExtrusionDef1.directionType = (short)Direction_Type.dtReverse;
            }
            // эскиз операции выдавливания
            iBaseExtrusionDef1.SetSketch(sketchDef);
            // создать операцию
            iBaseExtrusionEntity1.Create();
        }

        /// <summary>
        /// Метод для выдавливания
        /// </summary>
        /// <param name="height">Высота выдавливания</param>
        /// <param name="sketchDef">Эскиз</param>
        /// <param name="forward">Направление выдавливания</param>
        private void BossExtrusion(double height, ksSketchDefinition sketchDef, bool forward)
        {
            var iBaseExtrusionEntity = (ksEntity)KompasConnector.Instance.
                KompasPart.NewEntity((short)ksObj3dTypeEnum.o3d_bossExtrusion);
            // интерфейс свойств базовой операции выдавливания
            var iBaseExtrusionDef = (ksBossExtrusionDefinition)iBaseExtrusionEntity.GetDefinition();

            iBaseExtrusionDef.SetSideParam(forward, 0, height);

            if (forward == false)
            {
                iBaseExtrusionDef.directionType = (short)Direction_Type.dtReverse;
            }
            // эскиз операции выдавливания
            iBaseExtrusionDef.SetSketch(sketchDef);
            // создать операцию
            iBaseExtrusionEntity.Create();
        }
    }
}
