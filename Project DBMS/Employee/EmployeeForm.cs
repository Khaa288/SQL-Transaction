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
using SQLHelper;

namespace Project_DBMS.Employee
{
    public partial class EmployeeForm : Form
    {
        String maNV, currentContract;
        //String connectionString;
        bool version;

        public EmployeeForm() { InitializeComponent(); }

        public EmployeeForm(string EmployeeID)
        {
            InitializeComponent();
            EmployeeID_Label.Text = EmployeeID;
            maNV = EmployeeID;
            //connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }

        public EmployeeForm(string EmployeeID, bool ver)
        {
            InitializeComponent();
            EmployeeID_Label.Text = EmployeeID;
            maNV = EmployeeID;
            //connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            version = ver;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // SqlConnection connection = new SqlConnection(connectionString);
            // connection.Open();

            // String sqlQuery = String.Format("SELECT * FROM HOPDONG WHERE NV_XULI = '{0}'", maNV);
            // SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
            // DataTable table = new DataTable();
            // adapter.Fill(table);

            // HopDong_Grid.AutoGenerateColumns = false;
            // HopDong_Grid.DataSource = table;
            // connection.Close();

            // LINQ Update
            using var dbcontext = new DbmsqlBanHangContext();
            //HopDong_Grid.AutoGenerateColumns = false;
            HopDong_Grid.DataSource = dbcontext.ContractByEmp(maNV);
        }

        private void HopDong_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = HopDong_Grid.Rows[e.RowIndex];
            Console.OutputEncoding = Encoding.Unicode;
            currentContract = row.Cells["MAHOPDONG"].Value.ToString();
            TGHL_txtBox.Text = row.Cells["TgHieuluc"].Value.ToString();
            PTHH_txtBox.Text = row.Cells["PtHoahong"].Value.ToString();
            HopDong_gb.Text = "Hợp đồng " + currentContract;
        }

        private void GiaHan_Button_Click(object sender, EventArgs e)
        {
            // SqlConnection connection = new SqlConnection(connectionString);
            // connection.Open();
            // String procname = "";

            // if (version == true)
            // {
            //     procname = "sp_CapNhatHopDongUnrepeat";
            // }

            // else if (version == false)
            // {
            //     procname = "sp_CapNhatHopDongUnrepeat";
            // }

            // SqlCommand command = new SqlCommand(procname);
            // command.CommandType = CommandType.StoredProcedure;
            // command.Connection = connection;

            // command.Parameters.Add("@MAHOPDONG", SqlDbType.VarChar);
            // command.Parameters.Add("@PTHOAHONG", SqlDbType.Float);
            // command.Parameters.Add("@TG_HIEULUC", SqlDbType.DateTime);

            // command.Parameters["@MAHOPDONG"].Value = currentContract;
            // command.Parameters["@PTHOAHONG"].Value = float.Parse(PTHH_txtBox.Text);
            // command.Parameters["@TG_HIEULUC"].Value = DateTime.Parse(TGHL_txtBox.Text);

            // int n = command.ExecuteNonQuery();
            // if (n > 0)
            // {
            //     Console.OutputEncoding = Encoding.Unicode;
            //     MessageBox.Show("Cập nhật thành công!!!");
            // }
            // else
            // {
            //     MessageBox.Show("Update Failed!!!!");
            // }
            // connection.Close();

            //LINQ Update
            String procname = "";
            if (version == true)
                procname = "sp_CapNhatHopDongUnrepeat";
            else if (version == false)
                procname = "sp_CapNhatHopDongUnrepeat";

            using var dbcontext = new DbmsqlBanHangContext();
            bool isUpdate = dbcontext.ContractExtended(procname, currentContract, float.Parse(PTHH_txtBox.Text), DateTime.Parse(TGHL_txtBox.Text));
            if (isUpdate)
                MessageBox.Show("Update Successfully!!!!");
            else 
                MessageBox.Show("Update Failed!!!!");
        }

        private void TaiLai_btn_Click(object sender, EventArgs e)
        {
            // SqlConnection connection = new SqlConnection(connectionString);
            // connection.Open();

            // String sqlQuery = String.Format("SELECT * FROM HOPDONG WHERE NV_XULI = '{0}'", maNV);
            // SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
            // DataTable table = new DataTable();
            // adapter.Fill(table);

            // HopDong_Grid.AutoGenerateColumns = false;
            // HopDong_Grid.DataSource = table;
            // connection.Close();

            // LINQ Update
            using var dbcontext = new DbmsqlBanHangContext();
            HopDong_Grid.DataSource = dbcontext.ContractByEmp(maNV);
        }
    }
}
