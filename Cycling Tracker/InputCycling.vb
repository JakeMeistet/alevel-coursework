'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This form, for the most part has remained the same apart from the images for the button being added since the prototype.

'System.IO is imported into the class to allow for files to be read from/written to.
Imports System.IO
Public Class InputCycling

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

    'Record 'CycleInput' is created storing all the variables including ID, Speed, Distance, Time, Calories, Day, Month and Year
    'This is used to store all of the information tha the user inputs into the form all under one record.
    Structure CycleInput
        Dim ID As Integer
        Dim Speed As Decimal
        Dim Distance As Decimal
        Dim Time As Decimal
        Dim Calories As Decimal
        Dim Day, Month, Year As String
    End Structure

    'Variable 'Write' is declared as the structure CycleInput
    'This is used to the write the information in CycleInput into a file when needed
    Dim Write As CycleInput

    'Private subroutine to detect submit button click
    Private Sub BtnKeep_Click(sender As Object, e As EventArgs) Handles btnKeep.Click
        'I have used if statements because it allows for elses to be used and several nested if statements for validation
        'These are all validation checks to ensure that the user inputs the correct information
        'The first check runs to see wether he user has left any blanks in the information and if so the user is informed of the mistakes they can change.
        If Speed.Text = "" Or Distance.Text = "" Or Time.Text = "" Or Calories.Text = "" Or Day.Text = "" Or Month.Text = "" Or Year.Text = "" Then
            If IsNumeric(Speed.Text) = False Or IsNumeric(Distance.Text) = False Or IsNumeric(Time.Text) = False Or IsNumeric(Calories.Text) = False Or IsNumeric(Day.Text) = False Then
                MsgBox("Make sure all of your inputs are numbers")
            Else
                MsgBox("There are blanks in your information, ensure you input all the relevant information.")
            End If
            'Else - The textboxes are all filled in the next set of validation is run to ensure that the correct information is input 
        Else
            'The inputs for speed, distance, time, calories and dates are all checked for wether they are numeric
            'If not then the user is informed that they all must be numeric - they must then input the information again
            If IsNumeric(Speed.Text) = False Or IsNumeric(Distance.Text) = False Or IsNumeric(Time.Text) = False Or IsNumeric(Calories.Text) = False Or IsNumeric(Day.Text) = False Or IsNumeric(Month.Text) = False Or IsNumeric(Year.Text) = False Then
                MsgBox("One or more of your inputs are not numbers, re enter your information.")
                'Else - all the values inpu are numeric which is the correct format so further checks run.
            Else
                'The dates must be a length of 2 so they are therfore checked with this nested if statement
                'If they are 2 in length then further checks are made to see whether the date exists or not.
                If Day.Text.Length = 2 And Month.Text.Length = 2 And Year.Text.Length = 2 Then
                    'If the day is above 31, or less than one, the same applies for month however the max limit is 12 and for year if it's greater than the current year then the date doesn't exist
                    'The user is informed of this and has to input a correct date.
                    If Day.Text > 31 Or Day.Text < 1 Or Month.Text > 12 Or Month.Text < 1 Or Year.Text > 19 Then
                        MsgBox("That date doesn't exist")
                        'Else - as far as we know so far the date exists unless it's in february, leap year checks run.
                    Else
                        'If the month is feburary and the day is greater than 29 then the user is told the date doesn't exist
                        'I havent included full leap year checks because that would require a full date and calendar system to know when the leap years occurred.
                        If Month.Text = "02" And Day.Text > 29 Then
                            MsgBox("That date doesn't exist")
                            'Else - the format checks and presence checks have finished and the data input by the user is assigned to the variable write
                            'this variable uses the record/structure CycleInput
                        Else
                            'These variables are then used to write to the file
                            'They are written to CyclingDetails.txt so the user can use the
                            'main features of the program e.g. Leaderboard and Tracking
                            'ID from CycleInput record is set to the variable ID in Form1
                            Write.ID = Form1.ID
                            'Variables within CycleInput record are set to the text inputted in the form
                            Write.Speed = Speed.Text
                            Write.Distance = Distance.Text
                            Write.Time = Time.Text
                            Write.Calories = Calories.Text
                            Write.Day = Day.Text
                            Write.Month = Month.Text
                            Write.Year = Year.Text

                            'Directory is set to the CyclingDetails.txt directory
                            'This allows for this file to be written to
                            'The path is made by combining the path for MyDocuments (File) as well as the end of the path
                            'for CyclingDetails.txt stored in Module1 as CyclingDirectory
                            Directory = File & Module1.CyclingDirectory
                            'objWriter is then opened to write the cycling details to the file
                            'objWriter uses a streamwriter and persumes that the file already exists (which it should because if not the program makes it at the beginning)
                            Dim objWriter As New StreamWriter(Directory, True)
                            'All of the details are written to the file including the ID for identificaiton purposes.
                            objWriter.WriteLine(Write.ID)
                            objWriter.WriteLine(Write.Day & "/" & Write.Month & "/" & Write.Year)
                            objWriter.WriteLine(Write.Speed)
                            objWriter.WriteLine(Write.Distance)
                            objWriter.WriteLine(Write.Time)
                            objWriter.WriteLine(Write.Calories)
                            'File is closed and the form is closed
                            objWriter.Close()
                            Me.Close()
                        End If
                    End If
                    'Else - The inputs failed the format checks and the user is told that the date is written in the incorrect format.
                Else
                    MsgBox("The date is written in the incorrect format")
                End If
            End If
        End If
    End Sub

    'Private form to set the textof the FName and SName textboxes to the FName and SNames in Form1
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Simply sets the inputs by the user for their forname and surname to that of the forname and surname texbox within Form1
        FName.Text = Form1.FName.Text
        SName.Text = Form1.SName.Text
        'ParacyclistCheck subroutine is called to make any necessary changes if they user is a paracyclist
        ParacyclistCheck()
    End Sub

    'This subroutine has been used to check whether a user is a paracyclist or not.
    'The checks made in this subroutine are necessary for changes in the GUI or changes 
    'with suggestions for equipment the user can use. The subroutine also allows for disabled 
    'users to be taken into account with my system. When the user registers for the first time 
    'they will be asked whether they are a paracyclist this then leads to a menu to specify 
    'what bike they have to use when cycling which then allows for the necessary changes to be made.
    Sub ParacyclistCheck()
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
            'The next line is read from the file and added to IDallLines list
            IDallLines.Add(IDReader.ReadLine)
        Loop
        'The file is closed
        IDReader.Close()
        'ID is declared as string
        'ID is set to the value in the first line of ID.txt
        Dim ID As String = ReadLine(0, IDallLines)
        'The paths for MyDocuments and the end path for Paracyclists.txt are combined to give the full directoyr for Paracyclists.txt
        Directory = File & Module1.ParaDirectory
        'I have used this to read from a file rather than just using streamreader so that
        'when I need to read a specific line from a file I can use the ReadLine function
        'and simply enter the line number I would need.
        'Reader2 is declared as a Streamreader to read from Paracyclists.txt
        Dim Reader2 As New System.IO.StreamReader(Directory)
        'allLines2 is neclared as a list of string values
        'An example of data stored under allLines2 would be '1' which would be a userID
        'another example would be 'C1 - C5' which would be the bike the paracyclist uses
        Dim allLines2 As List(Of String) = New List(Of String)
        'Loop while Reader2 doesn't reach the end of the file
        'This do while loop is used to read all of the lines in the necessary file
        'and then store the next line read in the allLines2 list.
        'I have chosen to use a do while because the loop must execute
        'at least one or more times whereas if I used a normal while loop
        'then I wouldn't know If I would need it to loop at all at runtime.
        Do While Not Reader2.EndOfStream
            'The next line is read from the file and added to the list allLines2
            allLines2.Add(Reader2.ReadLine())
        Loop
        'The file is then closed
        Reader2.Close()
        'Line is declared as an integer and will be used to identify which line is to be read from in the file
        Dim Line As Integer
        'If the userID is 0 then the line is set to 0 because the user with ID 0's information starts at line 0 within this file
        If ID = 0 Then
            Line = 0
            'Else - the line is set to the ID * 2
            'This is because every 2 lines in the file
            'there is a new ID
        Else
            Line = ID * 2
        End If

        'Paracheck is declared as a string
        'It is set to the value of the line after the ID line because this includes the necessary information
        'to identify whether the user is a paracyclist or not.
        Dim ParaCheck As String = ReadLine(Line + 1, allLines2)

        'If ParaCheck is read and it equals 'N/A' then the program knows that this user isn't a paracyclist
        'hence the boolean Paracyclist in Module1 is set to false so al classes can then use this boolean to identify if the user is a paracyclist or not if needed
        If ParaCheck = "N/A" Then
            Module1.Paracyclist = False
            'Else - the program knows the user is a paracyclist and therefore sets the boolean Paracylist in Module1 to True
        Else
            Module1.Paracyclist = True
        End If

        'This check is used to identify if the user is needing a tandem bike and therefore is visally impaired.
        'If so then the program will make the program turn to a high contrast mode which is much more easy for the user to view.
        If ParaCheck = "B" Then
            'The background of the form is set to black
            Me.BackColor = Color.Black
            'This List of labels is used to use a for loop to set every label within the form to a bold font with wite text.
            Dim LblList As New List(Of Label) From {Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16}
            'For loop which loops to the end of the list of labels setting them all to the bold white font.
            For i As Int32 = 0 To LblList.Count - 1
                LblList(i).ForeColor = Color.White
                LblList(i).Font = Module1.BoldFont
                'i Increments by 1
            Next i
            'The title is made white
            'This isn't included in the loop because it is a larger size than the other labels and is already bold.
            LblInputCycling.ForeColor = Color.White
        End If

    End Sub

    'Public Function to allow for specific lines to be read from a file
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

End Class