'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images
'System.IO is imported for the form to use

'Since the prototype, all the new icons have been added to the buttons on the menu as well as keyboard shortcuts being added. This takes into account expert users who can quickly navigate the system.
'All buttons are now enabled because all of the sections have been developed for the final system. The user can now sign out and return to the log in screen instead of just exiting the program and having to re load it again.

Imports System.IO

'Form1 is the main navigation for my project where this form acts as the menu to access all elements of the program.
'Once signed in, this form will be opened where the user's information is displayed and they can choose any of the options
'within the menu so they can choose what they want to do with the program and can user it how they want to.
Public Class Form1
    'ID is declared as a public integer to be used to store the current user ID
    'IDLine and Line are declared as integers which are used to determine
    'the startline for each user's information as well as finding the
    'line for the user's ID in PersonalDetails.txt
    'StrID is declared as string which is used to store a string version
    'of the userID for when initially reading the ID from the file.
    Public ID As Integer
    Dim IDLine As Integer
    Dim Line As Integer
    Dim StrID As String

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
    Sub ParacyclistCheck()
        'Directory is set to the directory/path for Paracyclists.txt
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
        'The file is closed
        Reader2.Close()

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
        'If ParaCheck is equal to 'N/A' then the txt in the TxtPara textbox on the menu is set to 'No'
        'This shows that the user isn't a paracyclist
        'The boolean Paracyclist in Module1 is then set to False
        'and allows the other forms to take that boolean to check whether
        'a user is a paracyclist or not.
        If ParaCheck = "N/A" Then
            TxtPara.Text = "No"
            Module1.Paracyclist = False
            'Else (The other possibilities would be 'C1 - C5',
            ''T1 - T2', 'B' and 'H1 - H5' which the user specifies
            'if they enter the paracyclist options during register.
        Else
            'The text in the TxtPara textbox on the menu is set to 'Yes' - This shows that this user is a paracyclist
            'The boolean Paracyclist in Module1 is then set to True
            TxtPara.Text = "Yes"
            Module1.Paracyclist = True
        End If
        'If ParaCheck = 'B'
        'B means that the user has to user a tandem bike and is therefore visually impaired
        'This check is used to determine whether the colours for the forms need to be changed
        'in order for the user to be able to read and understand what the program is doing.
        If ParaCheck = "B" Then
            'The background colour of the program is set to black and all the labels on the form are set to white
            'This allows for a higher contrast mode so that if the cyclist just has poor vision it may be easier to read.
            Me.BackColor = Color.Black
            'LblList is declared as a list of labels including all the labels on the form
            'This is used so that a for loop can be used to repeat the code for each label in the list
            'Makes the program more efficient so that I don't have to repeat the colour and font change
            'for every label within the form.
            Dim LblList As New List(Of Label) From {Label1, Label2, Label3, Label4, Label5, LblPara}
            'For i is 0 through to the length of LblList - 1
            'The colours are then changed and the text is made bold
            For i As Int32 = 0 To LblList.Count - 1
                LblList(i).ForeColor = Color.White
                LblList(i).Font = Module1.BoldFont
                'i increments by 1 to change the font and colour of the next label within the list.
            Next i
            'The User label colour is set to white.
            'This is separate from the list and for loop because the title isn't set to bold.
            LblUser.ForeColor = Color.White
        End If

    End Sub

    'Private sub which is ran when the form first loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ParacyclistCheck subroutine is ran to check whether a user is disabled or not.
        ParacyclistCheck()
        'Directory is set to the directory for PersonalDetails.txt using file (the special folder path for MyDocuments)
        'as well as the readonly public string PersonalDirectory in Module1 to finish the end of the path to reach the text file.
        Directory = File & Module1.PersonalDirectory
        'IDLine is set to itself multiplied by 6
        'This is used to find the start line for the user's information in PersonalDetails.txt
        'IDLine finds the user ID in PersonalDetails.txt because it uses the ID to sign in multiplied by 6
        'The ID is stored every 6 lines within PersonalDetails.txt, hence ID * 6
        IDLine = 6 * ID
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a new StreamReader to read from PersonalDetails.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines2 would be '1' which would be a userID
        'another example would be 28/01/02 which would be a user's birthday.
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while Reader2 doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines2 list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime
        Do While Not Reader.EndOfStream
            'The next line of the file is read and added to the allLines list
            allLines.Add(Reader.ReadLine())
        Loop
        'The file is closed
        Reader.Close()
        'Personal Details are read from PersonalDetails.txt
        'FName, SName, DOB, Height1 and Weight are all textboxes where the data read from the file is set to
        'In the PersonalDetails.txt the forname is stored 1 line after the ID and the surname would be 2 lines after
        'this is why the readline function is used with IDLine + x (x being a value) because it corresponds to the number
        'of lines after the ID to retrieve the relevant data.
        'All the details are decrypted using a shift of -2 to revert the shift used originally
        'Module1.CC is the Cipher function stored in Module1 so that all forms can encrypt/decrypt when needed
        'Here the details are read using the readline function and then ar decrypted using Module1.CC
        FName.Text = Module1.CC(ReadLine(IDLine + 1, allLines), -2)
        SName.Text = Module1.CC(ReadLine(IDLine + 2, allLines), -2)
        DOB.Text = Module1.CC(ReadLine(IDLine + 3, allLines), -2)
        Height1.Text = Module1.CC(ReadLine(IDLine + 4, allLines), -2)
        Weight.Text = Module1.CC(ReadLine(IDLine + 5, allLines), -2)
        Directory = File & Module1.IDDirectory
        'objWriter is declared as a StreamWriter to write to PastID.txt
        'This overwrites every time and writes the latest user ID to the file for easy access throughout the system
        'This is used as a temporary store for the current user's ID which allows for easy retrival for when the program
        'requires searches to display the data relevant to the user.
        Dim objWriter As New System.IO.StreamWriter(Directory)
        'ID is written to the file
        objWriter.WriteLine(ID)
        'File is closed
        objWriter.Close()



    End Sub

    'Private sub to detect PersonalInput button clicked
    Private Sub PersonalInput_Click(sender As Object, e As EventArgs)
        'InputPersonal.vb form is opened
        InputPersonal.Show()
    End Sub

    'Private sub to detect CyclingButton button clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCycling.Click
        'InputCycling.vb is opened
        InputCycling.Show()
    End Sub

    'Public function to return the line read from a file within the form
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        'lines(lineNumber) is returned from the function to allow the user to read specific lines
        Return lines(lineNumber)
    End Function

    'Private sub to detect CharityButton clicked
    Private Sub BtnCharity_Click(sender As Object, e As EventArgs) Handles BtnCharity.Click
        'InputCharity.vb is opened
        InputCharity.Show()
    End Sub

    'Private sub to detect PersonalTrainer button clicked
    Private Sub BtnPersonalTrainer_Click(sender As Object, e As EventArgs) Handles BtnPersonalTrainer.Click
        'PersonalTrainer.vb is opened
        PersonalTrainer.Show()
    End Sub

    'Private sub to detect CyclistSearch button clicked
    Private Sub BtnCyclistSearch_Click(sender As Object, e As EventArgs) Handles BtnCyclistSearch.Click
        'SearchMenu.vb is opened
        SearchMenu.Show()
    End Sub

    'Private sub to detect PersonalTracking button clicked
    Private Sub BtnPTracking_Click(sender As Object, e As EventArgs) Handles BtnPTracking.Click
        'Tracking.vb is opened
        Tracking.Show()
    End Sub

    'Private sub to detect TrainingButton clicked
    Private Sub BtnTrainingR_Click(sender As Object, e As EventArgs) Handles BtnTrainingR.Click
        'Training.vb is opened
        Training.Show()
    End Sub

    'Private sub to detect UpdatePersonal button clicked
    Private Sub BtnUpdatePersonal_Click(sender As Object, e As EventArgs) Handles BtnUpdatePersonal.Click
        'UpdatePersonal.vb is opened
        UpdatePersonal.Show()
    End Sub

    'Private sub to detect Exit button clicked
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'OpenScreen.vb is opened
        OpenScreen.Show()
        'Form1 is closed
        Me.Close()
    End Sub

    'Private sub to detect UpdatePassword button clicked
    Private Sub BtnUpdatePass_Click(sender As Object, e As EventArgs) Handles BtnUpdatePass.Click
        'UpdatePass.vb is opened
        UpdatePass.Show()
    End Sub

    'Private sub to detect Equipment button clicked
    Private Sub BtnEquipment_Click(sender As Object, e As EventArgs) Handles BtnEquipment.Click
        'Equipment.vb is opened
        Equipment.Show()
    End Sub

    'Private sub to detect CharityStatistics button clicked
    Private Sub BtnCharityStats_Click(sender As Object, e As EventArgs) Handles BtnCharityStats.Click
        'CharityDirectory is declared as a string equal to the directory for CharityDetails.txt
        'This uses the global variable File to retrive the directory for the MyDocuments folder
        'It then combines that path with the rest of the path for CharityDetails.txt so that the file can be read from
        Directory = File & Module1.CharityDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a new StreamReader to read from CharityDetails.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is neclared as a list of string values
        'An example of data stored under allLines2 would be '1' which would be a userID
        'another example would be 100 which would be the calories.
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while Reader2 doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines2 list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime
        Do While Not Reader.EndOfStream
            'The next line is read from CharityDetails.txt and is added to the allLines list
            allLines.Add(Reader.ReadLine())
        Loop
        'The file is closed
        Reader.Close()
        'CheckNumber is declared and set to 0
        'CheckNumber is used as a line number to read from CharityDetails.txt
        'It can include any non-decimal numbers e.g. 2
        Dim CheckNumber As Integer = 0
        'CheckID is declared as a string
        'CheckID is used to asign the read ID from CharityDetails.txt
        'Will store strings such as '1' or '4'
        Dim CheckID As String
        'Directory is set to the directory of CharityDetails.txt
        'The path is made by combining the path of the MyDocuments folder(from File)
        'With the extra part of the directory (CharityDirectory) stored in Module1
        Directory = File & Module1.CharityDirectory
        'Lines is declared as a string to read all lines of CharityDetails.txt
        'ReadAllLines reads all lines from a text file and then closes the file immediately after
        'This is used to find the length of the file
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'If the length of CharityDetails is less than 1
        'Used to prevent Argument Out Of Range Exception errors.
        'A messagebox will tell the user that they have no records
        'therefore they can't currently use this function of the program
        'until they input a fundraiser.
        If lines.Length < 1 Then
            MsgBox("There are no records for this user")
            'Else - When there are enough lines to be read the program will allow the user to enter the CharityInformation form.
        Else
            'CheckID is set to the first line read from CharityDetails.txt
            CheckID = ReadLine(CheckNumber, allLines)
            'Do while loop used to loop as long as checkID doesn't equal ID
            'Do while loop used because the search needs to be executed at leat one time
            'If the search doesn't run at least then no search will have occured and the
            'form will never open.
            Do While CheckID <> ID.ToString
                'If CheckNumber + 6 is greater than or equal to the length of CharityDetails.txt then the do loop is exited
                'Prevents an argument out of range exception if the user hasn't got any information input into CharityDetails.txt
                If CheckNumber + 6 >= lines.Length Then
                    Exit Do
                End If
                'CheckNumber increments by 6
                'The ID is on every 6th line of the file
                CheckNumber = CheckNumber + 6
                'CheckID is set to the value of the next incremented line read in CharityDetails.txt
                CheckID = ReadLine(CheckNumber, allLines)
                'Directory is set to the directory/path of LineNumbers.txt
                'A combination of File (The directory/path for MyDocuments and the end of the path
                'stored under LineNoDirectory in Module1.
                Directory = File & Module1.LineNoDirectory
                'The Line number of CheckID Is written to LineNumbers.txt And the file Is closed
                'objWriter1 is declared as a New StreamWriter to overwrite CharityDetails.txt
                'This is used to write the linenumbers for the user's information from CharityDetails.txt
                Dim objWriter1 As New System.IO.StreamWriter(Directory)
                'CheckNumber is written to LineNumbers.txt
                objWriter1.WriteLine(CheckNumber)
                'The file is closed
                objWriter1.Close()
                'Loop ends when criteria is met
            Loop

            'lines1 is declared as a string to read all lines from CharityDetails.txt
            'Used to find the length of the file
            'ReadAllLines reads all lines from the requested file and then closes the file.
            Dim lines1 As String() = IO.File.ReadAllLines(Directory)

            'If the length of LineNumber.txt is less than 1 then the form will display a messagebox saying that there aren't enough records to give enough information
            'This prevents argument out of range exceptions from happening when the program tries to read more lines than are actually in the file.
            If lines1.Length < 1 Then
                MsgBox("There aren't enough records to give any information")
                'Else the CharityInformation form is opened allowing the user to see their charity statistics
            Else
                'CharityInformation.vb is opened
                CharityInformation.Show()
            End If
        End If

    End Sub

    'Private sub to detect Leaderboard button clicked
    Private Sub BtnLeaderboard_Click(sender As Object, e As EventArgs) Handles BtnLeaderboard.Click
        'Leaderboard.vb is opened
        Leaderboard.Show()
    End Sub

    'Private subroutine to detect any keypresses within form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Select Case statement used to specify what each keypress does
        'F1 through to F12 keys are used as keyboard shortcuts for all the buttons.
        'Each button is then assigned to Perform a click for it's relevant button.
        'This is used for expert users to more easily navigate around the program.
        Select Case e.KeyCode
            Case Keys.F1
                BtnCycling.PerformClick()
            Case Keys.F2
                BtnLeaderboard.PerformClick()
            Case Keys.F3
                BtnCyclistSearch.PerformClick()
            Case Keys.F4
                BtnCharity.PerformClick()
            Case Keys.F5
                BtnPTracking.PerformClick()
            Case Keys.F6
                BtnCharityStats.PerformClick()
            Case Keys.F7
                BtnTrainingR.PerformClick()
            Case Keys.F8
                BtnPersonalTrainer.PerformClick()
            Case Keys.F9
                BtnEquipment.PerformClick()
            Case Keys.F10
                BtnUpdatePersonal.PerformClick()
            Case Keys.F11
                BtnUpdatePass.PerformClick()
            Case Keys.F12
                BtnExit.PerformClick()
        End Select
    End Sub
End Class
