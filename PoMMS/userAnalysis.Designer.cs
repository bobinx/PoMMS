namespace PoMMS
{
    partial class userAnalysis
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.analyze = new MetroFramework.Controls.MetroLink();
            this.graphLink = new MetroFramework.Controls.MetroLink();
            this.monthlychart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.expensechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlychart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensechart)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.analyze);
            this.metroPanel1.Controls.Add(this.graphLink);
            this.metroPanel1.Controls.Add(this.expensechart);
            this.metroPanel1.Controls.Add(this.monthlychart);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(765, 358);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // analyze
            // 
            this.analyze.Image = global::PoMMS.Properties.Resources._1477247906_57;
            this.analyze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analyze.ImageSize = 60;
            this.analyze.Location = new System.Drawing.Point(0, 0);
            this.analyze.Name = "analyze";
            this.analyze.Size = new System.Drawing.Size(61, 59);
            this.analyze.TabIndex = 5;
            this.analyze.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.analyze.UseSelectable = true;
            this.analyze.Click += new System.EventHandler(this.analyze_Click);
            // 
            // graphLink
            // 
            this.graphLink.Image = global::PoMMS.Properties.Resources._1477248018_40;
            this.graphLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphLink.ImageSize = 60;
            this.graphLink.Location = new System.Drawing.Point(0, 58);
            this.graphLink.Name = "graphLink";
            this.graphLink.Size = new System.Drawing.Size(61, 60);
            this.graphLink.TabIndex = 4;
            this.graphLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.graphLink.UseSelectable = true;
            this.graphLink.Click += new System.EventHandler(this.loadlink_Click);
            // 
            // monthlychart
            // 
            chartArea5.Name = "ChartArea1";
            this.monthlychart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.monthlychart.Legends.Add(legend5);
            this.monthlychart.Location = new System.Drawing.Point(67, 9);
            this.monthlychart.Name = "monthlychart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            series5.Legend = "Legend1";
            series5.Name = "Month";
            series5.YValuesPerPoint = 2;
            this.monthlychart.Series.Add(series5);
            this.monthlychart.Size = new System.Drawing.Size(684, 275);
            this.monthlychart.TabIndex = 3;
            this.monthlychart.Text = "chart2";
            // 
            // expensechart
            // 
            chartArea6.Name = "ChartArea1";
            this.expensechart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.expensechart.Legends.Add(legend6);
            this.expensechart.Location = new System.Drawing.Point(55, -4);
            this.expensechart.Name = "expensechart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "Category";
            series6.YValuesPerPoint = 4;
            this.expensechart.Series.Add(series6);
            this.expensechart.Size = new System.Drawing.Size(696, 294);
            this.expensechart.TabIndex = 2;
            this.expensechart.Text = "chart1";
            this.expensechart.Click += new System.EventHandler(this.expensechart_Click);
            // 
            // userAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "userAnalysis";
            this.Size = new System.Drawing.Size(771, 364);
            this.Load += new System.EventHandler(this.userAnalysis_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthlychart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensechart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink graphLink;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthlychart;
        private System.Windows.Forms.DataVisualization.Charting.Chart expensechart;
        private MetroFramework.Controls.MetroLink analyze;
    }
}
