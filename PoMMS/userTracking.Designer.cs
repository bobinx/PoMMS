namespace PoMMS
{
    partial class userTracking
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tPanel = new MetroFramework.Controls.MetroPanel();
            this.addexpenseTile = new MetroFramework.Controls.MetroTile();
            this.incomeAddTile = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tPanel);
            this.metroPanel1.Controls.Add(this.addexpenseTile);
            this.metroPanel1.Controls.Add(this.incomeAddTile);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(7, 7);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(708, 346);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // tPanel
            // 
            this.tPanel.HorizontalScrollbarBarColor = true;
            this.tPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.tPanel.HorizontalScrollbarSize = 10;
            this.tPanel.Location = new System.Drawing.Point(320, 11);
            this.tPanel.Name = "tPanel";
            this.tPanel.Size = new System.Drawing.Size(372, 321);
            this.tPanel.TabIndex = 4;
            this.tPanel.VerticalScrollbarBarColor = true;
            this.tPanel.VerticalScrollbarHighlightOnWheel = false;
            this.tPanel.VerticalScrollbarSize = 10;
            // 
            // addexpenseTile
            // 
            this.addexpenseTile.ActiveControl = null;
            this.addexpenseTile.Location = new System.Drawing.Point(21, 22);
            this.addexpenseTile.Name = "addexpenseTile";
            this.addexpenseTile.Size = new System.Drawing.Size(284, 66);
            this.addexpenseTile.TabIndex = 3;
            this.addexpenseTile.Text = "Add Expense";
            this.addexpenseTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addexpenseTile.UseSelectable = true;
            this.addexpenseTile.Click += new System.EventHandler(this.addexpenseTile_Click);
            // 
            // incomeAddTile
            // 
            this.incomeAddTile.ActiveControl = null;
            this.incomeAddTile.Location = new System.Drawing.Point(21, 94);
            this.incomeAddTile.Name = "incomeAddTile";
            this.incomeAddTile.Size = new System.Drawing.Size(284, 66);
            this.incomeAddTile.TabIndex = 2;
            this.incomeAddTile.Text = "Add Income";
            this.incomeAddTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomeAddTile.UseSelectable = true;
            this.incomeAddTile.Click += new System.EventHandler(this.incomeAddTile_Click);
            // 
            // userTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "userTracking";
            this.Size = new System.Drawing.Size(723, 361);
            this.Load += new System.EventHandler(this.userTracking_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile incomeAddTile;
        private MetroFramework.Controls.MetroTile addexpenseTile;
        private MetroFramework.Controls.MetroPanel tPanel;
    }
}
