using System;
using System.Data;
using Npgsql;
using Csla;
using Csla.Data;
using Invoices.DataAccess;

namespace Invoices.DataAccess.Npgsql
{
    /// <summary>
    /// DAL SQL Server implementation of <see cref="IInvoiceListDal"/>
    /// </summary>
    public partial class InvoiceListDal : IInvoiceListDal
    {

        #region DAL methods

        /// <summary>
        /// Loads a InvoiceList collection from the database.
        /// </summary>
        /// <returns>A data reader to the InvoiceList.</returns>
        public IDataReader Fetch()
        {
            using (var ctx = ConnectionManager<NpgsqlConnection>.GetManager("Invoices"))
            {
                using (var cmd = new NpgsqlCommand("dbo.GetInvoiceList", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    return cmd.ExecuteReader();
                }
            }
        }

        #endregion

    }
}
