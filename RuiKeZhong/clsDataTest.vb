﻿Imports System

Imports System.Data

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports DataTier

Imports System.IO.File



'''<summary>
'''This is a test class for clsDataTest and is intended
'''to contain all clsDataTest Unit Tests
'''</summary>
<TestClass()> _
Public Class clsDataTest
    ''' <summary>
    ''' Module level variables
    ''' </summary>
    ''' <remarks></remarks>
    Dim target As clsData_Accessor = New clsData_Accessor()
    Dim mstrDBPath As String = _
        "C:\\Users\\rzhong\\Desktop\\NETRuikeZhong\\NETRuikeZhong\\bin\\Debug\\VBAutoSales.mdb"
    Dim mstrDBPath_BACKUP As String = _
        "C:\\Users\\rzhong\\Desktop\\NETRuikeZhong\\NETRuikeZhong\\bin\\Debug\\VBAutoSales_BACKUP.mdb"
    Private testContextInstance As TestContext
    ''' <summary>
    ''' Create a backup of the database
    ''' </summary>
    ''' <remarks></remarks>
    <TestInitialize()> _
    Public Sub copyDB()
        If System.IO.File.Exists(mstrDBPath) = True Then
            FileCopy(mstrDBPath, mstrDBPath_BACKUP)
            target.connect(mstrDBPath)
        End If
    End Sub
    ''' <summary>
    ''' Restore the database from the backup 
    ''' </summary>
    ''' <remarks></remarks>
    <TestCleanup()> _
    Public Sub restoreDB()
        If System.IO.File.Exists(mstrDBPath_BACKUP) = True Then
            FileCopy(mstrDBPath_BACKUP, mstrDBPath)
        End If
    End Sub
    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for connect
    '''</summary>
    <TestMethod()> _
    Public Sub connectTest()
        Dim target As clsData_Accessor = New clsData_Accessor ' TODO: Initialize to an appropriate value
        Dim strPathFile As String = mstrDBPath_BACKUP ' TODO: Initialize to an appropriate value

        Dim expected As String
        Dim actual As String

        expected = "Open"
        target.connect(strPathFile)
        target.mconAutoSales.Open()

        actual = target.mconAutoSales.State.ToString()

        Assert.AreEqual(expected, actual, "Bad Connect")

        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for getSalesStaff
    '''</summary>
    <TestMethod()> _
    Public Sub getSalesStaffTest()
        'Dim target As clsData = New clsData ' TODO: Initialize to an appropriate value
        Dim expected As Boolean ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        Dim dsReturned As New DataSet

        dsReturned = target.getSalesStaff()
        expected = True

        If dsReturned.Tables(0).Rows.Count > 0 Then
            actual = True
        Else
            actual = False
        End If

        Assert.AreEqual(expected, actual, "retrieval failed")
    End Sub

    '''<summary>
    '''A test for getAllCars
    '''</summary>
    <TestMethod()> _
    Public Sub getAllCarsTest()
        'Dim target As clsData = New clsData ' TODO: Initialize to an appropriate value
        Dim expected As Boolean ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        Dim dsReturned As New DataSet

        dsReturned = target.getAllCars()
        expected = True

        If dsReturned.Tables(0).Rows.Count > 0 Then
            actual = True
        Else
            actual = False
        End If

        Assert.AreEqual(expected, actual, "retrieval failed")
    End Sub

    '''<summary>
    '''A test for getOneCar
    '''</summary>
    <TestMethod()> _
    Public Sub getOneCarTest()
        'Dim target As clsData = New clsData ' TODO: Initialize to an appropriate value
        Dim strStockNo As String = "1995101" ' TODO: Initialize to an appropriate value
        Dim expected As Boolean ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        expected = True
        Dim dsReturned As New DataSet

        dsReturned = target.getOneCar(strStockNo)


        If dsReturned.Tables(0).Rows.Count > 0 Then
            actual = True
        Else
            actual = False
        End If

        Assert.AreEqual(expected, actual, "retrieval failed")
    End Sub

    '''<summary>
    '''A test for getCommission
    '''</summary>
    <TestMethod()> _
    Public Sub getCommissionTest()
        Dim expected As Boolean ' TODO: Initialize to an appropriate value
        Dim actual As Boolean
        Dim dsReturned As New DataSet

        dsReturned = target.getCommission()
        expected = True

        If dsReturned.Tables(0).Rows.Count > 0 Then
            actual = True
        Else
            actual = False
        End If

        Assert.AreEqual(expected, actual, "retrieval failed")
    End Sub

    '''<summary>
    '''A test for updateCommission
    '''</summary>
    <TestMethod()> _
    Public Sub updateCommissionTest()
        'Dim target As clsData = New clsData ' TODO: Initialize to an appropriate value
        Dim name As String = "Ke" ' TODO: Initialize to an appropriate value
        Dim stockNum As String = "123456" ' TODO: Initialize to an appropriate value
        Dim description As String = "me" ' TODO: Initialize to an appropriate value
        Dim sale As Decimal = 12D ' TODO: Initialize to an appropriate value
        Dim expected As String = "Ke"
        Dim actual As String
        Dim drRow As System.Data.DataRow

        Dim dsChanged As DataSet
        dsChanged = target.getCommission()

        drRow = dsChanged.Tables(0).Rows(0)
        drRow(1) = "Ke"

        target.updateCommission(name, stockNum, description, sale)
        dsChanged.Clear()
        dsChanged = target.getCommission()

        actual = dsChanged.Tables(0).Rows(0)(1)
        Assert.AreEqual(expected, actual, "Database update failed")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for updateNewCar
    '''</summary>
    <TestMethod()> _
    Public Sub updateNewCarTest()
        Dim stockNum As String = "1231" ' TODO: Initialize to an appropriate value
        Dim manufacturedYear As Integer = 2011 ' TODO: Initialize to an appropriate value
        Dim description As String = "myCar" ' TODO: Initialize to an appropriate value
        Dim model As String = "SUV" ' TODO: Initialize to an appropriate value
        Dim color As String = "Blue" ' TODO: Initialize to an appropriate value
        Dim cost As Decimal = 10000.6D ' TODO: Initialize to an appropriate value
        Dim retailPrice As Decimal = 20000.8D ' TODO: Initialize to an appropriate value

        Dim expected As String = "SUV"
        Dim actual As String
        Dim drRow As System.Data.DataRow

        Dim dsChanged As DataSet
        dsChanged = target.getAllCars()

        drRow = dsChanged.Tables(0).Rows(0)
        drRow(3) = "SUV"

        target.updateNewCar(stockNum, manufacturedYear, description, model, color, cost, retailPrice)

        dsChanged.Clear()
        dsChanged = target.getAllCars()

        actual = dsChanged.Tables(0).Rows(0)(3)
        Assert.AreEqual(expected, actual, "Database update failed")
    End Sub

    '''<summary>
    '''A test for updateOneCar
    '''</summary>
    <TestMethod()> _
    Public Sub updateOneCarTest()
        'Dim target As clsData = New clsData ' TODO: Initialize to an appropriate value
        Dim dsChanged As DataSet = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As String
        Dim actual As String

        'starting point
        dsChanged = target.getAllCars()

        'modify data
        Dim drRow As System.Data.DataRow

        drRow = dsChanged.Tables(0).Rows(0)


        drRow(0) = 123456

        expected = 123456

        'update
        target.updateOneCar(dsChanged)

        'verify updated data
        'empty out previous result set
        dsChanged.Clear()

        dsChanged = target.getAllCars()

        actual = _
            dsChanged.Tables(0).Rows(0)(0)


        Assert.AreEqual(expected, actual, "Database update failed")
    End Sub
End Class
