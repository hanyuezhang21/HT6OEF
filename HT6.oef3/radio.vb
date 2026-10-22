Module Program
    Public Class Voetballer
        Private naam As String
        Private leeftijd As Integer
        Private aantalGeleKaarten As Integer
        Private trefzekerheid As Double
        Public Sub New(naam As String, leeftijd As Integer, trefzekerheid As Double)
            Me.naam = naam
            Me.leeftijd = leeftijd
            Me.trefzekerheid = trefzekerheid
        End Sub
        Public Function NaarKleedkamer() As String
            If aantalGeleKaarten > 1 Then
                Return "KLEEDKAMER"
            Else
                Return "SPELEN"
            End If
        End Function
        Public Function GeefStrafshop() As String
            Dim intGetal As Integer
            intGetal = Int((100 - 0) * Rnd() + 0)

            If intGetal < trefzekerheid * 100 Then
                Return "Binnen"
            Else
                Return "Misser"
            End If
        End Function

    End Class
    Sub Main(args As String())
        Randomize()
        Dim mbappe As New Voetballer("Mbappe", 27, 0.76)
        Console.WriteLine(mbappe.GeefStrafshop())
    End Sub

End Module