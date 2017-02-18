using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using Invoices.DataAccess;

namespace Invoices.DataAccess.Sql
{
    /// <summary>
    /// DAL SQL Server implementation of <see cref="IProductTypeUpdatedByRootListDal"/>
    /// </summary>
    public partial class ProductTypeUpdatedByRootListDal : IProductTypeUpdatedByRootListDal
    {

        #region DAL methods

        /// <summary>
        /// Loads a ProductTypeUpdatedByRootList collection from the database.
        /// </summary>
        /// <returns>A data reader to the ProductTypeUpdatedByRootList.</returns>
        public IDataReader Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Invoices"))
            {
                using (var cmd = new SqlCommand("dbo.GetProductTypeUpdatedByRootList", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    return cmd.ExecuteReader();
                }
            }
        }

        #endregion

    }
}
