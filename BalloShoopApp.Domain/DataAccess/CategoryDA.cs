using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloShoopApp.Domain.DataAccess
{
    public class CategoryDA : DapperBase
    {
       

        public IList<Entities.Category> GetCategories() 
        {
            const string sql = "[dbo].[spSelCategories]";

            return Query<Entities.Category>(sql, null, commandType: CommandType.StoredProcedure).ToList();
        }

        // Retrieve the list of departments
        public static DataTable GetDepartments()
        {
            // get a configured DbCommand object
            DbCommand comm = GenericDataAccess.CreateCommand();
            // set the stored procedure name
            comm.CommandText = "[dbo].[spSelCategories]";
            // execute the stored procedure and return the results
            return GenericDataAccess.ExecuteSelectCommand(comm);
        }


    }
}
