using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_DBMS.Models;

namespace Project_DBMS.Partner.PartnerControl
{
    public partial class BranchControl : UserControl
    {
        String madoitac;
        bool version;

        public BranchControl()
        {
            InitializeComponent();
        }

        public BranchControl(String partnerID)
        {
            InitializeComponent();
            madoitac = partnerID;
        }

        public BranchControl(String partnerID, bool ver)
        {
            InitializeComponent();
            madoitac = partnerID;
            version = ver;
        }

        private void DS_CN_Button_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            //String sqlQuery = String.Format("SELECT * FROM CHINHANH WHERE MADOITAC = '{0}'", madoitac);
            //SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);

            //DataTable table = new DataTable();
            //SQLQuery.ToList().ForEach(value => table.Rows.Add(value));
            //adapter.Fill(table);
            //DSCN_Grid.DataSource = table;
            //connection.Close();

            // LINQ
            using var dbContext = new DbmsqlBanHangContext();

            var SQLQuery = from branch in dbContext.Chinhanhs
                           where branch.Madoitac == madoitac
                           select branch;
            DSCN_Grid.DataSource = SQLQuery.ToList();
        }
    }
}
