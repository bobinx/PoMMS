namespace PoMMS
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.statuslabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.ovchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.expenselabel = new MetroFramework.Controls.MetroLabel();
            this.incomelabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.anTile = new MetroFramework.Controls.MetroTile();
            this.viewInTile = new MetroFramework.Controls.MetroTile();
            this.viewExTile = new MetroFramework.Controls.MetroTile();
            this.trackTile = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.statuslabel);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.anTile);
            this.metroPanel1.Controls.Add(this.viewInTile);
            this.metroPanel1.Controls.Add(this.viewExTile);
            this.metroPanel1.Controls.Add(this.trackTile);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(759, 313);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Location = new System.Drawing.Point(31, 252);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(93, 19);
            this.statuslabel.TabIndex = 7;
            this.statuslabel.Text = "You have used";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.ovchart);
            this.metroPanel2.Controls.Add(this.expenselabel);
            this.metroPanel2.Controls.Add(this.incomelabel);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(517, 17);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(239, 254);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // ovchart
            // 
            chartArea2.Name = "Expense";
            this.ovchart.ChartAreas.Add(chartArea2);
            this.ovchart.Cursor = System.Windows.Forms.Cursors.Hand;
            legend2.Name = "Legend1";
            this.ovchart.Legends.Add(legend2);
            this.ovchart.Location = new System.Drawing.Point(2, 83);
            this.ovchart.Name = "ovchart";
            this.ovchart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ovchart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.Teal,
        System.Drawing.Color.Green};
            series2.ChartArea = "Expense";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Expense";
            this.ovchart.Series.Add(series2);
            this.ovchart.Size = new System.Drawing.Size(234, 168);
            this.ovchart.TabIndex = 7;
            this.ovchart.Text = "ovchart";
            this.ovchart.Click += new System.EventHandler(this.ovchart_Click);
            // 
            // expenselabel
            // 
            this.expenselabel.AutoSize = true;
            this.expenselabel.Location = new System.Drawing.Point(80, 61);
            this.expenselabel.Name = "expenselabel";
            this.expenselabel.Size = new System.Drawing.Size(0, 0);
            this.expenselabel.TabIndex = 6;
            this.expenselabel.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // incomelabel
            // 
            this.incomelabel.AutoSize = true;
            this.incomelabel.Location = new System.Drawing.Point(80, 30);
            this.incomelabel.Name = "incomelabel";
            this.incomelabel.Size = new System.Drawing.Size(0, 0);
            this.incomelabel.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 61);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Expense  :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Income   :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Overview:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // anTile
            // 
            this.anTile.ActiveControl = null;
            this.anTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anTile.Location = new System.Drawing.Point(275, 24);
            this.anTile.Name = "anTile";
            this.anTile.Size = new System.Drawing.Size(236, 96);
            this.anTile.TabIndex = 5;
            this.anTile.Text = "Visualize";
            this.anTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.anTile.UseSelectable = true;
            this.anTile.Click += new System.EventHandler(this.anTile_Click);
            // 
            // viewInTile
            // 
            this.viewInTile.ActiveControl = null;
            this.viewInTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewInTile.Location = new System.Drawing.Point(20, 138);
            this.viewInTile.Name = "viewInTile";
            this.viewInTile.Size = new System.Drawing.Size(236, 96);
            this.viewInTile.TabIndex = 4;
            this.viewInTile.Text = "View Income";
            this.viewInTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewInTile.UseSelectable = true;
            this.viewInTile.Click += new System.EventHandler(this.viewInTile_Click);
            // 
            // viewExTile
            // 
            this.viewExTile.ActiveControl = null;
            this.viewExTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExTile.Location = new System.Drawing.Point(275, 138);
            this.viewExTile.Name = "viewExTile";
            this.viewExTile.Size = new System.Drawing.Size(236, 96);
            this.viewExTile.TabIndex = 3;
            this.viewExTile.Text = "View Expense";
            this.viewExTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewExTile.UseSelectable = true;
            this.viewExTile.Click += new System.EventHandler(this.viewExTile_Click);
            // 
            // trackTile
            // 
            this.trackTile.ActiveControl = null;
            this.trackTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackTile.Location = new System.Drawing.Point(20, 24);
            this.trackTile.Name = "trackTile";
            this.trackTile.Size = new System.Drawing.Size(239, 96);
            this.trackTile.TabIndex = 2;
            this.trackTile.Text = "Expense tracking";
            this.trackTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.trackTile.UseSelectable = true;
            this.trackTile.Click += new System.EventHandler(this.trackTile_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Lime;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(765, 320);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile viewExTile;
        private MetroFramework.Controls.MetroTile trackTile;
        private MetroFramework.Controls.MetroTile anTile;
        private MetroFramework.Controls.MetroTile viewInTile;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel expenselabel;
        private MetroFramework.Controls.MetroLabel incomelabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel statuslabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ovchart;

    }
}
