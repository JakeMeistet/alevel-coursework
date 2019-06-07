'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'Most of this has remained the same, apart from the icons being added to each of the menu options

Public Class Equipment
    'File is declared as the directory/path of the MyDocuments folder for the computer that the program is being run on.
    'I have used this rather than hardwriting all directories because this allows for seamless use on different computers.
    'This is also used for the basis for all directories because the folder Cycling Tracker Final is made in MyDocuments.
    'The special folder locates the path for specific folders within the operating system
    Dim File = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

    'MClick is declared as a boolean and set to false
    'This public variable is used to determine which button is clicked
    'This also needs to be accessed from the suggestions class, hence it's public
    Public MClick As Boolean = False
    'Private sub to detect Maintainence button click
    Private Sub BtnMaintainence_Click(sender As Object, e As EventArgs) Handles BtnMaintainence.Click
        'MClick is set to true and Suggestions.vb is opened, the form then closes
        MClick = True
        Suggestions.Show()
        Me.Close()
    End Sub
    'CClick is declared as a boolean and set to false
    'This public variable is used to determine which button is clicked
    'This also needs to be accessed from the suggestions class, hence it's public
    Public CClick As Boolean = False
    Private Sub BtnClothing_Click(sender As Object, e As EventArgs) Handles BtnClothing.Click
        'CClick is set to true and Suggestions.vb is opened, the form then closes
        CClick = True
        Suggestions.Show()
        Me.Close()
    End Sub
    'BClick is declared as a boolean and set to false
    'This public variable is used to determine which button is clicked
    'This also needs to be accessed from the suggestions class, hence it's public
    Public BClick As Boolean = False
    Private Sub BtnBike_Click(sender As Object, e As EventArgs) Handles BtnBike.Click
        'BClick is set to true and Suggestions.vb is opened, the form then closes
        BClick = True
        Suggestions.Show()
        Me.Close()
    End Sub

    Private Sub Equipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Directory is declared as a string to store the currently being used
        'path of a file to read/write
        Dim Directory As String
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
            'The next line of the file is read and added to the IDallLines list of strings
            IDallLines.Add(IDReader.ReadLine)
            'Loop ends once IDReader reaches the end of the file
        Loop
        'FIle is closed
        IDReader.Close()
        'ID is declared as string
        'ID is set to the value in the first line of ID.txt
        'This is used to find the most recent userID which is written to
        'PastID.txt when the user registers/logs in, the file is overwritten
        'every time so the most recent ID is always on line 0
        Dim ID As String = ReadLine(0, IDallLines)
        'ParacyclistCheck subroutine is called passing the parameter ID through
        ParacyclistCheck(ID)
    End Sub

    'This subroutine has been used to check whether a user is a paracyclist or not.
    'The checks made in this subroutine are necessary for changes in the GUI or changes 
    'with suggestions for equipment the user can use. The subroutine also allows for disabled 
    'users to be taken into account with my system. When the user registers for the first time 
    'they will be asked whether they are a paracyclist this then leads to a menu to specify 
    'what bike they have to use when cycling which then allows for the necessary changes to be made.
    Sub ParacyclistCheck(ByVal ID)
        'Directory is declared as a string to store the current path of the file that if being read/written
        Dim Directory As String
        'The directory of Paracylists.txt is made using the path for MyDocuments and the end of the path ine Module1 ParaDirectory
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

        'If ParaCheck is equal to 'N/A'
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
            'The boolean paracyclist in Module1 is set to true because the user has been found to be a paracyclist
            Module1.Paracyclist = True
        End If

        'If ParaCheck is equal to B
        'B represents the type of bike that the paracyclist must use.
        'In this case they use a tandem bike and are therefore visually impaired
        'This simple check will change the colours of the form, making the labels white
        'and making the background black for a high contrast mode.
        If ParaCheck = "B" Then
            Me.BackColor = Color.Black
            Me.BackColor = Color.Black
            LblEquipment.ForeColor = Color.White
        End If

    End Sub

    'Public function to return the line read from a file within the form
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        'lines(lineNumber) is returned to allow for the specific line to be read from the list/file
        Return lines(lineNumber)
    End Function

End Class