Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports NETRuikeZhong



'''<summary>
'''This is a test class for frmCarWashTest and is intended
'''to contain all frmCarWashTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmCarWashTest


    Private testContextInstance As TestContext

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
    '''A test for readFiles
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub readFilesTest()
        Dim target As frmCarWash_Accessor = New frmCarWash_Accessor ' TODO: Initialize to an appropriate value
        Dim strFileName As String = "Interior.txt" ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 4
        Dim actual As Integer
        target.readFiles(strFileName)
        actual = target.mstrInteriorContent.Length
        Assert.AreEqual(expected, actual, "readFiles -")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for readFiles--Exterior.txt
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub readFilesTest2()
        Dim target As frmCarWash_Accessor = New frmCarWash_Accessor ' TODO: Initialize to an appropriate value
        Dim strFileName As String = "Exterior.txt" ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 4
        Dim actual As Integer
        target.readFiles(strFileName)
        actual = target.mstrExteriorContent.Length
        Assert.AreEqual(expected, actual, "readFiles -")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for readFiles--Exterior.txt
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub readFilesTest3()
        Dim target As frmCarWash_Accessor = New frmCarWash_Accessor ' TODO: Initialize to an appropriate value
        Dim strFileName As String = "PkgPrices.txt" ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 4
        Dim actual As Integer
        target.readFiles(strFileName)
        actual = target.mdecPackagePrices.Length
        Assert.AreEqual(expected, actual, "readFiles -")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub


    '''<summary>
    '''A test for readFiles
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub readFilesTest1()
        Dim target As frmCarWash_Accessor = New frmCarWash_Accessor ' TODO: Initialize to an appropriate value
        Dim strFileName As String = "FragDesc.txt" ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 6
        Dim actual As Integer
        target.readFiles(strFileName)
        actual = target.mfraLists.Length
        Assert.AreEqual(expected, actual, "readFiles -")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for readFiles
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub readFilesTest4()
        Dim target As frmCarWash_Accessor = New frmCarWash_Accessor ' TODO: Initialize to an appropriate value
        Dim strFileName As String = "FragDesc.txt" ' TODO: Initialize to an appropriate value
        Dim expected As String = "Pine"
        Dim actual As String
        target.readFiles(strFileName)
        actual = target.mfraLists(2).strDescription
        Assert.AreEqual(expected, actual, "readFiles -")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for readFiles
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub readFilesTest5()
        Dim target As frmCarWash_Accessor = New frmCarWash_Accessor ' TODO: Initialize to an appropriate value
        Dim strFileName As String = "FragDesc.txt" ' TODO: Initialize to an appropriate value
        Dim expected As String = "0"
        Dim actual As String
        target.readFiles(strFileName)
        actual = target.mfraLists(2).decPrice
        Assert.AreEqual(expected, actual, "readFiles -")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for resetFrag--found "Pine". Expected return index 2 of fragrance combobox 
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub resetFragTest()
        Dim target As frmCarWash_Accessor = New frmCarWash_Accessor ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 2 ' TODO: Initialize to an appropriate value
        target.readFiles("FragDesc.txt")
        Dim actual As Integer
        actual = target.resetFrag
        Assert.AreEqual(expected, actual, "Error:Could not find Pine in Fragrance Combobox")
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for resetFrag--Couldn't find "Pine". Expected return index -1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub resetFragTest1()
        Dim target As frmCarWash_Accessor = New frmCarWash_Accessor ' TODO: Initialize to an appropriate value
        Dim expected As Integer = -1 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.resetFrag
        Assert.AreEqual(expected, actual, "Error:find Pine in Fragrance Combobox but surppose to be not")
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for getFragIndex--
    ''' find the index of baby powder in FragranceStruct strDescription
    ''' expected return 1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub getFragIndexTest()
        Dim target As frmCarWash_Accessor = New frmCarWash_Accessor
        Dim expected As Integer = 1
        Dim actual As Integer
        target.readFiles("FragDesc.txt")
        actual = target.getFragIndex("baby powder")
        Assert.AreEqual(expected, actual, _
        "Error: Could not find the index of Baby Powder in FragranceStruct strDescription")
    End Sub

    '''<summary>
    '''A test for getFragIndex--
    ''' find the index of something no in FragranceStruct strDescription
    ''' expected return -1
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub getFragIndexTest1()
        Dim target As frmCarWash_Accessor = New frmCarWash_Accessor
        Dim expected As Integer = -1
        Dim actual As Integer
        target.readFiles("FragDesc.txt")
        actual = target.getFragIndex("something")
        Assert.AreEqual(expected, actual, _
        "Error: unexpected found")
    End Sub

End Class
