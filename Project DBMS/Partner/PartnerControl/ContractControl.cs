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
using Microsoft.EntityFrameworkCore;

namespace Project_DBMS.Partner.PartnerControl
{
    public partial class ContractControl : UserControl
    {
        //String connectionString = "";
        string madoitac = "";
        bool version;
        public ContractControl()
        {
            InitializeComponent();
            //connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }

        public ContractControl(String partnerID)
        {
            InitializeComponent();
            //connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            madoitac = partnerID;
        }

        public ContractControl(String partnerID, bool ver)
        {
            InitializeComponent();
            //connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            madoitac = partnerID;
            version = ver;
        }

        private void ContractControl_Load(object sender, EventArgs e)
        {
            // SqlConnection connection = new SqlConnection(connectionString);
            // String sqlQuery = String.Format("SELECT * FROM HOPDONG WHERE MA_NDD IN (SELECT MA_NDD FROM DOITAC WHERE MADOITAC = '{0}')", madoitac);
            // SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
            // DataTable table = new DataTable();
            // adapter.Fill(table);

            // HD_cbb.ValueMember = "MAHOPDONG";
            // HD_cbb.DisplayMember = "MAHOPDONG";
            // HD_cbb.DataSource = table;
            // HD_cbb.SelectedItem = -1;

            var dbcontext = new DbmsqlBanHangContext();
            var sqlQuery = from hopdong in dbcontext.Hopdongs
                           where (
                                from doitac in dbcontext.Doitacs
                                where doitac.Madoitac == madoitac
                                select doitac.MaNdd
                           ).ToList().Contains(hopdong.MaNdd)
                           select hopdong;

            HD_cbb.ValueMember = "MAHOPDONG";
            HD_cbb.DisplayMember = "MAHOPDONG";
            HD_cbb.DataSource = sqlQuery.ToList();
            HD_cbb.SelectedItem = -1;
        }

        private void Xem_Button_Click(object sender, EventArgs e)
        {
            // SqlConnection connection = new SqlConnection(connectionString);
            // connection.Open();
            // //DataRowView row = (DataRowView)HD_cbb.SelectedItem;
            // String contractID = HD_cbb.SelectedValue.ToString();

            // String procname = "";
            
            // if (version == true)
            // {
            //     procname = "sp_XemHopDongUnrepeatFix";
            // }

            // else if (version == false)
            // {
            //     procname = "sp_XemHopDongUnrepeat";
            // }

            // SqlCommand command = new SqlCommand(procname);
            // command.CommandType = CommandType.StoredProcedure;
            // command.Connection = connection;

            // command.Parameters.Add("@MAHOPDONG", SqlDbType.VarChar);
            // command.Parameters["@MAHOPDONG"].Value = contractID;

            // SqlDataReader reader = command.ExecuteReader();

            // DataTable table = new DataTable();
            // table.Load(reader);

            // DSHDGrid.DataSource = table;
            // connection.Close();

            // LINQ update
            String contractID = HD_cbb.SelectedValue.ToString();
            String procname = "";

            var dbcontext = new DbmsqlBanHangContext();
            
            if (version == true)
                procname = "sp_XemHopDongUnrepeatFix";
            else if (version == false)
                procname = "sp_XemHopDongUnrepeat";

            var result = dbcontext.Hopdongs.FromSqlRaw($"{procname} {contractID}").ToList();
            DSHDGrid.DataSource = result;
        }
    }
}
