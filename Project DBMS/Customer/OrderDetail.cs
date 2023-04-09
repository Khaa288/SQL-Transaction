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
    public partial class OrderDetail : Form
    {
        String madonhang, machinhanh;
        String connectionString = "";
        public OrderDetail()
        {
            InitializeComponent();
        }

        public OrderDetail(String orderID, String branchID)
        {
            InitializeComponent();

            madonhang = orderID;
            machinhanh = branchID;

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            Console.OutputEncoding = Encoding.Unicode;
            DonHang_gb.Text = "Đơn hàng: " + madonhang;

            CN_Label.Text = "- Chi nhánh: " + machinhanh;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            String sqlQuery = String.Format("SELECT TENMON, SOLUONG FROM CT_DONHANG WHERE MADONHANG = '{0}'", madonhang);

            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CT_MonAn_Grid.DataSource = table;

            connection.Close();
        }
    }
}
