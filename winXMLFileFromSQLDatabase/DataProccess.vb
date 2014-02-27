#Region "Imports"
Imports System.Data
Imports System.Data.SqlClient
#End Region

Public Class DataProccess

#Region "Local Variables"
    Private _Conn As SqlConnection
#End Region

#Region "Properties"
    Public Property Conn() As SqlConnection
        Get
            Return Me._Conn
        End Get
        Set(ByVal value As SqlConnection)
            Me._Conn = value
        End Set
    End Property
#End Region

#Region "Methods"
    Public Sub New()
        Me._Conn = New SqlConnection
    End Sub

    Public Function SelectQuery(ByVal ConnectionString As String, ByVal Query As String) As DataTable
        Dim DT As DataTable = New DataTable
        Me._Conn = New SqlConnection(ConnectionString)
        Dim DA As SqlDataAdapter = New SqlDataAdapter(Query, _Conn)
        DA.Fill(DT)

        Return DT
    End Function
#End Region
End Class

#Region "WithACCESS"
'#Region "Imports"
'Imports System.Data
'Imports System.Data.OleDb
'Imports System.Data.SqlClient
'#End Region

'Public Class DataProccess

'#Region "SQLLocal Variables"
'    Private _ConnSQL As SqlConnection
'#End Region
'#Region "ACCESSLocal Variables"
'    Private _ConnAcc As OleDbConnection
'#End Region

'#Region "SQLProperties"
'    Public Property Conn() As SqlConnection
'        Get
'            Return Me._ConnSQL
'        End Get
'        Set(ByVal value As SqlConnection)
'            Me._ConnSQL = value
'        End Set
'    End Property
'#End Region
'#Region "ACCESSProperties"
'    Public Property ConnAcc() As OleDbConnection
'        Get
'            Return Me._ConnAcc
'        End Get
'        Set(ByVal value As OleDbConnection)
'            Me._ConnAcc = value
'        End Set
'    End Property
'#End Region

'#Region "Constructor"
'    Public Sub New(ByVal IsSQLDatabase As Boolean)
'        If IsSQLDatabase = True Then
'            Me._ConnSQL = New SqlConnection
'        Else
'            Me._ConnAcc = New OleDbConnection
'        End If

'    End Sub
'#End Region

'#Region "SQLMethods"
'    Public Function SQLSelectQuery(ByVal ConnectionString As String, ByVal Query As String) As DataTable
'        Dim DT As DataTable = New DataTable
'        Me._ConnSQL = New SqlConnection(ConnectionString)
'        Dim DA As SqlDataAdapter = New SqlDataAdapter(Query, _ConnSQL)
'        DA.Fill(DT)

'        Return DT
'    End Function
'#End Region
'#Region "ACCESSMethods"
'    Public Function ACCESSSelectQuery(ByVal ConnectionString As String, ByVal Query As String) As DataTable
'        Dim DT As DataTable = New DataTable
'        Me._ConnAcc = New OleDbConnection(ConnectionString)
'        Dim DA As OleDbDataAdapter = New OleDbDataAdapter(Query, _ConnAcc)
'        DA.Fill(DT)

'        Return DT
'    End Function
'#End Region

'End Class
#End Region
