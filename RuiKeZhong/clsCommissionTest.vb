Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports BusinessTier



'''<summary>
'''This is a test class for clsCommissionTest and is intended
'''to contain all clsCommissionTest Unit Tests
'''</summary>
<TestClass()> _
Public Class clsCommissionTest


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
    '''A test for CostPrice
    '''</summary>
    <TestMethod()> _
    Public Sub CostPriceTest()
        Dim target As clsCommission = New clsCommission ' TODO: Initialize to an appropriate value
        Dim expected As Decimal = 1.2 ' TODO: Initialize to an appropriate value
        Dim actual As Decimal
        target.CostPrice = expected
        actual = target.CostPrice
        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for RetailPrice
    '''</summary>
    <TestMethod()> _
    Public Sub RetailPriceTest()
        Dim target As clsCommission = New clsCommission ' TODO: Initialize to an appropriate value
        Dim expected As Decimal = 5.5 ' TODO: Initialize to an appropriate value
        Dim actual As Decimal
        target.RetailPrice = expected
        actual = target.RetailPrice
        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for clsCommission Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub clsCommissionConstructorTest()
        Dim decCostPrice As Decimal = 5.6 ' TODO: Initialize to an appropriate value
        Dim decRetailPrice As Decimal = 5.8 ' TODO: Initialize to an appropriate value
        Dim expected As Decimal = 11.4
        Dim actual As Decimal
        Dim target As clsCommission = New clsCommission(decCostPrice, decRetailPrice)
        actual = target.CostPrice + target.RetailPrice
        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

    '''<summary>
    '''A test for calCommission
    '''</summary>
    <TestMethod()> _
    Public Sub calCommissionTest()
        Dim target As clsCommission = New clsCommission(11.0, 12.0)
        Dim expected As Decimal = 0.2 ' TODO: Initialize to an appropriate value
        Dim actual As Decimal
        actual = target.calCommission
        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
