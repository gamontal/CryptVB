Module StringValidation
    'Validates a string of alpha characters
    Function CheckForAlphaCharacters(ByVal stringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Not Char.IsLetter(StringToCheck.Chars(i)) Then
                If Not Char.IsWhiteSpace(StringToCheck.Chars(i)) Then
                    If Not Char.IsNumber(StringToCheck.Chars(i)) Then
                        If Not Char.IsPunctuation(StringToCheck.Chars(i)) Then
                            Return False
                        End If
                    End If
                End If
            End If
        Next

        Return True 'Return true if all elements are characters
    End Function
End Module
