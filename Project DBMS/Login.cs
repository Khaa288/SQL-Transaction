﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Project_DBMS.Partner;
using Project_DBMS.Customer;
using Project_DBMS.Shipper;
using Project_DBMS.Employee;
using Project_DBMS.Models;

namespace Project_DBMS
{
    public partial class Login : Form
    {
        bool version;
        public Login()
        {
            InitializeComponent();
            //_connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }

        public Login(bool fixedVer)
        {
            InitializeComponent();

            //_connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
            version = fixedVer;
        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            // _connection = new SqlConnection(_connectionString);
            // _connection.Open();

            // String login = String.Format("Select * from TAIKHOAN where TAIKHOAN ='{0}' and MATKHAU ='{1}'", usernameTxt.Text, passwordTxt.Text);

            // _command = new SqlCommand(login);
            // _command.Connection = _connection;

            // SqlDataReader reader = _command.ExecuteReader();
            // if (reader.Read())
            // {
            //     loaiTK = reader["LOAITAIKHOAN"].ToString();
            //     switch (loaiTK) {
            //         case "NV":
            //             EmployeeForm EmplForm = new EmployeeForm(reader["MATAIKHOAN"].ToString(), version);
            //             EmplForm.Show();
            //             break;
            //         case "DT":
            //             //MessageBox.Show("DT");
            //             PartnerForm partForm = new PartnerForm(reader["MATAIKHOAN"].ToString(), version);
            //             partForm.Show();
            //             break;
            //         case "KH":
            //             //MessageBox.Show("KH");
            //             CustomerForm cusForm = new CustomerForm(reader["MATAIKHOAN"].ToString(), version);
            //             cusForm.Show();
            //             break;
            //         case "TX":
            //             //MessageBox.Show("TX");
            //             ShipperForm shipperForm = new ShipperForm(reader["MATAIKHOAN"].ToString(), version);
            //             shipperForm.Show();
            //             break;
            //     }
            // }
            // else
            //     MessageBox.Show("Not found !!!");
            // reader.Close();

            // //Bước 5: Đóng kết nối
            // _connection.Close();

            // update using LINQ
            using var dbContext = new DbmsqlBanHangContext();
            var sqlQuery = from taikhoan in dbContext.Taikhoans
                           where (taikhoan.Taikhoan1 == usernameTxt.Text && taikhoan.Matkhau == passwordTxt.Text)
                           select taikhoan; 

            if (sqlQuery.ToList().Any())
            {
                var loaiTK = sqlQuery.FirstOrDefault().Loaitaikhoan;
                var maTK = sqlQuery.FirstOrDefault().Mataikhoan;

                switch (loaiTK) {
                    case "NV":
                        EmployeeForm EmplForm = new EmployeeForm(maTK, version);
                        EmplForm.Show();
                        break;
                    case "DT":
                        //MessageBox.Show("DT");
                        PartnerForm partForm = new PartnerForm(maTK, version);
                        partForm.Show();
                        break;
                    case "KH":
                        //MessageBox.Show("KH");
                        CustomerForm cusForm = new CustomerForm(maTK, version);
                        cusForm.Show();
                        break;
                    case "TX":
                        //MessageBox.Show("TX");
                        ShipperForm shipperForm = new ShipperForm(maTK, version);
                        shipperForm.Show();
                        break;
                }
            }
            else
                MessageBox.Show("Not found !!!");
        }
    }
}
