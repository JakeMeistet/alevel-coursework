'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This hasn't really been changed since the prototype other then the icons within the interface to make it more user-friendly.

'System.IO is imported to the form
Imports System.IO

Public Class PersonalTrainer
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

    'Line is declared as an integer and set to 0
    'This is used to determine what line is read from a file
    Dim Line As Integer = 0

    'This subroutine has been used to check whether a user is a paracyclist or not.
    'The checks made in this subroutine are necessary for changes in the GUI or changes 
    'with suggestions for equipment the user can use. The subroutine also allows for disabled 
    'users to be taken into account with my system. When the user registers for the first time 
    'they will be asked whether they are a paracyclist this then leads to a menu to specify 
    'what bike they have to use when cycling which then allows for the necessary changes to be made.
    Sub ParacyclistCheck()

        'The directory is set to a combination of the path for MyDocuments with the end of the
        'path stored under IDDirectory within Module1
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
            'The next line is read from the file and is added to the list
            IDallLines.Add(IDReader.ReadLine)
        Loop
        'The file is closed
        IDReader.Close()
        'ID is declared as string
        'ID is set to the value in the first line of ID.txt
        Dim ID As String = ReadLine(0, IDallLines)

        'The directory is set to a combination of the path for MyDocuments with the end of the
        'path stored under ParaDirectory within Module1
        Directory = File & Module1.ParaDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader2 is declared as a Streamreader to read from Paracyclists.txt
        Dim Reader2 As New System.IO.StreamReader(Directory)
        'allLines2 is declared as a list of string values
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
            'The next line is then read from the file and added to the list
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
            Dim LblList As New List(Of Label) From {LabelName, LabelLocation, LabelEmail, LabelMobile, LabelQual}
            'For i is equal to 0 through to he length of LblList - 1
            For i As Int32 = 0 To LblList.Count - 1
                'Current label colour is set to white and the font is made bold
                LblList(i).ForeColor = Color.White
                LblList(i).Font = Module1.BoldFont
                'i increments by 1
            Next i
            'The title colour is set to white
            LblTrainer.ForeColor = Color.White
        End If
    End Sub

    'Private sub to run when the form loads
    Private Sub PersonalTrainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ParacyclistCheck sub runs to check if any GUI changes need to be made
        ParacyclistCheck()
        'The directory is set to a combination of the path for MyDocuments with the end of the
        'path stored under TrainDirectory within Module1
        Directory = File & Module1.TrainDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader2 is declared as a Streamreader to read from Paracyclists.txt
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
        'The textbox's text in the form are set to the relevant infomration read from PersonalTrainer.txt
        'This includes the first personal trainer's information
        'This information is decrypted first using a shift of -2
        TrainerName.Text = Module1.CC(ReadLine(Line, allLines), -2)
        TrainerLoc.Text = Module1.CC(ReadLine(Line + 1, allLines), -2)
        TrainerQual.Text = Module1.CC(ReadLine(Line + 2, allLines), -2)
        TrainerMob.Text = Module1.CC(ReadLine(Line + 3, allLines), -2)
        TrainerEmail.Text = Module1.CC(ReadLine(Line + 4, allLines), -2)
    End Sub

    'Public Function to allo for specific lines to be read from a file
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        'lines(lineNumber) is returned to allow specific lines to be read from a file
        Return lines(lineNumber)
    End Function

    'Private subroutine to detect refresh button to be clicked
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'Line is incremented by 5
        Line = Line + 5
        'The directory is set to a combination of the path for MyDocuments with the end of the
        'path stored under TrainDirectory within Module1
        Directory = File & Module1.TrainDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader2 is declared as a Streamreader to read from Paracyclists.txt
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
        'If the name of the next personal trainer is Joanne Lifford, the refresh button will be disabled
        'Prevents Argument Out Of Range Exception
        If TrainerName.Text <> "Joanne Lifford" Then
            'The textbox's text in the form are set to the relevant infomration read from PersonalTrainer.txt
            'This includes the first personal trainer's information
            'This information is decrypted first using a shift of -2
            TrainerName.Text = Module1.CC(ReadLine(Line, allLines), -2)
            TrainerLoc.Text = Module1.CC(ReadLine(Line + 1, allLines), -2)
            TrainerQual.Text = Module1.CC(ReadLine(Line + 2, allLines), -2)
            TrainerMob.Text = Module1.CC(ReadLine(Line + 3, allLines), -2)
            TrainerEmail.Text = Module1.CC(ReadLine(Line + 4, allLines), -2)
            'Else
        Else
            btnRefresh.Enabled = False
            'The textbox's text in the form are set to the relevant infomration read from PersonalTrainer.txt
            'This includes the first personal trainer's information
            'This information is decrypted first using a shift of -2
            'TrainerName.Text = Module1.CC(ReadLine(Line, allLines), -2)
            'TrainerLoc.Text = Module1.CC(ReadLine(Line + 1, allLines), -2)
            'TrainerQual.Text = Module1.CC(ReadLine(Line + 2, allLines), -2)
            'TrainerMob.Text = Module1.CC(ReadLine(Line + 3, allLines), -2)
            'TrainerEmail.Text = Module1.CC(ReadLine(Line + 4, allLines), -2)
        End If
    End Sub

    'Private sub to detect done button click
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        'Form closes
        Me.Close()
    End Sub
End Class