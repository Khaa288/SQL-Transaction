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

namespace Project_DBMS.Shipper
{
    public partial class ShipperForm : Form
    {
        String connectionString;
        String mataixe, currentOrder, currentStatus;
        bool version;

        public ShipperForm()
        {
            InitializeComponent();
        }

        public ShipperForm(String shipperID)
        {
            InitializeComponent();
            mataixe = shipperID;

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

            TaiXe_Label.Text = shipperID;
        }

        public ShipperForm(String shipperID, bool ver)
        {
            InitializeComponent();
            mataixe = shipperID;

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

            TaiXe_Label.Text = shipperID;
            version = ver;
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            String sqlQuery = String.Format("SELECT * FROM DONHANG WHERE TAIXEXULI = '{0}'", mataixe);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DSDH_Grid.DataSource = table;

            connection.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            String procname = "";
            if (version == true)
            {
                procname = "sp_CapNhatDonDirtyFix";
            }

            else if (version == false)
            {
                procname = "sp_CapNhatDonDirty";
            }

            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // truyen tham so madonhang vao proc truoc
            command.Parameters.Add("@MADONHANG", SqlDbType.VarChar);
            command.Parameters.Add("@TINHTRANG", SqlDbType.NVarChar);

            command.Parameters["@MADONHANG"].Value = currentOrder;

            // tuy chon tinh trang vao truyen vao proc
            if (VChuyen_Radio.Checked)
            {
                command.Parameters["@TINHTRANG"].Value = VChuyen_Radio.Text;
            }

            else if (HoanTat_Radio.Checked)
            {
                command.Parameters["@TINHTRANG"].Value = HoanTat_Radio.Text;
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
                MessageBox.Show("Update Failed!!!!");
            }

            connection.Close();
        }

        private void DSDH_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DSDH_Grid.Rows[e.RowIndex];
            Console.OutputEncoding = Encoding.Unicode;

            currentOrder = (String)row.Cells["MADONHANG"].Value;
            currentStatus = (String)row.Cells["TINHTRANG"].Value;
            DonHang_gb.Text = "Đơn hàng " + currentOrder;
        }
    }
}
