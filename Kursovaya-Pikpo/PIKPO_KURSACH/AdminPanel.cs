using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PIKPO_KURSACH
{
    public partial class AdminPanel : Form
    {
        Connection con = new Connection();
        public AdminPanel()
        {
            InitializeComponent();
        }


        private void sell_catalog_Click(object sender, EventArgs e)
        {
            FormsFromAdminPanel.selling_catalog sell_catalog = new FormsFromAdminPanel.selling_catalog();
            sell_catalog.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
        {
            con.Open();
            SQLiteDataReader row;
            string query = "SELECT * FROM Users";
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    string buy = row["buy"].ToString();
                    count.Text = (Convert.ToInt32(count.Text) + Convert.ToInt32(buy)).ToString();
                }
            }
            SQLiteDataReader row2;
            string query2 = "SELECT * FROM Selling";
            row2 = con.ExecuteReader(query2);
            if (row2.HasRows)
            {
                while (row2.Read())
                {
                    string weight = row2["weight"].ToString();
                    string count = row2["count"].ToString();
                    count2.Text = (Convert.ToInt32(count2.Text) + Convert.ToInt32(weight) * Convert.ToInt32(count)).ToString();
                    count1.Text = (Convert.ToInt32(count1.Text) + Convert.ToInt32(count)).ToString();
                }
            }
            row2.Close();
            row.Close();
            con.Close();
        }
    }
}
