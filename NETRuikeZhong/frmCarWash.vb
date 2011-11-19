Imports System.IO
Imports System.Reflection
Public Class frmCarWash
    Structure FragranceStruct
        Dim strDescription As String
        Dim decPrice As Decimal
    End Structure
    'a dynamic array of FragranceStruct
    Dim mfraLists() As FragranceStruct

    'a string array to store the contents of Interior.txt
    Dim mstrInteriorContent() As String
    'a string array to store the contents of Exterior.txt
    Dim mstrExteriorContent() As String
    'a decimal array to store the package prices
    Dim mdecPackagePrices() As Decimal

    Dim mstrExternalFiles() As String = {"Exterior.txt", "FragDesc.txt", "FragPrices.txt", "Interior.txt", "PkgDesc.txt", "PkgPrices.txt"}
    Dim mobjCharges As BusinessTier.clsCharges

    ''' <summary>
    ''' This subprocedure will be used to initialize date
    ''' based on the contents of the passed filename
    ''' </summary>
    ''' <param name="strFileName"></param>
    ''' <remarks></remarks>
    Private Sub readFiles(ByVal strFileName As String)
        Dim objAssembly As Assembly
        objAssembly = Assembly.GetExecutingAssembly()
        Dim strNamespace As String = _
        objAssembly.GetName().Name.ToString()

        Try
            Dim fileName As String = strFileName
            Dim srFile As New  _
            StreamReader(objAssembly. _
                         GetManifestResourceStream(strNamespace & _
                "." & fileName))

            'Dim datFile As New StreamReader(fileName)

            Dim strContent As String

            Select Case fileName
                'oad the contents of the file into the module level 
                'array defined above to store exterior package 
                'descriptions in the order in which the records were read
                Case "Exterior.txt"
                    Dim intNdx As Integer
                    Do While srFile.Peek <> -1
                        strContent = srFile.ReadLine()
                        ReDim Preserve mstrExteriorContent(intNdx)
                        mstrExteriorContent(intNdx) = strContent
                        intNdx += 1
                    Loop

                    'load the contents of the file into the description 
                    'component of the module level array of 
                    'FragranceStruct in the order in which the records
                    'were read. Also, load the contents into the Fragrance combobox
                Case "FragDesc.txt"
                    Dim mintSubscript As Integer = -1
                    Do While srFile.Peek <> -1
                        strContent = srFile.ReadLine()
                        mintSubscript += 1
                        ReDim Preserve mfraLists(mintSubscript)
                        With mfraLists(mintSubscript)
                            .strDescription = strContent
                        End With

                        cboFragrance.Items.Add(strContent)
                    Loop

                    'sort the names
                    Dim arr(cboFragrance.Items.Count - 1) As String
                    Dim i As Integer
                    For i = 0 To cboFragrance.Items.Count - 1
                        arr(i) = cboFragrance.Items(i)
                    Next
                    Array.Sort(arr)
                    cboFragrance.Items.Clear()
                    For i = 0 To arr.Length - 1
                        cboFragrance.Items.Add(arr(i))
                    Next

                    'load the contents of the file into the price component 
                    'of the module level array of FragranceStruct (defined above) 
                    'in the order in which the records were read
                Case "FragPrices.txt"
                    Dim mintSubscript As Integer = -1
                    Do While srFile.Peek <> -1
                        strContent = srFile.ReadLine()
                        mintSubscript += 1
                        'mfraLists(mintSubscript)
                        With mfraLists(mintSubscript)
                            .decPrice = strContent
                        End With
                    Loop

                    'load the contents of the file into the module level 
                    'array defined above to store interior package 
                    'descriptions in the order in which the records were read
                Case "Interior.txt"
                    Dim intNdx As Integer
                    Do While srFile.Peek <> -1
                        strContent = srFile.ReadLine()
                        ReDim Preserve mstrInteriorContent(intNdx)
                        mstrInteriorContent(intNdx) = strContent
                        intNdx += 1
                    Loop

                    'load the contents of the file into 
                    'the Detailing Package combobox in the order in which the records were read
                Case "PkgDesc.txt"
                    Do While srFile.Peek <> -1
                        strContent = srFile.ReadLine()
                        cboDetailing.Items.Add(strContent)
                    Loop

                Case "PkgPrices.txt"
                    Dim intNdx As Integer
                    Do While srFile.Peek <> -1
                        strContent = srFile.ReadLine()
                        ReDim Preserve mdecPackagePrices(intNdx)
                        mdecPackagePrices(intNdx) = strContent
                        intNdx += 1
                    Loop

            End Select

            srFile.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error reading from file")
            Me.Close()
        End Try
    End Sub
    ''' <summary>
    ''' This function will retrun an integer representing the 
    ''' index of the Fragrance Combobox containing the searched
    ''' fragrance
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function resetFrag() As Integer
        Dim intNdx As Integer
        Dim fragrance As String = "Pine"
        For intNdx = 0 To cboFragrance.Items.Count - 1
            If fragrance.ToUpper = _
            cboFragrance.Items(intNdx).ToString.ToUpper Then
                Return intNdx
                Exit For
            End If
        Next
        Return -1
    End Function
    ''' <summary>
    ''' This function will receive a string argument 
    ''' representing the selected Fragrance and will
    ''' return an integer representing the index
    ''' of the Frgrance Struct array containing the
    ''' searched fragrance
    ''' </summary>
    ''' <param name="selectedFrag"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getFragIndex(ByVal selectedFrag As String) As Integer
        Dim intNdx As Integer
        For intNdx = 0 To mfraLists.Length - 1
            If selectedFrag.ToUpper = _
            mfraLists(intNdx).strDescription.ToUpper Then
                Return intNdx
                Exit For
            End If
        Next
        Return -1
    End Function

    Private Sub frmCarWash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'readFiles(mstrExternalFiles(1))
        'resetFrag()
        Dim numFiles As Integer
        Try
            For numFiles = 0 To mstrExternalFiles.Length - 1
                readFiles(mstrExternalFiles(numFiles))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error reading files")
        End Try
        cboDetailing.SelectedItem = cboDetailing.Items(0)
        cboFragrance.SelectedItem = cboFragrance.Items(resetFrag())


    End Sub

    Private Sub cboDetailing_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                Handles cboDetailing.SelectedIndexChanged, _
                        cboFragrance.SelectedIndexChanged
        Dim intNdx As Integer
        Dim upperIntNdx As Integer
        Dim strExteior As String
        Dim strInteior As String

        'default fragrance for any new package selection is PINE
        Dim cboSelected As ComboBox
        cboSelected = CType(sender, ComboBox)
        Select Case cboSelected.Name
            Case "cboDetailing"
                cboFragrance.SelectedItem = cboFragrance.Items(resetFrag())
        End Select

        'Clear the contents of both boxes
        lstExterior.Items.Clear()
        lstInterior.Items.Clear()

        'get the selected index of combobox Detailing
        upperIntNdx = cboDetailing.SelectedIndex

        For intNdx = 0 To upperIntNdx
            'get the contents and add them to listboxes
            strExteior = mstrExteriorContent(intNdx)
            lstExterior.Items.Add(strExteior)

            strInteior = mstrInteriorContent(intNdx)
            lstInterior.Items.Add(strInteior)
        Next

        'Modify the first item in the Interior listbox by
        'appending the name of the selected Fragrance to 
        'the first item E.g."Fragrance - Pine"
        lstInterior.Items.RemoveAt(0)
        strExteior = mstrInteriorContent(0) & _
        " - " & cboFragrance.SelectedItem
        lstInterior.Items.Insert(0, strExteior)

        'create an instance fo clsCharges
        Dim decPackagePrice As Decimal
        Dim decFragrancePrice As Decimal
        decPackagePrice = Decimal.Parse(mdecPackagePrices(upperIntNdx))
        decFragrancePrice = Decimal.Parse(mfraLists(getFragIndex(cboFragrance.SelectedItem)).decPrice)
        mobjCharges = New BusinessTier.clsCharges(decPackagePrice, decFragrancePrice)

        'Use the Get property procedures of the class to populate the labels on the form
        'with the charges, tax and total
        lblCharges.Text = mobjCharges.Charges.ToString("c")
        lblTaxes.Text = mobjCharges.Tax.ToString("c")
        lblTotal.Text = mobjCharges.Total.ToString("c")

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cboDetailing.SelectedItem = cboDetailing.Items(0)
        cboFragrance.SelectedItem = cboFragrance.Items(resetFrag())

    End Sub
End Class
