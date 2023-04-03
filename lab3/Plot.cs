using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace lab3
{
    public partial class Plot : Form
    {
        public Plot()
        {
            InitializeComponent();

            DrawGraph();
        }

        private void DrawGraph()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            int itemsCount = 5;
            // Подписи под столбиками
            string[] names = new string[]{ "ЦДА", "Цел. Бр.", "Действ. Бр.", "Глад. Бр.", "Ву" };

            // Высота столбиков
            double[] values = new double[itemsCount];

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 1000; ++i)
            {
                DDA.Dda(0, 0, 1000, 1000, Color.Black, out int steps);
            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            values[0] = ts.TotalMilliseconds / 1000f;
            
            stopWatch.Restart();
            for (int i = 0; i < 1000; ++i)
            {
                Brezenhem.BrezenhemFloat(0, 0, 1000, 1000, Color.Black, out int steps);
            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;
            values[1] = ts.TotalMilliseconds / 1000f;
            
            
            stopWatch.Restart();
            for (int i = 0; i < 1000; ++i)
            {
                Brezenhem.BrezenhemInteger(0, 0, 1000, 1000, Color.Black, out int steps);
            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;
            values[2] = ts.TotalMilliseconds / 1000f;


            stopWatch.Restart();
            for (int i = 0; i < 1000; ++i)
            {
                Brezenhem.BrezenhemSmooth(0, 0, 1000, 1000, Color.Black, out int steps);
            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;
            values[3] = ts.TotalMilliseconds / 1000f;



            stopWatch.Restart();
            for (int i = 0; i < 1000; ++i)
            {
                VU.Vu(0, 0, 1000, 1000, Color.Black, out int steps);
            }
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;
            values[4] = ts.TotalMilliseconds / 1000f;



            // Создадим кривую-гистограмму
            // Первый параметр - название кривой для легенды
            // Второй параметр - значения для оси X, т.к. у нас по этой оси будет идти текст, а функция ожидает тип параметра double[], то пока передаем null
            // Третий параметр - значения для оси Y
            // Четвертый параметр - цвет
            BarItem curve = pane.AddBar("Замеры скорости", null, values, Color.Blue);

            // Настроим ось X так, чтобы она отображала текстовые данные
            pane.XAxis.Type = AxisType.Text;

            // Уставим для оси наши подписи
            pane.XAxis.Scale.TextLabels = names;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            zedGraph.AxisChange();
            pane.XAxis.Title.Text = "Методы";
            pane.YAxis.Title.Text = "Среднее время работы алгоритма в мс";
            pane.Title.Text = "Исследования времени работы";

            // Обновляем график
            zedGraph.Invalidate();
        }
    }
}
