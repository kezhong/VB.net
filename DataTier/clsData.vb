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
    Dim mdaAllUsedcars As New OleDbDataAdapter

    'select single records from the UsedCars table
    Dim mdaSingleUsedCar As New OleDbDataAdapter

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


    'data set: is populated with the result set
    'of the database query (holds the actual data)
    'NONVENDOR SPECIFIC 
    'DISCONNECTED

    Dim mdsAllUsedCars As New DataSet
    Dim mdsSingleUsedCar As New DataSet
    Dim mdsAllSalesStaff As New DataSet
    Dim mdsAllCommissions As New DataSet

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
    ''' <summary>
    ''' Receive no arguments and will return 
    ''' mdsAllSalesStaff dataset
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getSalesStaff() As DataSet
        Try
            mdaAllSalesStaff.SelectCommand = New OleDbCommand
            mdaAllSalesStaff.SelectCommand.Connection = mconAutoSales

            mdaAllSalesStaff.SelectCommand.CommandText = _
            "SELECT * FROM SalesStaff"

            mdaAllSalesStaff.Fill(mdsAllSalesStaff, "SalesStaff")

            Return mdsAllSalesStaff

        Catch ex As Exception
            Throw
        End Try

    End Function
    ''' <summary>
    ''' ''' Receive no arguments and will return 
    ''' mdsAllUsedCars dataset
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAllCars() As DataSet
        Try
            mdaAllUsedcars.SelectCommand = New OleDbCommand
            mdaAllUsedcars.SelectCommand.Connection = mconAutoSales

            mdaAllUsedcars.SelectCommand.CommandText = _
            "SELECT * FROM UsedCars"

            mdaAllUsedcars.Fill(mdsAllUsedCars, "AllUsedCards")

            mcmdAllCars = New OleDbCommandBuilder(mdaAllUsedcars)

            Return mdsAllUsedCars

        Catch ex As Exception

            Throw
        End Try
    End Function

    Public Function getOneCar(ByVal strStockNo As String) As DataSet
        Try
            mdsSingleUsedCar.Clear()

            mdaSingleUsedCar.SelectCommand = New OleDbCommand
            mdaSingleUsedCar.SelectCommand.Connection = mconAutoSales

            mdaSingleUsedCar.SelectCommand.CommandText = _
            "SELECT * FROM UsedCars WHERE StockNo = '" & strStockNo & "'"

            mdaSingleUsedCar.Fill(mdsSingleUsedCar, "UsedCars")

            mcmdOneCar = New OleDbCommandBuilder(mdaSingleUsedCar)


            Return mdsSingleUsedCar

        Catch ex As Exception

            Throw
        End Try


    End Function

    Public Function getCommission() As DataSet
        Try
            mdaAllCommissions.SelectCommand = New OleDbCommand
            mdaAllCommissions.SelectCommand.Connection = mconAutoSales

            mdaAllCommissions.SelectCommand.CommandText = _
            "SELECT * FROM Commissions"

            mdaAllCommissions.Fill(mdsAllCommissions, "Commissions")

            mcmdCommission = New OleDbCommandBuilder(mdaAllCommissions)

            Return mdsAllCommissions

        Catch ex As Exception

            Throw
        End Try
    End Function

    Public Sub updateCommission(ByVal name As String, _
                                ByVal stockNum As String, _
                                ByVal description As String, _
                                ByVal sale As Decimal)

        mdaAllCommissions.SelectCommand = New OleDbCommand
        mdaAllCommissions.SelectCommand.Connection = mconAutoSales

        Dim newRow As DataRow
        newRow = mdsAllCommissions.Tables("Commissions").NewRow
        mdaAllCommissions.SelectCommand.CommandText = _
            "SELECT * FROM Commissions"
        mdaAllCommissions.Fill(mdsAllCommissions, "Commissions")
        newRow(1) = name
        newRow(2) = stockNum
        newRow(3) = description
        newRow(4) = sale
        'Add new row to the dataset
        mdsAllCommissions.Tables("Commissions").Rows.Add(newRow)
        'make the above insert permanent with an update
        Try
            mdaAllCommissions.Update(mdsAllCommissions, "Commissions")


        Catch ex As Exception

        End Try
    End Sub

    Public Sub updateNewCar(ByVal stockNum As String, _
                               ByVal manufacturedYear As Integer, _
                               ByVal description As String, _
                               ByVal model As String, _
                               ByVal color As String, _
                               ByVal cost As Decimal, _
                               ByVal retailPrice As Decimal)

        mdaAllUsedcars.SelectCommand = New OleDbCommand
        mdaAllUsedcars.SelectCommand.Connection = mconAutoSales


        mdaAllUsedcars.SelectCommand.CommandText = _
        "SELECT * FROM UsedCars"
        mdaAllUsedcars.Fill(mdsAllUsedCars, "UsedCars")

        Dim newRow As DataRow
        newRow = mdsAllUsedCars.Tables("UsedCars").NewRow

        newRow("StockNo") = stockNum
        newRow("ManufacturedYear") = manufacturedYear
        newRow("Description") = description
        newRow("Model") = model
        newRow("Color") = color
        newRow("CostPrice") = cost
        newRow("RetailPrice") = retailPrice

        'Add new row to the dataset
        mdsAllUsedCars.Tables("UsedCars").Rows.Add(newRow)
        'make the above insert permanent with an update
        Try
            mdaAllUsedcars.Update(mdsAllUsedCars, "UsedCars")


        Catch ex As Exception
            Throw

        End Try
    End Sub

    Public Sub updateOneCar(ByVal dsChanged As DataSet)
        Try

            mdaSingleUsedCar.Update(dsChanged, "UsedCars")
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
