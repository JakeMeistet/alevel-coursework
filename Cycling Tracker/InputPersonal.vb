'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This has remained the same for the most part. The only changes sare the button image as well as the checkbox which allows the user to identify whether or not they are a paracyclist.
'If this checkbox is checked then the user is taken to a different form before the menu to enter what bike type they have to use.

'System.IO is imported into the class so that files can be read from/written to
Imports System.IO
Public Class InputPersonal

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

    'The record PersonalWrite is created
    'PersonalWrite stors the DOB, Height and Weight as Strings
    'This record is used to write these details to the PersonalDetails file because the user's Forename and Surname have already been written to the file.
    'This will complete the user's personal details.
    Structure PersonalWrite
        Dim DOB, Height, Weight As String
    End Structure

    'This boolean is used within subroutines in this class/form and is used to check whether a user is a paracyclist or not.
    'This variable is global because it is used in several subroutines.
    Dim BParacyclist As Boolean = False

    'Subroutine CheckBoxCheck is used to check whether the paracyclists checkbox has been checked within the form
    'The sub will change the state of BParacyclist to determine whether a user is a paracyclist or not
    Sub CheckBoxCheck()
        'This if statement checks whether the checkbox for paracyclists is actually checked
        'If it is true then the boolean is changed and the subroutine ends.
        If CheckBox1.Checked = True Then
            BParacyclist = True
            'Else - information is written to Paracyclists.txt which states that this user is not a paracyclist
        Else
            'Firstly the ID is found
            'The directory is set to the path for PastID.txt
            Directory = File & Module1.IDDirectory
            'I have used this to read from a file rather than just using streamreader so that
            'when I need to read a specific line from a file I can use the ReadLine function
            'and simply enter the line number I would need.
            'Reader is declared as a Streamreader to read from PastID.txt
            Dim Reader As New System.IO.StreamReader(Directory)
            'allLines is neclared as a list of string values
            'An example of data stored under allLines would be '1' which would be a user
            Dim allLines As List(Of String) = New List(Of String)
            'Loop while Reader doesn't reach the end of the file
            'This do while loop is used to read all of the lines in the necessary file
            'and then store the next line read in the allLines list.
            'I have chosen to use a do while because the loop must execute
            'at least one or more times whereas if I used a normal while loop
            'then I wouldn't know If I would need it to loop at all at runtime.
            Do While Not Reader.EndOfStream
                'The next line is read from the file and added to the allLines list
                allLines.Add(Reader.ReadLine())
            Loop
            'The file is then closed
            Reader.Close()

            'ID is declared as a string
            'The ID is then read from the first line of the text file
            Dim ID As String = ReadLine(0, allLines)
            'BParacyclist boolean is set to false
            'This identifies this user as not a paracyclist
            BParacyclist = False
            'The directory is then set to the path for Paracyclists.txt
            'This is done by combining the path for MyDocuments (File) with the add on to the path
            'stored under ParaDirectory in Module1
            Directory = File & Module1.ParaDirectory
            'objWriter is declared as a streamwriter to ammend to Paracyclists.txt
            Dim objWriter As New System.IO.StreamWriter(Directory, True)
            'The user's ID is written to the file along with the textx 'N/A'
            'this text identifies the user as not being a Paracyclist
            objWriter.WriteLine(ID)
            objWriter.WriteLine("N/A")
            'The file is then closed and the subroutine is closed
            objWriter.Close()
        End If
    End Sub

    'Private sub to detect when the submit button is clicked
    Private Sub BtnKeep_Click(sender As Object, e As EventArgs) Handles btnKeep.Click
        'These are all validation checks to ensure that the user inputs the relevant information
        'This also avoids any potential error such as Argument Out Of Range Exception
        'The first check checks whether ther height values, weight values and the dob values are numeric or not
        'If not then the user is informed that the inputs must be numeric and not include any letters
        If IsNumeric(Foot.Text) = False Or IsNumeric(Inches.Text) = False Or IsNumeric(Stone.Text) = False Or IsNumeric(Pounds.Text) = False Or IsNumeric(Day.Text) = False Or IsNumeric(Month.Text) = False Or IsNumeric(Year.Text) = False Then
            MsgBox("One or more of your inputs are not numbers, re enter your information.")
            'Else - the inputs are numeric then further checks run
        Else
            If Foot.Text < 1 Or Inches.Text < 1 Or Stone.Text < 1 Or Pounds.Text < 1 Then
                MsgBox("The Height and weight values cannot be less than 1")
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
                                MsgBox("The measurements inputs are incorrect")
                                'Else the details are written to the personalwrite structure under the variable write
                            Else
                                'Write is declared as the record PersonalWrite
                                'This ise used to write all of the date to the PersonalDetails.txt file
                                Dim Write As PersonalWrite
                                'PersonalWrite's DOB is stored as the day, month and year input
                                Write.DOB = (Day.Text & "/" & Month.Text & "/" & Year.Text)
                                'PersonalWrites's Height is set to the feet and inches input
                                Write.Height = (Foot.Text & "ft " & Inches.Text & "in")
                                'PersonalWrites's Weight is set to the stone and pounds input
                                Write.Weight = (Stone.Text & "st " & Pounds.Text & "lb")
                                'PersonalWriter subroutine is initiated passing the varible 'Write' through
                                PersonalWriter(Write)
                                'The CheckBoxCheck subroutine is run to check if the user is a paracyclist or not
                                CheckBoxCheck()
                                'Paracyclist checks are run with the BParacyclist variable
                                'If the user is a paracyclist then the Paracyclist form shows and this form closes
                                If BParacyclist = True Then
                                    Paracyclist.Show()
                                    Me.Close()
                                    'Else - the user isn't a paracyclist
                                Else
                                    'The menu shows and this form closes
                                    Form1.Show()
                                    Me.Close()
                                End If

                            End If
                        End If
                    End If
                Else
                    MsgBox("The date is written in the incorrect format")
                End If
            End If
        End If


    End Sub

    'Subroutine PersonalWriter 
    'This is used to write all of the user's details to a file once checks have validated the input data,
    Sub PersonalWriter(ByVal Write)
        'The directory is set to the path for PersonalDetails.txt
        'This is done by combining the path of MyDocuments (File) with the end directory of PersonalDetails.txt
        'Stored in Module1 as PersonalDirectory
        Directory = File & Module1.PersonalDirectory
        'PersonalDetails.txt is opened and ammended to
        'This uses objWriter as a streamwriter to write to PersonalDetails.txt
        Dim objWriter As New System.IO.StreamWriter(Directory, True)
        'The DOB, Height and Weight are all stored to the file
        objWriter.WriteLine(Module1.CC(Write.DOB, 2))
        objWriter.WriteLine(Module1.CC(Write.Height, 2))
        objWriter.WriteLine(Module1.CC(Write.Weight, 2))
        'The file is closed
        objWriter.Close()
    End Sub

    'Private sub to run when the form loads
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The text of textboxes FName and SName are set to the Forname and Surname inputted on the OpenScreen form
        FName.Text = OpenScreen.RegisterForename
        SName.Text = OpenScreen.RegisterSurname
    End Sub

    'Public function to return the line read from a file within the form
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

End Class