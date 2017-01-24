'  This file was generated by CSLA Object Generator - CslaGenFork v4.5
'
' Filename:    UserInactiveNVL
' ObjectType:  UserInactiveNVL
' CSLAType:    NameValueList

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Csla
Imports Csla.Data
Imports DocStore.Business.Util

Namespace DocStore.Business.Admin

    ''' <summary>
    ''' Inactive users (name value list).<br/>
    ''' This is a generated base class of <see cref="UserInactiveNVL"/> business object.
    ''' </summary>
    <Serializable()>
    Partial Public Class UserInactiveNVL
    Inherits NameValueListBase(Of Integer, String)

        #Region " Private Fields "

        Private Shared _list As UserInactiveNVL

        #End Region

        #Region " Cache Management Methods "

        ''' <summary>
        ''' Clears the in-memory UserInactiveNVL cache so it is reloaded on the next request.
        ''' </summary>
        Public Shared Sub InvalidateCache()
            _list = Nothing
        End Sub

        ''' <summary>
        ''' Used by async loaders to load the cache.
        ''' </summary>
        ''' <param name="lst">The list to cache.</param>
        Friend Shared Sub SetCache(lst As UserInactiveNVL)
            _list = lst
        End Sub

        Friend Shared ReadOnly Property IsCached As Boolean
            Get
                Return _list IsNot Nothing
            End Get
        End Property

        #End Region

        #Region " Factory Methods "

        ''' <summary>
        ''' Factory method. Loads a <see cref="UserInactiveNVL"/> object.
        ''' </summary>
        ''' <returns>A reference to the fetched <see cref="UserInactiveNVL"/> object.</returns>
        Public Shared Function GetUserInactiveNVL() As UserInactiveNVL
            If _list Is Nothing Then
                _list = DataPortal.Fetch(Of UserInactiveNVL)(false)
            End If

            Return _list
        End Function

        ''' <summary>
        ''' Factory method. Asynchronously loads a <see cref="UserInactiveNVL"/> object.
        ''' </summary>
        ''' <param name="callback">The completion callback method.</param>
        Public Shared Sub GetUserInactiveNVL(callback As EventHandler(Of DataPortalResult(Of UserInactiveNVL)))
            If _list Is Nothing Then
                DataPortal.BeginFetch(Of UserInactiveNVL)(false, Sub(o, e)
                        _list = e.Object
                        callback(o, e)
                    End Sub)
            Else
                callback(Nothing, New DataPortalResult(Of UserInactiveNVL)(_list, Nothing, Nothing))
            End If
        End Sub

        #End Region

        #Region " Constructor "

        ''' <summary>
        ''' Initializes a new instance of the <see cref="UserInactiveNVL"/> class.
        ''' </summary>
        ''' <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        <System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>
        Public Sub New()
            ' Use factory methods and do not use direct creation.
        End Sub

        #End Region

        #Region " Data Access "

        ''' <summary>
        ''' Loads a <see cref="UserInactiveNVL"/> collection from the database, based on given criteria.
        ''' </summary>
        ''' <param name="isActive">The Is Active.</param>
        Protected Overloads Sub DataPortal_Fetch(isActive As Boolean)
            Using cn = New SqlConnection(Database.DocStoreConnection)
                Using cmd = New SqlCommand("GetUserInactiveNVL", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@IsActive", isActive).DbType = DbType.Boolean
                    cn.Open()
                    Dim args = New DataPortalHookArgs(cmd, isActive)
                    OnFetchPre(args)
                    LoadCollection(cmd)
                    OnFetchPost(args)
                End Using
            End Using
        End Sub

        Private Sub LoadCollection(cmd As SqlCommand)
            IsReadOnly = False
            Dim rlce = RaiseListChangedEvents
            RaiseListChangedEvents = False
            Using dr = New SafeDataReader(cmd.ExecuteReader())
                While dr.Read()
                    Add(New NameValuePair(
                        dr.GetInt32("UserID"),
                        dr.GetString("Name")))
                End While
            End Using
            RaiseListChangedEvents = rlce
            IsReadOnly = True
        End Sub

        #End Region

        #Region " DataPortal Hooks "

        ''' <summary>
        ''' Occurs after setting query parameters and before the fetch operation.
        ''' </summary>
        Partial Private Sub OnFetchPre(args As DataPortalHookArgs)
        End Sub

        ''' <summary>
        ''' Occurs after the fetch operation (object or collection is fully loaded and set up).
        ''' </summary>
        Partial Private Sub OnFetchPost(args As DataPortalHookArgs)
        End Sub

        #End Region

    End Class
End Namespace