using System;
using Csla;
using SelfLoadSoftDelete.DataAccess;
using SelfLoadSoftDelete.DataAccess.ERCLevel;

namespace SelfLoadSoftDelete.Business.ERCLevel
{

    /// <summary>
    /// H02_Continent (editable child object).<br/>
    /// This is a generated base class of <see cref="H02_Continent"/> business object.
    /// </summary>
    /// <remarks>
    /// This class contains one child collection:<br/>
    /// - <see cref="H03_SubContinentObjects"/> of type <see cref="H03_SubContinentColl"/> (1:M relation to <see cref="H04_SubContinent"/>)<br/>
    /// This class is an item of <see cref="H01_ContinentColl"/> collection.
    /// </remarks>
    [Serializable]
    public partial class H02_Continent : BusinessBase<H02_Continent>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="Continent_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> Continent_IDProperty = RegisterProperty<int>(p => p.Continent_ID, "Continents ID");
        /// <summary>
        /// Gets the Continents ID.
        /// </summary>
        /// <value>The Continents ID.</value>
        public int Continent_ID
        {
            get { return GetProperty(Continent_IDProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Continent_Name"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Continent_NameProperty = RegisterProperty<string>(p => p.Continent_Name, "Continents Name");
        /// <summary>
        /// Gets or sets the Continents Name.
        /// </summary>
        /// <value>The Continents Name.</value>
        public string Continent_Name
        {
            get { return GetProperty(Continent_NameProperty); }
            set { SetProperty(Continent_NameProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about child <see cref="H03_Continent_SingleObject"/> property.
        /// </summary>
        public static readonly PropertyInfo<H03_Continent_Child> H03_Continent_SingleObjectProperty = RegisterProperty<H03_Continent_Child>(p => p.H03_Continent_SingleObject, "H03 Continent Single Object", RelationshipTypes.Child);
        /// <summary>
        /// Gets the H03 Continent Single Object ("self load" child property).
        /// </summary>
        /// <value>The H03 Continent Single Object.</value>
        public H03_Continent_Child H03_Continent_SingleObject
        {
            get { return GetProperty(H03_Continent_SingleObjectProperty); }
            private set { LoadProperty(H03_Continent_SingleObjectProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about child <see cref="H03_Continent_ASingleObject"/> property.
        /// </summary>
        public static readonly PropertyInfo<H03_Continent_ReChild> H03_Continent_ASingleObjectProperty = RegisterProperty<H03_Continent_ReChild>(p => p.H03_Continent_ASingleObject, "H03 Continent ASingle Object", RelationshipTypes.Child);
        /// <summary>
        /// Gets the H03 Continent ASingle Object ("self load" child property).
        /// </summary>
        /// <value>The H03 Continent ASingle Object.</value>
        public H03_Continent_ReChild H03_Continent_ASingleObject
        {
            get { return GetProperty(H03_Continent_ASingleObjectProperty); }
            private set { LoadProperty(H03_Continent_ASingleObjectProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about child <see cref="H03_SubContinentObjects"/> property.
        /// </summary>
        public static readonly PropertyInfo<H03_SubContinentColl> H03_SubContinentObjectsProperty = RegisterProperty<H03_SubContinentColl>(p => p.H03_SubContinentObjects, "H03 SubContinent Objects", RelationshipTypes.Child);
        /// <summary>
        /// Gets the H03 Sub Continent Objects ("self load" child property).
        /// </summary>
        /// <value>The H03 Sub Continent Objects.</value>
        public H03_SubContinentColl H03_SubContinentObjects
        {
            get { return GetProperty(H03_SubContinentObjectsProperty); }
            private set { LoadProperty(H03_SubContinentObjectsProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="H02_Continent"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="H02_Continent"/> object.</returns>
        internal static H02_Continent NewH02_Continent()
        {
            return DataPortal.CreateChild<H02_Continent>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="H02_Continent"/> object from the given H02_ContinentDto.
        /// </summary>
        /// <param name="data">The <see cref="H02_ContinentDto"/>.</param>
        /// <returns>A reference to the fetched <see cref="H02_Continent"/> object.</returns>
        internal static H02_Continent GetH02_Continent(H02_ContinentDto data)
        {
            H02_Continent obj = new H02_Continent();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(data);
            obj.MarkOld();
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="H02_Continent"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public H02_Continent()
        {
            // Use factory methods and do not use direct creation.

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="H02_Continent"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(Continent_IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(H03_Continent_SingleObjectProperty, DataPortal.CreateChild<H03_Continent_Child>());
            LoadProperty(H03_Continent_ASingleObjectProperty, DataPortal.CreateChild<H03_Continent_ReChild>());
            LoadProperty(H03_SubContinentObjectsProperty, DataPortal.CreateChild<H03_SubContinentColl>());
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="H02_Continent"/> object from the given <see cref="H02_ContinentDto"/>.
        /// </summary>
        /// <param name="data">The H02_ContinentDto to use.</param>
        private void Fetch(H02_ContinentDto data)
        {
            // Value properties
            LoadProperty(Continent_IDProperty, data.Continent_ID);
            LoadProperty(Continent_NameProperty, data.Continent_Name);
            var args = new DataPortalHookArgs(data);
            OnFetchRead(args);
        }

        /// <summary>
        /// Loads child objects.
        /// </summary>
        internal void FetchChildren()
        {
            LoadProperty(H03_Continent_SingleObjectProperty, H03_Continent_Child.GetH03_Continent_Child(Continent_ID));
            LoadProperty(H03_Continent_ASingleObjectProperty, H03_Continent_ReChild.GetH03_Continent_ReChild(Continent_ID));
            LoadProperty(H03_SubContinentObjectsProperty, H03_SubContinentColl.GetH03_SubContinentColl(Continent_ID));
        }

        /// <summary>
        /// Inserts a new <see cref="H02_Continent"/> object in the database.
        /// </summary>
        [Transactional(TransactionalTypes.TransactionScope)]
        private void Child_Insert()
        {
            var dto = new H02_ContinentDto();
            dto.Continent_Name = Continent_Name;
            using (var dalManager = DalFactorySelfLoadSoftDelete.GetManager())
            {
                var args = new DataPortalHookArgs(dto);
                OnInsertPre(args);
                var dal = dalManager.GetProvider<IH02_ContinentDal>();
                using (BypassPropertyChecks)
                {
                    var resultDto = dal.Insert(dto);
                    LoadProperty(Continent_IDProperty, resultDto.Continent_ID);
                    args = new DataPortalHookArgs(resultDto);
                }
                OnInsertPost(args);
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="H02_Continent"/> object.
        /// </summary>
        [Transactional(TransactionalTypes.TransactionScope)]
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            var dto = new H02_ContinentDto();
            dto.Continent_ID = Continent_ID;
            dto.Continent_Name = Continent_Name;
            using (var dalManager = DalFactorySelfLoadSoftDelete.GetManager())
            {
                var args = new DataPortalHookArgs(dto);
                OnUpdatePre(args);
                var dal = dalManager.GetProvider<IH02_ContinentDal>();
                using (BypassPropertyChecks)
                {
                    var resultDto = dal.Update(dto);
                    args = new DataPortalHookArgs(resultDto);
                }
                OnUpdatePost(args);
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
            }
        }

        /// <summary>
        /// Self deletes the <see cref="H02_Continent"/> object from database.
        /// </summary>
        [Transactional(TransactionalTypes.TransactionScope)]
        private void Child_DeleteSelf()
        {
            using (var dalManager = DalFactorySelfLoadSoftDelete.GetManager())
            {
                var args = new DataPortalHookArgs();
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
                OnDeletePre(args);
                var dal = dalManager.GetProvider<IH02_ContinentDal>();
                using (BypassPropertyChecks)
                {
                    dal.Delete(ReadProperty(Continent_IDProperty));
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
