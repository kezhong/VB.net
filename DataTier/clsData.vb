Imports System.Data.OleDb
''' <summary>
''' clsData will contain functionality that will interact
''' directly with the database
''' </summary>
''' <remarks></remarks>
Public Class clsData
    Dim mblnTest As Boolean
    Dim mconAutoSales As OleDbConnection

    'data adapter:  handles and retrieval and updating
    'of the data
    'select all records from the UsedCars table
    Dim mdaAllUsedCards As New OleDbDataAdapter

    'select single records from the UsedCars table
    Dim mdaSingleUsedCard As New OleDbDataAdapter

    'select all records from the SalesStaff table
    Dim mdaAllSalesStaff As New OleDbDataAdapter

    'select all records from the Commissions table
    Dim mdaAllCommissions As New OleDbDataAdapter

    'generates insert, delete and update commands
    'for the associated data adapter

    'Used to generate SQLstatments for the "One Car" module 
    'level OleDbDataAdapter object defined above
    Dim mcmdOneCar As OleDbCommandBuilder

    'Used to generate SQLstatments for the "All Car" module 
    'level OleDbDataAdapter object defined above
    Dim mcmdAllCars As OleDbCommandBuilder

    'Used to generate SQLstatments for the "Commision" module 
    'level OleDbDataAdapter object defined above
    Dim mcmdCommission As OleDbCommandBuilder

    ''' <summary>
    ''' Connect to database
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub connect()
        Try
            If mblnTest = True Then
                'do nothing
                'for use with unit testing
                'to bypass this connection
            Else
                mconAutoSales = New OleDbConnection( _
                "provider = Microsoft.Jet.OLEDB.4.0;" & _
                "data source = VBAutoSales.mdb")

            End If
        Catch ex As Exception
            Throw 'defer exception handling back to
            'the client side
        End Try
    End Sub
    ''' <summary>
    ''' for use with unit testing
    ''' </summary>
    ''' <param name="strPathFile"></param>
    ''' <remarks></remarks>
    Public Sub connect(ByVal strPathFile As String)
        Try
            mconAutoSales = New OleDbConnection( _
            "provider = Microsoft.Jet.OLEDB.4.0;" & _
            "data source = " & strPathFile)
        Catch ex As Exception
            Throw 'defer exception handling
        End Try
    End Sub


End Class
