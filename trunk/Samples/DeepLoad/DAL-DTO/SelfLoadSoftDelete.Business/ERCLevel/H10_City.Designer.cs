using System;
using Csla;
using SelfLoadSoftDelete.DataAccess;
using SelfLoadSoftDelete.DataAccess.ERCLevel;

namespace SelfLoadSoftDelete.Business.ERCLevel
{

    /// <summary>
    /// H10_City (editable child object).<br/>
    /// This is a generated base class of <see cref="H10_City"/> business object.
    /// </summary>
    /// <remarks>
    /// This class contains one child collection:<br/>
    /// - <see cref="H11_CityRoadObjects"/> of type <see cref="H11_CityRoadColl"/> (1:M relation to <see cref="H12_CityRoad"/>)<br/>
    /// This class is an item of <see cref="H09_CityColl"/> collection.
    /// </remarks>
    [Serializable]
    public partial class H10_City : BusinessBase<H10_City>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="City_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> City_IDProperty = RegisterProperty<int>(p => p.City_ID, "Cities ID");
        /// <summary>
        /// Gets the Cities ID.
        /// </summary>
        /// <value>The Cities ID.</value>
        public int City_ID
        {
            get { return GetProperty(City_IDProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="City_Name"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> City_NameProperty = RegisterProperty<string>(p => p.City_Name, "Cities Name");
        /// <summary>
        /// Gets or sets the Cities Name.
        /// </summary>
        /// <value>The Cities Name.</value>
        public string City_Name
        {
            get { return GetProperty(City_NameProperty); }
            set { SetProperty(City_NameProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about child <see cref="H11_City_SingleObject"/> property.
        /// </summary>
        public static readonly PropertyInfo<H11_City_Child> H11_City_SingleObjectProperty = RegisterProperty<H11_City_Child>(p => p.H11_City_SingleObject, "H11 City Single Object", RelationshipTypes.Child);
        /// <summary>
        /// Gets the H11 City Single Object ("self load" child property).
        /// </summary>
        /// <value>The H11 City Single Object.</value>
        public H11_City_Child H11_City_SingleObject
        {
            get { return GetProperty(H11_City_SingleObjectProperty); }
            private set { LoadProperty(H11_City_SingleObjectProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about child <see cref="H11_City_ASingleObject"/> property.
        /// </summary>
        public static readonly PropertyInfo<H11_City_ReChild> H11_City_ASingleObjectProperty = RegisterProperty<H11_City_ReChild>(p => p.H11_City_ASingleObject, "H11 City ASingle Object", RelationshipTypes.Child);
        /// <summary>
        /// Gets the H11 City ASingle Object ("self load" child property).
        /// </summary>
        /// <value>The H11 City ASingle Object.</value>
        public H11_City_ReChild H11_City_ASingleObject
        {
            get { return GetProperty(H11_City_ASingleObjectProperty); }
            private set { LoadProperty(H11_City_ASingleObjectProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about child <see cref="H11_CityRoadObjects"/> property.
        /// </summary>
        public static readonly PropertyInfo<H11_CityRoadColl> H11_CityRoadObjectsProperty = RegisterProperty<H11_CityRoadColl>(p => p.H11_CityRoadObjects, "H11 CityRoad Objects", RelationshipTypes.Child);
        /// <summary>
        /// Gets the H11 City Road Objects ("self load" child property).
        /// </summary>
        /// <value>The H11 City Road Objects.</value>
        public H11_CityRoadColl H11_CityRoadObjects
        {
            get { return GetProperty(H11_CityRoadObjectsProperty); }
            private set { LoadProperty(H11_CityRoadObjectsProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="H10_City"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="H10_City"/> object.</returns>
        internal static H10_City NewH10_City()
        {
            return DataPortal.CreateChild<H10_City>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="H10_City"/> object from the given H10_CityDto.
        /// </summary>
        /// <param name="data">The <see cref="H10_CityDto"/>.</param>
        /// <returns>A reference to the fetched <see cref="H10_City"/> object.</returns>
        internal static H10_City GetH10_City(H10_CityDto data)
        {
            H10_City obj = new H10_City();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(data);
            obj.MarkOld();
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="H10_City"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public H10_City()
        {
            // Use factory methods and do not use direct creation.

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="H10_City"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(City_IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(H11_City_SingleObjectProperty, DataPortal.CreateChild<H11_City_Child>());
            LoadProperty(H11_City_ASingleObjectProperty, DataPortal.CreateChild<H11_City_ReChild>());
            LoadProperty(H11_CityRoadObjectsProperty, DataPortal.CreateChild<H11_CityRoadColl>());
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="H10_City"/> object from the given <see cref="H10_CityDto"/>.
        /// </summary>
        /// <param name="data">The H10_CityDto to use.</param>
        private void Fetch(H10_CityDto data)
        {
            // Value properties
            LoadProperty(City_IDProperty, data.City_ID);
            LoadProperty(City_NameProperty, data.City_Name);
            var args = new DataPortalHookArgs(data);
            OnFetchRead(args);
        }

        /// <summary>
        /// Loads child objects.
        /// </summary>
        internal void FetchChildren()
        {
            LoadProperty(H11_City_SingleObjectProperty, H11_City_Child.GetH11_City_Child(City_ID));
            LoadProperty(H11_City_ASingleObjectProperty, H11_City_ReChild.GetH11_City_ReChild(City_ID));
            LoadProperty(H11_CityRoadObjectsProperty, H11_CityRoadColl.GetH11_CityRoadColl(City_ID));
        }

        /// <summary>
        /// Inserts a new <see cref="H10_City"/> object in the database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        [Transactional(TransactionalTypes.TransactionScope)]
        private void Child_Insert(H08_Region parent)
        {
            var dto = new H10_CityDto();
            dto.Parent_Region_ID = parent.Region_ID;
            dto.City_Name = City_Name;
            using (var dalManager = DalFactorySelfLoadSoftDelete.GetManager())
            {
                var args = new DataPortalHookArgs(dto);
                OnInsertPre(args);
                var dal = dalManager.GetProvider<IH10_CityDal>();
                using (BypassPropertyChecks)
                {
                    var resultDto = dal.Insert(dto);
                    LoadProperty(City_IDProperty, resultDto.City_ID);
                    args = new DataPortalHookArgs(resultDto);
                }
                OnInsertPost(args);
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="H10_City"/> object.
        /// </summary>
        [Transactional(TransactionalTypes.TransactionScope)]
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            var dto = new H10_CityDto();
            dto.City_ID = City_ID;
            dto.City_Name = City_Name;
            using (var dalManager = DalFactorySelfLoadSoftDelete.GetManager())
            {
                var args = new DataPortalHookArgs(dto);
                OnUpdatePre(args);
                var dal = dalManager.GetProvider<IH10_CityDal>();
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
        /// Self deletes the <see cref="H10_City"/> object from database.
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
                var dal = dalManager.GetProvider<IH10_CityDal>();
                using (BypassPropertyChecks)
                {
                    dal.Delete(ReadProperty(City_IDProperty));
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
