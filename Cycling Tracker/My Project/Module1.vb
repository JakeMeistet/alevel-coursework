Module Module1

    'All of the continuations of the MyDocuments directory are stored here
    'these are all readonly public variables which when added onto the MyDocuments path
    'make the paths for each individual file for the whole program. Hence all of these need to be
    'public variables so that all classes/forms have access to the variables.
    Public ReadOnly PersonalDirectory As String = "\Cycling Tracker Final\PersonalDetails.txt"
    Public ReadOnly IDDirectory As String = "\Cycling Tracker Final\PastID.txt"
    Public ReadOnly CyclingDirectory As String = "\Cycling Tracker Final\CyclingDetails.txt"
    Public ReadOnly CharityDirectory As String = "\Cycling Tracker Final\CharityDetails.txt"
    Public ReadOnly EmailDirectory As String = "\Cycling Tracker Final\Emails.txt"
    Public ReadOnly PassDirectory As String = "\Cycling Tracker Final\Passwords.txt"
    Public ReadOnly AdminPassDirectory As String = "\Cycling Tracker Final\Admin.txt"
    Public ReadOnly TrainDirectory As String = "\Cycling Tracker Final\PersonalTrainer.txt"
    Public ReadOnly KnownDirectory As String = "\Cycling Tracker Final\KnownCyclists.txt"
    Public ReadOnly LineNoDirectory As String = "\Cycling Tracker Final\LineNumbers.txt"
    Public ReadOnly ParaDirectory As String = "\Cycling Tracker Final\Paracyclists.txt"

    'Public variable 'Paracyclist' is declared as a boolean and set to False
    'Used to identify whether a user is a paracyclist or not throughout the program
    Public Paracyclist As Boolean = False

    'Public BoldFont is the basic font but made bold so that that can be used for the visually impaired usrs.
    Public BoldFont As New Font("SansSerif", 6.5, FontStyle.Bold)

    'Function user to complete a ceaser cipher
    Function CC(value As String, shift As Integer) As String
        'Buffer is used as a character in a char array
        Dim buffer() As Char = value.ToCharArray()
        'For loop to loop to the length of the buffer - 1
        For i As Integer = 0 To buffer.Length - 1 Step 1
            'letter is declared as a character as the array buffer(i)
            Dim letter As Char = buffer(i)
            'Letter is equal to the ascii letter + its cipher shift
            letter = Chr(Asc(letter) + shift)
            'For specific letters there are different shifts
            If (letter > "}") Then
                letter = Chr(Asc(letter) - 93)
            ElseIf (letter < " ") Then
                letter = Chr(Asc(letter) + 93)
            End If
            'the current value in the buffer array is set to letter
            buffer(i) = letter

        Next
        'buffer is returned as a string
        Return New String(buffer)

    End Function

    'Validates a string of alpha characters
    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Not Char.IsLetter(StringToCheck.Chars(i)) Then
                Return False
            End If
        Next

        Return True 'Return true if all elements are characters
    End Function


End Module
