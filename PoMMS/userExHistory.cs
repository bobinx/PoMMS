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
    public partial class userExHistory : MetroFramework.Controls.MetroUserControl
    {
        public userExHistory()
        {
            InitializeComponent();
            gridRefresh();
        }
        protected void gridRefresh()
        {
            try
            {
                string select = "SELECT * FROM Expense";
                SqlDataAdapter dap = new SqlDataAdapter(select, Properties.Settings.Default.pommsuserdataConnectionString);
                SqlCommandBuilder sqb = new SqlCommandBuilder(dap);                       //------------Check if needed
                DataSet ds = new DataSet();
                dap.Fill(ds);
                this.metroGrid1.DataSource = ds.Tables[0];
                this.metroGrid1.Refresh();
                this.metroGrid1.Update();
            }
            catch (Exception ex) { MessageBox.Show("Cannot bind to current DB!\ndbview.gridRefresh()" + ex); }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            gridRefresh();
        }
    }
}
