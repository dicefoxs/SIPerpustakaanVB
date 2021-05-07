Public Class PenerbitController
    Private ArrayPenerbit As New List(Of Penerbit)

    Public Sub New()
        Dim penerbit As New Penerbit
        penerbit.idPenerbit = 1
        penerbit.namaPenerbit = "Laboratorium RPL"
        addPenerbit(penerbit)
    End Sub

    Public Sub addPenerbit(ByVal penerbit As Penerbit)
        Me.ArrayPenerbit.Add(penerbit)
    End Sub

    Public Function getPenerbits() As List(Of Penerbit)
        Return Me.ArrayPenerbit
    End Function
End Class
