'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'Since the prototype I have taken into account the end user feedback and have allowed the user to edit information of a certain charity under their userID. The user would input the charity ID they were given when creating the charity instead of the charity name and then continue to update the information.
'This replaces the old information under that charity ID with the new information input by the user. The user can only edit charities under their own User.

Public Class InputCharity
    'UserID is declared as a public string because it is used between classes.
    'The userID is then found reading the most recent line from PastID.txt
    Public UserID As String

    'Record 'Write' is created storing the details to be written to the file later in the form
    'This Structure is used to write the relevant information to the file when it reaches that point in the class.
    Structure Write
        Dim ID As String
        'Charity is declared as string
        Dim Charity As String
        'Goal, Raised and GiftAid are declared as decimals values
        Dim Goal As Decimal
        Dim Raised As Decimal
        Dim GiftAid As Decimal
    End Structure

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
        'Directory is set to the path of Paracyclists.txt
        'This is done my combining the path of MyDocuments (File) with the rest of the path
        'stored under the variable ParaDirectory in Module1
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
            'The next line from the file is added to the list allLines2
            allLines2.Add(Reader2.ReadLine())
        Loop
        'The file is closed.
        Reader2.Close()
        'Line is declared as an integer
        'This is used to specify the line in which
        'is wanted to be read from Paracyclists.txt
        Dim Line As Integer

        'If the UserID is 0 then their information starts at line 0 in Paracyclists.txt
        'Hence line is set to 0
        If ID = 0 Then
            Line = 0
            'Else - The userID is greater than 0, Line is set to 2 * the ID
            'This is because there is a user ID every 2 lines within Paracyclists.txt
        Else
            'Line is set to ID * 2
            Line = ID * 2
        End If

        'Paracheck is declared as a string and is set to read the line after the ID line in Paracyclists.txt
        'This is because the information to determine wether the user is a paracyclist is stored on this line.
        Dim ParaCheck As String = ReadLine(Line + 1, allLines2)

        'If ParaCheck is 'N/A' then the program knows this user isn't a paracyclist
        'This information is written to the file when the user doesn't choose the paracyclist checkbox during register
        If ParaCheck = "N/A" Then
            'The boolean paracyclist is set to false in Module1
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
            Dim LblList As New List(Of Label) From {Label2, Label3, Label4, Label5}
            'For loop which cycles through all forms changing the colours and fonts to white and bold
            For i As Int32 = 0 To LblList.Count - 1
                LblList(i).ForeColor = Color.White
                LblList(i).Font = Module1.BoldFont
                'i Increments by 1
            Next i
            'The title label is only made white and not bold because it is already white.
            LblInputCharity.ForeColor = Color.White
        End If
    End Sub

    'WriteDetails is declared as the record Write
    'This is used to write any necessary details to the file.
    Dim WriteDetails As Write

    'Private sub to detect submit button click
    Private Sub BtnKeep_Click(sender As Object, e As EventArgs) Handles btnKeep.Click
        'These are validation checks for the program
        'If the user inputs a number for the charity name then
        'checks are made to see whether the  other information is numeric
        'Used to replace information already written in the CharityDetails.txt file
        If IsNumeric(CharityName.Text) Then
            'This validation check ensures that the numbers for money are all numeric and if not then the user will be asked to change their information
            'This if statement is used because it allows for an Else rather than repeating case statements.
            If IsNumeric(Goal.Text) = False Or IsNumeric(Raised.Text) = False Or IsNumeric(GiftAid.Text) = False Then
                MsgBox("One or more of your inputs are not numbers, re enter your information.")
                'Else the program will continue in calling the FindUser and CharityWrite subroutines
            Else
                'FindUser sub is called
                FindUser()
                'CharityWriter sub is called
                CharityWriter()
            End If
            'Else - if the user inputs a non-numeric value for the charity name then
            'checks are made to see whether the other information is numeric
            'This is used to write a new charity under that user's ID number.
        Else
            'This validation check ensures that the numbers for money are all numeric and if not then the user will be asked to change their information
            'This if statement is used because it allows for an Else rather than repeating case statements.
            If IsNumeric(Goal.Text) = False Or IsNumeric(Raised.Text) = False Or IsNumeric(GiftAid.Text) = False Then
                MsgBox("One or more of your inputs are not numbers, re enter your information.")
                'Else - the program will continue in calling the IDFind subroutine.
            Else
                If Convert.ToInt64(Goal.Text) < 0 Or Convert.ToInt64(Raised.Text) < 0 Or Convert.ToInt64(GiftAid.Text) < 0 Then
                    MsgBox("You cannot input negative numbers into the money values")
                Else
                    'IDFind sub is called
                    IDFind()
                End If
            End If
        End If
    End Sub

    'Subroutine IDFind is used to find the new ID for a charity in which is newly written to the file
    'This allows for the charity to be edited in the future as long as the user remembers the ID
    'The charity will also be assigned to that user specifically
    Sub IDFind()
        'LastID is declared as an integer to find the most recent charityID from the previous new entry.
        Dim LastID As Integer
        'The directory is set to the path of CharityDetails.txt
        'This is used by combining the path of MyDocuments (File) and the end of the path for CharityDetails.txt
        'stored as CharityDirectory within Module1
        Directory = File & Module1.CharityDirectory
        'Lines is declared as a string, it reads all lines from CharityDetails.txt and is immediately closed
        'This is used to find the length of the file.
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from CharityDetails.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a userID and/or a charityID
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while Reader doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader.EndOfStream
            'The next line is read from the file and added to the list allLines
            allLines.Add(Reader.ReadLine)
        Loop
        'The file is closed
        Reader.Close()

        'NewID is declared as an integer
        'This will be used to add 1 to the LastID to generate the new charityID
        Dim NewID As Integer
        'If the length of the file is less than 1
        'This means that there is no inforamtion currently stored in the file
        If lines.Length < 1 Then
            'This if statement is used for validation so if no information is input into any of the textboxes
            'The program will ask the user to input the relevant data.
            If Goal.Text = "" Or Raised.Text = "" Or GiftAid.Text = "" Then
                MsgBox("Please Input the relevant data requested.")
                'Else - the program will continue setting all of the relevant information to its variables.
            Else
                'the NewID starts at 0 so the ID is set to 0 and the user is told the charity ID through a message box.
                NewID = 0
                MsgBox("The Charity ID for " & CharityName.Text & " is: " & NewID)
                'The variables in the Write structure are now set using WriteDetails
                'These are set to the information input by the user in the textboxes as well as the
                'newly generated CharityID
                WriteDetails.ID = NewID
                WriteDetails.Charity = CharityName.Text
                WriteDetails.Goal = Goal.Text
                WriteDetails.Raised = Raised.Text
                WriteDetails.GiftAid = GiftAid.Text
                'CharityWrite subroutine is initiated
                FindUser()
                'The file is closed
                Reader.Close()
                'CharityWrite subroutine is initiated.
                CharityWrite()
            End If
            'Else - there is a previous ID
            'This is used for validation to prevent Argument Out Of Range exceptions from occuring
        Else
            'This if statement is used for validation so if no information is input into any of the textboxes
            'The program will ask the user to input the relevant data.
            If Goal.Text = "" Or Raised.Text = "" Or GiftAid.Text = "" Then
                MsgBox("Please Input the relevant data requested.")
                'Else - the program will continue setting all of the relevant information to its variables.
            Else
                'The last ID is read from the file
                'Considering there is an ID every 6th line within the file, 6 is taken away from the length of the file to navigate to the correct line
                'The NewID is then set to one more than the previous.
                LastID = ReadLine(lines.Length - 6, allLines)
                NewID = LastID + 1
                'The variables in the Write structure are now set using WriteDetails
                'These are set to the information input by the user in the textboxes as well as the
                'newly generated CharityID
                MsgBox("The Charity ID for " & CharityName.Text & " is: " & NewID)
                WriteDetails.ID = NewID
                WriteDetails.Charity = CharityName.Text
                WriteDetails.Goal = Goal.Text
                WriteDetails.Raised = Raised.Text
                WriteDetails.GiftAid = GiftAid.Text
                'FindUser subroutine is initiated.
                FindUser()
                'The file is closed
                Reader.Close()
                'CharityWrite subroutine is initiated
                CharityWrite()
            End If
        End If


    End Sub

    'This simple subroutine is used to just read the most recent ID from the PastID.txt files
    'This allows for the program to understand which user is using the program and therefore which user to register the charity under.
    Sub FindUser()
        'Directory is set to the Directory for PastID.txt
        'This is done by combining the Directory for MyDocuments and the end of the directory
        'for PastID.txt
        Directory = File & Module1.IDDirectory
        'Lines is declared as a string
        'it reads all lines from PastID.txt and then closes the file immediately.
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from PastID.txt
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
            'The next line is read from the file and added to the allLines list
            allLines.Add(Reader.ReadLine)
        Loop
        'The file is closed
        Reader.Close()
        'The first line from PastID.txt is read which contains the current user's ID
        UserID = ReadLine(0, allLines)
    End Sub

    'CharityWriter subroutine is used to write all of the charity information to the file
    'This includes the user ID so that each charity input is assigned to a certain user.
    'This is used so that the charity stats section can be used where the user can view their
    'money raised as well as averages, percentages and past charities that they have raised money for.
    Sub CharityWriter()
        'The directory is changed to the path of CharityDetails.txt
        Directory = File & Module1.CharityDirectory
        'Lines is declared as a string to find the length of CharityDetails.txt
        'This reads all lines and then closes the file immediately
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'CheckID is declared as a string
        'This is used to make comparisons with the CharityName
        Dim CheckID As String
        'Line is declared as an Integer and set to 0
        'This is so that the first line (line 0) is read at first from the file.
        Dim Line As Integer = 0
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from CharityDetails.txt
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
            'The next line is read and added to the end of the list allLines
            allLines.Add(Reader.ReadLine)
        Loop
        'The file closes
        Reader.Close()
        'Line is set to 0 to read the first line
        Line = 0
        'CheckID is set to the value in the first line of CharityDetails.txt
        CheckID = ReadLine(Line, allLines)
        'If the ID equals the one input by the user in the text box when the line is 0
        'This means that the line for that charities information is 0 so the line is set to 0
        If CheckID.ToString = CharityName.Text Then
            Line = 0
            'Else - the first line doesn't include the information
        Else
            'While CheckID (String) doesn't equal ID (String)
            'Loops as long as it can't find the input CharityName/ID
            'Will exit if Line becomes equal to or greater than the length of the file
            'This prevents Argument Out Of Range Exception error
            While CheckID.ToString <> CharityName.Text
                'Line increments by 6 because there is a new ID every 6th line within the file.
                Line = Line + 6
                'If the line is greater than or equal to the length of the file the loop is exited.
                'This prevents Argument Out Of Range Exception error
                If Line >= lines.Length Then
                    Exit While
                End If
                'CheckID is set to the value of the next line in PersonalDetails.txt
                CheckID = ReadLine(Line, allLines)
                'Loop ends when criteria is met
            End While
        End If
        'Checks whether the charity exists or not in that file
        'If the ID isn't found then the user is informed that the charity doesn't currently exitst
        'within the file
        If CheckID.ToString <> CharityName.Text Then
            MsgBox("The charity ID doesn't exist")
            'Else - the charity exists, may not be for that user though
            'hence the checks that then occur
        Else
            'If the length of the file is less than 1 then line is set to 0 to prevent Argument Out Of Range Exceptions
            If lines.Length < 1 Then
                Line = 0
            End If

            'CurrentUserID is declared as a string and set to the ID of that charity
            Dim CurrentUserID As String = ReadLine(Line + 1, allLines)
            'If the currentID equals the ID of the charity then the program will go to replace all of the information including the Goal, Raised and GiftAid
            If CurrentUserID = UserID Then
                'Replace is declared as a string to read allLines form the file and close it
                'The line numbers can then be specified so the lines can be replaced with the text input into the textboxes
                Dim Replace() As String = System.IO.File.ReadAllLines(Directory)
                'The Goal, Raised and Gift Aid are all replaced with the new information input 
                Replace(Line + 3) = Goal.Text
                Replace(Line + 4) = Raised.Text
                Replace(Line + 5) = GiftAid.Text
                'Replaces the relevant lines
                System.IO.File.WriteAllLines(Directory, Replace)
                'Written to PersonalDetails.txt
                'Form closes
                Me.Close()
                'Else the user doesn't have that charity under their ID and is informed of that.
            Else
                MsgBox("That charity isn't under your user")
            End If
        End If
    End Sub

    'Subroutine CharityWrite
    Sub CharityWrite()
        Directory = File & Module1.CharityDirectory
        Dim objWriter As New System.IO.StreamWriter(Directory, True)
        'The ID and details inputted into the form are written to the file
        objWriter.WriteLine(WriteDetails.ID)
        objWriter.WriteLine(UserID)
        objWriter.WriteLine(WriteDetails.Charity)
        objWriter.WriteLine(WriteDetails.Goal)
        objWriter.WriteLine(WriteDetails.Raised)
        objWriter.WriteLine(WriteDetails.GiftAid)
        objWriter.Close()
        'Form closes
        Me.Close()
    End Sub

    'ID is declared as a public integer
    'This is public because it is accessed by several classes within the program
    Public ID As Integer
    'IDLine is declared as an integer
    'This is global so the class can access the lind of the User ID in the file being read.
    Dim IDLine As Integer

    'Private subroutine to run when ther form loads
    Private Sub InputCharity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Directory is set to the path for PastID.txt
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
            'The next line is read from the file and added to the list
            IDallLines.Add(IDReader.ReadLine)
        Loop
        'The file is closed
        IDReader.Close()
        'ID is declared as string
        'ID is set to the value in the first line of ID.txt
        Dim ID As String = ReadLine(0, IDallLines)

        'ParacyclistCheck subroutine is initiated passing ID through it to determine whether the user is a paracyclist or not.
        ParacyclistCheck(ID)

        'Directory is set to the directory of PersonalDetails.txt combining the path for MyDocuments (File) and the end of the path for PersonalDetails.txt
        'stores in Module1 as PersonalDirectory
        Directory = File & Module1.PersonalDirectory
        'Lines is declared to be used to find the length of PersonalDetails.txt
        'This reads all lines of PersonalDetails.txt and immediately closes the file.
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'IDLine is set to the length of PersonalDetails.txt - 6
        'This is because there is an ID every 6th line of the file so the most recent ID can be found by taking 6 from the length of the file
        IDLine = lines.Length - 6

        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader2 is declared as a Streamreader to read from PersonalDetails.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines would be '1' which would be a userID
        'another example would be 28/01/02 which would be the user's birthday.
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
        'ID is set to the value under the line number (stored in IDLine) in PersonalDetails.txt 
        ID = ReadLine(IDLine, allLines)
    End Sub

    'Public Function to allow for specific lines to be read from a file
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

End Class