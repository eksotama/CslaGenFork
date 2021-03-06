<% if (!Info.UseCustomLoading) { %>
	<% if (!Info.DataSetLoadingScheme) { %>
		
		/// <summary>
		/// Factory method. New <see cref="<%=Info.ObjectName%>" /> Object is created and loaded from the given SafeDataReader.
		/// </summary>
		internal static <%=Info.ObjectName%> Get<%=Info.ObjectName%>(SafeDataReader dr)
		{
		<% if (Info.GetRoles.Trim() != String.Empty) { %>
			if (!CanGetObject())
				throw new System.Security.SecurityException("User not authorized to load a <%= Info.ObjectName %>");
		<% } %>
			<%=Info.ObjectName%> obj = new <%=Info.ObjectName%>();<% if (Info.ObjectType == CslaObjectType.EditableSwitchable) { %>
			obj.MarkAsChild();<% } %>
			obj.Fetch(dr);
			<% if (LoadsChildren(Info)) { %>		
			obj.FetchChildren(dr);
			<% } 
			if (Info.ObjectType != CslaObjectType.ReadOnlyObject && !IsCollectionType(Info.ObjectType)) { %>
			obj.MarkOld();
			obj.ValidationRules.CheckRules();<% } %>
			<% if (ActiveObjects) { %>
			obj.RegisterAndSubscribe();
			<% } %>
			return obj;
		}
	<% } else { %>
		
		/// <summary>
		/// Factory method. New <see cref="<%=Info.ObjectName%>" /> object is created and loaded from the given SafeDataReader.
		/// </summary>
		internal static <%=Info.ObjectName%> Get<%=Info.ObjectName%>(DataRow<% if (IsCollectionType(Info.ObjectType)) {%>[]<% } %> dr)
		{
			<% if (Info.GetRoles.Trim() != string.Empty) { %>
			if (!CanGetObject())
				throw new System.Security.SecurityException("User not authorized to load a <%= Info.ObjectName %>");
			<% } %>
			<%=Info.ObjectName%> obj = new <%=Info.ObjectName%>();
			<% if (Info.ObjectType == CslaObjectType.EditableSwitchable) { %>
			obj.MarkAsChild();<% } %>
			obj.Fetch(dr);<% if (LoadsChildren(Info) && !IsCollectionType(Info.ObjectType)) { %>
			obj.FetchChildren(dr);
			<% } %><% if (Info.ObjectType != CslaObjectType.ReadOnlyObject && !IsCollectionType(Info.ObjectType)) { %>
			obj.MarkOld();
			obj.ValidationRules.CheckRules();
			<% } %><% if (ActiveObjects) { %>
			obj.RegisterAndSubscribe();
			<% } %>
			return obj;
		}
	<% } %>
<% } %>
