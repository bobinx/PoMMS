namespace PoMMS
{
    partial class AddExpense
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
            this.expCat = new MetroFramework.Controls.MetroComboBox();
            this.expDesc = new MetroFramework.Controls.MetroTextBox();
            this.expAmt = new MetroFramework.Controls.MetroTextBox();
            this.addExpButton = new MetroFramework.Controls.MetroTile();
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
            this.metroPanel1.Controls.Add(this.expCat);
            this.metroPanel1.Controls.Add(this.expDesc);
            this.metroPanel1.Controls.Add(this.expAmt);
            this.metroPanel1.Controls.Add(this.addExpButton);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 10);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(373, 320);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // statustrack
            // 
            this.statustrack.AutoSize = true;
            this.statustrack.Location = new System.Drawing.Point(64, 198);
            this.statustrack.Name = "statustrack";
            this.statustrack.Size = new System.Drawing.Size(0, 0);
            this.statustrack.TabIndex = 10;
            // 
            // expCat
            // 
            this.expCat.FormattingEnabled = true;
            this.expCat.ItemHeight = 23;
            this.expCat.Items.AddRange(new object[] {
            "Food",
            "Stationary",
            "Clothing",
            "Entertainment"});
            this.expCat.Location = new System.Drawing.Point(140, 52);
            this.expCat.Name = "expCat";
            this.expCat.Size = new System.Drawing.Size(203, 29);
            this.expCat.TabIndex = 9;
            this.expCat.UseSelectable = true;
            // 
            // expDesc
            // 
            // 
            // 
            // 
            this.expDesc.CustomButton.Image = null;
            this.expDesc.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.expDesc.CustomButton.Name = "";
            this.expDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.expDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.expDesc.CustomButton.TabIndex = 1;
            this.expDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.expDesc.CustomButton.UseSelectable = true;
            this.expDesc.CustomButton.Visible = false;
            this.expDesc.Lines = new string[0];
            this.expDesc.Location = new System.Drawing.Point(140, 91);
            this.expDesc.MaxLength = 32767;
            this.expDesc.Name = "expDesc";
            this.expDesc.PasswordChar = '\0';
            this.expDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.expDesc.SelectedText = "";
            this.expDesc.SelectionLength = 0;
            this.expDesc.SelectionStart = 0;
            this.expDesc.ShortcutsEnabled = true;
            this.expDesc.Size = new System.Drawing.Size(203, 23);
            this.expDesc.TabIndex = 8;
            this.expDesc.UseSelectable = true;
            this.expDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.expDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // expAmt
            // 
            // 
            // 
            // 
            this.expAmt.CustomButton.Image = null;
            this.expAmt.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.expAmt.CustomButton.Name = "";
            this.expAmt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.expAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.expAmt.CustomButton.TabIndex = 1;
            this.expAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.expAmt.CustomButton.UseSelectable = true;
            this.expAmt.CustomButton.Visible = false;
            this.expAmt.Lines = new string[0];
            this.expAmt.Location = new System.Drawing.Point(140, 17);
            this.expAmt.MaxLength = 32767;
            this.expAmt.Name = "expAmt";
            this.expAmt.PasswordChar = '\0';
            this.expAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.expAmt.SelectedText = "";
            this.expAmt.SelectionLength = 0;
            this.expAmt.SelectionStart = 0;
            this.expAmt.ShortcutsEnabled = true;
            this.expAmt.Size = new System.Drawing.Size(203, 23);
            this.expAmt.TabIndex = 6;
            this.expAmt.UseSelectable = true;
            this.expAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.expAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addExpButton
            // 
            this.addExpButton.ActiveControl = null;
            this.addExpButton.Location = new System.Drawing.Point(140, 140);
            this.addExpButton.Name = "addExpButton";
            this.addExpButton.Size = new System.Drawing.Size(99, 38);
            this.addExpButton.TabIndex = 5;
            this.addExpButton.Text = "Add Expense";
            this.addExpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addExpButton.UseSelectable = true;
            this.addExpButton.Click += new System.EventHandler(this.addExpButton_Click);
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
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "AddExpense";
            this.Size = new System.Drawing.Size(391, 338);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox expCat;
        private MetroFramework.Controls.MetroTextBox expDesc;
        private MetroFramework.Controls.MetroTextBox expAmt;
        private MetroFramework.Controls.MetroTile addExpButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public MetroFramework.Controls.MetroLabel statustrack;
    }
}
