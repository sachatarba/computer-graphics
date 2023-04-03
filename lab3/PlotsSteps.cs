using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace lab3
{
    public partial class PlotsSteps : Form
    {
        public PlotsSteps()
        {
            InitializeComponent();
            DrawGraphs();
        }

        void GraphDda()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl2.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();


            // Заполняем список точек
            PointF pointStart = new PointF(1000, 0);
            PointF pointRot = new PointF();
            for (int angle = 0; angle < 91; ++angle)
            {
                // добавим в список точку
                pointRot = Geometry.TurnPoint(new PointF(0, 0), pointStart, angle);
                DDA.Dda(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                //VU.Vu(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                //Brezenhem.BrezenhemInteger(0, 0, Convert.ToInt32(pointRot.X), Convert.ToInt32(pointRot.X), Color.Black, out int steps, stepmode: true);
                //Brezenhem.BrezenhemFloat(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);


                //Brezenhem.BrezenhemSmooth(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                list.Add(angle, steps);
                //list.Add(angle, angle);
            }

            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("DDA", list, Color.Blue, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl2.AxisChange();

            // Обновляем график
            zedGraphControl2.Invalidate();
        }

        void GraphBrezInt()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl3.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();


            // Заполняем список точек
            PointF pointStart = new PointF(1000, 0);
            PointF pointRot = new PointF();
            for (int angle = 0; angle < 91; ++angle)
            {
                // добавим в список точку
                pointRot = Geometry.TurnPoint(new PointF(0, 0), pointStart, angle);
                //DDA.Dda(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                VU.Vu(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                //Brezenhem.BrezenhemInteger(0, 0, Convert.ToInt32(pointRot.X), Convert.ToInt32(pointRot.Y), Color.Black, out int steps, stepmode: true);
                //Brezenhem.BrezenhemFloat(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);


                //Brezenhem.BrezenhemSmooth(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                list.Add(angle, steps);
                //list.Add(angle, angle);
            }

            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("BrezInt", list, Color.Blue, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl3.AxisChange();

            // Обновляем график
            zedGraphControl3.Invalidate();
        }
        void GraphBrezFLoat()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl4.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();


            // Заполняем список точек
            PointF pointStart = new PointF(1000, 0);
            PointF pointRot = new PointF();
            for (int angle = 0; angle < 91; ++angle)
            {
                // добавим в список точку
                pointRot = Geometry.TurnPoint(new PointF(0, 0), pointStart, angle);
                //DDA.Dda(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                //VU.Vu(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                //Brezenhem.BrezenhemInteger(0, 0, Convert.ToInt32(pointRot.X), Convert.ToInt32(pointRot.X), Color.Black, out int steps, stepmode: true);
                Brezenhem.BrezenhemFloat(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);


                //Brezenhem.BrezenhemSmooth(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                list.Add(angle, steps);
                //list.Add(angle, angle);
            }

            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("BrezFloat", list, Color.Blue, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl4.AxisChange();

            // Обновляем график
            zedGraphControl4.Invalidate();
        }

        void GraphBrezSmooth()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl5.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();


            // Заполняем список точек
            PointF pointStart = new PointF(1000, 0);
            PointF pointRot = new PointF();
            for (int angle = 0; angle < 91; ++angle)
            {
                // добавим в список точку
                pointRot = Geometry.TurnPoint(new PointF(0, 0), pointStart, angle);
                //DDA.Dda(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                //VU.Vu(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                //Brezenhem.BrezenhemInteger(0, 0, Convert.ToInt32(pointRot.X), Convert.ToInt32(pointRot.X), Color.Black, out int steps, stepmode: true);
                //Brezenhem.BrezenhemFloat(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);


                Brezenhem.BrezenhemSmooth(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                list.Add(angle, steps);
                //list.Add(angle, angle);
            }

            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("BrezSmooth", list, Color.Blue, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl5.AxisChange();

            // Обновляем график
            zedGraphControl5.Invalidate();
        }

        void GraphVu()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl6.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();


            // Заполняем список точек
            PointF pointStart = new PointF(1000, 0);
            PointF pointRot = new PointF();
            for (int angle = 0; angle < 91; ++angle)
            {
                // добавим в список точку
                pointRot = Geometry.TurnPoint(new PointF(0, 0), pointStart, angle);
                //DDA.Dda(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                VU.Vu(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                //Brezenhem.BrezenhemInteger(0, 0, Convert.ToInt32(pointRot.X), Convert.ToInt32(pointRot.X), Color.Black, out int steps, stepmode: true);
                //Brezenhem.BrezenhemFloat(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);


                //Brezenhem.BrezenhemSmooth(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                list.Add(angle, steps);
                //list.Add(angle, angle);
            }

            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("Vu", list, Color.Blue, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl6.AxisChange();

            // Обновляем график
            zedGraphControl6.Invalidate();
        }

        void DrawGraphs()
        {
            GraphBrezInt();
            GraphBrezFLoat();
            GraphBrezSmooth();
            GraphDda();
            GraphVu();
        }
    }
}
