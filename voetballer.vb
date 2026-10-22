Module Program
    Public Class Radio

        Private strLiedje1 As String
        Private strLiedje2 As String
        Private strLiedje3 As String

        Public Sub New()
            strLiedje1 = "Liedje1"
            strLiedje2 = "Liedje2"
            strLiedje3 = "Liedje3"
        End Sub

        Private Function SpeelLiedjeRadio() As String
            Dim rnd As New Random()
            Dim intGetal As Integer

            intGetal = rnd.Next(1, 4)

            Select Case intGetal
                Case 1
                    Return strLiedje1
                Case 2
                    Return strLiedje2
                Case 3
                    Return strLiedje3
                Case Else
                    Return "Geen liedje"
            End Select
        End Function

        Public Sub SpeelLiedje()
            Console.WriteLine("Ik ga een liedje spelen...")
            Console.WriteLine(SpeelLiedjeRadio())
        End Sub

    End Class
    Sub Main(args As String())
        Dim radioke As New Radio()
        radioke.SpeelLiedje()
    End Sub

End Module
