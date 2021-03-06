<%
bool dependentAllowNew2 = false;
bool dependentAllowEdit2 = false;
bool dependentAllowRemove2 = false;
string itemName2 = string.Empty;
if (!IsReadOnlyType(Info.ObjectType) && IsCollectionType(Info.ObjectType))
{
    CslaObjectInfo itemInfo2 = FindChildInfo(Info, Info.ItemType);
    itemName2 = itemInfo2.ObjectName;
    if ((CurrentUnit.GenerationParams.GenerateAuthorization != Authorization.None &&
        CurrentUnit.GenerationParams.GenerateAuthorization != Authorization.PropertyLevel) &&
        ((itemInfo2.NewRoles.Trim() != String.Empty) ||
        (itemInfo2.UpdateRoles.Trim() != String.Empty) ||
        (itemInfo2.DeleteRoles.Trim() != String.Empty)))
    {
        if (Info.AllowNew && itemInfo2.NewRoles.Trim() != String.Empty)
            dependentAllowNew2 = true;
        if (Info.AllowEdit && itemInfo2.UpdateRoles.Trim() != String.Empty)
            dependentAllowEdit2 = true;
        if (Info.AllowRemove && itemInfo2.DeleteRoles.Trim() != String.Empty)
            dependentAllowRemove2 = true;
    }
}
%>

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="<%= Info.ObjectName %>"/> class.
        /// </summary>
        /// <remarks> This isn't a public access method in order to prevent direct creation.
        /// Use factory methods instead.</remarks>
        <%= GetConstructorVisibility(Info) %> <%= Info.ObjectName %>()
        {
            // Prevent direct creation
            <% if (Info.ObjectType == CslaObjectType.ReadOnlyCollection) {
                if (Info.UpdaterType != string.Empty) {
                    CslaObjectInfo childInfo4 = FindChildInfo(Info, Info.ItemType);
                    if (childInfo4.UpdateValueProperties.Count > 0) { %>
            <%= Info.UpdaterType %>.<%= Info.UpdaterType %>Saved += <%= Info.UpdaterType %>SavedHandler;
                    <% } %>
                <% } %>
            <% } %>
            <% if (ActiveObjects) {
                if (Info.ObjectType != CslaObjectType.EditableChildCollection) { %>
            RegisterAndSubscribe();
                <% }
            }
            // DataPortal_CreateChild already takes care of marking childs
            // CurrentUnit.GenerationParams.UseChildDataPortal is enought to say when this happens
            // except Get-(SafeDataReader dr) that bypass Child DataPortal methods
            if (!CurrentUnit.GenerationParams.UseChildDataPortal &&
                (Info.ObjectType == CslaObjectType.EditableChild ||
                Info.ObjectType == CslaObjectType.EditableChildCollection))
            {
                %>

            // show the framework that this is a child object
            MarkAsChild();
            <%
            }
            //if (Info.ObjectType == CslaObjectType.EditableChildCollection ||
            //    Info.ObjectType == CslaObjectType.EditableRootCollection ||
            //    Info.ObjectType == CslaObjectType.DynamicEditableRootCollection ||
            //    Info.ObjectType == CslaObjectType.ReadOnlyCollection)
            if (IsCollectionType(Info.ObjectType))
            {
                %>

            RaiseListChangedEvents = false;
            AllowNew = <%= dependentAllowNew2 ? Info + ".CanAddObject()" : Info.AllowNew.ToString().ToLower() %>;
            AllowEdit = <%= dependentAllowEdit2 ? Info + ".CanEditObject()" : Info.AllowEdit.ToString().ToLower() %>;
            AllowRemove = <%= dependentAllowRemove2 ? Info + ".CanDeleteObject()" : Info.AllowRemove.ToString().ToLower() %>;
            RaiseListChangedEvents = true;
        <%    }
    foreach (ChildProperty prop in Info.GetMyChildProperties())
    {
        CslaObjectInfo _child = FindChildInfo(Info, prop.TypeName);
        if (_child == null) {
            Warnings.Append("TypeName '" + prop.TypeName + "' doesn't exist in this project." + Environment.NewLine);
        }
    } %>
        }

        #endregion
