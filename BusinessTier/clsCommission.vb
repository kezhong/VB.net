''' <summary>
''' Used to calculate a saleperson's commission
''' </summary>
''' <remarks></remarks>
Public Class clsCommission
    Protected COMMISSION_RATE As Decimal = 0.2D
    Protected mdecCostPrice As Decimal
    Protected mdecRetailPrice As Decimal

#Region "Gets and Sets"
    Property CostPrice() As Decimal
        Get
            Return mdecCostPrice
        End Get
        Set(ByVal value As Decimal)
            mdecCostPrice = value
        End Set
    End Property

    Property RetailPrice() As Decimal
        Get
            Return mdecRetailPrice
        End Get
        Set(ByVal value As Decimal)
            mdecRetailPrice = value
        End Set
    End Property

#End Region

#Region "Constructors"
    Public Sub New()
        mdecCostPrice = 0
        mdecRetailPrice = 0
        'do not initialize shared variables'
    End Sub
    Public Sub New(ByVal decCostPrice As Decimal, _
                      ByVal decRetailPrice As Decimal)
        mdecCostPrice = decCostPrice
        mdecRetailPrice = decRetailPrice
    End Sub
#End Region

    'calculate the commission
    Public Function calCommission() As Decimal
        Dim commission As Decimal
        commission = (mdecRetailPrice - mdecCostPrice) * COMMISSION_RATE
        Return commission
    End Function

End Class
