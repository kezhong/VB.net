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


End Class
