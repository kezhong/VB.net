Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports NETRuikeZhong



'''<summary>
'''This is a test class for frmEstimateTest and is intended
'''to contain all frmEstimateTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmEstimateTest


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
    '''A test for radAll_CheckChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub radStandard_CheckChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Decimal
        Dim actual As Decimal
        expected = target.mdecSTANDARD
        sender = target.radStandard
        target.radAll_CheckChanged(sender, e)

        actual = target.mdecFinish
        Assert.AreEqual(expected, actual, "Error:Price of Car Exterior Finish --- Standard")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for radAll_CheckChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub radPearlized_CheckChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Decimal
        Dim actual As Decimal

        expected = target.mdecPEARLIZED
        sender = target.radPearlized
        target.radAll_CheckChanged(sender, e)

        actual = target.mdecFinish
        Assert.AreEqual(expected, actual, "Error:Price of Car Exterior Finish --- Pearlized")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for radAll_CheckChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub radCustomizedDetailing_CheckChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Decimal
        Dim actual As Decimal
        expected = target.mdecCUSTOMIZED
        sender = target.radCustomized
        target.radAll_CheckChanged(sender, e)
        actual = target.mdecFinish
        Assert.AreEqual(expected, actual, "Error:Price of Car Exterior Finish --- Customized Detailing")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for chkAll_CheckedChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub chkAll1_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Decimal
        Dim actual As Decimal
        expected = 0
        target.chkStereoSystem.Checked = False
        target.chkLeatherInterior.Checked = False
        target.chkCptNavigation.Checked = False
        target.chkAll_CheckedChanged(sender, e)
        actual = target.mdecAccessories
        Assert.AreEqual(expected, actual, "Error:Price of Accessories --- All of checkboxes are not selected")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for chkAll_CheckedChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub chkAll2_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Decimal
        Dim actual As Decimal
        expected = target.mdecSTEREO_SYSTEM

        target.chkStereoSystem.Checked = True
        target.chkLeatherInterior.Checked = False
        target.chkCptNavigation.Checked = False

        target.chkAll_CheckedChanged(sender, e)
        actual = target.mdecAccessories
        Assert.AreEqual(expected, actual, "Error:Price of Accessories --- Only Stereo System is selected")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for chkAll_CheckedChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub chkAll3_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Decimal
        Dim actual As Decimal
        expected = target.mdecLEATHER_INTERIOR

        target.chkStereoSystem.Checked = False
        target.chkLeatherInterior.Checked = True
        target.chkCptNavigation.Checked = False

        target.chkAll_CheckedChanged(sender, e)
        actual = target.mdecAccessories
        Assert.AreEqual(expected, actual, "Error:Price of Accessories --- Only Lenather Interior is selected")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for chkAll_CheckedChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub chkAll4_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Decimal
        Dim actual As Decimal
        expected = target.mdecCOMPUTER_NAVIGATION

        target.chkStereoSystem.Checked = False
        target.chkLeatherInterior.Checked = False
        target.chkCptNavigation.Checked = True

        target.chkAll_CheckedChanged(sender, e)
        actual = target.mdecAccessories
        Assert.AreEqual(expected, actual, "Error:Price of Accessories --- Only computer navigatgion is selected")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for chkAll_CheckedChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub chkAll5_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Decimal
        Dim actual As Decimal
        expected = target.mdecSTEREO_SYSTEM + target.mdecLEATHER_INTERIOR

        target.chkStereoSystem.Checked = True
        target.chkLeatherInterior.Checked = True
        target.chkCptNavigation.Checked = False

        target.chkAll_CheckedChanged(sender, e)
        actual = target.mdecAccessories
        Assert.AreEqual(expected, actual, "Error:Price of Accessories --- Stereo System  and Leather Interior are selected")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for chkAll_CheckedChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub chkAll6_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Decimal
        Dim actual As Decimal
        expected = target.mdecSTEREO_SYSTEM + target.mdecCOMPUTER_NAVIGATION

        target.chkStereoSystem.Checked = True
        target.chkLeatherInterior.Checked = False
        target.chkCptNavigation.Checked = True

        target.chkAll_CheckedChanged(sender, e)
        actual = target.mdecAccessories
        Assert.AreEqual(expected, actual, "Error:Price of Accessories ---  Stereo System and Computer Navigation are selected")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for chkAll_CheckedChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub chkAll7_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As Decimal
        Dim actual As Decimal
        expected = target.mdecLEATHER_INTERIOR + target.mdecCOMPUTER_NAVIGATION

        target.chkStereoSystem.Checked = False
        target.chkLeatherInterior.Checked = True
        target.chkCptNavigation.Checked = True

        target.chkAll_CheckedChanged(sender, e)
        actual = target.mdecAccessories
        Assert.AreEqual(expected, actual, "Error:Price of Accessories ---  Leather Interior and Computer Navigation are selected")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for btnClear_Click
    ''' to ensure that data areas are cleared
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub ctxClear_ClickTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As String
        Dim actual As String
        expected = ""
        actual = target.txtCustomerName.Text + target.txtCarPrice.Text + target.txtTradeInAllowance.Text _
                 + target.lblAccessoriesFinish.Text + target.lblAmountDue.Text + target.lblSubtotal.Text _
                 + target.lblSalesTax.Text + target.lblTotal.Text + target.lblAmountDue.Text

        target.ctxClear_Click(sender, e)
        Assert.AreEqual(expected, actual, "Error:textboes and labels are not be cleared.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub


    '''<summary>
    '''A test for quote subprocedure -- Do not accept quote
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub quoteTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim acceptOrNo As Boolean = False ' TODO: Initialize to an appropriate value
        Dim expected As Boolean
        Dim actual As Boolean
        expected = False
        target.quote(acceptOrNo)
        actual = target.ctxAcceptQuote.Enabled
        Assert.AreEqual(expected, actual, "Error:Accept Quote context menu is Enabled .")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for quote subprocedure -- Accept quote
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub quoteTest2()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim acceptOrNo As Boolean = True ' TODO: Initialize to an appropriate value
        Dim expected As Boolean
        Dim actual As Boolean
        expected = True
        target.quote(acceptOrNo)
        actual = target.ctxAcceptQuote.Enabled
        Assert.AreEqual(expected, actual, "Error:Accept Quote context menu is UnEnabled .")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for clear subprocedure -- clear
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub clearTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim clearOrNo As Boolean = True ' TODO: Initialize to an appropriate value
        Dim expected As Boolean
        Dim actual As Boolean
        expected = True
        target.clear(clearOrNo)
        actual = target.ctxCalculate.Enabled And target.ctxClear.Enabled
        Assert.AreEqual(expected, actual, "Error:Calculate or Clear context menu is unEnabled")

        'Private Accessor for clear is not found. Please rebuild the containing project or run the Publicize.exe manually.

    End Sub
    '''<summary>
    '''A test for clear subprocedure -- not clear
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub clearTest2()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim clearOrNo As Boolean = False ' TODO: Initialize to an appropriate value
        Dim expected As Boolean
        Dim actual As Boolean
        expected = False
        target.clear(clearOrNo)
        actual = target.ctxCalculate.Enabled And target.ctxClear.Enabled
        Assert.AreEqual(expected, actual, "Error:Calculate or Clear context menu is Enabled")
    End Sub

    '''<summary>
    '''A test for calculate of payment -- Min(0.00) insterest rate, Min(1) year
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub calculateTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim expected As Double
        Dim actual As Double

        target.lblNoOfYears.Text = "1"
        target.lblInsterestRate.Text = "0.00"
        target.amountDue = 1000

        expected = 83.33
        expected = Double.Parse(expected.ToString("####0.00"))

        target.calculate()
        actual = target.payment
        actual = Double.Parse(actual.ToString("####0.00"))
        Assert.AreEqual(expected, actual, "Error:Calculation error on payment")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for calculate of payment -- Min(0.00) insterest rate, Max(10) year, Amount due :1000
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub calculateTest2()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim expected As Double
        Dim actual As Double

        target.lblNoOfYears.Text = "10"
        target.lblInsterestRate.Text = "0.0"
        target.amountDue = 1000
        expected = 8.33
        expected = Double.Parse(expected.ToString("####0.00"))

        target.calculate()
        actual = target.payment
        actual = Double.Parse(actual.ToString("####0.00"))
        Assert.AreEqual(expected, actual, "Error:Calculation error on payment")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for calculate of payment -- Max(0.25) insterest rate, Max(10) year, Amount due :1000
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub calculateTest3()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim expected As Double
        Dim actual As Double

        target.lblNoOfYears.Text = "10"
        target.lblInsterestRate.Text = "0.25"
        target.amountDue = 1000

        expected = 22.75
        expected = Double.Parse(expected.ToString("####0.00"))

        target.calculate()
        actual = target.payment
        actual = Double.Parse(actual.ToString("####0.00"))
        Assert.AreEqual(expected, actual, "Error:Calculation error on payment")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for calculate of payment -- Max(0.25) insterest rate, Min(1) year, Amount due :1000
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub calculateTest4()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim expected As Double
        Dim actual As Double

        target.lblNoOfYears.Text = "1"
        target.lblInsterestRate.Text = "0.25"
        target.amountDue = 1000

        expected = 95.04
        expected = Double.Parse(expected.ToString("####0.00"))

        target.calculate()
        actual = target.payment
        actual = Double.Parse(actual.ToString("####0.00"))
        Assert.AreEqual(expected, actual, "Error:Calculation error on payment")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for calculate of payment -- Max(0.25) insterest rate, Max(10) year, Amount due :0
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub calculateTest5()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim expected As Double
        Dim actual As Double

        target.lblNoOfYears.Text = "10"
        target.lblInsterestRate.Text = "0.25"
        target.amountDue = 0

        expected = 0
        expected = Double.Parse(expected.ToString("####0.00"))

        target.calculate()
        actual = target.payment
        actual = Double.Parse(actual.ToString("####0.00"))
        Assert.AreEqual(expected, actual, "Error:Calculation error on payment")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    '''<summary>
    '''A test for calculate of payment -- Min(0.00) insterest rate, Min(1) year, Amount due :0
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub calculateTest6()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim expected As Double
        Dim actual As Double

        target.lblNoOfYears.Text = "1"
        target.lblInsterestRate.Text = "0.00"
        target.amountDue = 0

        expected = 0
        expected = Double.Parse(expected.ToString("####0.00"))

        target.calculate()
        actual = target.payment
        actual = Double.Parse(actual.ToString("####0.00"))
        Assert.AreEqual(expected, actual, "Error:Calculation error on payment")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for enableFinance--finace:false
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub enableFinanceTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim finace As Boolean = False ' TODO: Initialize to an appropriate value
        Dim expected As Boolean
        Dim actual As Boolean

        expected = False
        target.enableFinance(finace)

        actual = target.grpHSB.Enabled
        Assert.AreEqual(expected, actual, "Error:grpHSB Enabled is true")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for enableFinance--finace:true
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETRuikeZhong.exe")> _
    Public Sub enableFinanceTest1()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor ' TODO: Initialize to an appropriate value
        Dim finace As Boolean = True ' TODO: Initialize to an appropriate value
        Dim expected As Boolean
        expected = True
        target.enableFinance(finace)
        Dim actual As Boolean
        actual = target.grpHSB.Enabled
        Assert.AreEqual(expected, actual, "Error:grpHSB Enabled is false")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

End Class
