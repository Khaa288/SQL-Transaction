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
    public partial class MenuControl : UserControl
    {
        String connectionString = "";
        string madoitac = "";
        bool version;

        public MenuControl()
        {
            InitializeComponent();

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }

        public MenuControl(string partnerID)
        {
            InitializeComponent();

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

            madoitac = partnerID;
        }

        public MenuControl(string partnerID, bool ver)
        {
            InitializeComponent();

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

            madoitac = partnerID;
            version = ver;
        }

        private void MenuControl_Load(object sender, EventArgs e)
        {
            // dua du lieu vao combobox
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            String sqlQuery = String.Format("SELECT * FROM CHINHANH WHERE MADOITAC = '{0}'", madoitac);
            SqlDataAdapter CNadapter = new SqlDataAdapter(sqlQuery, connection);

            sqlQuery = "SELECT * FROM MONAN";
            SqlDataAdapter MAadapter = new SqlDataAdapter(sqlQuery, connection);

            DataTable CNtable = new DataTable();
            CNadapter.Fill(CNtable);

            CN_cbb.ValueMember = "MACHINHANH";
            CN_cbb.DisplayMember = "MACHINHANH";
            CN_cbb.DataSource = CNtable;
            CN_cbb.SelectedItem = -1;

            DataTable MAtable = new DataTable();
            MAadapter.Fill(MAtable);

            MonAn_cbb.ValueMember = "TENMON";
            MonAn_cbb.DisplayMember = "TENMON";
            MonAn_cbb.DataSource = MAtable;
            MonAn_cbb.SelectedItem = -1;

            connection.Close();
        }

        private void Xem_Button_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            DataRowView row = (DataRowView)CN_cbb.SelectedItem;
            String branchID = (String)row.Row["MACHINHANH"];
            String sqlQuery = String.Format("SELECT * FROM THUCDON, MONAN WHERE TENMONAN = TENMON AND MACHINHANH = '{0}'", branchID);

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DSTDGrid.AutoGenerateColumns = false;
            DSTDGrid.DataSource = table;
        }

        private void DSTDGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DSTDGrid.Columns[e.ColumnIndex].Name == "delete_btn")
            {
                Console.OutputEncoding = Encoding.Unicode;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    String procname = "";

                    if (version == true)
                    {
                        procname = "sp_XoaMonPhanTom";
                    }

                    else if (version == false)
                    {
                        procname = "sp_XoaMonPhanTom";
                    }

                    SqlCommand command = new SqlCommand(procname);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.Add("@MACHINHANH", SqlDbType.VarChar);
                    command.Parameters.Add("@TENMONAN", SqlDbType.NVarChar);

                    DataGridViewRow row = DSTDGrid.Rows[e.RowIndex];
                    DataRowView rw = (DataRowView)CN_cbb.SelectedItem;

                    String machinhanh = (String)rw.Row["MACHINHANH"];
                    String tenmon = (String)row.Cells["TenMonAn"].Value;

                    command.Parameters["@MACHINHANH"].Value = machinhanh;
                    command.Parameters["@TENMONAN"].Value = tenmon;

                    int n = command.ExecuteNonQuery();
                    if (n > 0)
                    {
                        Console.OutputEncoding = Encoding.Unicode;
                        //MessageBox.Show(machinhanh + tenmon);
                        MessageBox.Show("Hủy thành công!!!");
                    }
                    else
                    {
                        MessageBox.Show("Update Failed!!!!");
                    }

                    connection.Close();
                }
            }
        }

        private void Them_btn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            String procname = "";

            if (version == true)
            {
                procname = "sp_ThemMonPhanTom";
            }

            else if (version == false)
            {
                procname = "sp_ThemMonPhanTom";
            }

            SqlCommand command = new SqlCommand(procname);
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            command.Parameters.Add("@MACHINHANH", SqlDbType.VarChar);
            command.Parameters.Add("@TENMONAN", SqlDbType.NVarChar);

            DataRowView rw = (DataRowView)CN_cbb.SelectedItem;
            DataRowView row = (DataRowView)MonAn_cbb.SelectedItem;

            String machinhanh = (String)rw.Row["MACHINHANH"];
            String tenmon = (String)row.Row["TENMON"];

            command.Parameters["@MACHINHANH"].Value = machinhanh;
            command.Parameters["@TENMONAN"].Value = tenmon;

            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                Console.OutputEncoding = Encoding.Unicode;
                MessageBox.Show(tenmon);
                //MessageBox.Show("Thêm thành công!!!");
            }
            else
            {
                MessageBox.Show("Insert Failed!!!!");
            }

            connection.Close();
        }
    }
}
