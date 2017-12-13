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
    public partial class userTracking : MetroFramework.Controls.MetroUserControl
    {
        public static string connectionstring = Properties.Settings.Default.pommsuserdataConnectionString;
        public static SqlConnection Cn = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        static userTracking _instance1;
        public static userTracking Instance
        {
            get
            {
                if (_instance1 == null)
                    _instance1 = new userTracking();
                return _instance1;
            }
        }
        public MetroFramework.Controls.MetroPanel AddContainer
        {
            get { return tPanel; }
            set { tPanel = value; }
        }
        public userTracking()
        {
            InitializeComponent();
        }

        private void addexpenseTile_Click(object sender, EventArgs e)
        {
            if (!userTracking.Instance.AddContainer.Controls.ContainsKey("AddExpense"))
            {
                //this.addexpenseTile.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.addexpenseTile.Style = (MetroFramework.MetroColorStyle)10;
                AddExpense aex = new AddExpense();
                aex.Dock = DockStyle.Fill;
                userTracking.Instance.AddContainer.Controls.Add(aex);
            }
            userTracking.Instance.AddContainer.Controls["AddExpense"].BringToFront();
            //userTracking.Instance.MetroBack.Visible = true;
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userTracking_Load(object sender, EventArgs e)
        {
            _instance1 = this;
            AddExpense addex = new AddExpense();
            addex.Dock = DockStyle.Fill;
            tPanel.Controls.Add(addex);
        }

        private void incomeAddTile_Click(object sender, EventArgs e)
        {
            if (!userTracking.Instance.AddContainer.Controls.ContainsKey("AddIncome"))
            {
                AddIncome ain = new AddIncome();
                ain.Dock = DockStyle.Fill;
                userTracking.Instance.AddContainer.Controls.Add(ain);
            }
            userTracking.Instance.AddContainer.Controls["AddIncome"].BringToFront();
        }
    }
}
