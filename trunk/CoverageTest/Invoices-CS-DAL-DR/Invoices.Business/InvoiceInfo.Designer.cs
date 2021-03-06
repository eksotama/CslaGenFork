using System;
using System.Data;
using Csla;
using Csla.Data;

namespace Invoices.Business
{

    /// <summary>
    /// InvoiceInfo (read only object).<br/>
    /// This is a generated <see cref="InvoiceInfo"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="InvoiceList"/> collection.
    /// </remarks>
    [Serializable]
    public partial class InvoiceInfo : ReadOnlyBase<InvoiceInfo>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="InvoiceId"/> property.
        /// </summary>
        public static readonly PropertyInfo<Guid> InvoiceIdProperty = RegisterProperty<Guid>(p => p.InvoiceId, "Invoice Id", Guid.NewGuid());
        /// <summary>
        /// The invoice internal identification
        /// </summary>
        /// <value>The Invoice Id.</value>
        public Guid InvoiceId
        {
            get { return GetProperty(InvoiceIdProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="InvoiceNumber"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> InvoiceNumberProperty = RegisterProperty<string>(p => p.InvoiceNumber, "Invoice Number");
        /// <summary>
        /// The public invoice number
        /// </summary>
        /// <value>The Invoice Number.</value>
        public string InvoiceNumber
        {
            get { return GetProperty(InvoiceNumberProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="CustomerId"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> CustomerIdProperty = RegisterProperty<string>(p => p.CustomerId, "Customer Id");
        /// <summary>
        /// Gets the Customer Id.
        /// </summary>
        /// <value>The Customer Id.</value>
        public string CustomerId
        {
            get { return GetProperty(CustomerIdProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="InvoiceDate"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> InvoiceDateProperty = RegisterProperty<SmartDate>(p => p.InvoiceDate, "Invoice Date");
        /// <summary>
        /// Gets the Invoice Date.
        /// </summary>
        /// <value>The Invoice Date.</value>
        public string InvoiceDate
        {
            get { return GetPropertyConvert<SmartDate, string>(InvoiceDateProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TotalAmount"/> property.
        /// </summary>
        public static readonly PropertyInfo<decimal> TotalAmountProperty = RegisterProperty<decimal>(p => p.TotalAmount, "Total Amount");
        /// <summary>
        /// Computed invoice total amount
        /// </summary>
        /// <value>The Total Amount.</value>
        public decimal TotalAmount
        {
            get { return GetProperty(TotalAmountProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IsActive"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> IsActiveProperty = RegisterProperty<bool>(p => p.IsActive, "Is Active");
        /// <summary>
        /// Gets the Is Active.
        /// </summary>
        /// <value><c>true</c> if Is Active; otherwise, <c>false</c>.</value>
        public bool IsActive
        {
            get { return GetProperty(IsActiveProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="CreateDate"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> CreateDateProperty = RegisterProperty<SmartDate>(p => p.CreateDate, "Create Date", new SmartDate(DateTime.Now));
        /// <summary>
        /// Gets the Create Date.
        /// </summary>
        /// <value>The Create Date.</value>
        public SmartDate CreateDate
        {
            get { return GetProperty(CreateDateProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="CreateUser"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> CreateUserProperty = RegisterProperty<int>(p => p.CreateUser, "Create User", Security.UserInformation.UserId);
        /// <summary>
        /// Gets the Create User.
        /// </summary>
        /// <value>The Create User.</value>
        public int CreateUser
        {
            get { return GetProperty(CreateUserProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChangeDate"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ChangeDateProperty = RegisterProperty<SmartDate>(p => p.ChangeDate, "Change Date");
        /// <summary>
        /// Gets the Change Date.
        /// </summary>
        /// <value>The Change Date.</value>
        public SmartDate ChangeDate
        {
            get { return GetProperty(ChangeDateProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChangeUser"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> ChangeUserProperty = RegisterProperty<int>(p => p.ChangeUser, "Change User");
        /// <summary>
        /// Gets the Change User.
        /// </summary>
        /// <value>The Change User.</value>
        public int ChangeUser
        {
            get { return GetProperty(ChangeUserProperty); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceInfo"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public InvoiceInfo()
        {
            // Use factory methods and do not use direct creation.
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="InvoiceInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Child_Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(InvoiceIdProperty, dr.GetGuid("InvoiceId"));
            LoadProperty(InvoiceNumberProperty, dr.GetString("InvoiceNumber"));
            LoadProperty(CustomerIdProperty, dr.GetString("CustomerId"));
            LoadProperty(InvoiceDateProperty, dr.GetSmartDate("InvoiceDate", true));
            LoadProperty(IsActiveProperty, dr.GetBoolean("IsActive"));
            LoadProperty(CreateDateProperty, dr.GetSmartDate("CreateDate", true));
            LoadProperty(CreateUserProperty, dr.GetInt32("CreateUser"));
            LoadProperty(ChangeDateProperty, dr.GetSmartDate("ChangeDate", true));
            LoadProperty(ChangeUserProperty, dr.GetInt32("ChangeUser"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        #endregion

        #region DataPortal Hooks

        /// <summary>
        /// Occurs after the low level fetch operation, before the data reader is destroyed.
        /// </summary>
        partial void OnFetchRead(DataPortalHookArgs args);

        #endregion

    }
}
