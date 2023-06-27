using System.Collections.Generic;
using System.Linq;
using Project_DBMS.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace SQLHelper {
    static class S_Helper {
        public static List<Hopdong> ContractByEmp(this DbmsqlBanHangContext dbcontext, string empId) {
            return dbcontext.Hopdongs.Where(value => value.NvXuli == empId).Select(contract => contract).ToList();
        }

        public static bool ContractExtended(this DbmsqlBanHangContext dbcontext, String procname, string contractId, double percentage, DateTime extendDate) {
            return dbcontext.Database.ExecuteSqlRaw($"{procname} @MAHOPDONG, @PTHOAHONG, @TG_HIEULUC",
                new SqlParameter("@MAHOPDONG", contractId),
                new SqlParameter("@PTHOAHONG", percentage),
                new SqlParameter("@TG_HIEULUC", extendDate)
            ) > 0 ? true : false;
        }
    }
}