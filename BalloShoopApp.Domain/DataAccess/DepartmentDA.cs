using BalloShoopApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloShoopApp.Domain.DataAccess
{
    public class DepartmentDA : DapperBase
    {
        public IList<Department> GetDepartments()
        {
            const string sql = "[dbo].[spSelDepartments]";

            return Query<Department>(sql, null, commandType: CommandType.StoredProcedure).ToList();
        }
    }
}
