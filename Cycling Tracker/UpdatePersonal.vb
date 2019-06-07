'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This works similarly to the updatepass form, where this allows the user to update their information. This replaces the old information under their user.

Public Class UpdatePersonal
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

    'ID is declared as an integer
    'ID is used to identifiy which user is currently using the form
    Dim ID As Integer

    'Private sub to detect when Update button is clicked
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        'I have used if statements because it allows for elses to be used and several nested if statements for validation
        'These are all validation checks to ensure that the user inputs the correct information
        'The first check runs to see wether he user has left any blanks in the information and if so the user is informed of the mistakes they can change.
        If Day.Text = "" Or Month.Text = "" Or Year.Text = "" Or Foot.Text = "" Or Inches.Text = "" Or Stone.Text = "" Or Pounds.Text = "" Then
            MsgBox("Please input the necessary information")
            'Else - Numeric checks are run to check if all the inputs are numeric and don't include letters
        Else
            If Foot.Text < 1 Or Inches.Text < 1 Or Stone.Text < 1 Or Pounds.Text < 1 Then
                MsgBox("The Height and weight values cannot be less than 1")
            Else
                'These are all validation checks to ensure that the user inputs the relevant information
                'This also avoids any potential error such as Argument Out Of Range Exception
                'The first check checks whether ther height values, weight values and the dob values are numeric or not
                'If not then the user is informed that the inputs must be numeric and not include any letters
                If IsNumeric(Foot.Text) = False Or IsNumeric(Inches.Text) = False Or IsNumeric(Stone.Text) = False Or IsNumeric(Pounds.Text) = False Or IsNumeric(Day.Text) = False Or IsNumeric(Month.Text) = False Or IsNumeric(Year.Text) = False Then
                    MsgBox("One or more of your inputs are not numbers, re enter your information.")
                    'Else - the inputs are numeric then further checks run
                Else
                    'The dates must be a length of 2 so they are therfore checked with this nested if statement
                    'If they are 2 in length then further checks are made to see whether the date exists or not.
                    If Day.Text.Length = 2 And Month.Text.Length = 2 And Year.Text.Length = 2 Then
                        'If the day is above 31, or less than one, the same applies for month however the max limit is 12 and for year if it's greater than the current year then the date doesn't exist
                        'The user is informed of this and has to input a correct date.
                        If Day.Text > 31 Or Day.Text < 1 Or Month.Text > 12 Or Month.Text < 1 Then
                            MsgBox("That date doesn't exist")
                            'Else - as far as we know so far the date exists unless it's in february, leap year checks run.
                        Else
                            'If the month is feburary and the day is greater than 29 then the user is told the date doesn't exist
                            'I havent included full leap year checks because that would require a full date and calendar system to know when the leap years occurred.
                            If Month.Text = "02" And Day.Text > 29 Then
                                MsgBox("That date doesn't exist")
                                'Else - the format checks and presence checks have finished more checks are ran to ensure the lengths of the height and weight values
                            Else
                                'The values for height and weight are checked that they are the correct length.
                                'If they are too long then the user is told that the measurement inputs are incorrect
                                'They must then check and input their data again
                                If Foot.Text.Length > 1 And Inches.Text.Length > 2 And Stone.Text.Length > 2 And Pounds.Text.Length > 2 Then
                                    MsgBox("The measurements input are incorrect")
                                    'Else the details are written to 1D arrary write
                                Else
                                    '1D Array Write is declared with 2 elements
                                    'This is used to write all of the new details to the file
                                    Dim Write(2)
                                    'Write values are set to the DOB, Height and Weight
                                    Write(0) = (Day.Text & "/" & Month.Text & "/" & Year.Text)
                                    Write(1) = (Foot.Text & "ft " & Inches.Text & "in")
                                    Write(2) = (Stone.Text & "st " & Pounds.Text & "lb")
                                    'IDFind subroutine is initiated
                                    IDFind()
                                    'PersonalWriter subroutine is initiate passing write array through
                                    PersonalWriter(Write)
                                End If
                            End If
                        End If
                    Else
                        MsgBox("The date is written in the incorrect format")
                    End If
                End If
            End If
        End If
    End Sub

    'IDFind subroutine
    'This subroutine is used to find the user ID from 
    'the PastID.txt file
    Sub IDFind()
        'Directory is set to the directory/path of PastID.txt
        'This is done by combining the path for MyDocuments(File) as well as the end of the path
        'for PastID.txt which is stored under CIDDirectory in Module1 as a Public ReadOnly String
        Directory = File & Module1.IDDirectory
        'Lines is declared as a string to read all lines of PastID.txt
        'ReadAllLines reads all of the lines and then closes the program immediately afterwards
        'Used to find the length of PastID.txt
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from PastID.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a userID
        'another example would be 12 which would be the speed they cycled.
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while Reader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader.EndOfStream
            'Next line is read and added to allLines list
            allLines.Add(Reader.ReadLine())
        Loop
        'File is closed
        Reader.Close()
        'First line in ID.txt is read and assigned the variable ID
        ID = ReadLine(0, allLines)
    End Sub

    'PersonalWriter subroutine
    'This subroutine is used to replace the old user information in the file with the new information input by the user
    'Write is passed into the subroutine because it contains the information Input by the user
    Sub PersonalWriter(ByVal Write)
        'Directory is set to the directory/path of PersonalDetails.txt
        'This is done by combining the path for MyDocuments(File) as well as the end of the path
        'for PersonalDetails.txt which is stored under PersonalDirectory in Module1 as a Public ReadOnly String
        Directory = File & Module1.PersonalDirectory
        Dim CheckID As String
        'Line is declared as an Integer and set to 0
        Dim Line As Integer = 0
        'Lines is declared as a string to read all lines of PersonalDetails.txt
        'ReadAllLines reads all of the lines and then closes the program immediately afterwards
        'Used to find the length of PersonalDetails.txt
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from PastID.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a userID
        'another example would be 12 which would be the speed they cycled.
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while Reader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader.EndOfStream
            'Next line is read and added to allLines list
            allLines.Add(Reader.ReadLine())
        Loop
        'File is closed
        Reader.Close()
        'CheckID is set to the value in the first line fo PersonalDetails.txt
        CheckID = ReadLine(Line, allLines)

        'Do loop to loop while CheckID (String) doesn't equal ID (String)
        'This must a least execute once and performs a search for the User ID within the
        'PersonalDetails.txt file
        'This is so that the informations under the user can then be replaced
        Do While CheckID.ToString <> ID.ToString
            'CheckID is set to the value of the next line in PersonalDetails.txt
            CheckID = ReadLine(Line, allLines)
            If CheckID.ToString = ID.ToString Then
                Line = Line
            Else
                'Line increments by 1
                Line = Line + 1
            End If
            'Loop ends when criteria is met
        Loop

        'CheckID is set to the most recent line read from PersonalDetails.txt
        'This is the line of the user's ID
        CheckID = ReadLine(Line, allLines)
        'ID is converted to a 64 bit integer from CheckID to IntID
        Dim IntID As Integer = Convert.ToInt64(CheckID)
        'If CheckID(Integer) is less than 1 then line is set to 0
        'If the ID is 0 then the line defaults to 0 because that's where their information starts
        If IntID < 1 Then
            Line = 0
            'Else, line decreases by 1
        Else
            Line = Line - 1
        End If
        'Replace is declared as a string to allow certain lines to be replaced in PersonalDetails.txt
        Dim Replace() As String = System.IO.File.ReadAllLines(Directory)
        'The DOB, Height and Weight are all replaced with the new information input 
        'The new details are encrypted by shift 2 like all other data in this file and
        'then replaces the old information in the file
        Replace(Line + 3) = Module1.CC(Write(0), 2)
        Replace(Line + 4) = Module1.CC(Write(1), 2)
        Replace(Line + 5) = Module1.CC(Write(2), 2)
        System.IO.File.WriteAllLines(Directory, Replace)
        'Written to PersonalDetails.txt

        'Text of the menu is updated with the new DOB, Height and Weight
        Form1.DOB.Text = Write(0)
        Form1.Height1.Text = Write(1)
        Form1.Weight.Text = Write(2)
        'Form closes
        Me.Close()
    End Sub

    'Public function to allow for certain lines to be read from a file
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        'lines(lineNumber) is returned to allow the user to read specific lines from a file/list of string
        Return lines(lineNumber)
    End Function

    'This subroutine has been used to check whether a user is a paracyclist or not.
    'The checks made in this subroutine are necessary for changes in the GUI or changes 
    'with suggestions for equipment the user can use. The subroutine also allows for disabled 
    'users to be taken into account with my system. When the user registers for the first time 
    'they will be asked whether they are a paracyclist this then leads to a menu to specify 
    'what bike they have to use when cycling which then allows for the necessary changes to be made.
    Sub ParacyclistCheck()
        'Directory is set to the directory of PastID.txt
        'This is done by combining the path for MyDocuments which is under the
        'variable File and taking the end of the direcory from the public, readonly
        'IDDirectory stored in Module1
        Directory = File & Module1.IDDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'IDReader is declared as a Streamreader to read from PastID.txt
        Dim IDReader As New System.IO.StreamReader(Directory)
        'IDallLines is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a userID
        Dim IDallLines As List(Of String) = New List(Of String)
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while IDReader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the IDallLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not IDReader.EndOfStream
            'The line read is added to the list IDallLines
            IDallLines.Add(IDReader.ReadLine)
        Loop
        'File is closed
        IDReader.Close()
        'ID is declared as string
        'ID is set to the value in the first line of ID.txt
        'This variable is used to assign the value from the first line of PastID.txt
        'this line always stores the current user's ID
        Dim ID As String = ReadLine(0, IDallLines)
        'Directory is set to the path of Paracyclists.txt
        'This is done by combining the path for MyDocuments (File)
        'with the end of the directory for Paracyclists.txt stored in Module1 as ParaDirectory.
        Directory = File & Module1.ParaDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader2 is declared as a Streamreader to read from Paracyclists.txt
        Dim Reader2 As New System.IO.StreamReader(Directory)
        'allLines2 is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a userID
        'another example would be C1 - C5 which would be the type of bike they use.
        Dim allLines2 As List(Of String) = New List(Of String)
        'Loop while Reader2 doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines2 list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader2.EndOfStream
            'The next line read is added to the list allLines2
            allLines2.Add(Reader2.ReadLine())
        Loop
        'File is closed
        Reader2.Close()
        'Line is declared as an integer
        Dim Line As Integer

        'If ID is equal to 0 then line is set to 0
        'When the user ID their information always starts at line 0,
        'hence the Line variable is set to 0 when ID  is also 0.
        If ID = 0 Then
            Line = 0
            'Else - An ID is every 2 lines in Paracyclists.txt
            'hence ID * 2 to get the linen number.
        Else
            'Line is set to ID times by 2
            'A new ID in this file is every 2 lines hence *2
            Line = ID * 2
        End If

        'ParaCheck is declared as a string
        'Set to the value of the line after the line the ID is stored on
        'Paracheck is used to check what the line equals to determine whether
        'the user Is a paracyclist or not.
        Dim ParaCheck As String = ReadLine(Line + 1, allLines2)

        'If ParaCheck is equal to 'N/A' 
        'Boolean Paracyclist from Module1 is set to false
        'This is because during register, the user didn't
        'select the Paracyclist checkbox.
        If ParaCheck = "N/A" Then
            Module1.Paracyclist = False
            'Else - If the user is a paracyclist then the boolean
            'is set to true because during register the user used the
            'paracyclist checkbox.
        Else
            'Boolean Paracyclist from Module1 is set to true
            Module1.Paracyclist = True
        End If

        'If ParaCheck is equal to 'B'
        'This is used to determine whether the user
        'has to use a tandem bike and is therefore visually
        'impaired and therefore the program changes the colours
        'of the program.
        If ParaCheck = "B" Then
            'Form background is set to black
            Me.BackColor = Color.Black
            'LblList is declared as a list of labels including all of the labels in the form excluding the title
            Dim LblList As New List(Of Label) From {Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14}
            'For i is equal to 0 through to the length of LblList - 1
            For i As Int32 = 0 To LblList.Count - 1
                'The next label's colour is set to white and font is made bold
                LblList(i).ForeColor = Color.White
                LblList(i).Font = Module1.BoldFont
                'i increments by 1
            Next i
            'Title colour is set to white
            LblUpdatePersonal.ForeColor = Color.White
        End If

    End Sub

    'Private sub to run when the form loads
    Private Sub UpdatePersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Paracyclist check sub is called to perform any necessary changes to the outputs or design of the GUI
        ParacyclistCheck()
        'Searching is declared as a boolean and set to true
        'Searching is used to search as long as it is true
        Dim Searching As Boolean = True
        'Directory Is set to the directory/path of PersonalDetails.txt
        'This is done by combining the path for MyDocuments(File) as well as the end of the path
        'for PersonalDetails.txt which is stored under PersonalDirectory in Module1 as a Public ReadOnly String
        Directory = File & Module1.PersonalDirectory
        Dim CheckID As String
        'Line is declared as an Integer and set to 0
        Dim Line As Integer = 0
        'Lines is declared as a string to read all lines of PersonalDetails.txt
        'ReadAllLines reads all of the lines and then closes the program immediately afterwards
        'Used to find the length of PersonalDetails.txt
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from PastID.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a userID
        'another example would be 12 which would be the speed they cycled.
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while Reader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader.EndOfStream
            'Next line is read and added to allLines list
            allLines.Add(Reader.ReadLine())
        Loop
        'File is closed
        Reader.Close()
        'IDFind subroutine is initiated
        IDFind()
        'StrID is declared as a string and set to ID(As String)
        Dim StrID As String = ID.ToString
        'CheckID is set to the value of the first line in PersonalDetails.txt 
        CheckID = ReadLine(Line, allLines)
        'Do loop while CheckID doesn't equal StrID and searching = true
        'This performs a small search to find the ID line within PersonalDetails.txt
        Do While CheckID <> StrID And Searching
            'CheckID is set to the value of the next line read
            CheckID = ReadLine(Line, allLines)
            'Line increments by 1
            'This allows the next line to be read
            Line = Line + 1
            'Loop ends when criteria is met
        Loop
        'If ID is less than 1 then Line is set to 0
        'This is because the user with ID 0 has information starting on line 0 in PersonalDetails.txt
        If ID < 1 Then
            Line = 0
            'Else, line is decreased by 1
        Else
            Line = Line - 1
        End If
        'CheckID is converted to an integer
        Convert.ToInt64(CheckID)
        'The FName and SName textboxes are set to the first two lines after the ID read in PersonalDetails.txt
        'The text is decrypted from the file and displayed on the form.
        FName.Text = Module1.CC(ReadLine(Line + 1, allLines), -2)
        SName.Text = Module1.CC(ReadLine(Line + 2, allLines), -2)
    End Sub
End Class