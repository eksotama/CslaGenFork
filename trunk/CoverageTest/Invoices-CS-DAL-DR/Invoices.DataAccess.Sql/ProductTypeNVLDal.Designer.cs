using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using Invoices.DataAccess;

namespace Invoices.DataAccess.Sql
{
    /// <summary>
    /// DAL SQL Server implementation of <see cref="IProductTypeNVLDal"/>
    /// </summary>
    public partial class ProductTypeNVLDal : IProductTypeNVLDal
    {

        #region DAL methods

        /// <summary>
        /// Loads a ProductTypeNVL list from the database.
        /// </summary>
        /// <returns>A data reader to the ProductTypeNVL.</returns>
        public IDataReader Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Invoices"))
            {
                using (var cmd = new SqlCommand("dbo.GetProductTypeNVL", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    return cmd.ExecuteReader();
                }
            }
        }

        #endregion

    }
}
