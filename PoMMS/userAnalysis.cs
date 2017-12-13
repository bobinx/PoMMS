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
    public partial class userAnalysis : MetroFramework.Controls.MetroUserControl
    {
        SqlConnection Cn = new SqlConnection(Properties.Settings.Default.pommsuserdataConnectionString);
        public userAnalysis()
        {
            InitializeComponent();
        }

        private void loadlink_Click(object sender, EventArgs e)
        {
            expensechart.Visible = false;
            monthlychart.Visible = true;
            LoadGraph();
        }

        private async void analyze_Click(object sender, EventArgs e)
        {
            monthlychart.Visible = false;
            expensechart.Visible = true;
            await analyzeCat();        
            LoadChart();
        }

        private void LoadChart()
        {
            //            SqlConnection Cn = new SqlConnection(Properties.Settings.Default.pommsuserdataConnectionString);
            SqlCommand Cmd = new SqlCommand("select * from Category;", Cn);
            SqlDataReader myreader;
            try
            {
                Cn.Open();
                myreader = Cmd.ExecuteReader();
                expensechart.DataSource = myreader;
                expensechart.Series["Category"].XValueMember = "category";
                expensechart.Series["Category"].YValueMembers = "amount";
                expensechart.DataBind();
            }
            catch (Exception ex) { MessageBox.Show("Error in plotting chart:" + ex.Message); }
            Cn.Close();
        }

        
        private void LoadGraph()
        {
            float amount;
            try
            {
                SqlCommand select = new SqlCommand(), insert = new SqlCommand();
                select.Connection = Cn;
                insert.Connection = Cn;
                Cn.Open();
                for (int i = 1; i <= 12; i++)
                {
                    select.CommandText = "SELECT SUM(amount) FROM Expense where month=" + i + "";
                    var result = select.ExecuteScalar();
                    if (result != DBNull.Value)
                        amount = float.Parse(result.ToString());
                    else amount = 0;
                    insert.CommandText = "update Monthly set amount=" + amount + " where id=" + i;
                    insert.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error creating table month" + ex.Message); }
            Cn.Close();
            //draw graph
            SqlCommand Cmd = new SqlCommand("select * from Monthly;", Cn);
            SqlDataReader myreader;
            try
            {
                Cn.Open();
                myreader = Cmd.ExecuteReader();
                monthlychart.DataSource = myreader;
                monthlychart.Series["Month"].XValueMember = "month";
                monthlychart.Series["Month"].YValueMembers = "amount";
                monthlychart.DataBind();
                Cn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error plotting graph" + ex.Message); }
            }


    private async Task analyzeCat()
    {
    float amount;
            try
            {
                SqlCommand select = new SqlCommand(), insert = new SqlCommand();
                select.Connection = Cn;
                insert.Connection = Cn;
                Cn.Open();
                
                    select.CommandText = "SELECT SUM(amount) FROM Expense where category='Food'";
                    var result = select.ExecuteScalar();
                    if (result != DBNull.Value)
                        amount = float.Parse(result.ToString());
                    else amount = 0;
                    insert.CommandText = "update Category set amount=" + amount + " where category='Food'";
                    insert.ExecuteNonQuery();

                    select.CommandText = "SELECT SUM(amount) FROM Expense where category='Stationary'";
                    var result1 = select.ExecuteScalar();
                    if (result1 != DBNull.Value)
                        amount = float.Parse(result1.ToString());
                    else amount = 0;
                    insert.CommandText = "update Category set amount=" + amount + " where category='Stationary'";
                    insert.ExecuteNonQuery();

                    select.CommandText = "SELECT SUM(amount) FROM Expense where category='Clothing'";
                    var result2 = select.ExecuteScalar();
                    if (result2 != DBNull.Value)
                        amount = float.Parse(result2.ToString());
                    else amount = 0;
                    insert.CommandText = "update Category set amount=" + amount + " where category='Clothing'";
                    insert.ExecuteNonQuery();

                    select.CommandText = "SELECT SUM(amount) FROM Expense where category='Entertainment'";
                    var result3 = select.ExecuteScalar();
                    if (result3 != DBNull.Value)
                        amount = float.Parse(result3.ToString());
                    else amount = 0;
                    insert.CommandText = "update Category set amount=" + amount + " where category='Entertainment'";
                    insert.ExecuteNonQuery();

                    select.CommandText = "SELECT SUM(amount) FROM Expense where category='Other'";
                    var result4 = select.ExecuteScalar();
                    if (result4 != DBNull.Value)
                        amount = float.Parse(result4.ToString());
                    else amount = 0;
                    insert.CommandText = "update Category set amount=" + amount + " where category='Other'";
                    insert.ExecuteNonQuery();
            
            }
            catch (Exception ex) { MessageBox.Show("Error creating table Category" + ex.Message); }
            Cn.Close();
    }

    private void expensechart_Click(object sender, EventArgs e)
    {

    }

    private void metroPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void userAnalysis_Load(object sender, EventArgs e)
    {

    }


        //end class namespace
}

}