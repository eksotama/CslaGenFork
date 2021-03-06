//  This file was generated by CSLA Object Generator - CslaGenFork v4.5
//
// Filename:    RoleList
// ObjectType:  RoleList
// CSLAType:    ReadOnlyCollection

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using DocStore.Business.Util;
using Csla.Rules;
using Csla.Rules.CommonRules;

namespace DocStore.Business.Admin
{

    /// <summary>
    /// Collection of role's basic information (read only list).<br/>
    /// This is a generated <see cref="RoleList"/> business object.
    /// This class is a root collection.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="RoleInfo"/> objects.
    /// </remarks>
    [Serializable]
#if WINFORMS
    public partial class RoleList : ReadOnlyBindingListBase<RoleList, RoleInfo>
#else
    public partial class RoleList : ReadOnlyListBase<RoleList, RoleInfo>
#endif
    {

        #region Collection Business Methods

        /// <summary>
        /// Determines whether a <see cref="RoleInfo"/> item is in the collection.
        /// </summary>
        /// <param name="roleID">The RoleID of the item to search for.</param>
        /// <returns><c>true</c> if the RoleInfo is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int roleID)
        {
            foreach (var roleInfo in this)
            {
                if (roleInfo.RoleID == roleID)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Find Methods

        /// <summary>
        /// Finds a <see cref="RoleInfo"/> item of the <see cref="RoleList"/> collection, based on a given RoleID.
        /// </summary>
        /// <param name="roleID">The RoleID.</param>
        /// <returns>A <see cref="RoleInfo"/> object.</returns>
        public RoleInfo FindRoleInfoByRoleID(int roleID)
        {
            for (var i = 0; i < this.Count; i++)
            {
                if (this[i].RoleID.Equals(roleID))
                {
                    return this[i];
                }
            }

            return null;
        }

        #endregion

        #region Private Fields

        private static RoleList _list;

        #endregion

        #region Cache Management Methods

        /// <summary>
        /// Clears the in-memory RoleList cache so it is reloaded on the next request.
        /// </summary>
        public static void InvalidateCache()
        {
            _list = null;
        }

        /// <summary>
        /// Used by async loaders to load the cache.
        /// </summary>
        /// <param name="list">The list to cache.</param>
        internal static void SetCache(RoleList list)
        {
            _list = list;
        }

        internal static bool IsCached
        {
            get { return _list != null; }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="RoleList"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="RoleList"/> collection.</returns>
        public static RoleList GetRoleList()
        {
            if (_list == null)
                _list = DataPortal.Fetch<RoleList>();

            return _list;
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="RoleList"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetRoleList(EventHandler<DataPortalResult<RoleList>> callback)
        {
            if (_list == null)
                DataPortal.BeginFetch<RoleList>((o, e) =>
                    {
                        _list = e.Object;
                        callback(o, e);
                    });
            else
                callback(null, new DataPortalResult<RoleList>(_list, null, null));
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleList"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public RoleList()
        {
            // Use factory methods and do not use direct creation.

            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AllowNew = false;
            AllowEdit = false;
            AllowRemove = false;
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Object Authorization

        /// <summary>
        /// Adds the object authorization rules.
        /// </summary>
        protected static void AddObjectAuthorizationRules()
        {
            BusinessRules.AddRule(typeof (RoleList), new IsInRole(AuthorizationActions.GetObject, "User"));

            AddObjectAuthorizationRulesExtend();
        }

        /// <summary>
        /// Allows the set up of custom object authorization rules.
        /// </summary>
        static partial void AddObjectAuthorizationRulesExtend();

        /// <summary>
        /// Checks if the current user can retrieve RoleList's properties.
        /// </summary>
        /// <returns><c>true</c> if the user can read the object; otherwise, <c>false</c>.</returns>
        public static bool CanGetObject()
        {
            return BusinessRules.HasPermission(Csla.Rules.AuthorizationActions.GetObject, typeof(RoleList));
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="RoleList"/> collection from the database or from the cache.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            if (IsCached)
            {
                LoadCachedList();
                return;
            }

            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.DocStoreConnection, false))
            {
                using (var cmd = new SqlCommand("GetRoleList", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    var args = new DataPortalHookArgs(cmd);
                    OnFetchPre(args);
                    LoadCollection(cmd);
                    OnFetchPost(args);
                }
            }
            _list = this;
        }

        private void LoadCachedList()
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AddRange(_list);
            RaiseListChangedEvents = rlce;
            IsReadOnly = true;
        }

        private void LoadCollection(SqlCommand cmd)
        {
            using (var dr = new SafeDataReader(cmd.ExecuteReader()))
            {
                Fetch(dr);
            }
        }

        /// <summary>
        /// Loads all <see cref="RoleList"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(RoleInfo.GetRoleInfo(dr));
            }
            RaiseListChangedEvents = rlce;
            IsReadOnly = true;
        }

        #endregion

        #region DataPortal Hooks

        /// <summary>
        /// Occurs after setting query parameters and before the fetch operation.
        /// </summary>
        partial void OnFetchPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the fetch operation (object or collection is fully loaded and set up).
        /// </summary>
        partial void OnFetchPost(DataPortalHookArgs args);

        #endregion

    }
}
