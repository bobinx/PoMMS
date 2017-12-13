namespace PoMMS
{
    partial class AddIncome
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.statustrack = new MetroFramework.Controls.MetroLabel();
            this.statuslabel = new MetroFramework.Controls.MetroLabel();
            this.incCat = new MetroFramework.Controls.MetroComboBox();
            this.incDesc = new MetroFramework.Controls.MetroTextBox();
            this.incAmt = new MetroFramework.Controls.MetroTextBox();
            this.addIncButton = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.statustrack);
            this.metroPanel1.Controls.Add(this.statuslabel);
            this.metroPanel1.Controls.Add(this.incCat);
            this.metroPanel1.Controls.Add(this.incDesc);
            this.metroPanel1.Controls.Add(this.incAmt);
            this.metroPanel1.Controls.Add(this.addIncButton);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 10);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(373, 320);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // statustrack
            // 
            this.statustrack.AutoSize = true;
            this.statustrack.Location = new System.Drawing.Point(64, 200);
            this.statustrack.Name = "statustrack";
            this.statustrack.Size = new System.Drawing.Size(0, 0);
            this.statustrack.TabIndex = 11;
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.statuslabel.Location = new System.Drawing.Point(143, 196);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(0, 0);
            this.statuslabel.TabIndex = 10;
            // 
            // incCat
            // 
            this.incCat.FormattingEnabled = true;
            this.incCat.ItemHeight = 23;
            this.incCat.Items.AddRange(new object[] {
            "Pocket Money",
            "Salary",
            "Miscellaneous"});
            this.incCat.Location = new System.Drawing.Point(140, 52);
            this.incCat.Name = "incCat";
            this.incCat.Size = new System.Drawing.Size(203, 29);
            this.incCat.TabIndex = 9;
            this.incCat.UseSelectable = true;
            // 
            // incDesc
            // 
            // 
            // 
            // 
            this.incDesc.CustomButton.Image = null;
            this.incDesc.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.incDesc.CustomButton.Name = "";
            this.incDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.incDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.incDesc.CustomButton.TabIndex = 1;
            this.incDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.incDesc.CustomButton.UseSelectable = true;
            this.incDesc.CustomButton.Visible = false;
            this.incDesc.Lines = new string[0];
            this.incDesc.Location = new System.Drawing.Point(140, 91);
            this.incDesc.MaxLength = 32767;
            this.incDesc.Name = "incDesc";
            this.incDesc.PasswordChar = '\0';
            this.incDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.incDesc.SelectedText = "";
            this.incDesc.SelectionLength = 0;
            this.incDesc.SelectionStart = 0;
            this.incDesc.ShortcutsEnabled = true;
            this.incDesc.Size = new System.Drawing.Size(203, 23);
            this.incDesc.TabIndex = 8;
            this.incDesc.UseSelectable = true;
            this.incDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.incDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // incAmt
            // 
            // 
            // 
            // 
            this.incAmt.CustomButton.Image = null;
            this.incAmt.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.incAmt.CustomButton.Name = "";
            this.incAmt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.incAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.incAmt.CustomButton.TabIndex = 1;
            this.incAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.incAmt.CustomButton.UseSelectable = true;
            this.incAmt.CustomButton.Visible = false;
            this.incAmt.Lines = new string[0];
            this.incAmt.Location = new System.Drawing.Point(140, 17);
            this.incAmt.MaxLength = 32767;
            this.incAmt.Name = "incAmt";
            this.incAmt.PasswordChar = '\0';
            this.incAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.incAmt.SelectedText = "";
            this.incAmt.SelectionLength = 0;
            this.incAmt.SelectionStart = 0;
            this.incAmt.ShortcutsEnabled = true;
            this.incAmt.Size = new System.Drawing.Size(203, 23);
            this.incAmt.TabIndex = 6;
            this.incAmt.UseSelectable = true;
            this.incAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.incAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addIncButton
            // 
            this.addIncButton.ActiveControl = null;
            this.addIncButton.Location = new System.Drawing.Point(140, 140);
            this.addIncButton.Name = "addIncButton";
            this.addIncButton.Size = new System.Drawing.Size(99, 38);
            this.addIncButton.TabIndex = 5;
            this.addIncButton.Text = "Add Income";
            this.addIncButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addIncButton.UseSelectable = true;
            this.addIncButton.Click += new System.EventHandler(this.addIncButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 91);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Description    :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Category       :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Amount         :";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "AddIncome";
            this.Size = new System.Drawing.Size(389, 338);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox incAmt;
        private MetroFramework.Controls.MetroTile addIncButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox incDesc;
        private MetroFramework.Controls.MetroComboBox incCat;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel statuslabel;
        public MetroFramework.Controls.MetroLabel statustrack;
    }
}
