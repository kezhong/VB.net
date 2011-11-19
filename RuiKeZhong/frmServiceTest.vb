Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports NETRuikeZhong



'''<summary>
'''This is a test class for frmServiceTest and is intended
'''to contain all frmServiceTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmServiceTest


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
    '''A test for clear menu
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub ctxClear_ClickTest()
        Dim target As frmService_Accessor = New frmService_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As String
        Dim actual As String
        expected = ""
        target.ctxClear_Click(sender, e)
        actual = target.txtPrice.Text + target.txtParts.Text + target.txtShopMaterial.Text + target.lblGST.Text + target.lblPST.Text + target.lblTotal.Text
        Assert.AreEqual(expected, actual, "Error:textboes and labels are not be cleared.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub


    '''<summary>
    '''A test for txtBoxes_Leave
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub txtBoxes_LeaveTest()
        Dim target As frmService_Accessor = New frmService_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.txtPrice ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = False
        target.txtParts.Text = ""
        target.txtShopMaterial.Text = "456"
        target.txtPrice.Text = "789"
        target.txtBoxes_Leave(sender, e)

        Dim actual As Boolean = target.ctxCalculate.Enabled

        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtBoxes_Leave
    ''' part, price and shop material are entered
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub txtBoxes_LeaveTest1()
        Dim target As frmService_Accessor = New frmService_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.txtPrice ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Boolean = True
        target.txtParts.Text = "123"
        target.txtPrice.Text = "456"
        target.txtShopMaterial.Text = "46"
        target.txtBoxes_Leave(sender, e)

        Dim actual As Boolean = target.ctxCalculate.Enabled

        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
End Class
