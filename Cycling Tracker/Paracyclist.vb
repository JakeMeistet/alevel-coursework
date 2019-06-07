'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images7

'Since the prototype, this form has been added to take into account disabled users. During registration, the user has the ability to say whether they are a paracyclist or not, if they choose yes, they will be taken to this form to specify what bike they must use.

Public Class Paracyclist

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

    'Private subroutine to detect the click of the submit button
    Private Sub btnKeep_Click(sender As Object, e As EventArgs) Handles btnKeep.Click
        'The directory is made using a combination of the MyDocuments path with then end of the
        'path stored as ParaDirectory within Module1
        Directory = File & Module1.ParaDirectory
        'Lines is declared as a string which reads allLines from Paracyclists.txt
        'The file is immediately closed but lines can be used to find the length of the file
        Dim lines As String() = IO.File.ReadAllLines(Directory)
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader is declared as a Streamreader to read from Paracyclist.txt
        'ID.txt is opened so it can be read from
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is declared as a list of string values
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
        'The file is then closed
        Reader.Close()
        'The lastID is declared and found by reading the file at line - 2 from the length.
        'There is an ID every2 lines hence - 2 from the length
        Dim LastID As Integer = ReadLine(lines.Length - 2, allLines)
        'ID is declared as an integer as is set to one more than the previous 
        Dim ID As Integer = LastID + 1

        'The directory is made using a combination of the MyDocuments path with then end of the
        'path stored as ParaDirectory within Module1
        Directory = File & Module1.ParaDirectory

        'Option chosen is declared as a string and is changed depending on what bike the user has selected.
        'This is the written to the file
        Dim OptionChosen As String
        'If the first checkbox is checked then
        If Option1.Checked = True Then
            'The option chosen id changed to the relevant bike
            'Allows for checks to be made for why a user is a paracyclist
            OptionChosen = "C1 - C5"
            'objWriter is declared as a streamwriter to ammend to Paracyclists.txt
            Dim objWriter As New System.IO.StreamWriter(Directory, True)
            'The userID and the option chosen is written to the file.
            objWriter.WriteLine(ID)
            objWriter.WriteLine(OptionChosen)
            'File is closed
            objWriter.Close()
            'The paracyclist boolean in Module1 is set to true so the program can identify the user as a paracyclist
            Module1.Paracyclist = True
            'The menu is shown
            Form1.Show()
            'This form is closed
            Me.Close()
            'If the second checkbox is checked then
        ElseIf Option2.Checked = True Then
            'The option chosen id changed to the relevant bike
            'Allows for checks to be made for why a user is a paracyclist
            OptionChosen = "T1 - T2"
            'objWriter is declared as a streamwriter to ammend to Paracyclists.txt
            Dim objWriter As New System.IO.StreamWriter(Directory, True)
            'The userID and the option chosen is written to the file.
            objWriter.WriteLine(ID)
            objWriter.WriteLine(OptionChosen)
            'File is closed
            objWriter.Close()
            'The paracyclist boolean in Module1 is set to true so the program can identify the user as a paracyclist
            Module1.Paracyclist = True
            'The menu is shown
            Form1.Show()
            'This form is closed
            Me.Close()
            'If the third checkbox is checked then
        ElseIf Option3.Checked = True Then
            'The option chosen id changed to the relevant bike
            'Allows for checks to be made for why a user is a paracyclist
            OptionChosen = "H1 - H5"
            'objWriter is declared as a streamwriter to ammend to Paracyclists.txt
            Dim objWriter As New System.IO.StreamWriter(Directory, True)
            'The userID and the option chosen is written to the file.
            objWriter.WriteLine(ID)
            objWriter.WriteLine(OptionChosen)
            'File is closed
            objWriter.Close()
            'The paracyclist boolean in Module1 is set to true so the program can identify the user as a paracyclist
            Module1.Paracyclist = True
            'The menu is shown
            Form1.Show()
            'This form is closed
            Me.Close()
            'If the fourth checkbox is checked then
        ElseIf Option4.Checked = True Then
            'The option chosen id changed to the relevant bike
            'Allows for checks to be made for why a user is a paracyclist
            OptionChosen = "B"
            'objWriter is declared as a streamwriter to ammend to Paracyclists.txt
            Dim objWriter As New System.IO.StreamWriter(Directory, True)
            'The userID and the option chosen is written to the file.
            objWriter.WriteLine(ID)
            objWriter.WriteLine(OptionChosen)
            'File is closed
            objWriter.Close()
            'The paracyclist boolean in Module1 is set to true so the program can identify the user as a paracyclist
            Module1.Paracyclist = True
            'The menu is shown
            Form1.Show()
            'This form is closed
            Me.Close()
            'No Checkboxes are checked
        Else
            'User must select a checkbox
            MsgBox("Please select one of the boxes")
        End If

    End Sub

    'Sub check is used to prevent more than one 
    'option from being checked at any one point
    'hence the 4 if statements, one for each button
    Sub Check()
        If Option1.Checked = True Then
            Option2.Checked = False
            Option3.Checked = False
            Option4.Checked = False
        ElseIf Option2.Checked = True Then
            Option1.Checked = False
            Option3.Checked = False
            Option4.Checked = False
        ElseIf Option3.Checked = True Then
            Option1.Checked = False
            Option2.Checked = False
            Option4.Checked = False
        ElseIf Option4.Checked = True Then
            Option1.Checked = False
            Option2.Checked = False
            Option3.Checked = False
        End If
    End Sub

    'These four subroutines run the check subroutine when the check is changed so that only one can be selected at any one time
    Private Sub Option1_CheckedChanged(sender As Object, e As EventArgs) Handles Option1.CheckedChanged
        Check()
    End Sub

    Private Sub Option2_CheckedChanged(sender As Object, e As EventArgs) Handles Option2.CheckedChanged
        Check()
    End Sub

    Private Sub Option3_CheckedChanged(sender As Object, e As EventArgs) Handles Option3.CheckedChanged
        Check()
    End Sub

    Private Sub Option4_CheckedChanged(sender As Object, e As EventArgs) Handles Option4.CheckedChanged
        Check()
    End Sub

    'Public function to return the line read from a file within the form
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

End Class