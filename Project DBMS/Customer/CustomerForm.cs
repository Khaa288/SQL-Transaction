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
    public partial class CustomerForm : Form
    {
        String makhachhang;
        String connectionString;
        String currentOrder, currentBranch;
        bool version;

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(string CustomerID)
        {
            InitializeComponent();

            customerID_Label.Text = CustomerID;

            makhachhang = CustomerID;

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }

        public CustomerForm(string CustomerID, bool ver)
        {
            InitializeComponent();

            customerID_Label.Text = CustomerID;

            makhachhang = CustomerID;

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            version = ver;
        }

        private void Xem_Button_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            //String sqlQuery = String.Format("SELECT * FROM DONHANG WHERE KHACHHANG = '{0}'", makhachhang);
            //SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //DHKH_Grid.DataSource = table;

            //connection.Close();

            // DIRTY READ 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            String procname = "";
            if (version == true)
            {
                procname = "sp_XemDonDirtyFix";
            }

            else if (version == false)
            {
                procname = "sp_XemDonDirty";
            }

            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.Add("@MAKHACHHANG", SqlDbType.VarChar);
            command.Parameters["@MAKHACHHANG"].Value = makhachhang;

            SqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            DHKH_Grid.AutoGenerateColumns = false;
            DHKH_Grid.DataSource = table;

            connection.Close();
        }

        private void dathang_button_Click(object sender, EventArgs e)
        {
            Order orderForm = new Order(version);
            orderForm.Show();
        }

        private void Huydon_Button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            String procname = "";
            if (version == true)
            {
                procname = "sp_HuyDonLostUpdateFix";
            }

            else if (version == false)
            {
                procname = "sp_HuyDonLostUpdate";
            }

            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.Add("@MADONHANG", SqlDbType.VarChar);
            command.Parameters["@MADONHANG"].Value = currentOrder;

            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Hủy thành công!!!");
            }
            else
            {
                MessageBox.Show("Update Failed!!!!");
            }
            connection.Close();
        }

        private void DHKH_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DHKH_Grid.Rows[e.RowIndex];
            Console.OutputEncoding = Encoding.Unicode;

            currentOrder = (String)row.Cells["MADONHANG"].Value;
            currentBranch = (String)row.Cells["CHINHANH"].Value;
            DonHang_gb.Text = "Đơn hàng " + currentOrder;
        }

        private void XemChiTiet_Button_Click(object sender, EventArgs e)
        {
            OrderDetail ODForm = new OrderDetail(currentOrder, currentBranch);
            ODForm.Show();
        }
    }
}
