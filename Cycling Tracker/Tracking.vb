'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This form has remained pretty much the same since the prototype where the same calculations are made and the information is displayed in the same way. Certain issues have just been sorted since.

'The namespace system.io is imported to allow for files to be written from/read to.
Imports System.IO
Public Class Tracking
    'Directory is declared as a string
    'This is used to store the current directory/path that the
    'program is reading/writing from. This is a global variable
    'because it needs to be accessible from all procedures within the form
    'File is declared as the directory for MyDocuments for the computer the program is currently being run on
    Dim Directory As String
    'File is declared as the directory/path of the MyDocuments folder for the computer that the program is being run on.
    'I have used this rather than hardwriting all directories because this allows for seamless use on different computers.
    'This is also used for the basis for all directories because the folder Cycling Tracker Final is made in MyDocuments.
    'The special folder locates the path for specific folders within the operating system
    Dim File = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

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
            Dim LblList As New List(Of Label) From {LblID, LblASpeed, LblADis, LblATime, Label10, Label15, Label20, Label25}
            'For loop which cycles through all forms changing the colours and fonts to white and bold
            For i As Int32 = 0 To LblList.Count - 1
                LblList(i).ForeColor = Color.White
                LblList(i).Font = Module1.BoldFont
                'i Increments by 1
            Next i
            'The title label is only made white and not bold because it is already white.
            LblTracking.ForeColor = Color.White
        End If

    End Sub

    'When the form loads
    Private Sub Tracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The directory is set to the directory of LineNumbers.txt
        'This is done by combining the MyDocuments path (File) the the end path for LineNumbers.txt
        'Stored under LineNoDirectory in Module1
        Directory = File & Module1.LineNoDirectory
        'Checklines is used to find the length of LineNumbers.txt
        'It is declared as a string and it reads all lines of the file and immediately closes it
        Dim Checklines As String() = IO.File.ReadAllLines(Directory)
        'If the length of LineNumbers.txt is greater than 10 
        'If statement used to allow for else to be used
        ' If Checklines.Length > 10 Then
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
        'ID is declared as a string and reads IDDirectory, line 0
        'The ID is stored on the first line of PastID.txt because it is overwritten every time a user logs in or registers
        Dim ID As String = ReadLine(0, IDallLines)
        'Sets the textbox 'TextID' to have the text equal to ID
        TxtID.Text = ID
        'Initiates the Read subroutine, passing ID by its value
        ParacyclistCheck()
            Read(ID)
            'Else
        'Read Subroutine is called passing ID by val
        'Read(ID)
        'End If

    End Sub

    'Subroutine Read 

    Sub Read(ByVal ID)
        'Directory is set to the directory for LineNumbers.txt
        'This is done by combining the path for MyDocuments stored under the variable
        'File with the end of the directory for LineNumbers.txt stored in Module1
        'as LineNoDirectory.
        Directory = File & Module1.LineNoDirectory
        'The file is overwritten to ensure that it is blank and ready to be used in LinearSearch()
        Dim objWriter As New System.IO.StreamWriter(Directory)
        'File is closed
        objWriter.Close()


        'Directory is declared as a string and is set to the directory of PastID.txt
        'Made through the combination of the MyDocuments path (File) and IDDirectory stored in Module1
        'This is the continuation fo the directory
        Directory = File & Module1.IDDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from PastID.txt
        'PastID.txt is opened so it can be read from
        Dim Reader2 As New System.IO.StreamReader(Directory)
        'allLines2 is neclared as a list of string values
        'An example of data stored under allLines2 would be '1' which would be a userID
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
        'The ID is retrieved from the first line of PastID.txt
        ID = ReadLine(0, allLines2)
        TxtID.Text = ID
        'Initiates LinearSearch function passing ID and allLines by its value
        LinearSearch(ID)

    End Sub

    'Function LinearSearch
    Function LinearSearch(ByVal ID)
        'Directory is declared as a string and is set to the directory of PastID.txt
        'Made through the combination of the MyDocuments path (File) and IDDirectory stored in Module1
        'This is the continuation fo the directory
        Directory = File & Module1.CyclingDirectory
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
        'Directory is declared as a string and is set to the directory of CyclingDetails.txt
        'Made through the combination of the MyDocuments path (File) and CyclingDirectory stored in Module1
        'This is the continuation fo the directory
        Directory = File & Module1.CyclingDirectory
        'lines is declared as a string
        'This reads all lines from CyclingDetails.txt and closes the file
        'It can be used to find the length of the file
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'Declares LineNumber as an integer and sets it to 0
        'LineNumber is used to specify which line is going to be read from the file
        Dim LineNumber As Integer = 0
        'Declares CheckID as a string and reads CyclingDirectory with LineNumber as the number of the line
        Dim CheckID As String = ReadLine(LineNumber, allLines)

        'Loop until LineNumber is greater than or equal to the length of the file
        'This will prevent Argument Out Of Range Exceptions
        Do
            If LineNumber + 6 >= lines.Length Then
                MsgBox("There are no records under this user")
                Me.Close()
            Else
                'If CheckID does not equal ID then the line number will increment by 6
                If CheckID <> ID Then
                    LineNumber = LineNumber + 6
                    'Increments by 6 because there is a userid every 6 lines within CyclingDetails.txt
                    'Else the line number is written to LineNumbers.txt and LineNumber increments by 6 
                    'Sets CheckID as the next line in CyclingDirectory
                    CheckID = ReadLine(LineNumber, allLines)
                Else
                    'The line number is written to the file because it's a line number that contains the user ID and the other
                    'necessary information can be found using that one user ID line.
                    'Directory is declared as a string and is set to the directory of LineNumbers.txt
                    'Made through the combination of the MyDocuments path (File) and LineNoDirectory stored in Module1
                    'This is the continuation fo the directory
                    Directory = File & Module1.LineNoDirectory
                    Dim objWriter As New System.IO.StreamWriter(Directory, True)
                    objWriter.WriteLine(LineNumber)
                    'File is closed
                    objWriter.Close()
                    LineNumber = LineNumber + 6
                    'Increments by 6 because there is a userid every 6 lines within CyclingDetails.txt
                End If
            End If
            'Loop ends when criteria is met
        Loop Until LineNumber + 6 >= lines.Length

        'Directory is declared as a string and is set to the directory of LineNumbers.txt
        'Made through the combination of the MyDocuments path (File) and LineNoDirectory stored in Module1
        'This is the continuation fo the directory
        Directory = File & Module1.LineNoDirectory
        'Checklines is used to find the length of LineNumbers.txt
        'It is declared as a string and it reads all lines of the file and immediately closes it
        Dim Checklines As String() = IO.File.ReadAllLines(Directory)
        'Checks whether the length of LineNumber.txt is less than 1, if so the form will close giving the information that there are no records for that user
        'If the length of the file is less than 1 then the user is told that there isn't any data to be displayed on a leaderboard
        'Prevents Argument Out Of Ranger Exception
        If Checklines.Length < 1 Then
            MsgBox("There are no records under this user")
            'Form closes
            Me.Close()
            'If the length of the file is less than 1 then the user is told that there isn't enough data to be displayed on a leaderboard
            'Prevents Argument Out Of Ranger Exception
        ElseIf Checklines.Length < 10 Then
            MsgBox("There are not enough records under this user")
            'Form closes
            Me.Close()
        Else
            'I have used this to read from a file rather than just using streamreader so that
            'when I need to read a specific line from a file I can use the ReadLine function
            'and simply enter the line number I would need.
            'FinalReader is declared as a Streamreader to read from LineNumbers.txt
            Dim FinalReader As New System.IO.StreamReader(Directory)
            'FinalallLines is neclared as a list of string values
            'An example of data stored under FinalallLines would be '0' which would be a line number
            Dim FinalallLines As List(Of String) = New List(Of String)
            'Loop while FinalReader doesn't reach the end of the file
            'This do while loop is used to read all of the lines in the necessary file
            'and then store the next line read in the FinalallLines list.
            'I have chosen to use a do while because the loop must execute
            'at least one or more times whereas if I used a normal while loop
            'then I wouldn't know If I would need it to loop at all at runtime.
            Do While Not FinalReader.EndOfStream
                'The next line is read and added to the list
                allLines.Add(FinalReader.ReadLine)
            Loop
            'The file is closed
            FinalReader.Close()
            'Directory is declared as a string and is set to the directory of LineNumbers.txt
            'Made through the combination of the MyDocuments path (File) and LineNoDirectory stored in Module1
            'This is the continuation fo the directory
            Directory = File & Module1.LineNoDirectory
            'Calculations subroutine is initiated
            Calculations()
        End If

        'LineNumber is returned
        Return LineNumber
    End Function

    'The record 'FinalSum' is used to store Speed, Distance and time for calculations, where all variables within the record are set to decimals
    Structure FinalSum
        Dim Speed As Decimal
        Dim Distance As Decimal
        Dim Time As Decimal
    End Structure


    'Subroutine Calculations
    Sub Calculations()
        'Directory is declared as a string and is set to the directory of LineNumbers.txt
        'Made through the combination of the MyDocuments path (File) and LineNoDirectory stored in Module1
        'This is the continuation for the directory
        Directory = File & Module1.LineNoDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader2 is declared as a Streamreader to read from LineNumbers.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a linenumber
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while Reader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader.EndOfStream
            'The next line is read from the file and added to IDallLines list
            allLines.Add(Reader.ReadLine)
        Loop
        'File is closed
        Reader.Close()
        'Lines is used to find the length of LineNumbers.txt
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'LoopNumber is declared as an integer
        'Used to increment the do until loop
        Dim LoopNumber As Integer
        'The directory is set to a combination of the path for MyDocuments with the end of the
        'path stored under TrainDirectory within Module1
        Directory = File & Module1.CyclingDirectory
        'CalcReader is declared as a new stream reader to read the lineNumbers for
        'the information that is stored in CyclingDetails.txt
        Dim CalcReader As New System.IO.StreamReader(Directory)
        'CalcallLines is declared as a list of string values which
        'stores all lines read from the file
        'An example of information stored would be '1' as a user ID
        Dim CalcallLines As List(Of String) = New List(Of String)
        'Loop while CalcReader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the CalcallLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not CalcReader.EndOfStream
            'Next line is read and added to the CalcallLines list
            CalcallLines.Add(CalcReader.ReadLine)
        Loop
        'File is closed
        CalcReader.Close()
        'TotalLines is declared as an integer and set to the length of LineNumbers.txt
        Dim TotalLines As Integer = lines.Length
        'Sum is declared as the record FinalSum
        'This is used to add together all of the speeds, distances and times
        Dim Sum As FinalSum
        'LineNumber is declared as The first line read from LineNumbers.txt
        Dim LineNumber = ReadLine(LoopNumber, allLines)
        'LoopNumber is set to 0 and Sum.Speed is set to 0
        LoopNumber = 0
        Sum.Speed = 0
        'Do loop until LoopNumber is greater than or equal to the length of LineNumbers.txt
        'This is used to add all of the money raised and gift aids togeter to get totals
        Do
            'The Speed, Distance and Time are summed with the next value in CyclingDirectory
            Sum.Speed = Sum.Speed + ReadLine(ReadLine(LoopNumber, allLines) + 2, CalcallLines)
            Sum.Distance = Sum.Distance + ReadLine(ReadLine(LoopNumber, allLines) + 3, CalcallLines)
            Sum.Time = Sum.Time + ReadLine(ReadLine(LoopNumber, allLines) + 4, CalcallLines)
            LoopNumber = LoopNumber + 1
            'Loop ends when criteris is met
        Loop Until LoopNumber = TotalLines

        'These are the average calculations where the sums are divided by the number of items added
        'where the number of items would be total lines (the number of lines where the data was present)
        Final.AvgSpeed = Sum.Speed / TotalLines
        Final.AvgDistance = Sum.Distance / TotalLines
        Final.AvgTime = Sum.Time / TotalLines

        'Average Speed, Average Distance and Average Time are rounded to 2 decimal places.
        'This allows for the user to be able to understand the information more easily.
        Dim Speed As Integer = Math.Round(Final.AvgSpeed, 2, MidpointRounding.AwayFromZero)
        Dim Distance As Integer = Math.Round(Final.AvgDistance, 2, MidpointRounding.AwayFromZero)
        Dim Time As Integer = Math.Round(Final.AvgTime, 2, MidpointRounding.AwayFromZero)

        'The text of the textboxes are set to the relevant averages after the calculations
        TxtASpeed.Text = Speed & " m/ph"
        TxtADis.Text = Distance & " miles"
        TxtATime.Text = Time & " minutes"
        'Table Subroutine is initiated passing the Speed, Distance and Time by its value
        Table(Speed, Distance, Time)
    End Sub
    'Final is declared as the record 'Result'
    Dim Final As Result
    'The record 'Result' is declared including the Average Speed, Distance and Time all set to Decimal values
    Structure Result
        Dim AvgSpeed, AvgDistance, AvgTime As Decimal
    End Structure

    'Public function used to allow for the specific lines to be returned when requested through the program
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

    'CheckID and ID are declared as String values
    Dim CheckID, ID As String

    'Private sub activated when the 'Done' button is clicked
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        'Subroutine Write is initiated and the form is closed

        Me.Close()
    End Sub

    Dim AllIncLines As Integer

    'Subroutine Table which recieves Speed, Distance and Time variables passed through it
    Sub Table(ByVal Speed, ByVal Distance, ByVal Time)
        'Directory is declared as a string and is set to the directory of LineNumbers.txt
        'Made through the combination of the MyDocuments path (File) and LineNoDirectory stored in Module1
        'This is the continuation for the directory
        Directory = File & Module1.LineNoDirectory
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader2 is declared as a Streamreader to read from LineNumbers.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a linenumber
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while Reader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader.EndOfStream
            'The next line is read from the file and added to IDallLines list
            allLines.Add(Reader.ReadLine)
        Loop
        'File is closed
        Reader.Close()
        'Directory is declared as a string and is set to the directory CyclingDetails.txt
        'Made through the combination of the MyDocuments path (File) and CyclingDirectory stored in Module1
        'This is the continuation for the directory
        Directory = File & Module1.CyclingDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'CycleReader is declared as a Streamreader to read from CyclingDetails.txt
        Dim CycleReader As New System.IO.StreamReader(Directory)
        AllIncLines = lines.Length
        'allLines is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a UserID
        Dim CycleallLines As List(Of String) = New List(Of String)
        'Loop while CycleReader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the CycleallLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not CycleReader.EndOfStream
            'Next line is read from the file and added to the list
            CycleallLines.Add(CycleReader.ReadLine)
        Loop
        'File closes
        CycleReader.Close()
        'Text for labels 6, 11, 16 and 21 are set to the relevant dates from past few rides
        Label6.Text = ReadLine(ReadLine(AllIncLines - 1, allLines) + 1, CycleallLines)
        Label11.Text = ReadLine(ReadLine(AllIncLines - 2, allLines) + 1, CycleallLines)
        Label16.Text = ReadLine(ReadLine(AllIncLines - 3, allLines) + 1, CycleallLines)
        Label21.Text = ReadLine(ReadLine(AllIncLines - 4, allLines) + 1, CycleallLines)
        'Text for labels 7, 12, 17 and 22 are set to the relevant speeds from past few rides
        Label7.Text = ReadLine(ReadLine(AllIncLines - 1, allLines) + 2, CycleallLines)
        Label12.Text = ReadLine(ReadLine(AllIncLines - 2, allLines) + 2, CycleallLines)
        Label17.Text = ReadLine(ReadLine(AllIncLines - 3, allLines) + 2, CycleallLines)
        Label22.Text = ReadLine(ReadLine(AllIncLines - 4, allLines) + 2, CycleallLines)

        'If statements to see how large a number is inputted to the labels, when compared to the averages (Speed, Distance and Time)
        'If greater than then label colour will become green 
        'If equal to then label colour will become orange
        'If less than then the label colour will become red
        If Label7.Text < Speed Then
            Label7.ForeColor = Color.Red
        ElseIf Label7.Text = Speed Then
            Label7.ForeColor = Color.Orange
        Else
            Label7.ForeColor = Color.Green
        End If

        If Label12.Text < Speed Then
            Label12.ForeColor = Color.Red
        ElseIf Label12.Text = Speed Then
            Label12.ForeColor = Color.Orange
        Else
            Label12.ForeColor = Color.Green
        End If

        If Label17.Text < Speed Then
            Label17.ForeColor = Color.Red
        ElseIf Label17.Text = Speed Then
            Label17.ForeColor = Color.Orange
        Else
            Label17.ForeColor = Color.Green
        End If

        If Label22.Text < Speed Then
            Label22.ForeColor = Color.Red
        ElseIf Label22.Text = Speed Then
            Label22.ForeColor = Color.Orange
        Else
            Label22.ForeColor = Color.Green
        End If

        'Text for labels 8, 13, 18 and 23 are set to the relevant distances from past few rides
        Label8.Text = ReadLine(ReadLine(AllIncLines - 1, allLines) + 3, CycleallLines)
        Label13.Text = ReadLine(ReadLine(AllIncLines - 2, allLines) + 3, CycleallLines)
        Label18.Text = ReadLine(ReadLine(AllIncLines - 3, allLines) + 3, CycleallLines)
        Label23.Text = ReadLine(ReadLine(AllIncLines - 4, allLines) + 3, CycleallLines)

        'If statements to see how large a number is inputted to the labels, when compared to the averages (Speed, Distance and Time)
        'If greater than then label colour will become green 
        'If equal to then label colour will become orange
        'If less than then the label colour will become red
        If Label8.Text < Distance Then
            Label8.ForeColor = Color.Red
        ElseIf Label8.Text = Distance Then
            Label8.ForeColor = Color.Orange
        Else
            Label8.ForeColor = Color.Green
        End If

        If Label13.Text < Distance Then
            Label13.ForeColor = Color.Red
        ElseIf Label13.Text = Distance Then
            Label13.ForeColor = Color.Orange
        Else
            Label13.ForeColor = Color.Green
        End If

        If Label18.Text < Distance Then
            Label18.ForeColor = Color.Red
        ElseIf Label18.Text = Distance Then
            Label18.ForeColor = Color.Orange
        Else
            Label18.ForeColor = Color.Green
        End If

        If Label23.Text < Distance Then
            Label23.ForeColor = Color.Red
        ElseIf Label23.Text = Distance Then
            Label23.ForeColor = Color.Orange
        Else
            Label23.ForeColor = Color.Green
        End If

        'Text for labels 9, 14, 19 and 24 are set to the relevant times from past rides
        Label9.Text = ReadLine(ReadLine(AllIncLines - 1, allLines) + 4, CycleallLines)
        Label14.Text = ReadLine(ReadLine(AllIncLines - 2, allLines) + 4, CycleallLines)
        Label19.Text = ReadLine(ReadLine(AllIncLines - 3, allLines) + 4, CycleallLines)
        Label24.Text = ReadLine(ReadLine(AllIncLines - 4, allLines) + 4, CycleallLines)

        'If statements to see how large a number is inputted to the labels, when compared to the averages (Speed, Distance and Time)
        'If greater than then label colour will become green 
        'If equal to then label colour will become orange
        'If less than then the label colour will become red
        If Label9.Text < Time Then
            Label9.ForeColor = Color.Red
        ElseIf Label9.Text = Time Then
            Label9.ForeColor = Color.Orange
        Else
            Label9.ForeColor = Color.Green
        End If

        If Label14.Text < Time Then
            Label14.ForeColor = Color.Red
        ElseIf Label14.Text = Time Then
            Label14.ForeColor = Color.Orange
        Else
            Label14.ForeColor = Color.Green
        End If

        If Label19.Text < Time Then
            Label19.ForeColor = Color.Red
        ElseIf Label19.Text = Time Then
            Label19.ForeColor = Color.Orange
        Else
            Label19.ForeColor = Color.Green
        End If

        If Label24.Text < Time Then
            Label24.ForeColor = Color.Red
        ElseIf Label24.Text = Time Then
            Label24.ForeColor = Color.Orange
        Else
            Label24.ForeColor = Color.Green
        End If

        'Text for labels 10, 15, 20 and 25 are set to the relevant calories from the past few rides
        Label10.Text = ReadLine(ReadLine(AllIncLines - 1, allLines) + 5, CycleallLines)
        Label15.Text = ReadLine(ReadLine(AllIncLines - 2, allLines) + 5, CycleallLines)
        Label20.Text = ReadLine(ReadLine(AllIncLines - 3, allLines) + 5, CycleallLines)
        Label25.Text = ReadLine(ReadLine(AllIncLines - 4, allLines) + 5, CycleallLines)

    End Sub

End Class