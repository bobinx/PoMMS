using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PoMMS
{
    public partial class Dashboard : MetroFramework.Controls.MetroUserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackTile_Click(object sender, EventArgs e)
        {
            if (!Home.Instance.MetroContainer.Controls.ContainsKey("userTracking"))
            {
                userTracking utr = new userTracking();
                utr.Dock = DockStyle.Fill;
                Home.Instance.MetroContainer.Controls.Add(utr);
            }
            Home.Instance.MetroContainer.Controls["userTracking"].BringToFront();
            Home.Instance.MetroBack.Visible = true;
        }

        private void viewExTile_Click(object sender, EventArgs e)
        {
            if (!Home.Instance.MetroContainer.Controls.ContainsKey("userExHistory"))
            {
                userExHistory uhis = new userExHistory();
                uhis.Dock = DockStyle.Fill;
                Home.Instance.MetroContainer.Controls.Add(uhis);
            }
            Home.Instance.MetroContainer.Controls["userExHistory"].BringToFront();
            Home.Instance.MetroBack.Visible = true;
        }


        private void anTile_Click(object sender, EventArgs e)
        {
            if (!Home.Instance.MetroContainer.Controls.ContainsKey("userAnalysis"))
            {
                userAnalysis uan = new userAnalysis();
                uan.Dock = DockStyle.Fill;
                Home.Instance.MetroContainer.Controls.Add(uan);
            }
            Home.Instance.MetroContainer.Controls["userAnalysis"].BringToFront();
            Home.Instance.MetroBack.Visible = true;
        }

        private void viewInTile_Click(object sender, EventArgs e)
        {
            if (!Home.Instance.MetroContainer.Controls.ContainsKey("userInHistory"))
            {
                userInHistory inhis = new userInHistory();
                inhis.Dock = DockStyle.Fill;
                Home.Instance.MetroContainer.Controls.Add(inhis);
            }
            Home.Instance.MetroContainer.Controls["userInHistory"].BringToFront();
            Home.Instance.MetroBack.Visible = true;
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            incomelabel.Text = Properties.Settings.Default.income.ToString();
            expenselabel.Text = Properties.Settings.Default.expense.ToString();
            float pc = (Properties.Settings.Default.expense / Properties.Settings.Default.income) * 100;
            statuslabel.Text = "You have used up " + pc.ToString("#00.00") + "% of your income!";
            chartUpdate();
        }

        private void ovchart_Click(object sender, EventArgs e)
        {
            chartUpdate();
        }
        private void chartUpdate() {
            
            ovchart.Series["Expense"].Points.AddXY("Remaining", Properties.Settings.Default.income - Properties.Settings.Default.expense);
            ovchart.Series["Expense"].Points.AddXY("Spent", Properties.Settings.Default.expense);
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
         
        }

    }
}
