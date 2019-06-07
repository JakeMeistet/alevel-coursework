'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This has been added since the prototype where this form allows for the user to input the number of ours they train per week and then a strategy is output to the user.

Public Class Training
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

    'Private sub to detect when submit button is clicked
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        'Clears the list view so the suggested training can be used again without closing and re opening the menu option
        ListSport.Items.Clear()
        'If the text in the input textbox is blank or not numeric, the user will be asked to input the hours they train
        If TxtInput.Text = "" Or IsNumeric(TxtInput.Text) = False Or TxtInput.Text < 0 Then
            MsgBox("Please input the hours you train")
            'Once the data input is valid then the program will suggest the relevant raining the user should do.
        Else
            Dim Input As Integer = TxtInput.Text
            'If input is less than 10 then the relevant information will be output to the listbox
            If Input < 10 Then
                'If the user is a paracyclist then the running will be removed from the training suggestions
                'The hours will increase for one of the other suggestions
                If Module1.Paracyclist = True Then
                    TxtHoursTo.Text = 10 & " Hours"
                    TxtMilesTo.Text = 20 & " Miles"
                    ListSport.Items.Add("4 Hours")
                    ListSport.Items.Add("Cycling")
                    ListSport.Items.Add("3 Hours")
                    ListSport.Items.Add("Cardio")
                    ListSport.Items.Add("3 Hours")
                    ListSport.Items.Add("Anything else")
                Else
                    'The normal suggestions are made based on the original hours input by the user
                    TxtHoursTo.Text = 10 & " Hours"
                    TxtMilesTo.Text = 20 & " Miles"
                    ListSport.Items.Add("4 Hours")
                    ListSport.Items.Add("Cycling")
                    ListSport.Items.Add("1 Hour")
                    ListSport.Items.Add("Running")
                    ListSport.Items.Add("3 Hours")
                    ListSport.Items.Add("Cardio")
                    ListSport.Items.Add("2 Hours")
                    ListSport.Items.Add("Anything else")
                End If
                'If input is less than 15 then the relevant information will be output to the listbox
            ElseIf Input < 15 Then
                'If the user is a paracyclist then the running will be removed from the training suggestions
                'The hours will increase for one of the other suggestions
                If Module1.Paracyclist = True Then
                    TxtHoursTo.Text = 5 & " Hours"
                    TxtMilesTo.Text = 10 & " Miles"
                    ListSport.Items.Add("2 Hours")
                    ListSport.Items.Add("Cycling")
                    ListSport.Items.Add("1.5 Hours")
                    ListSport.Items.Add("Cardio")
                    ListSport.Items.Add("1.5 Hours")
                    ListSport.Items.Add("Anything else")
                Else
                    'The normal suggestions are made based on the original hours input by the user
                    TxtHoursTo.Text = 5 & " Hours"
                    TxtMilesTo.Text = 10 & " Miles"
                    ListSport.Items.Add("2 Hours")
                    ListSport.Items.Add("Cycling")
                    ListSport.Items.Add("0.5 Hours")
                    ListSport.Items.Add("Running")
                    ListSport.Items.Add("1.5 Hours")
                    ListSport.Items.Add("Cardio")
                    ListSport.Items.Add("1 Hours")
                    ListSport.Items.Add("Anything else")
                End If
                'Else, the relevant information will be output to the listbox
            Else
                'If the user is a paracyclist then the running will be removed from the training suggestions
                'The hours will increase for one of the other suggestions
                If Module1.Paracyclist = True Then
                    TxtHoursTo.Text = 2.5 & " Hours"
                    TxtMilesTo.Text = 5 & " Miles"
                    ListSport.Items.Add("1 Hours")
                    ListSport.Items.Add("Cycling")
                    ListSport.Items.Add("0.75 Hours")
                    ListSport.Items.Add("Cardio")
                    ListSport.Items.Add("0.75 Hours")
                    ListSport.Items.Add("Anything else")
                Else
                    'The normal suggestions are made based on the original hours input by the user
                    TxtHoursTo.Text = 2.5 & " Hours"
                    TxtMilesTo.Text = 5 & " Miles"
                    ListSport.Items.Add("1 Hours")
                    ListSport.Items.Add("Cycling")
                    ListSport.Items.Add("0.25 Hour")
                    ListSport.Items.Add("Running")
                    ListSport.Items.Add("0.75 Hours")
                    ListSport.Items.Add("Cardio")
                    ListSport.Items.Add("0.5 Hours")
                    ListSport.Items.Add("Anything else")
                End If

            End If
        End If
    End Sub

    'Private sub to detect when the Done button is clicked
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        'Form closes
        Me.Close()
    End Sub

    Private Sub Training_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ParacyclistCheck()
    End Sub

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
            Dim LblList As New List(Of Label) From {LblHoursTo, LblMilesTo, TrainingHours, LblHoursOf}
            'For i is equal to 0 through to he length of LblList - 1
            For i As Int32 = 0 To LblList.Count - 1
                'Current label colour is set to white and the font is made bold
                LblList(i).ForeColor = Color.White
                LblList(i).Font = Module1.BoldFont
                'i increments by 1
            Next i
            'The title colour is set to white
            'The listbox font is made bold and white where its background is made black
            ListSport.Font = Module1.BoldFont
            ListSport.ForeColor = Color.White
            ListSport.BackColor = Color.Black
            LblTraining.ForeColor = Color.White
        End If
    End Sub

    'Public function used to allow for the specific lines to be returned when requested through the program
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

End Class