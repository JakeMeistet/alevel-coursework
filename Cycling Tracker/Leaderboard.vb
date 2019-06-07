'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This has been drastically improved since the prototype solution. Now, the user is able to sort their information based on certain criteria (Speed, Distance, Time and Calories).
'This gives a much more understandable and useful leaderboard system which allows for the user to review their own information. The icons have also been added for a more user-friendly interface.

Public Class Leaderboard
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

    'CurrentItem is declared as an integer and is set to 0
    'CyclingDirectory is declared as a string and set to the directory of CyclingDetails.txt
    Dim CurrentItem As Integer = 0

    'Private sub that's initiated when the form is loaded
    Private Sub Leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form loads, the paracyclistcheck subroutine runs 
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
        'IDReader is declared as a Streamreader to read from PastID.txt
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
            'The next line is read from the file and then added to the list
            IDallLines.Add(IDReader.ReadLine)
        Loop
        'The file is closed
        IDReader.Close()

        'ID is declared as string
        'ID is set to the value in the first line of ID.txt
        'The most recent ID is always stored on the first line of PastID.txt
        Dim ID As String = ReadLine(0, IDallLines)
        'The directory is set to the directory of Paracyclists.txt
        'This is done by combining the MyDocuments path (File) the the end path for Paracyclists.txt
        'Stored under ParaDirectory in Module1
        Directory = File & Module1.ParaDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader2 is declared as a Streamreader to read from Paracyclists.txt
        Dim Reader2 As New System.IO.StreamReader(Directory)
        'allLines2 is neclared as a list of string values
        'An example of data stored under allLines2 would be '1' which would be a userID
        'another example would be 'T1 - T2' which shows that the user has to have a trike
        Dim allLines2 As List(Of String) = New List(Of String)
        'Loop while Reader2 doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines2 list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader2.EndOfStream
            'The next line is read from the file and added to the list
            allLines2.Add(Reader2.ReadLine())
        Loop
        'The file is closed
        Reader2.Close()

        'Line Is declared as an integer which Is used to specify the line that Is read to find the user's information
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
            'The background turns black
            'The Listview's background is also made black with all text made white
            'For high contrast mode
            Me.BackColor = Color.Black
            LblLBoard.ForeColor = Color.White
            ListView1.BackColor = Color.Black
            ListView1.ForeColor = Color.White
            ListView1.Font = Module1.BoldFont
        End If

    End Sub

    'Subroutine startup used run the basic tasks during load of the form
    Sub Startup(ByVal ButtonNumber)
        'Items in the list view are cleared so the user can use all of the buttons to sort without having to exit the form every time
        ListView1.Items.Clear()
        'LineNumbers.txt is created and then closed immediately to ensure the file exists
        'This rewrites over the old file ensuring that the file is blank
        'The directory is a combination of the path for MyDocuments (File) and the add  on of LineNumbers.txt found stored as LineNoDirectory in Module1
        Directory = File & Module1.LineNoDirectory
        Dim Writer As New System.IO.StreamWriter(Directory)
        'The file is closed
        Writer.Close()

        'Directory is declared as a string and is set to the directory of PastID.txt
        'Made through the combination of the MyDocuments path (File) and IDDirectory stored in Module1
        'This is the continuation fo the directory
        Directory = File & Module1.IDDirectory
        'ID is declared as an integer
        'This is used to store the current user ID
        Dim ID As String
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from PastID.txt
        'ID.txt is opened so it can be read from
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a userID
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
        'ID is set to the first line of ID.txt
        ID = ReadLine(0, allLines)
        'Read subroutine is initiated passing the variable ID by value
        Read(ID, ButtonNumber)
    End Sub

    'This class is used to store the speed, distance, time and calories
    'I have used a class instead of a structure because it allows me to sort by variables in the leaderboard rather than
    'just sorting the speed, distance, time and calories all individually.
    Class Info
        Public Speed, Distance, Time, Calories As Decimal
    End Class

    'Subroutine Read is usd to read the necessary information from the CyclingDetails.txt file
    'The information for the user is searched for so that the leaderboard can display the user's data
    Sub Read(ByVal ID, ByVal ButtonNumber)
        'Directory is declared as a string and is set to the directory of CyclingDetails.txt
        'Made through the combination of the MyDocuments path (File) and CyclingDirectory stored in Module1
        'This is the continuation fo the directory
        Directory = File & Module1.CyclingDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from CyclingDetails.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines would be '12' which could be a speed or a distance
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
        'Lines1 is declared as a string - this reads all lines from CyclingDetails.txt and then closes the file
        'This is used to find the length of the file
        Dim lines1 As String() = IO.File.ReadAllLines(Directory)
        'LineRead is declared as a string
        'This is used to store the line just previously read from the file
        Dim LineRead As String
        'LineNumber is declared as an integer
        'This stores the current linenumber of what is being read and stored in LineRead
        Dim LineNumber As Integer

        'If statement to check whether the length of the file is to short to display any useful informations
        'If the length is less than 1 then the message will be displayed saying the user doesn't have any records.
        'This also prevents Argument Out Of Range Exceptions from occuring
        If lines1.Length < 1 Then
            MsgBox("There are no records")
            'The form closes
            Me.Close()
            Exit Sub
        Else
            'The first line is read from CyclingDetails.txt
            LineRead = ReadLine(LineNumber, allLines)
            'CheckNumber is declared as an Integer
            'CheckNumber is set to 0
            'CheckID is declared as a string
            Dim CheckNumber As Integer
            CheckNumber = 0
            Dim CheckID As String

            'CheckID is set to the first line of CyclingDirectory
            CheckID = ReadLine(CheckNumber, allLines)
            CheckNumber = 0
            'Variable i is declared as an Integer and set to 0
            'Lines is declared to be used to find the line length of CyclingDetails.txt
            Dim lines As String() = IO.File.ReadAllLines(Directory)
            'Do loop to loop until CheckNumber is equal to the length of CyclingDetails.txt
            'This is used to search for the data under that specific user's ID number
            Do
                'CheckID is set to the value of the next line in CyclingDetails.txt
                'If CheckID is not equal to ID then CheckNumber increments by 6
                If CheckNumber < lines.Length Then
                    If CheckID <> ID Then
                        'CheckNumber increments by 6
                        'This happens because every 6th line is a user ID in this file
                        CheckNumber = CheckNumber + 6
                        'The next check runs to check whether CheckNumber is less than the length of the filem if it is then the next line will be read.
                        If CheckNumber < lines.Length Then
                            CheckID = ReadLine(CheckNumber, allLines)
                        End If
                        'Else - All lines have been searched for within the file
                    Else
                        'The directory is set to the path of MyDocuments combined with the ending of LineNoDirectory stored in Module1
                        'this completes the directory for LineNumbers.txt
                        Directory = File & Module1.LineNoDirectory
                        'objWriter is declared as a streamwriter to ammend to the LineNumber.txt file
                        Dim objWriter As New System.IO.StreamWriter(Directory, True)
                        'The next checknumber (linenumber) is written to the file if it contains the user's ID
                        objWriter.WriteLine(CheckNumber)
                        'The file closes
                        objWriter.Close()
                        'CheckNumber increments by 6
                        'This happens because every 6th line is a user ID in this file
                        CheckNumber = CheckNumber + 6
                        'The next check runs to check whether CheckNumber is less than the length of the filem if it is then the next line will be read.
                        If CheckNumber < lines.Length Then
                            CheckID = ReadLine(CheckNumber, allLines)
                        End If
                    End If
                    'Else the do loop is exited
                Else
                    Exit Do
                End If
                'Loop ends when criteria is met
            Loop Until CheckNumber >= lines.Length

            'The directory is set to the path of MyDocuments combined with the ending of LineNoDirectory stored in Module1
            'this completes the directory for LineNumbers.txt
            Directory = File & Module1.LineNoDirectory

            'Lines2 is declared as a string - it reads all lines from LineNumbers.txt and closes the file
            'This can be used to find the length of the file
            Dim lines2 As String() = IO.File.ReadAllLines(Directory)
            'I have used this to read from a file rather than just using streamreader so that
            'when I need to read a specific line from a file I can use the ReadLine function
            'and simply enter the line number I would need.
            'CheckReader is declared as a Streamreader to read from LineNumbers.txt
            Dim CheckReader As New System.IO.StreamReader(Directory)
            'CheckallLines is neclared as a list of string values
            'An example of data stored under CheckallLines would be '12' which would be a line number
            Dim CheckallLines As List(Of String) = New List(Of String)
            'Loop while CheckReader doesn't reach the end of the file
            'This do while loop is used to read all of the lines in the necessary file
            'and then store the next line read in the CheckallLines list.
            'I have chosen to use a do while because the loop must execute
            'at least one or more times whereas if I used a normal while loop
            'then I wouldn't know If I would need it to loop at all at runtime.
            Do While Not CheckReader.EndOfStream
                'The next line is read from the file and added to the list 
                CheckallLines.Add(CheckReader.ReadLine())
            Loop
            'The file is closed
            CheckReader.Close()
            'NumberLine is declared as a 1D array with 10 values
            'This is used to read the 10 most recent of the user's entries 
            'so the most recent rides are displayed on the leaderboard
            Dim NumberLine(10)
            'i is declared as an integer and is set to 0
            'This is used in a loop and is declared because it starts off as the length of the file - 1
            Dim i As Integer = 0
            'This checks if the length of LineNumbers.txt is less than 11
            'If this check wasn't her an Argument Out Of Range would occur
            If lines2.Length < 11 Then
                'User is told that they don't have enough data to display into the table
                MsgBox("There is currently not enough data to display a ranked table")
                'The form then closes
                Me.Close()
                'Else - There is enough data in the file to be displayed on a leaderboard
            Else
                'Variable i is set to the length of LineNumbers.txt
                i = lines2.Length - 1
                'Count is declared as an integer and set to 0
                'This is used in the for loop below as a positive increment along the negative increment of i
                Dim Count As Integer = 0
                'For loop from length of LineNumbers.txt to length - 10 with a step of -1
                'Used to read the 10 most recent entries of data to display on the leaderboard
                For i = lines2.Length - 1 To (lines2.Length - 10) Step -1
                    'The value of NumberLine array in Count position is set to the value of the line in LineNumbers.txt
                    'Count increments by 1
                    'i increments by -1
                    NumberLine(Count) = ReadLine(i, CheckallLines)
                    Count = Count + 1
                    'Loop ends once criteria is met
                Next i
            End If

            'Variable i is set to 0
            i = 0
            Dim ArrRead(9) As Info
            'For loop which loops when i = 0 to 9
            'This is used to write the 10 latest entried to the array ready to be sorted
            For i = 0 To 9
                ArrRead(i) = New Info
                'Speeds are written to the array ArrRead
                ArrRead(i).Speed = ReadLine(NumberLine(i) + 2, allLines)

                'Distances are written to the array ArrRead
                ArrRead(i).Distance = ReadLine(NumberLine(i) + 3, allLines)

                'Times are written to the array ArrRead
                ArrRead(i).Time = ReadLine(NumberLine(i) + 4, allLines)

                'Calories are written to the array ArrRead
                ArrRead(i).Calories = ReadLine(NumberLine(i) + 5, allLines)

            Next


            'Sort subroutine is initiated passing ArrRead by val
            Sort(ArrRead, ButtonNumber)
        End If
        'End If


    End Sub

    'This subroutine performs all of the sorts to display sorted information on the ranked leaderboard
    Sub Sort(ByVal ArrRead, ByVal ButtonNumber)
        'TempItem is declared as the Class Info to allow receive the variables from ArrRead()
        'This is used to sort by and not loose variable in the sorting process.
        Dim TempItem As Info
        'If the Sort by Speed button has been pressed then the program will sort by speed
        If ButtonNumber = 1 Then
            'For loop to loop for iPass is 1 to 9 to allow for all 10 sorts to occur
            For iPass = 1 To 9
                'Nested for loop to perform the 9 bubble sorts of the speed.
                For i = 0 To 8
                    If ArrRead(i).Speed < ArrRead(i + 1).Speed Then
                        TempItem = ArrRead(i)
                        ArrRead(i) = ArrRead(i + 1)
                        ArrRead(i + 1) = TempItem
                    End If
                    'i increments by 1
                Next i
                'iPass increments by 1
            Next iPass

            'If the Sort by Distance button has been pressed then the program will sort by speed
        ElseIf ButtonNumber = 2 Then
            'For loop to loop for iPass is 1 to 9 to allow for all 10 sorts to occur
            For iPass = 1 To 9
                'Nested for loop to perform the 9 bubble sorts of the distance
                For i = 0 To 8
                    If ArrRead(i).Distance < ArrRead(i + 1).Distance Then
                        TempItem = ArrRead(i)
                        ArrRead(i) = ArrRead(i + 1)
                        ArrRead(i + 1) = TempItem
                    End If
                    'i increments by 1
                Next i
                'iPass increments by 1
            Next iPass

            'If the Sort by Time button has been pressed then the program will sort by speed
        ElseIf ButtonNumber = 3 Then
            'For loop to loop for iPass is 1 to 9 to allow for all 10 sorts to occur
            For iPass = 1 To 9
                'Nested for loop to perform the 9 bubble sorts of the time
                For i = 0 To 8
                    If ArrRead(i).Time < ArrRead(i + 1).Time Then
                        TempItem = ArrRead(i)
                        ArrRead(i) = ArrRead(i + 1)
                        ArrRead(i + 1) = TempItem
                    End If
                    'i increments by 1
                Next i
                'iPass increments by 1
            Next iPass

            'If the Sort by Calories button has been pressed then the program will sort by speed
        ElseIf ButtonNumber = 4 Then
            'For loop to loop for iPass is 1 to 9 to allow for all 10 sorts to occur
            For iPass = 1 To 9
                'Nested for loop to perform the 9 bubble sorts of the calories
                For i = 0 To 8
                    If ArrRead(i).Calories < ArrRead(i + 1).Calories Then
                        TempItem = ArrRead(i)
                        ArrRead(i) = ArrRead(i + 1)
                        ArrRead(i + 1) = TempItem
                    End If
                    'i increments by 1
                Next i
                'iPass increments by 1
            Next iPass
        End If

        '4 sets of bubble sorts to sort the Speeds, Distances, Times and Calories in descending ordersss

        'Column1 which lists rank 1 to 9
        'For loop from 1 to 9 to write the ranks to the first column of the list view
        For i = 1 To 10
            ListView1.Items.Add(i)
        Next

        'For loop which loops when i = 1 to 9
        For i = 0 To 9
            'Adds the speeds, distances, times and calories to the ListView
            'Also adds the measurements to the end of the variables
            ListView1.Items(i).SubItems.Add(ArrRead(i).Speed & " m/ph")
            ListView1.Items(i).SubItems.Add(ArrRead(i).Distance & " miles")
            ListView1.Items(i).SubItems.Add(ArrRead(i).Time & " minutes")
            ListView1.Items(i).SubItems.Add(ArrRead(i).Calories & " kCal")
        Next i
    End Sub

    'Public Function used to read specific lines from files
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

    'Private sub to detect when done button is clicked and when it is, the form is closed
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        Me.Close()
    End Sub

    'Sub to detect button click for sorting by speed
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Button number corresponds with which button is pressed
        'Startup sub is called
        Dim ButtonNumber As Integer = 1
        Startup(ButtonNumber)
    End Sub

    'Sub to detect button click for sorting by distance
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Button number corresponds with which button is pressed
        'Startup sub is called
        Dim ButtonNumber As Integer = 2
        Startup(ButtonNumber)
    End Sub

    'Sub to detect button click for sorting by time
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Button number corresponds with which button is pressed
        'Startup sub is called
        Dim ButtonNumber As Integer = 3
        Startup(ButtonNumber)
    End Sub

    'Sub to detect button click for sorting by calories
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Button number corresponds with which button is pressed
        'Startup sub is called
        Dim ButtonNumber As Integer = 4
        Startup(ButtonNumber)
    End Sub
End Class