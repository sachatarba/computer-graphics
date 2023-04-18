using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace lab4
{
    public partial class Plot : Form
    {
        public Plot()
        {
            InitializeComponent();
            DrawAll();
        }

        void DrawAll()
        {
            DrawCirclesPlot();
            DrawEllipsesPlot();
        }
        void DrawCirclesPlot()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl1.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            PointPairList f1_list = new PointPairList();
            PointPairList f2_list = new PointPairList();
            PointPairList f3_list = new PointPairList();
            PointPairList f4_list = new PointPairList();
            Point center = new Point(0, 0);

            for (int radius = 1000; radius < 8000; radius += 1000)
            {
                // добавим в список точку
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                
                for (int i = 0; i < 100; ++i)
                {
                    Canonical.GetPointsForCircle(center, radius);
 
                }
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                f1_list.Add(new PointPair(radius, ts.TotalMilliseconds / 100f));

                stopWatch.Restart();

                for (int i = 0; i < 100; ++i)
                {
                    Parametric.GetPointsForCircle(center, radius);

                }
                stopWatch.Stop();
                ts = stopWatch.Elapsed;
                f2_list.Add(new PointPair(radius, ts.TotalMilliseconds / 100f));

                stopWatch.Restart();

                for (int i = 0; i < 100; ++i)
                {
                    Midpoint.GetPointsForCircle(center, radius);

                }
                stopWatch.Stop();
                ts = stopWatch.Elapsed;
                f3_list.Add(new PointPair(radius, ts.TotalMilliseconds / 100f));

                stopWatch.Restart();

                for (int i = 0; i < 100; ++i)
                {
                    Brezenhem.GetPointsByOctant(center, radius);

                }
                stopWatch.Stop();
                ts = stopWatch.Elapsed;
                f4_list.Add(new PointPair(radius, ts.TotalMilliseconds / 100f));
            }

            
            LineItem f1_curve = pane.AddCurve("Каноническое", f1_list, Color.HotPink, SymbolType.Default);
            LineItem f2_curve = pane.AddCurve("Параметрическое", f2_list, Color.Red, SymbolType.Plus);
            LineItem f3_curve = pane.AddCurve("Средняя точка", f3_list, Color.Blue, SymbolType.None);
            LineItem f4_curve = pane.AddCurve("Брезенхем", f4_list, Color.HotPink, SymbolType.Diamond);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl1.AxisChange();
            pane.Title.Text = "Среднее время работы алгоритмов отрисовки окружностей";
            pane.XAxis.Title.Text = "Радиус";
            pane.YAxis.Title.Text = "Среднее время (мс)";

            // Обновляем график
            zedGraphControl1.Invalidate();
        }

        void DrawEllipsesPlot()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl2.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            PointPairList f1_list = new PointPairList();
            PointPairList f2_list = new PointPairList();
            PointPairList f3_list = new PointPairList();
            PointPairList f4_list = new PointPairList();
            Point center = new Point(0, 0);

            for (int radius = 1000; radius < 5000; radius += 1000)
            {
                // добавим в список точку
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                for (int i = 0; i < 100; ++i)
                {
                    Canonical.GetPointsForEllipse(center, radius, radius);

                }
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                f1_list.Add(new PointPair(radius, ts.TotalMilliseconds / 100f));

                stopWatch.Restart();

                for (int i = 0; i < 100; ++i)
                {
                    Parametric.GetPointsForEllipse(center, radius, radius);

                }
                stopWatch.Stop();
                ts = stopWatch.Elapsed;
                f2_list.Add(new PointPair(radius, ts.TotalMilliseconds / 100f));

                stopWatch.Restart();

                for (int i = 0; i < 100; ++i)
                {
                    Midpoint.GetPointsForEllipse(center, radius, radius);

                }
                stopWatch.Stop();
                ts = stopWatch.Elapsed;
                f3_list.Add(new PointPair(radius, ts.TotalMilliseconds / 100f));

                stopWatch.Restart();

                for (int i = 0; i < 100; ++i)
                {
                    Brezenhem.GetPointsForEllipse(center, radius, radius);

                }
                stopWatch.Stop();
                ts = stopWatch.Elapsed;
                f4_list.Add(new PointPair(radius, ts.TotalMilliseconds / 100f));
            }


            LineItem f1_curve = pane.AddCurve("Каноническое", f1_list, Color.HotPink, SymbolType.Default);
            LineItem f2_curve = pane.AddCurve("Параметрическое", f2_list, Color.Red, SymbolType.Plus);
            LineItem f3_curve = pane.AddCurve("Средняя точка", f3_list, Color.Blue, SymbolType.None);
            LineItem f4_curve = pane.AddCurve("Брезенхем", f4_list, Color.HotPink, SymbolType.Diamond);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl2.AxisChange();
            pane.Title.Text = "Среднее время работы алгоритмов отрисовки эллипсов";
            pane.XAxis.Title.Text = "Полуоси";
            pane.YAxis.Title.Text = "Среднее время (мс)";

            // Обновляем график
            zedGraphControl2.Invalidate();
        }
    }
}
