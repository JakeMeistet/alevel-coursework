'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'Two more searches have been added since the prototype where if the user has the admin password they can search through all of the user's cycling information and the user can search through some Land's End to John O'Groats statistics.

Public Class SearchMenu
    'CurrentDirectory is declared as a string
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

    'Private sub to detect if the user wants to search known cyclists (ButtonKnown)
    Private Sub BtnKnown_Click(sender As Object, e As EventArgs) Handles BtnKnown.Click
        'KnownSearch.vb is opened and the form is closed
        KnownSearch.Show()
        Me.Close()
    End Sub

    'Private sub to detect if the user wants to search their own details (ButtonPersonal)
    Private Sub BtnPersonal_Click(sender As Object, e As EventArgs) Handles BtnPersonal.Click
        'UserSearch.vb is opened and the forms is closed
        UserSearch.Show()
        Me.Close()
    End Sub

    'Private sub to detect if the user wants to search other user's data (ButtonOther)
    Private Sub BtnOther_Click(sender As Object, e As EventArgs) Handles BtnOther.Click
        'Admin login page is shown
        'This will allow the user to log in to view all account data if they know the admin password
        LblAdmin.Show()
        LblPassword.Show()
        TxtPassword.Show()
        BtnAdmin.Show()
        BtnBack.Show()
        'Search buttons are hidden
        BtnPersonal.Hide()
        BtnOther.Hide()
        BtnKnown.Hide()
        LblSearch.Hide()
        'Message to tell the user that the admin password is 'password'
        MsgBox("The admin password is 'password'")
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
        'ID is set to the value in the first line of ID.txt
        Dim ID As String = ReadLine(0, IDallLines)
        'The Directory is set to the directory of Paracyclists.txt
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
        'Line is declared as an integer which Is used to specify the line that Is read to find the user's information
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
            'All labels are made white and the font of the password label is made bold
            LblPassword.ForeColor = Color.White
            LblPassword.Font = Module1.BoldFont
            LblSearch.ForeColor = Color.White
            LblAdmin.ForeColor = Color.White
        End If

    End Sub

    'Private sub to run when the form loads
    Private Sub SearchMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ParacyclistCheck()
        'Admin login page is hidden
        LblAdmin.Hide()
        LblPassword.Hide()
        TxtPassword.Hide()
        BtnAdmin.Hide()
        InvalidPass.Hide()
        BtnBack.Hide()
    End Sub

    'Private sub to detect when the admin login button is clicked
    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        'PassDirectory is declared as a string
        'PassDirectory is set to the directory of Admin.txt
        Directory = File & Module1.AdminPassDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from AdminPassword.txt
        'AdminPassword.txt is opened so it can be read from
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is declared as a list of string values
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
        'The file is then closed
        Reader.Close()

        'If the password input is equal to the password in the file then AdminSearch.vb is opened
        'The password is decrypted here by shift -2
        If TxtPassword.Text = Module1.CC(ReadLine(0, allLines), -2) Then
            'AdminSearch class/form is shown and the form closes
            AdminSearch.Show()
            Me.Close()
            'Else InvalidPass Label is shown because the password was incorrect
        Else
            MsgBox("Invalid Password")
        End If
    End Sub

    'Public function is used read specific lines from a file
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        'Goes back to the normal menu for searches
        'Admin login page is hidden
        LblAdmin.Hide()
        LblPassword.Hide()
        TxtPassword.Hide()
        BtnAdmin.Hide()
        BtnBack.Hide()
        'Search buttons are shown
        BtnPersonal.Show()
        BtnOther.Show()
        BtnKnown.Show()
        LblSearch.Show()
    End Sub

    'Private subroutine to detect keypresses
    'I have used this to allow for keyboard shortcuts for expert users
    'The F keys are assignes to the 3 options to search from the buttons.
    'This means when those keyboard keys are pressed then it acts as a button click for those buttons
    Private Sub OpenScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                BtnPersonal.PerformClick()
            Case Keys.F2
                BtnOther.PerformClick()
            Case Keys.F3
                BtnKnown.PerformClick()
        End Select
    End Sub

End Class