using System;
using Csla;
using SelfLoadSoftDelete.DataAccess;
using SelfLoadSoftDelete.DataAccess.ERLevel;

namespace SelfLoadSoftDelete.Business.ERLevel
{

    /// <summary>
    /// G03_Continent_Child (editable child object).<br/>
    /// This is a generated base class of <see cref="G03_Continent_Child"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="G02_Continent"/> collection.
    /// </remarks>
    [Serializable]
    public partial class G03_Continent_Child : BusinessBase<G03_Continent_Child>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="Continent_Child_Name"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Continent_Child_NameProperty = RegisterProperty<string>(p => p.Continent_Child_Name, "SubContinents Child Name");
        /// <summary>
        /// Gets or sets the SubContinents Child Name.
        /// </summary>
        /// <value>The SubContinents Child Name.</value>
        public string Continent_Child_Name
        {
            get { return GetProperty(Continent_Child_NameProperty); }
            set { SetProperty(Continent_Child_NameProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="G03_Continent_Child"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="G03_Continent_Child"/> object.</returns>
        internal static G03_Continent_Child NewG03_Continent_Child()
        {
            return DataPortal.CreateChild<G03_Continent_Child>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="G03_Continent_Child"/> object, based on given parameters.
        /// </summary>
        /// <param name="continent_ID1">The Continent_ID1 parameter of the G03_Continent_Child to fetch.</param>
        /// <returns>A reference to the fetched <see cref="G03_Continent_Child"/> object.</returns>
        internal static G03_Continent_Child GetG03_Continent_Child(int continent_ID1)
        {
            return DataPortal.FetchChild<G03_Continent_Child>(continent_ID1);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="G03_Continent_Child"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public G03_Continent_Child()
        {
            // Use factory methods and do not use direct creation.

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="G03_Continent_Child"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="G03_Continent_Child"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="continent_ID1">The Continent ID1.</param>
        protected void Child_Fetch(int continent_ID1)
        {
            var args = new DataPortalHookArgs(continent_ID1);
            OnFetchPre(args);
            using (var dalManager = DalFactorySelfLoadSoftDelete.GetManager())
            {
                var dal = dalManager.GetProvider<IG03_Continent_ChildDal>();
                var data = dal.Fetch(continent_ID1);
                Fetch(data);
            }
            OnFetchPost(args);
        }

        /// <summary>
        /// Loads a <see cref="G03_Continent_Child"/> object from the given <see cref="G03_Continent_ChildDto"/>.
        /// </summary>
        /// <param name="data">The G03_Continent_ChildDto to use.</param>
        private void Fetch(G03_Continent_ChildDto data)
        {
            // Value properties
            LoadProperty(Continent_Child_NameProperty, data.Continent_Child_Name);
            var args = new DataPortalHookArgs(data);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="G03_Continent_Child"/> object in the database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        [Transactional(TransactionalTypes.TransactionScope)]
        private void Child_Insert(G02_Continent parent)
        {
            var dto = new G03_Continent_ChildDto();
            dto.Parent_Continent_ID = parent.Continent_ID;
            dto.Continent_Child_Name = Continent_Child_Name;
            using (var dalManager = DalFactorySelfLoadSoftDelete.GetManager())
            {
                var args = new DataPortalHookArgs(dto);
                OnInsertPre(args);
                var dal = dalManager.GetProvider<IG03_Continent_ChildDal>();
                using (BypassPropertyChecks)
                {
                    var resultDto = dal.Insert(dto);
                    args = new DataPortalHookArgs(resultDto);
                }
                OnInsertPost(args);
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="G03_Continent_Child"/> object.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        [Transactional(TransactionalTypes.TransactionScope)]
        private void Child_Update(G02_Continent parent)
        {
            if (!IsDirty)
                return;

            var dto = new G03_Continent_ChildDto();
            dto.Parent_Continent_ID = parent.Continent_ID;
            dto.Continent_Child_Name = Continent_Child_Name;
            using (var dalManager = DalFactorySelfLoadSoftDelete.GetManager())
            {
                var args = new DataPortalHookArgs(dto);
                OnUpdatePre(args);
                var dal = dalManager.GetProvider<IG03_Continent_ChildDal>();
                using (BypassPropertyChecks)
                {
                    var resultDto = dal.Update(dto);
                    args = new DataPortalHookArgs(resultDto);
                }
                OnUpdatePost(args);
            }
        }

        /// <summary>
        /// Self deletes the <see cref="G03_Continent_Child"/> object from database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        [Transactional(TransactionalTypes.TransactionScope)]
        private void Child_DeleteSelf(G02_Continent parent)
        {
            using (var dalManager = DalFactorySelfLoadSoftDelete.GetManager())
            {
                var args = new DataPortalHookArgs();
                OnDeletePre(args);
                var dal = dalManager.GetProvider<IG03_Continent_ChildDal>();
                using (BypassPropertyChecks)
                {
                    dal.Delete(parent.Continent_ID);
                }
                OnDeletePost(args);
            }
        }

        #endregion

        #region DataPortal Hooks

        /// <summary>
        /// Occurs after setting all defaults for object creation.
        /// </summary>
        partial void OnCreate(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Delete, after setting query parameters and before the delete operation.
        /// </summary>
        partial void OnDeletePre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Delete, after the delete operation, before Commit().
        /// </summary>
        partial void OnDeletePost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after setting query parameters and before the fetch operation.
        /// </summary>
        partial void OnFetchPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the fetch operation (object or collection is fully loaded and set up).
        /// </summary>
        partial void OnFetchPost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the low level fetch operation, before the data reader is destroyed.
        /// </summary>
        partial void OnFetchRead(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after setting query parameters and before the update operation.
        /// </summary>
        partial void OnUpdatePre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after the update operation, before setting back row identifiers (RowVersion) and Commit().
        /// </summary>
        partial void OnUpdatePost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after setting query parameters and before the insert operation.
        /// </summary>
        partial void OnInsertPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after the insert operation, before setting back row identifiers (ID and RowVersion) and Commit().
        /// </summary>
        partial void OnInsertPost(DataPortalHookArgs args);

        #endregion

    }
}
