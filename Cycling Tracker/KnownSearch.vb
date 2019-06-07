'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This was not within the prototype version of the system. This form allows for the user to search for a limited few number of cyclist information who cycled from Land's End to John O'Groats/John O'Groats to Land's End which also includes my own informaiton.

Public Class KnownSearch
    'File is declared as the directory/path of the MyDocuments folder for the computer that the program is being run on.
    'I have used this rather than hardwriting all directories because this allows for seamless use on different computers.
    'This is also used for the basis for all directories because the folder Cycling Tracker Final is made in MyDocuments.
    'The special folder locates the path for specific folders within the operating system
    Dim File = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    'Directory is declared as a string so that the file directories can be specified where necessary
    'Every time the directory needs to change I just use Directory to store the current path.
    'An example of the directory would be Directory  = File and Module1.PersonalDirectory where the 
    'endings to the of the paths are stored as public readonly strings in Module1 so they can be accessed
    'in every form easily without being changes whatsoever.
    Dim Directory As String

    'Line is declared as an integer and set to  0
    'This is used to read specific lines from a file and is global because it is used throughout many subroutines withn this class
    Dim Line As Integer = 0

    'Record KnownDetails is created storing the year and days as string
    'This is used to store the details found after search as well as holding the line number of the line where the information was found
    Structure KnownDetails
        Dim Year, Days As String
        Dim FoundLine As Integer
    End Structure

    'SearchResults is declared as the structure KnownDetails
    'This is because the results are the variables within the structure and therefore SearchResults will be used to display the Search Results to the form
    Dim SearchResults As KnownDetails
    Dim CurrentVal As String

    'Private sub to detect search button click
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        'The text of the textboxes on the form are set to blank to remove any potential information that was there previously
        YearOutput.Text = ""
        DayOutput.Text = ""
        'These are validation checks
        'If the input is blank or numeric then the user is asked to input in the correct format.
        'SearchInput in this form would be a surname
        If SearchInput.Text = "" Or IsNumeric(SearchInput.Text) Then
            MsgBox("Please input a surname e.g. Bailey")
            'Else - the program continues within it's processes including searches
        Else
            'The directory is set to that of KnownCyclists.txt
            'This is done by combining the path of MyDocuments(File) with the end of the directory stored as KnownDirectory under Module1
            Directory = File & Module1.KnownDirectory
            'Lines is declared as a string
            'Lines is used to read all lines from KnownCyclists.txt which is then closed immediately
            'This allows us to fine the length of the file
            Dim lines As String() = IO.File.ReadAllLines(Directory)
            'SearchRequest is declared as the text in TextBox 'SearchInput'
            'This assigns the search to a variable
            Dim SearchRequest As String = SearchInput.Text
            'I have used this to read from a file rather than just using streamreader so that
            'when I need to read a specific line from a file I can use the ReadLine function
            'and simply enter the line number I would need.
            'Reader is declared as a Streamreader to read from KnownCyclists.txt
            Dim Reader As New System.IO.StreamReader(Directory)
            'allLines is neclared as a list of string values
            'An example of data stored under allLines would be 'Bailey' which would be a surname
            Dim allLines As List(Of String) = New List(Of String)
            'Loop while Reader doesn't reach the end of the file
            'This do while loop is used to read all of the lines in the necessary file
            'and then store the next line read in the allLines list.
            'I have chosen to use a do while because the loop must execute
            'at least one or more times whereas if I used a normal while loop
            'then I wouldn't know If I would need it to loop at all at runtime.
            Do While Not Reader.EndOfStream
                'The next line is read from the file and added to the list
                allLines.Add(Reader.ReadLine())
            Loop
            'The file is closed
            Reader.Close()
            'Line is set to 0
            'This resets the variable
            Line = 0

            'Do until loop which loops until the line in the file is equal to the search
            'Will also end if the name can't be found and line is greater than or equal to the length of the file
            Do
                'If statement to only run the reading of the file if Line is less than the length of the file
                If Line < lines.Length Then
                    'Line is read from the file
                    CurrentVal = ReadLine(Line, allLines)
                    'Line increments by 1 to read the next line from the file
                    Line = Line + 1
                End If
            Loop Until (Line >= lines.Length) Or (CurrentVal.ToUpper = SearchRequest.ToUpper)

            'If the search hasn't been found then the program tells the user that that name has no records
            If CurrentVal.ToUpper <> SearchRequest.ToUpper Then
                MsgBox("No Records under that name")
                'Else the lines are read and assigned to the structure KnownDetails using SearchResults
            Else
                'SearchResults is declared as the record 'KnownDetails'
                'The year in KnownDetials is set to the line + 1 in KnownCyclists.txt
                SearchResults.Year = ReadLine(Line, allLines)
                'The days in KnownDetials is set to the line + 2 in KnownCyclists.txt
                SearchResults.Days = ReadLine(Line + 1, allLines)

                'The textboxes; YearOutput and DayOutput's text is set to the year and days in KnownDetails
                YearOutput.Text = SearchResults.Year
                DayOutput.Text = SearchResults.Days
            End If
        End If
    End Sub

    'Public function used to read specific lines from a file
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

    'Private sub to detect done button is clicked
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        'Form closes
        Me.Close()
    End Sub

    Private Sub KnownSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Message telling the user which cyclists are stored in the system and can be searched for.
        MsgBox("Search for 'Bailey', 'Broadwith', 'Wheal', 'Lane', 'Jones' or 'Baldwin' because this information is stored within the file.")
        ParacyclistCheck()
    End Sub

    'This subroutine has been used to check whether a user is a paracyclist or not.
    'The checks made in this subroutine are necessary for changes in the GUI or changes 
    'with suggestions for equipment the user can use. The subroutine also allows for disabled 
    'users to be taken into account with my system. When the user registers for the first time 
    'they will be asked whether they are a paracyclist this then leads to a menu to specify 
    'what bike they have to use when cycling which then allows for the necessary changes to be made.
    Sub ParacyclistCheck()
        'The directory is set to the directory of PastID.txt
        'This is done by combining the MyDocuments path (File) the the end path for PastID.txt
        'Stored under IDDirectory in Module1
        Directory = File & Module1.IDDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from PastID.txt
        Dim IDReader As New System.IO.StreamReader(Directory)
        'IDallLines is neclared as a list of string values
        'An example of data stored under IDallLines would be '1' which would be a userID
        Dim IDallLines As List(Of String) = New List(Of String)
        'Loop while IDReader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the IDallLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not IDReader.EndOfStream
            'The next line is read from the file and added to the list
            IDallLines.Add(IDReader.ReadLine)
        Loop
        'The file closes
        IDReader.Close()
        'ID is declared as string
        'The ID is read from the first line of PastID.txt
        Dim ID As String = ReadLine(0, IDallLines)
        'The directory is set to the directory of Paracyclists.txt
        'This is done by combining the MyDocuments path (File) the the end path for Paracyclists.txt
        'Stored under ParaDirectory in Module1
        Directory = File & Module1.ParaDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from Paracyclists.txt
        Dim Reader2 As New System.IO.StreamReader(Directory)
        'allLines2 is neclared as a list of string values
        'An example of data stored under allLines2 would be '1' which would be a userID
        Dim allLines2 As List(Of String) = New List(Of String)
        'Loop while Reade2r doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines2 list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader2.EndOfStream
            'The next line is read and added to the list
            allLines2.Add(Reader2.ReadLine())
        Loop
        'The file is closed
        Reader2.Close()

        'Line is declared as an integer which is used to specify the line that is read to find the user's information
        Dim Line As Integer

        'If the ID is 0 then the user's information in Paracyclists.txt starts on line 0
        'so line is set to 0
        If ID = 0 Then
            Line = 0
            'Else - Every 2 lines is a new ID hence Line is ser to 2* ID when the ID isn't 0
        Else
            Line = ID * 2
        End If

        'Paracheck is declared as a string and is set to read the line after the ID line in Paracyclists.txt
        'This is because the information to determine wether the user is a paracyclist is stored on this line.
        Dim ParaCheck As String = ReadLine(Line + 1, allLines2)

        'If ParaCheck is 'N/A' then the program knows this user isn't a paracyclist
        'This information is written to the file when the user doesn't choose the paracyclist checkbox during register
        If ParaCheck = "N/A" Then
            'The Boolean paracyclist Is set to false in Module1
            'This is so that all classes can Identify whether the user is paracyclist or not.
            Module1.Paracyclist = False
            'Else - the user is a paracyclist, the line must equal 'B', 'C1 - C5', 'H1 - H5' or 'T1 - T2'
        Else
            'The boolean is then set to true in module1 so that all classes can identify wether a user is a paracyclist or not
            Module1.Paracyclist = True
        End If

        'If ParaCheck is 'B' this means that the user is visually impaired
        'Colour changes will then occur to the form where necessary.
        If ParaCheck = "B" Then
            'The background is made black
            Me.BackColor = Color.Black
            'The lblList is used to list all labels in the form and use a for loop to change the colour and font
            Dim LblList As New List(Of Label) From {Search, Year, Day}
            'For loop which cycles through all forms changing the colours and fonts to white and bold
            For i As Int32 = 0 To LblList.Count - 1
                LblList(i).ForeColor = Color.White
                LblList(i).Font = Module1.BoldFont
                'i Increments by 1
            Next i
            'The title label is only made white and not bold because it is already white.
            LblSearch.ForeColor = Color.White
        End If

    End Sub

End Class