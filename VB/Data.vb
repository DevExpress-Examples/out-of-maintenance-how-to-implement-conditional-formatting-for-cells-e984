Imports System.Collections.Generic

Namespace ConditionalCellFormatting

    Public Class SimpleDataList
        Inherits List(Of SimpleData)

        Private initCountField As Integer

        Public Property InitCount As Integer
            Get
                Return initCountField
            End Get

            Set(ByVal value As Integer)
                initCountField = value
                Populate()
            End Set
        End Property

        Private Sub Populate()
            Clear()
            For i As Integer = 0 To InitCount - 1
                Add(New SimpleData("Row " & i, i))
            Next
        End Sub
    End Class

    Public Class SimpleData

        Public Property Text As String

        Public Property Int As Integer

        Public Sub New()
        End Sub

        Public Sub New(ByVal str As String, ByVal num As Integer)
            Text = str
            Int = num
        End Sub
    End Class
End Namespace
