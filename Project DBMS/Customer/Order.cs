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

namespace Project_DBMS.Customer
{
    public partial class Order : Form
    {
        String connectionString = "";
        bool version;

        public Order()
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }

        public Order(bool ver)
        {
            InitializeComponent();
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            version = ver;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            String sqlQuery = "SELECT * FROM MONAN, THUCDON WHERE TENMON = TENMONAN";
            SqlDataAdapter TDadapter = new SqlDataAdapter(sqlQuery, connection);
            DataTable TDtable = new DataTable();
            TDadapter.Fill(TDtable);

            TD_Grid.AutoGenerateColumns = false;
            TD_Grid.DataSource = TDtable;

            sqlQuery = "SELECT * FROM CHINHANH";
            SqlDataAdapter CNadapter = new SqlDataAdapter(sqlQuery, connection);
            DataTable CNtable = new DataTable();
            CNadapter.Fill(CNtable);

            CN_cbb.ValueMember = "MACHINHANH";
            CN_cbb.DisplayMember = "MACHINHANH";
            CN_cbb.DataSource = CNtable;
            CN_cbb.SelectedItem = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sẽ được thêm vào sau!!!");
        }

        private void btn_Tailai_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataRowView row = (DataRowView)CN_cbb.SelectedItem;
            String branchID = (String)row.Row["MACHINHANH"];
            String procname = "";
            if(version ==true)
            {
                procname = "sp_XemMonAnPhanTomFix";
            }

            else if (version == false)
            {
                procname = "sp_XemMonAnPhanTom";
            }

            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.Add("@MACHINHANH", SqlDbType.VarChar);
            command.Parameters["@MACHINHANH"].Value = branchID;
            SqlDataReader reader = command.ExecuteReader();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();
            table.Load(reader);

            TD_Grid.AutoGenerateColumns = false;
            TD_Grid.DataSource = table;
            connection.Close();
        }
    }
}
