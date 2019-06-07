'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This works in the same way as it did within the prototype, all that has changed is the images have been added to the interface to make it more user-friendly.

Public Class UserSearch
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

    'SearchVariable record is created
    'Stores the decimal variables Speed, Distance, Time and Calories
    Structure SearchVariables
        Dim Speed, Distance, Time, Calories As Decimal
    End Structure

    'Private sub to detect Search button click
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        'If any of the date information is blank
        'This is used to validate if the inpu for the date numbers were blank
        'if they are then the user is asked to input something into the textboxs for their search.
        If DaySearch.Text = "" Or MonthSearch.Text = "" Or YearSearch.Text = "" Then
            'Messagebox will ask the user to input the requested data
            MsgBox("Please input a correct date")
            'Else - The textboxes are no longer blank so the program checks whether all of the inputs
            'for dates are numeric
        Else
            'If the date information input by the user isn't numeric
            'This is for validation because a date in this format can't be
            'any characters that aren't letters so the program checks that the
            'values input are numeric and if not it will ask the user to re-input the data
            If IsNumeric(DaySearch.Text) = False Or IsNumeric(MonthSearch.Text) = False Or IsNumeric(YearSearch.Text) = False Then
                'Messagebox will tell the user that the dates need to be input as numbers
                MsgBox("One or more of your inputs are not numbers, re enter your information.")
                'Else - the date is numeric so the program will continue to perform further validation
            Else
                'If the date information length (per textbox) is 2
                'This is necessary for format checking. My program uses dates in the format dd/mm/yy so
                'this if statement ensures that once the inputs are numeric that they are a maximum of 2 in length
                If DaySearch.Text.Length = 2 And MonthSearch.Text.Length = 2 And YearSearch.Text.Length = 2 Then
                    'If the format is correct then date checks are ran
                    'Checks to determine whether a date actually exists
                    'This ensures that the date input by the user isn't anything beyond this year
                    'and that months aren't above 12 as well as days not being above 31 days.
                    'I could've included checks to ensure that the user can't input dates beyond the present
                    'day however I decided to not do this currently because the program would need a way to find the
                    'current date and then perform checks on that.
                    If DaySearch.Text > 31 Or DaySearch.Text < 1 Or MonthSearch.Text > 12 Or MonthSearch.Text < 1 Or YearSearch.Text > 19 Then
                        'If date doesn't exist
                        'Messagebox is displayed telling the user the date doesn't exist
                        MsgBox("That date doesn't exist")
                        'Else - If the date is correct then basic leap year checks are ran
                    Else
                        'If the month is February and the day is greater than the 29th
                        'Even though this doesn't check for specific leap years, it ensures that dates in
                        'February can't go above the 29th no matter what year is input by the user.
                        If MonthSearch.Text = "02" And DaySearch.Text > 29 Then
                            'Messagebox tells the user that the date doesn't exist
                            MsgBox("That date doesn't exist")
                            'Else - The checks are complete and the program continues
                        Else
                            'ID is declared as an integer
                            Dim ID As Integer
                            'ID.txt is opened to be read from
                            Directory = File & Module1.IDDirectory
                            'I have used this to read from a file rather than just using streamreader so that
                            'when I need to read a specific line from a file I can use the ReadLine function
                            'and simply enter the line number I would need.
                            'Reader is declared as a Streamreader to read from PastID.txt
                            Dim Reader As New System.IO.StreamReader(Directory)
                            'allLines is neclared as a list of string values
                            'An example of data stored under allLines would be '1' which would be a userID
                            'another example would be 12 which would be the amount of money raised.
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
                            'ID is set to the value in the first line of ID.txt
                            ID = ReadLine(0, allLines)
                            'Read subroutine is initiate passing ID through
                            Read(ID)
                        End If
                    End If
                Else
                    'MessageBox is displayed telling the user that the date is written in the incorrect format
                    'The user will then have to input the dates again until they are written in the correct format
                    'e.g. 28/01/02
                    MsgBox("The date is written in the incorrect format")
                End If
            End If
        End If


    End Sub

    'Subroutine Read
    'This subroutine is used to open the CyclingDetails.txt
    'file and read all lines from so that the necessaruy lines can be read in the LinearSearch subroutine
    'This sub reads from the CyclingDetails file and declards any necessar variables needed during the search
    Sub Read(ByVal ID)


        'Directory is set to the CyclingDetails.txt directory
        'This allows for this file to be written to
        'The path is made by combining the path for MyDocuments (File) as well as the end of the path
        'for CyclingDetails.txt stored in Module1 as CyclingDirectory
        Directory = File & Module1.CyclingDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from CyclingDetails.txt
        'CyclingDetails.txt is opened so it can be read from
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
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'InputSearch and LineRead are declared as String
        'These are used to assign the user's search to a variable
        'And lineRead is used to read the next line from a file
        Dim InputSearch, LineRead As String
        'InputSearch is set to the day, month an year the user input
        'This puts the date into the correct format
        InputSearch = DaySearch.Text & "/" & MonthSearch.Text & "/" & YearSearch.Text
        'LineNumber is declared as an integer
        'This is used to determine which line is currently being read fro
        'LineNumber is used to find the dates
        Dim LineNumber As Integer
        'LineRead is set to the first line in CyclingDetails.txt
        If lines.Length < 1 Then
            MsgBox("There are no records")
            Me.Close()
        Else
            LineRead = ReadLine(LineNumber, allLines)
            'CheckNumber is declared as an integer
            'CheckNumber is set to be the line to read
            'the UserIDs from the file
            Dim CheckNumber As Integer
            'CheckNumber is set to 0
            CheckNumber = 0
            'LineNumber is set to 1
            LineNumber = 1
            'CheckID and CheckSearch are declared as strings
            Dim CheckID, CheckSearch As String
            'This is set to the first date in the file which is compared with the InputSearch
            'CheckSearch is set to the value in Line 1 of CyclingDetails.txt
            'This is set to the first ID within the file (on line 0)
            'CheckID is set to the value in line 0 of CyclingDetails.txt
            CheckSearch = ReadLine(LineNumber, allLines)
            CheckID = ReadLine(CheckNumber, allLines)
            'LinearSearch function is initiated passing the relevant variables through
            LinearSearch(LineNumber, CheckNumber, CheckSearch, CheckID, ID, InputSearch, allLines)
        End If
    End Sub

    'Public function to allow specific lines to be read from a file
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        'lines(lineNumber) is returned from the function to allow for specific lines to be read from the list/files
        Return lines(lineNumber)
    End Function


    'Linear Search function passing the necessary variables through by value
    'All of the necessary paramaters are passed through ByVal from the Read(ID) subroutine
    'This subroutine performs all of the linear searches for the admin to view the data from the
    'date that they wish to see.
    Sub LinearSearch(ByVal LineNumber, ByVal CheckNumber, ByVal CheckSearch, ByVal CheckID, ByVal ID, ByVal InputSearch, ByVal allLines)
        'Directory is set to the path of CyclingDetails.txt
        'This is done by combining the path for MyDocuments and the end of the path for CyclingDetails.txt
        'Which is stored under the ReadOnly variable CyclingDirectory in Module1
        Directory = File & Module1.CyclingDirectory
        'Lines is declared as a string to read all lines of CyclingDetails.txt
        'ReadAllLines reads all of the lines and then closes the program immediately afterwards
        'Used to find the length of CyclingDetails.txt
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'Loop until CheckID is equal to ID and CheckSearch is equal to InputSearch
        'Or loop until CheckNumber + 6 or LineNumber + 6 is greater than or equal to the length of the file
        'This loop must execute at least once to search hence the Do Loop Until has been used.
        'The loop also allows for the program to exit the loop immediately once a certain condition is met.
        Do
            'If statement to exit the do loop once LineNumber has exceeded the length of the file
            'This prevents Argument Out Of Range Exceptions
            If LineNumber >= lines.Length Then
                Exit Do
                'Else - The data can be read because LineNumber is less than the length of the file
            Else
                'IF CheckID doesn't equal ID
                If CheckID <> ID Then
                    'If statement to exit the do loop once LineNumber or CheckNumber has exceeded the length of the file
                    'This prevents Argument Out Of Range Exceptions
                    If CheckNumber >= lines.Length Or LineNumber >= lines.Length Then
                        Exit Do
                    End If
                    'If CheckSearch doesn't equal InputSearch

                    'If statement to exit the do loop once LineNumber or CheckNumber has exceeded the length of the file
                    'This prevents Argument Out Of Range Exceptions
                    If CheckSearch <> InputSearch Then
                        If CheckNumber >= lines.Length Or LineNumber >= lines.Length Then
                            Exit Do
                        End If
                        'CheckNumber and LineNumber increment by 6
                        'Every 6th line would be the next ID and Date. CheckNumber starts at line 0
                        'This corresponds with every ID every 6th Line, whereas LineNumber starts on Line 1
                        'This corresponds with every date in the file every 6th line.
                        CheckNumber = CheckNumber + 6
                        LineNumber = LineNumber + 6
                        'CheckSearch is set to the line LineNumber read from the file
                        'This reads the next date in the file for the search
                        CheckSearch = ReadLine(LineNumber, allLines)
                        'CheckID is set to the line CheckNumber read from the file
                        'This then reads the next ID stored in the file for the search
                        CheckID = ReadLine(CheckNumber, allLines)
                    End If
                    'Else - An id has been found that matches the current user ID
                    'Checks for the dates are then run
                Else
                    'If statement to exit the do loop once LineNumber or CheckNumber has exceeded the length of the file
                    'This prevents Argument Out Of Range Exceptions
                    If CheckNumber >= lines.Length Or LineNumber >= lines.Length Then
                        Exit Do
                    End If
                    'If CheckSearch Doesn't equal InputSearch
                    If CheckSearch <> InputSearch Then
                        'CheckNumber and LineNumber increment by 6
                        'Every 6th line would be the next ID and Date. CheckNumber starts at line 0
                        'This corresponds with every ID every 6th Line, whereas LineNumber starts on Line 1
                        'This corresponds with every date in the file every 6th line.
                        CheckNumber = CheckNumber + 6
                        LineNumber = LineNumber + 6
                        'CheckSearch is set to the line LineNumber read from the file
                        'This reads the next date in the file for the search
                        CheckSearch = ReadLine(LineNumber, allLines)
                        'CheckID is set to the line CheckNumber read from the file
                        'This then reads the next ID stored in the file for the search
                        CheckID = ReadLine(CheckNumber, allLines)
                        'If statement to exit the do loop once LineNumber or CheckNumber has exceeded the length of the file
                        'This prevents Argument Out Of Range Exceptions
                        If CheckNumber >= lines.Length Or LineNumber >= lines.Length Then
                            Exit Do
                        End If
                        'Else
                    Else
                        'If statement to exit the do loop once LineNumber or CheckNumber has exceeded the length of the file
                        'This prevents Argument Out Of Range Exceptions
                        If CheckNumber >= lines.Length Or LineNumber >= lines.Length Then
                            Exit Do
                        End If
                        'Do Loop Continues
                        Continue Do
                    End If
                End If
            End If
            'Loop ends when criteria is met
        Loop Until (CheckID = ID And CheckSearch = InputSearch) Or (CheckNumber + 6 >= lines.Length Or LineNumber + 6 >= lines.Length)

        'If CheckID doesn't equal ID or CheckSearch doesn't equal InputSearch
        'Prevents Argurment Out Of Range Exceptions
        If CheckID <> ID Or CheckSearch <> InputSearch Then
            'Messagebox displays that there isn't any records
            MsgBox("You have no records under that date.")
            'Else
        Else
            'Textboxes are loaded with the relevant data
            'This allows the user to view their data on the form
            SpeedOutput.Text = ReadLine(LineNumber + 1, allLines) & " m/ph"
            DistanceOutput.Text = ReadLine(LineNumber + 2, allLines) & " miles"
            TimeOutput.Text = ReadLine(LineNumber + 3, allLines) & " minutes"
            CaloriesOutput.Text = ReadLine(LineNumber + 4, allLines) & " kCal"
        End If
    End Sub

    'Private sub to detect Done button click
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        'Form closes
        Me.Close()
    End Sub

    Private Sub UserSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'If ParaCheck is equal to 'B'
        If ParaCheck = "B" Then
            'The form's background colour is set to Black
            Me.BackColor = Color.Black
            'LblList is declared as a list of labels including all labels in the form except for the title
            Dim LblList As New List(Of Label) From {Search, Label3, Label4, Label5, Label6, Label7, Speed, Distance, Time, Calories}
            'For i is equal to 0 through to he length of LblList - 1
            For i As Int32 = 0 To LblList.Count - 1
                'Current label colour is set to white and the font is made bold
                LblList(i).ForeColor = Color.White
                LblList(i).Font = Module1.BoldFont
                'i increments by 1
            Next i
            'The title colour is set to white
            LblUserSearch.ForeColor = Color.White
        End If

    End Sub

End Class
