using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PoMMS
{
    public partial class AddExpense : MetroFramework.Controls.MetroUserControl
    {
        public AddExpense()
        {
            InitializeComponent();
        }

        private void addExpButton_Click(object sender, EventArgs e)
        {
            string amount=expAmt.Text,category=expCat.Text,description=expDesc.Text;
            DateTime date = DateTime.Now;
            string id=date.Minute+""+date.Second;
            Regex regex = new Regex("^[0-9.]+$");
            if (regex.IsMatch(amount))
            {
                if (category != "")
                {
                    try
                    {
                        float amt = float.Parse(amount);
                        userTracking.Cn.ConnectionString = Properties.Settings.Default.pommsuserdataConnectionString;
                        userTracking.Cn.Open();
                        userTracking.cmd.Parameters.Clear();
                        userTracking.cmd.Connection = userTracking.Cn;
                        userTracking.cmd.CommandText = "insert into Expense values (@id,@date,@month,@year,@amount,@category,@description)";
                        userTracking.cmd.Parameters.Add("@id", id);
                        userTracking.cmd.Parameters.Add("@date", date.Day);
                        userTracking.cmd.Parameters.Add("@month", date.Month);
                        userTracking.cmd.Parameters.Add("@year", date.Year);
                        userTracking.cmd.Parameters.Add("@amount", amt);
                        userTracking.cmd.Parameters.Add("@category", category);
                        userTracking.cmd.Parameters.Add("@description", description);
                        userTracking.cmd.ExecuteNonQuery();
                        userTracking.cmd.Parameters.Clear();
                        userTracking.Cn.Close();

                        Properties.Settings.Default.expense+=amt;
                        Properties.Settings.Default.Save();
                        float pc = (Properties.Settings.Default.expense / Properties.Settings.Default.income) * 100;
                        statustrack.Text = "Added Expense!\nYou have used up " + pc.ToString("#00.00") + "% of your income!";
                    }
                    catch (Exception ex) { userTracking.Cn.Close(); MessageBox.Show("Cannot Add Expense [AdddExpense.cs]" + ex.Message); }
                }
                else MessageBox.Show(this,"Choose a Category");
            }
            else MessageBox.Show("Enter a valid amount");
        }//end-------------------------------------------------------------------
        }
    }

