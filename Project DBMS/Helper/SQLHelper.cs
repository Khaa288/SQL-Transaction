using System.Collections.Generic;
using System.Linq;
using Project_DBMS.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace SQLHelper {
    // Employee helper class
    static class Emp_Helper {
        public static List<Hopdong> ContractByEmp(this DbmsqlBanHangContext dbcontext, String empId) {
            return dbcontext.Hopdongs.Where(value => value.NvXuli == empId).Select(contract => contract).ToList();
        }

        public static bool ContractExtended(this DbmsqlBanHangContext dbcontext, String procname, String contractId, double percentage, DateTime extendDate) {
            return dbcontext.Database.ExecuteSqlRaw($"{procname} @MAHOPDONG, @PTHOAHONG, @TG_HIEULUC",
                new SqlParameter("@MAHOPDONG", contractId),
                new SqlParameter("@PTHOAHONG", percentage),
                new SqlParameter("@TG_HIEULUC", extendDate)
            ) > 0 ? true : false;
        }
    }

    // Shipper helper class
    static class Ship_Helper {
        public static List<Donhang> ShipperOrders(this DbmsqlBanHangContext dbcontext, String shipperID) {
            return dbcontext.Donhangs.Where(value => value.Taixexuli == shipperID).Select(order => order).ToList();
        }

        public static bool OrderStatusUpdated(this DbmsqlBanHangContext dbcontext, String procname, String OrderId, String OrderStatus) {
            return dbcontext.Database.ExecuteSqlRaw($"{procname} @MADONHANG, @TINHTRANG",
                new SqlParameter("@MADONHANG", OrderId),
                new SqlParameter("@TINHTRANG", OrderStatus)
            ) > 0 ? true : false;
        }
    }

    static class Customre_Helper {
        public static List<Donhang> CustomerOrders(this DbmsqlBanHangContext dbcontext, String custId) {
            return dbcontext.Donhangs.Where(value => value.Khachhang == custId).Select(order => order).ToList();
        }

        public static List<Donhang> CustomerOrderDirtyRead(this DbmsqlBanHangContext dbcontext, String procname, String custId) {
            return dbcontext.Donhangs.FromSqlRaw($"{procname} @MAKHACHHANG",
                new SqlParameter("@MAKHACHHANG", custId)
            ).ToList();   
        }

        public static bool CustomerCancelOrder(this DbmsqlBanHangContext dbcontext, String procname, String orderId) {
            return dbcontext.Database.ExecuteSqlRaw($"{procname} @MADONHANG",
                new SqlParameter("@MADONHANG", orderId)
            ) > 0 ? true : false;
        }

        // public static List<Monan> AllDishes(this DbmsqlBanHangContext dbcontext) {
            
        // }
    }
}