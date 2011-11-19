Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports NETRuikeZhong



'''<summary>
'''This is a test class for frmSummaryTest and is intended
'''to contain all frmSummaryTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmSummaryTest


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
    '''A test for summary form
    ''' 
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub frmSummary_LoadTest()
        Dim target As frmSummary_Accessor = New frmSummary_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value


        'run the calculateion twice and get the accumlated valiables.

        Dim objServ As New BusinessTier.clsService(500, 50, 5)
        objServ.calcAMount()

        Dim objServ1 As New BusinessTier.clsService(500, 50, 5)
        objServ.calcAMount()





        Dim expected As String = "$1,243.202$77.70$55.50$621.60"

        target.frmSummary_Load(sender, e)

        Dim actual As String
        actual = target.lblTotalAllServiceContracts.Text + target.lblNumContracts.Text + target.lblTotalPST.Text _
        + target.lblTotalGST.Text + target.lblAvgContract.Text

        Assert.AreEqual(expected, actual)

        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
End Class
