using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Controls
{
    public class Chart : Telerik.WinControls.UI.RadChartView
    {
        // private Telerik.WinControls.UI.RadPrintDocument PrintDocument;
        private RASF.General.Controls.Button btnPrint;
        public Chart()
            : base()
        {
            Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.ThemeName = "Office2013LightTheme";
            //    this.PrintDocument = new Telerik.WinControls.UI.RadPrintDocument();
            //  this.PrintDocument.DefaultPageSettings.Landscape = true;
            this.ShowGrid = true;

            this.btnPrint = new RASF.General.Controls.Button();
            this.btnPrint.Text = "چاپ";
            this.btnPrint.Size = new System.Drawing.Size(40, 25);
            this.btnPrint.Location = new System.Drawing.Point(this.Width - btnPrint.Width - 5, 5);
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))));
            this.btnPrint.Click += btnPrint_Click;
            this.Controls.Add(btnPrint);

            this.ShowTitle = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //   this.Print(true, this.PrintDocument);
        }

        public void DrawBarChart(String XValue, String YValye, String Title)
        {
            this.Title = Title;
            this.Series.Clear();
            this.Update();
            Telerik.WinControls.UI.CartesianArea area = this.GetArea<Telerik.WinControls.UI.CartesianArea>();
            area.ShowGrid = true;
            Telerik.WinControls.UI.CategoricalAxis horizontalAxis = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis verticalAcix = new Telerik.WinControls.UI.LinearAxis();
            verticalAcix.AxisType = Telerik.Charting.AxisType.Second;
            verticalAcix.LabelFormat = "{0:###,###,###,###,###}";
            Telerik.WinControls.UI.BarSeries series = new Telerik.WinControls.UI.BarSeries(XValue, YValye);
            series.HorizontalAxis = horizontalAxis;
            series.VerticalAxis = verticalAcix;
            series.DataSource = this.DataSource;
            series.ShowLabels = true;
            series.LabelFormat = "{0:###,###,###,###,###}";
            series.Palette = new Telerik.WinControls.UI.PaletteEntry(System.Drawing.Color.White, System.Drawing.Color.Black);
            this.Series.Add(series);
            //  this.ChartElement.TitlePosition =System.Drawing.;
            // this.ChartElement.Font.Size =12;
        }

        public void DrawLineChart(String XValue, String YValye, String Title)
        {
            this.Title = Title;
            this.Series.Clear();
            Telerik.WinControls.UI.CartesianArea area = this.GetArea<Telerik.WinControls.UI.CartesianArea>();
            area.ShowGrid = true;
            Telerik.WinControls.UI.CategoricalAxis horizontalAxis = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis verticalAxis = new Telerik.WinControls.UI.LinearAxis();
            verticalAxis.AxisType = Telerik.Charting.AxisType.Second;
            verticalAxis.LabelFormat = "{0:###,###,###,###,###}";
            Telerik.WinControls.UI.LineSeries series = new Telerik.WinControls.UI.LineSeries();
            series.PointSize = new System.Drawing.SizeF(7, 7);
            series.HorizontalAxis = horizontalAxis;
            series.VerticalAxis = verticalAxis;
            series.BorderWidth = 2;
            series.CombineMode = Telerik.Charting.ChartSeriesCombineMode.None;
            series.DataSource = this.DataSource;
            series.CategoryMember = XValue;
            series.ValueMember = YValye;
            series.ShowLabels = true;
            series.LabelFormat = "{0:###,###,###,###,###}";
            series.Palette = new Telerik.WinControls.UI.PaletteEntry(System.Drawing.Color.White, System.Drawing.Color.Black);
            this.Series.Add(series);
        }
    }
}


