
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace project_RAD
{
    public partial class GraphForm : Form
    {
        // Дата и сумма по дате
        private List<Tuple<DateTime, decimal>> graphData;

        public GraphForm(List<Tuple<DateTime, decimal>> graphData)
        {
            InitializeComponent();
            this.graphData = graphData;
            InitializeGraph();
        }

        private void InitializeGraph()
        {
            // Очистка предыдущих серий данных
            chart.Series.Clear();

            // Группировка данных по дате
            var groupedData = graphData.GroupBy(data => data.Item1)
                                       .Select(g => new { Date = g.Key, TotalSum = g.Sum(item => item.Item2) })
                                       .OrderBy(g => g.Date);

            // Создание серии данных
            Series series = new Series("Суммы к оплате")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.DateTime
            };

            foreach (var data in groupedData)
            {
                series.Points.AddXY(data.Date, data.TotalSum);
            }

            // Добавление серии на график
            chart.Series.Add(series);

            // Настройка осей графика
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yyyy";
            chart.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;

            // Настройка легенды
            chart.Legends[0].Enabled = true;
        }
    }
}