Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports NETRuikeZhong



'''<summary>
'''This is a test class for frmBaseTest and is intended
'''to contain all frmBaseTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmBaseTest


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
    '''A test for validateNumeric
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub validateNumericTest()
        Dim target As frmBase_Accessor = New frmBase_Accessor
        Dim expected As Boolean = True
        Dim actual As Boolean
        actual = target.validateNumeric(100)

        Assert.AreEqual(expected, actual)

    End Sub
End Class
