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

namespace Project_DBMS.Partner.PartnerControl
{
    public partial class OrderControl : UserControl
    {
        String _connectionString = "";
        String madoitac, currentOrder, currentStatus, loaiTK;
        bool version;
        public OrderControl()
        {
            InitializeComponent();

            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }

        public OrderControl(string partnerID)
        {
            InitializeComponent();

            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

            madoitac = partnerID;
        }

        public OrderControl(string partnerID, bool ver)
        {
            InitializeComponent();

            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

            madoitac = partnerID;
            version = ver;
        }

        private void DS_DH_Button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            String sqlQuery = String.Format("SELECT * FROM DONHANG WHERE CHINHANH IN (SELECT MACHINHANH FROM CHINHANH WHERE MADOITAC = '{0}')", madoitac);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
           
            DataTable table = new DataTable();
            adapter.Fill(table);
            DSDHGrid.DataSource = table;

            connection.Close();
        }

        private void Update_OrderStat_Button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            String procsName = "";

            if (version == true && Dirty_Radio.Checked)
            {
                procsName = "sp_CapNhatDonDirtyFix";
            }
            else if (version == false && Dirty_Radio.Checked)
            {
                procsName = "sp_CapNhatDonDirty";
            }

            if (version == true && LostUp_Radio.Checked)
            {
                procsName = "sp_CapNhatDonLostUpdateFix";
            }

            else if (version == false && LostUp_Radio.Checked)
            {
                procsName = "sp_CapNhatDonLostUpdate";
            }


            MessageBox.Show(procsName);
            
            SqlCommand command = new SqlCommand(procsName);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            
            command.Parameters.Add("@MADONHANG", SqlDbType.VarChar);
            command.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar);

            // truyen gia tri vao tham so 
            command.Parameters["@MADONHANG"].Value = currentOrder;
            if (ChoNhan_Radio.Checked)
            {
                command.Parameters["@TINHTRANG"].Value = ChoNhan_Radio.Text;
            }

            else if (DangCB_Radio.Checked)
            {
                command.Parameters["@TINHTRANG"].Value = DangCB_Radio.Text;
            }

            else
            {
                command.Parameters["@TINHTRANG"].Value = currentStatus;
            }

            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Cập nhật thành công!!!");
            }
            else
            {
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show("Cập nhật thất bại!!!");
            }
            connection.Close();

        }

        private void DSDHGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DSDHGrid.Rows[e.RowIndex];
            currentOrder = (String)row.Cells["MADONHANG"].Value;
            currentStatus = (String)row.Cells["TINHTRANG"].Value;
            Console.OutputEncoding = Encoding.Unicode;
            update_gb.Text = "Đơn hàng " + currentOrder;
        }
    }
}
