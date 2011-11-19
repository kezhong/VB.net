Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports BusinessTier



'''<summary>
'''This is a test class for clsChargesTest and is intended
'''to contain all clsChargesTest Unit Tests
'''</summary>
<TestClass()> _
Public Class clsChargesTest


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
    '''A test for clsCharges Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub clsChargesConstructorTest()
        Dim expected As Decimal = 0.0
        Dim target As clsCharges = New clsCharges()
        Dim actual As Decimal = target.Charges
        Assert.AreEqual(expected, actual, "Error:default constructor")
        'Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

End Class
