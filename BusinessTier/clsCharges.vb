Public Class clsCharges
    Private TAX_RATE As Decimal = 0.12D
    Dim mdecCharges As Decimal
    Dim mdecTax As Decimal
    Dim mdecTotal As Decimal
    Dim mdecPackagePrice As Decimal
    Dim mdecFragrancePrice As Decimal

#Region "Gets and Sets"
    ReadOnly Property Charges() As Decimal
        Get
            Return mdecCharges
        End Get
    End Property

    ReadOnly Property Tax() As Decimal
        Get
            Return mdecTax
        End Get
    End Property
    ReadOnly Property Total() As Decimal
        Get
            Return mdecTotal
        End Get
    End Property
#End Region


#Region "Constructor"
    Public Sub New()
        mdecCharges = 0.0
        mdecTax = 0.0
        mdecTotal = 0.0
        mdecPackagePrice = 0.0
        mdecFragrancePrice = 0.0

    End Sub
    Public Sub New(ByVal decPackagePrice As Decimal, _
                      ByVal decFragrancePrice As Decimal)
        mdecPackagePrice = decPackagePrice
        mdecFragrancePrice = decFragrancePrice
        Calculate()
    End Sub
#End Region

    Public Sub Calculate()
        mdecCharges = mdecPackagePrice + mdecFragrancePrice
        mdecTax = mdecCharges * TAX_RATE
        mdecTotal = mdecTax + mdecCharges
    End Sub


End Class
