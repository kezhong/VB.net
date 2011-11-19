Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports BusinessTier



'''<summary>
'''This is a test class for clsServiceTest and is intended
'''to contain all clsServiceTest Unit Tests
'''</summary>
<TestClass()> _
Public Class clsServiceTest


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

    '''<summary>
    '''A test for Parts
    '''</summary>
    <TestMethod()> _
    Public Sub PartsTest()
        Dim decPrices As Decimal = 1.0
        Dim decParts As Decimal = 2.0
        Dim decMaterials As Decimal = 3.0
        Dim actual As Decimal
        Dim expected As Decimal = 2.0

        Dim target As clsService = New clsService(decPrices, decParts, decMaterials)
        actual = target.Parts
        Assert.AreEqual(expected, actual, "Error:Parts")
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
    '''<summary>
    '''A test for Prices
    '''</summary>
    <TestMethod()> _
    Public Sub PricesTest()
        Dim decPrices As Decimal = 1.0
        Dim decParts As Decimal = 2.0
        Dim decMaterials As Decimal = 3.0
        Dim actual As Decimal
        Dim expected As Decimal = 1.0

        Dim target As clsService = New clsService(decPrices, decParts, decMaterials)
        actual = target.Prices
        Assert.AreEqual(expected, actual, "Error:Prices")
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
    '''<summary>
    '''A test for Materials
    '''</summary>
    <TestMethod()> _
    Public Sub MaterialsTest()
        Dim decPrices As Decimal = 1.0
        Dim decParts As Decimal = 2.0
        Dim decMaterials As Decimal = 3.0
        Dim actual As Decimal
        Dim expected As Decimal = 3.0

        Dim target As clsService = New clsService(decPrices, decParts, decMaterials)
        actual = target.Meterials()
        Assert.AreEqual(expected, actual, "Error:Meterials")
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for clsService Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub clsServiceConstructorTest()
        Dim decPrices As Decimal = 2.0
        Dim decParts As Decimal = 2.0
        Dim decMaterials As Decimal = 3.0
        Dim expected As Decimal
        Dim actual As Decimal
        expected = decPrices + decParts + decMaterials
        Dim target As clsService = New clsService(decPrices, decParts, decMaterials)
        actual = target.Parts() + target.Prices() + target.Meterials()
        Assert.AreEqual(expected, actual, "Error:Gets and Sets improper")
    End Sub



    '''<summary>
    '''A test for average contract includes tax
    '''</summary>
    <TestMethod()> _
    Public Sub averageContractTest()
        Dim decPrices As Decimal = 100.0
        Dim decParts As Decimal = 200.0
        Dim decMaterials As Decimal = 300.0
        Dim expected As Decimal = 744.0
        Dim actual As Decimal
        Dim target As clsService = New clsService(decPrices, decParts, decMaterials)
        target.calcAMount()
        actual = target.averageContract()
        Assert.AreEqual(expected, actual, "Error:calculation of average")

    End Sub

    '''<summary>
    '''A test for calcAMount
    '''</summary>
    <TestMethod()> _
    Public Sub calcAMountTest()
        Dim decPrices As Decimal = 250.5
        Dim decParts As Decimal = 200.5
        Dim decMaterials As Decimal = 300.11
        Dim expected As Decimal = 841.24
        Dim expectedFormated As String = expected.ToString("c")
        Dim actual As Decimal

        Dim target As clsService = New clsService(decPrices, decParts, decMaterials)

        actual = target.calcAMount()

        Dim actualFormated As String = actual.ToString("c")
        Assert.AreEqual(expectedFormated, actualFormated, "Error:calculation of total")

    End Sub

    '''<summary>
    '''A test for CalculatedPST
    '''</summary>
    <TestMethod()> _
    Public Sub CalculatedPSTTest()
        Dim decPrices As Decimal = 250.5
        Dim decParts As Decimal = 200.5
        Dim decMaterials As Decimal = 300.11
        Dim expected As Decimal = 52.58
        Dim expectedFormated As String = expected.ToString("c")
        Dim actual As Decimal
        Dim target As clsService = New clsService(decPrices, decParts, decMaterials)
        target.calcAMount()
        actual = target.CalculatedPST
        Dim actualFormated As String = actual.ToString("c")
        Assert.AreEqual(expectedFormated, actualFormated, "Error:calculation of PST")
    End Sub
    '''<summary>
    '''A test for CalculatedGST
    '''</summary>
    <TestMethod()> _
    Public Sub CalculatedGSTTest()
        Dim decPrices As Decimal = 250.5
        Dim decParts As Decimal = 200.5
        Dim decMaterials As Decimal = 300.11
        Dim expected As Decimal = 37.56
        Dim expectedFormated As String = expected.ToString("c")
        Dim actual As Decimal
        Dim target As clsService = New clsService(decPrices, decParts, decMaterials)
        target.calcAMount()
        actual = target.CalculatedGST
        Dim actualFormated As String = actual.ToString("c")
        Assert.AreEqual(expectedFormated, actualFormated, "Error:calculation of PST")
    End Sub

    '''<summary>
    '''A test for clsService Constructor
    '''</summary>
    <TestMethod()> _
    Public Sub clsServiceConstructorTest1()
        Dim expected As Decimal = 0.0
        Dim target As clsService = New clsService
        Dim actual As Decimal
        actual = target.Prices + target.Parts + target.Meterials
        Assert.AreEqual(expected, actual, "Error:Initialized clsService instance faild")

    End Sub

End Class
