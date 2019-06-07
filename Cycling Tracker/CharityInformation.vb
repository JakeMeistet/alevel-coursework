'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This section wasn't previously included within the prototype solution. This allows for the user to view all of the previous charities they have raised money for as well as viewing information based on their most recent fundraiser.
'Many calculations take place in this form like percentages, means and totals.

Public Class CharityInformation
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

    'This subroutine has been used to check whether a user is a paracyclist or not.
    'The checks made in this subroutine are necessary for changes in the GUI or changes 
    'with suggestions for equipment the user can use. The subroutine also allows for disabled 
    'users to be taken into account with my system. When the user registers for the first time 
    'they will be asked whether they are a paracyclist this then leads to a menu to specify 
    'what bike they have to use when cycling which then allows for the necessary changes to be made.
    Sub ParacyclistCheck(ByVal ID)
        'Directory is set to the directory for Paracyclists.txt
        'This is done by combining the path for MyDocuments stored under the variable
        'File with the end of the directory for Paracyclists.txt stored in Module1
        'as ParaDirectory.
        Directory = File & Module1.ParaDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader2 is declared as a Streamreader to read from Paracyclists.txt
        Dim Reader2 As New System.IO.StreamReader(Directory)
        'allLines2 is neclared as a list of string values
        'An example of data stored under allLines2 would be '1' which would be a userID
        'another example would be C1 - C5 which would be the bike they have to use.
        Dim allLines2 As List(Of String) = New List(Of String)
        'Loop while Reader2 doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines2 list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader2.EndOfStream
            'The next line is read and added to the allLines2 list
            allLines2.Add(Reader2.ReadLine())
        Loop
        'The file is closed
        Reader2.Close()
        'Line is declared as an integer
        Dim Line As Integer

        'If the user ID is 0 then the Line will be set to 0
        'This is because the first user(ID 0) would have their information
        'starting on the first line of the file.
        If ID = 0 Then
            Line = 0
            'Else (If the user ID is anything more than 0 then the line
            'of the user's ID within the file is determined by using the
            'known ID and multiplying it by 2 because an ID is every 2 lines
            'within Paracyclists.txt.
        Else
            'Line is set to 2 times the user ID
            Line = ID * 2
        End If

        'ParaCheck is declared as a string
        'Paracheck is set to the line after the ID in Paracyclists.txt
        'Paracheck is used to determine whether or not a user is a paracyclist or not
        'If the user isn't then the line read in paracheck would be "N/A"
        'Else the program knows that the user signed in is a paracyclist.
        Dim ParaCheck As String = ReadLine(Line + 1, allLines2)
        'If ParaCheck is equal to 'N/A
        'This shows that the user isn't a paracyclist
        'The boolean Paracyclist in Module1 is then set to False
        'and allows the other forms to take that boolean to check whether
        'a user is a paracyclist or not.
        If ParaCheck = "N/A" Then
            Module1.Paracyclist = False
            'Else (The other possibilities would be 'C1 - C5',
            ''T1 - T2', 'B' and 'H1 - H5' which the user specifies
            'if they enter the paracyclist options during register.
        Else
            'The boolean Paracyclist in Module1 is then set to True
            Module1.Paracyclist = True
        End If

        'If ParaCheck is equal to 'B'
        If ParaCheck = "B" Then
            'The form's background colour is set to Black
            Me.BackColor = Color.Black
            'LblList is declared as a list of labels including all labels in the form except for the title
            Dim LblList As New List(Of Label) From {LblID, LblARaised, LblAGiftAid, LblPercentage, LblTGift, LblTotal, ToRaise}
            'For i is equal to 0 through to he length of LblList - 1
            For i As Int32 = 0 To LblList.Count - 1
                'Current label colour is set to white and the font is made bold
                LblList(i).ForeColor = Color.White
                LblList(i).Font = Module1.BoldFont
                'i increments by 1
            Next i
            'The title colour is set to white
            LblCharityInfo.ForeColor = Color.White
        End If
    End Sub

    'Private sub initiated when form is loaded
    Private Sub CharityInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Directory is set to the path of PastID.txt
        Directory = File & Module1.IDDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'IDReader is declared as a Streamreader to read from PastID.txt
        Dim IDReader As New System.IO.StreamReader(Directory)
        'IDallLines is neclared as a list of string values
        'An example of data stored under allLines2 would be '1' which would be a userID
        Dim IDallLines As List(Of String) = New List(Of String)
        'Loop while IDReader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the IDallLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not IDReader.EndOfStream
            'The next line is read from the file and added to IDallLines list
            IDallLines.Add(IDReader.ReadLine)
        Loop
        'The file is closed
        IDReader.Close()
        'ID is declared as string
        'ID is set to the value in the first line of ID.txt
        'This file stores the ID of the most recent user (the one currently using the program)
        Dim ID As String = ReadLine(0, IDallLines)
        'ParacyclistCheck subroutine is initiated passing ID through by its value
        ParacyclistCheck(ID)
        'The text of textbox 'TxtID' is set to the variable ID
        TxtID.Text = ID
        'Read subroutine is initiated passing ID by its value
        Read(ID)
    End Sub

    'Sub Read passing ID ByVal
    Sub Read(ByVal ID)
        'Directory is set to the path of CharityDetails.txt
        Directory = File & Module1.CharityDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from Paracyclists.txt
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
        'Directory is set to the path for LineNumbers.txt
        Directory = File & Module1.LineNoDirectory
        'objWriter is used to overwrite the LineNumber.txt file
        'The file is overwritten and immediately closed
        'This ensures that this file only ever has data on line 0 when
        'the ID is written to the file
        Dim objWriter As New System.IO.StreamWriter(Directory)
        'File is closed
        objWriter.Close()
        'LinearSearch function is initiated passing both ID and allLines by value
        LinearSearch(ID, allLines)
    End Sub

    'Linear Search function passing the necessary variables through by value
    'All of the necessary paramaters are passed through ByVal from the Read(ID) subroutine
    'This subroutine performs all of the linear searches for the admin to view the data from the
    'User and date that they wish to see.
    Sub LinearSearch(ByVal ID, ByVal allLines)
        'TotalLines is declared as an integer which is used to find the total number of lines in a file
        'This is then passed into the calculations subroutine.
        Dim TotalLines As Integer
        'Directory is set to the path for CharityDetails.txt
        'This is accomplished by combining the path for MyDocuments (File) with
        'the end of the path stored in Module1 as CharityDirectory
        Directory = File & Module1.CharityDirectory
        'Lines is declared as a string reading all lines from CharityDetails.txt to find the length
        'This reads all lines from the CharityDetails.txt file and closes it immediately.
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'LineNumber is declared as an integer and set to 1
        'LineNumber is used to determine the line number of the
        'user ID in charitydetails.txt
        Dim LineNumber As Integer = 1
        'CheckID is declared as string
        'CheckID is set to the value in line 1 of CharityDetails
        Dim CheckID As String = ReadLine(LineNumber, allLines)

        'Do loop until LineNumber is greater than or equal to the length of CharityDetails.txt
        'This do loop has been used because the loop must execute at least one time to perform the search.
        Do
            'The next incremented line (LineNumber) of CharityDetails.txt is read and assigned to the variable CheckID
            CheckID = ReadLine(LineNumber, allLines)
            'If CheckID doesn't equal ID then LineNumber will increment by 6
            If CheckID <> ID Then
                'LineNumber increments by 6
                'This is because there is a UserID every 6th line in CharityDetails.txt
                'in between is all the information for charity under that user.
                LineNumber = LineNumber + 6
                'Else, the LineNumber will be written to LineNumbers.txt
                'The ID line has been found at this point so the processes continue
            Else
                'Directory is set to the path of LineNumbers.txt
                'This directory is used so that the line numbers of the userIDs in the CharityDetails.txt 
                'can be recorded to check if there is enough information to actually display on the form.
                Directory = File & Module1.LineNoDirectory
                'objWriter ammends LineNumbers.txt using StreamWriter
                Dim objWriter As New System.IO.StreamWriter(Directory, True)
                'The LineNumber is written to the file
                objWriter.WriteLine(LineNumber)
                'The file closes
                objWriter.Close()
                'LineNumber increments by 6
                LineNumber = LineNumber + 6
            End If
            'Loop ends when criteria is met
        Loop Until LineNumber >= lines.Length

        'Directory is set to the path for LineNumbers.txt
        'This ensures that the directory is set to the one for LineNumbers.txt
        Directory = File & Module1.LineNoDirectory
        'lines2 is declared as a string to read all lines from LineNumbers.txt
        'Used to find the length of the file
        'lines2 reads all limes from LineNumbers.txt and immediately closes the file
        Dim lines2 As String() = IO.File.ReadAllLines(Directory)
        'TotalLines is set to the length of LineNumbers.txt
        'This assigns the length of the file to a variable
        TotalLines = lines2.Length
        'If the length of the file is equal to 0 then a messagebox will be displayed telling the user that they don't have enough information 
        'This prevents any Argument Out Of Range Exceptions.
        If TotalLines = 0 Then
            MsgBox("Not enough information for this user")
            'Form closes
            Me.Close()
            'Else - There is enough information in the file to be read and output to the form
        Else
            'Directory is set to the path for LineNumbers.txt
            'Ensures the correct path is being used
            Directory = File & Module1.LineNoDirectory
            'I have used this to read from a file rather than just using streamreader so that
            'when I need to read a specific line from a file I can use the ReadLine function
            'and simply enter the line number I would need.
            'FinalReader is declared as a Streamreader to read from LineNumbers.txt
            Dim FinalReader As New System.IO.StreamReader(Directory)
            'FinalallLines is neclared as a list of string values
            'An example of data stored under FinalallLines would be '1' which would be a LineNumber in the file
            Dim FinalallLines As List(Of String) = New List(Of String)
            'Loop while FinalReader doesn't reach the end of the file
            'This do while loop is used to read all of the lines in the necessary file
            'and then store the next line read in the FinalallLines list.
            'I have chosen to use a do while because the loop must execute
            'at least one or more times whereas if I used a normal while loop
            'then I wouldn't know If I would need it to loop at all at runtime.
            Do While Not FinalReader.EndOfStream
                'The next line is read and added to allLines list
                allLines.Add(FinalReader.ReadLine)
            Loop
            'File closes
            FinalReader.Close()

            'Directory is set to the path of CharityDetails.txt
            'This ensures that the path is changed to that of the correct file for reading purposes
            Directory = File & Module1.CharityDirectory
            'Loop used to check whether a file is blank 
            Using ReadFile As System.IO.StreamReader = New IO.StreamReader(Directory)
                'Line is declared as a string to read a line from CharityDetails.txt
                Dim line As String
                line = ReadFile.ReadLine
                'If the file is blank, a message box will be displayed telling the user they have no records
                If String.IsNullOrWhiteSpace(line) Then
                    MsgBox("There are no records under this user")
                    'Else, the subroutine Calculations will be initiated
                    'Else - the file has information to be read in it so the calculations subroutine is called
                Else
                    'Sub calculations is called
                    Calculations(TotalLines)
                End If
                'The next line is read from the file
                line = ReadFile.ReadLine
            End Using
        End If
    End Sub

    'FinalSum record is created
    'Raised and GiftAid are both declared as decimals within the record
    'This strucutre is used to add up all of the money raised and giftaid raised
    'This information is used to find the averages as well as to just be displayed on the form
    Structure FinalSum
        Dim Raised As Decimal
        Dim GiftAid As Decimal
    End Structure


    'Result record is created
    'AverageRaised and AverageGiftAid are declared as decimals within the record
    Structure Result
        Dim AvgRaised, AvgGiftAid As Decimal
    End Structure

    'Subroutine Calculations passing TotalLines from LinearSearch ByVal
    'This subroutine performs any major calculations for this class hence the name calculations.
    'It performs averages, sums and eventually displayes the results on the form.
    Sub Calculations(ByVal TotalLines)

        'Sum is declared as the record FinalSum
        'This variable is declared as the structure FinalSum
        'so it is used to total all of the raised money and raised gift aid.
        Dim Sum As FinalSum

        'Final is declared as record Result
        'This is used to store the averages for the raised money and gift aid
        'This information is both written to a file and displayed on the form
        Dim Final As Result

        'Reader and allLines are used to read from the file LineNumbers.txt
        Directory = File & Module1.LineNoDirectory
        'Reader is declared as a new stream reader to read the lineNumbers for
        'the information that is stored in CharityDetails.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'AllLines is declared as a list of string values which
        'stores all lines read from the file
        'An example of information stored would be '1' as a user ID or
        ''1000' which could be a goal that the user wants to reach in their fundraiser.
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while Reader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader.EndOfStream
            'Next line from the file is read and added to the list
            allLines.Add(Reader.ReadLine)
        Loop
        'File is closed.
        Reader.Close()

        'Lines and Lines2 are declared as strings
        'Lines is set to be used to find line length of LineNumbers.txt
        'Lines2 is set to be used to find the line length of CharityDetails.txt 
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'The path is changed under Directory to that of CharityDetails.txt
        Directory = File & Module1.CharityDirectory
        Dim lines2 As String() = IO.File.ReadAllLines(Directory)

        'LoopNumber is declared as an integer
        'Used to increment the do until loop
        Dim LoopNumber As Integer
        'CalcReader is declared as a new stream reader to read the lineNumbers for
        'the information that is stored in CharityDetails.txt
        Dim CalcReader As New System.IO.StreamReader(Directory)
        'CalcallLines is declared as a list of string values which
        'stores all lines read from the file
        'An example of information stored would be '1' as a user ID or
        ''1000' which could be a goal that the user wants to reach in their fundraiser.
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

        'TotalLines is declared as an integer
        'TotalLines is set to the length of LineNumbers.txt
        TotalLines = lines.Length
        LoopNumber = 0
        'Charities is declared as string
        Dim Charities As String

        'Do loop until LoopNumber is greater than or equal to the length of LineNumbers.txt
        'This is used to add all of the money raised and gift aids togeter to get totals
        Do Until LoopNumber >= TotalLines
            'Sums of Raised and GiftAid are added till the loops end so they can be used for mean average later
            Sum.Raised = Sum.Raised + ReadLine(ReadLine(LoopNumber, allLines) + 3, CalcallLines)
            Sum.GiftAid = Sum.GiftAid + ReadLine(ReadLine(LoopNumber, allLines) + 4, CalcallLines)
            'LoopNumber increments by 1
            LoopNumber = LoopNumber + 1
            'Loop ends when criteria is met
        Loop

        'Items in ListBox1 are cleared
        'This is used so that the listbox doesn't repeat all of the information endlessly.
        ListBox1.Items.Clear()
        'For loop to loop until variable i reaches the length of LineNumbers.txt - 1
        'A for loop is used to easily increment i each cycle so that the next line is read every time
        'The information is then added to the listbox
        For i = 0 To lines.Length - 1
            'Charities is set to the relevant line within thge file
            Charities = ReadLine(ReadLine(i, allLines) + 1, CalcallLines)
            'Charities are added to the ListBox
            ListBox1.Items.Add(Charities)
            'Variable i increments by 1 and loop ends once criteria is met
        Next i

        'LoopNumber is set to 0
        'This makes it ready for the next loop
        LoopNumber = 0

        'Averages are calculated for Raised and GiftAid by dividing the sums by the line length of LineNumbers.txt
        If TotalLines > 0 Then
            'These are the average calculations where the sums are divided by the number of items added
            'where the number of items would be total lines (the number of lines where the data was present)
            Final.AvgRaised = Sum.Raised / TotalLines
            Final.AvgGiftAid = Sum.GiftAid / TotalLines

            'Average Raised and Average Gift Aid are rounded to 2 decimal places.
            'This allows for the user to be able to understand the information more easily.
            Dim AvgRaised As Decimal = Math.Round(Final.AvgRaised, 2, MidpointRounding.AwayFromZero)
            Dim AvgGiftAid As Decimal = Math.Round(Final.AvgGiftAid, 2, MidpointRounding.AwayFromZero)

            'Percentage, Goal and Raised are all declared as decimals
            'These are all used to asign the calculated values to their own variables
            Dim Percentage, Goal, Raised As Decimal
            'Line is declared to retrieve the most recent goal and raised information from the file
            Dim Line As Integer = ReadLine(lines.Length - 1, allLines)
            'Goal and Raised are set to the relevant lines read from CharityDetails.txt
            'These are from the most recent entry by the user
            Goal = ReadLine(Line + 2, CalcallLines)
            Raised = ReadLine(Line + 3, CalcallLines)
            'ToRaise is declared as a decimal
            'This is the amount of money the user still has
            'to raise out of their most recent goal.
            Dim ToRaise As Decimal = Goal - Raised

            'All of the information is set into its textboxes in the form.
            TxtToRaise.Text = "£" & ToRaise
            TxtARaised.Text = "£" & AvgRaised
            TxtAGiftAid.Text = "£" & AvgGiftAid
            TxtTotal.Text = "£" & Sum.Raised
            TxtTotalG.Text = "£" & Sum.GiftAid

            'Raised is divided by goal and  is divided by 100 to calculate the percentage
            Percentage = (Raised / Goal) * 100
            'Percentage is rounded to 2 decimal places and the text of textbox 'TxtPercentage' is set to the percentage
            Percentage = Math.Round(Percentage, 2, MidpointRounding.AwayFromZero)
            'Percentage is assigned to its texbox within the form
            TxtPercentage.Text = Percentage & "%"
        End If
    End Sub

    'Public function used to read specific lines from a text file
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

    'Private subroutine to detect Done button clicked, if yes the form is closed
    Private Sub BtnDone_Cloick(sender As Object, e As EventArgs) Handles BtnDone.Click
        Me.Close()
    End Sub

End Class