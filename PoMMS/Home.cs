using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoMMS
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        static Home _instance;
        public static Home Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Home();
                return _instance;
            }
        }
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mPanel; }
            set { mPanel = value; }
        }
        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return mlBack; }
            set { mlBack = value; }
        }

        public Home()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
       /* void fetchStatus()
        { 
        //------------------------------------------------------------------------
            SqlConnection Cn = new SqlConnection();
            Cn.ConnectionString = Properties.Settings.Default.pommsuserdataConnectionString;
            SqlCommand Cmd = new SqlCommand("SELECT amount FROM Income;", Cn);
            Cn.Open();
            float income = 0, expense = 0;
            using (var reader = Cmd.ExecuteReader())
            {
                var index1 = reader.GetOrdinal("amount");
                while (reader.Read())
                {
                    var amount = reader.GetValue(index1);
                    income = income + (float)amount;
                }
            }
            Cmd = new SqlCommand("SELECT amount FROM Expense;", Cn);
            using (var reader = Cmd.ExecuteReader())
            {
                var index1 = reader.GetOrdinal("amount");
                while (reader.Read())
                {
                    var amount = reader.GetValue(index1);
                    expense = expense + (float)amount;
                }
            }
            Properties.Settings.Default.income = income;
            Properties.Settings.Default.expense = expense;

            Cn.Close();

        //----------------------------------------------------------------------
        }*/
        

        private async void Home_Load(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Style = (MetroFramework.MetroColorStyle)9;
            mlBack.Visible = false;
            _instance = this;
            await pocketUpdate();
            Dashboard dash = new Dashboard();
            dash.Dock = DockStyle.Fill;
            //fetchStatus();
            mPanel.Controls.Add(dash);
        }

        private void mlBack_Click(object sender, EventArgs e)
        {
            mPanel.Controls["Dashboard"].BringToFront();
            mlBack.Visible = false;
        }

        public async Task pocketUpdate()
        {
            SqlConnection Cn = new SqlConnection(Properties.Settings.Default.pommsuserdataConnectionString);
            try
            {
                float amount;
                SqlCommand inc = new SqlCommand(), exp = new SqlCommand();
                inc.Connection = Cn;
                exp.Connection = Cn;
                Cn.Open();
                    exp.CommandText = "SELECT SUM(amount) FROM Expense";
                    inc.CommandText = "SELECT SUM(amount) FROM Income";
                    var income = inc.ExecuteScalar();
                    if (income != DBNull.Value)
                        amount = float.Parse(income.ToString());
                    else amount = 0;
                    Properties.Settings.Default.income=amount;

                    var expense= exp.ExecuteScalar();
                    if (expense != DBNull.Value)
                        amount = float.Parse(expense.ToString());
                    else amount = 0;
                    Properties.Settings.Default.expense = amount;
                }
            catch (Exception ex) { MessageBox.Show("Error in updating status at Dashboard" + ex.GetBaseException()); }
            Cn.Close();
        }
    }
}
