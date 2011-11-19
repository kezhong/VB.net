
Public Class clsService
    Protected PST_RATE As Decimal = 0.07
    Protected GST_RATE As Decimal = 0.05
    Dim mdecPrices As Decimal
    Dim mdecParts As Decimal
    Dim mdecMaterials As Decimal
    Dim mdecCalculatedPST As Decimal
    Dim mdecCalculatedGST As Decimal
    Dim mdecCalculatedTotal As Decimal
    Protected Shared mintNoOfContracts As Integer
    Protected Shared mdecAccumulatedCalcTotals As Decimal
    Protected Shared mdecAccumulatedGST As Decimal
    Protected Shared mdecAccumulatedPST As Decimal
#Region "Gets and Sets"
    Property Prices() As Decimal
        Get
            Return mdecPrices
        End Get
        Set(ByVal value As Decimal)
            mdecPrices = value
        End Set
    End Property
    Property Parts() As Decimal
        Get
            Return mdecParts
        End Get
        Set(ByVal value As Decimal)
            mdecParts = value
        End Set
    End Property
    Property Meterials() As Decimal
        Get
            Return mdecMaterials
        End Get
        Set(ByVal value As Decimal)
            mdecMaterials = value
        End Set
    End Property
    Property CalculatedPST() As Decimal
        Get
            Return mdecCalculatedPST
        End Get
        Set(ByVal value As Decimal)
            mdecCalculatedPST = value
        End Set
    End Property
    Property CalculatedGST() As Decimal
        Get
            Return mdecCalculatedGST
        End Get
        Set(ByVal value As Decimal)
            mdecCalculatedGST = value
        End Set
    End Property
    Property CalculatedTotal() As Decimal
        Get
            Return mdecCalculatedTotal
        End Get
        Set(ByVal value As Decimal)
            mdecCalculatedTotal = value
        End Set
    End Property
    Shared ReadOnly Property NoOfContracts() As Integer
        Get
            Return mintNoOfContracts
        End Get
    End Property
    Shared ReadOnly Property AccumulatedCalcTotals() As Decimal
        Get
            Return mdecAccumulatedCalcTotals
        End Get
    End Property
    Shared ReadOnly Property AccumulatedGST() As Decimal
        Get
            Return mdecAccumulatedGST
        End Get
    End Property
    Shared ReadOnly Property AccumulatedPST() As Decimal
        Get
            Return mdecAccumulatedPST
        End Get
    End Property
#End Region
#Region "methods"
    ''' <summary>
    ''' overridable allows for the method to be
    ''' re-implemented in the derived class
    ''' </summary>
    ''' <remarks></remarks>
    Public Function calcAMount()
        Dim subTotal As Decimal
        subTotal = mdecParts + mdecPrices + mdecMaterials
        mdecCalculatedPST = subTotal * PST_RATE
        mdecCalculatedGST = subTotal * GST_RATE
        mdecCalculatedTotal = mdecCalculatedGST + mdecCalculatedPST + subTotal
        mintNoOfContracts += 1
        mdecAccumulatedCalcTotals += mdecCalculatedTotal
        mdecAccumulatedGST += mdecCalculatedGST
        mdecAccumulatedPST += mdecCalculatedPST
        Return mdecCalculatedTotal
    End Function
    ''' <summary>
    ''' Divide the accumulated service contract amount by the accumulated
    ''' number of service contracts and return the result to the calling routine
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function averageContract()
        Dim average As Decimal
        If mintNoOfContracts = 0 Then
            mintNoOfContracts = 1
        End If
        average = mdecAccumulatedCalcTotals / mintNoOfContracts
        Return average
    End Function
#End Region

#Region "Constructors"
    Public Sub New()
        mdecPrices = 0
        mdecParts = 0
        mdecMaterials = 0
        'do not initialize shared variables'

    End Sub
    Public Sub New(ByVal decPrices As Decimal, _
                      ByVal decParts As Decimal, _
                      ByVal decMaterials As Decimal)
        mdecPrices = decPrices
        mdecParts = decParts
        mdecMaterials = decMaterials
    End Sub
#End Region

End Class
