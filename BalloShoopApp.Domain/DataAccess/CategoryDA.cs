using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloShoopApp.Domain.DataAccess
{
    public static class CategoryDA
    {
        static CategoryDA()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static IList<Entities.Category> GetCategories() {

            IList<Entities.Category> result = null;

            DbCommand comm = GenericDataAccess.CreateCommand();
            // set the stored procedure name
            comm.CommandText = "[dbo].[spSelCategories]";
            // execute the stored procedure and return the results
            var reader = GenericDataAccess.ExecuteIDataReaderCommand(comm);

            while (reader.Read())
            {
                result.Add(new Entities.Category()
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Description = reader["Description"].ToString(),
                    Name = reader["Name"].ToString()
                }); ;
            }
            return result;
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
