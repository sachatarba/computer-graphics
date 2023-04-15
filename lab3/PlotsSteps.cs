using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static IronPython.Modules._ast;

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
            pane.Title.Text = "Замеры числа ступенек";
            pane.XAxis.Title.Text = "Угол в градусах";
            pane.YAxis.Title.Text = "Число ступенек";

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
                //VU.Vu(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                Brezenhem.BrezenhemFloat(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                //Brezenhem.BrezenhemInteger(0, 0, Convert.ToInt32(pointRot.X), Convert.ToInt32(pointRot.Y), Color.Black, out int steps, stepmode: true);


                //Brezenhem.BrezenhemSmooth(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                list.Add(angle, steps);
                //list.Add(angle, angle);
            }

            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("BrezInt", list, Color.Blue, SymbolType.None);
            pane.Title.Text = "Замеры числа ступенек";
            pane.XAxis.Title.Text = "Угол в градусах";
            pane.YAxis.Title.Text = "Число ступенек";

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
            pane.Title.Text = "Замеры числа ступенек";
            pane.XAxis.Title.Text = "Угол в градусах";
            pane.YAxis.Title.Text = "Число ступенек";

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
            pane.Title.Text = "Замеры числа ступенек";
            pane.XAxis.Title.Text = "Угол в градусах";
            pane.YAxis.Title.Text = "Число ступенек";

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
            pane.Title.Text = "Замеры числа ступенек";
            pane.XAxis.Title.Text = "Угол в градусах";
            pane.YAxis.Title.Text = "Число ступенек";

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl6.AxisChange();

            // Обновляем график
            zedGraphControl6.Invalidate();
        }

        void DrawAll()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl1.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек для кривой f1(x)
            PointPairList f1_list = new PointPairList();

            // Создадим список точек для кривой f2(x)
            PointPairList f2_list = new PointPairList();
            PointPairList f3_list = new PointPairList();
            PointPairList f4_list = new PointPairList();
            PointPairList f5_list = new PointPairList();

            PointF pointStart = new PointF(1000, 0);
            PointF pointRot = new PointF();
            for (int angle = 0; angle < 91; ++angle)
            {
                // добавим в список точку
                pointRot = Geometry.TurnPoint(new PointF(0, 0), pointStart, angle);
                DDA.Dda(0, 0, pointRot.X, pointRot.Y, Color.Black, out int steps, stepmode: true);
                f1_list.Add(angle, steps);
                Brezenhem.BrezenhemFloat(0, 0, pointRot.X, pointRot.Y, Color.Black, out steps, stepmode: true);
                f2_list.Add(angle, steps);
                Brezenhem.BrezenhemInteger(0, 0, Convert.ToInt32(pointRot.X), Convert.ToInt32(pointRot.X), Color.Black, out steps, stepmode: true);
                f3_list.Add(angle, steps);
                Brezenhem.BrezenhemSmooth(0, 0, pointRot.X, pointRot.Y, Color.Black, out steps, stepmode: true);
                f4_list.Add(angle, steps);
                VU.Vu(0, 0, pointRot.X, pointRot.Y, Color.Black, out steps, stepmode: true);
                f5_list.Add(angle, steps);
                //list.Add(angle, angle);
            }

            // !!!
            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem f1_curve = pane.AddCurve("Dda", f1_list, Color.HotPink, SymbolType.Default);

            // !!!
            // Создадим кривую с названием "Sin",
            // которая будет рисоваться красным цветом (Color.Red),
            // Опорные точки будут выделяться плюсиками (SymbolType.Plus)
            LineItem f2_curve = pane.AddCurve("BrezFloat", f2_list, Color.Red, SymbolType.Plus);
            LineItem f3_curve = pane.AddCurve("BrezInt", f3_list, Color.Blue, SymbolType.None);
            LineItem f4_curve = pane.AddCurve("BrezSmooth", f4_list, Color.HotPink, SymbolType.Diamond);
            LineItem f5_curve = pane.AddCurve("Vu", f5_list, Color.LightPink, SymbolType.Circle);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl1.AxisChange();
            pane.Title.Text = "Замеры числа ступенек";
            pane.XAxis.Title.Text = "Угол в градусах";
            pane.YAxis.Title.Text = "Число ступенек";

            // Обновляем график
            zedGraphControl1.Invalidate();
        }

        void DrawGraphs()
        {
            Thread t1 = new Thread(GraphBrezInt);
            Thread t2 = new Thread(GraphBrezFLoat);
            Thread t3 = new Thread(GraphBrezSmooth);
            Thread t4 = new Thread(GraphDda);
            Thread t5 = new Thread(GraphVu);
            Thread t6 = new Thread(DrawAll);
            t1.Start();
            t2.Start();
            t3.Start(); 
            t4.Start();
            t5.Start();
            t6.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
