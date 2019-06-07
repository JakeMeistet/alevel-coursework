'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'Since the prototype, the exit button has been moved to the log in screen which will close any of the open forms within the program if clicked. The icons have also been added for a more user-friendly interface.
'All files in the system are also created if they don't exist already on the device running the system. If the files have to be created then the pre-set information will be written and encrypted where necessary.

'System.IO is imported to the form
Imports System.IO

Public Class OpenScreen
    'CurrentDirectory is declared as a string
    'This is used to store the current directory/path that the
    'program is reading/writing from. This is a global variable
    'because it needs to be accessible from all procedures within the form
    'File is declared as the directory for MyDocuments for the computer the program is currently being run on
    Dim CurrentDirectory As String
    'File is declared as the directory/path of the MyDocuments folder for the computer that the program is being run on.
    'I have used this rather than hardwriting all directories because this allows for seamless use on different computers.
    'This is also used for the basis for all directories because the folder Cycling Tracker Final is made in MyDocuments.
    'The special folder locates the path for specific folders within the operating system
    Dim File = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

    'The register credentials are declared as strings
    'These are used to take the register credentials that the
    'user input into the relevant textboxes. These are global variables
    'because they need to be accessible in all procedures. These variables are written
    'to PersonalDetails.txt as well as the other information which is writtenm in the
    'InputPersonal.vb form.
    Public RegisterForename, RegisterSurname, RegisterPassword As String
    'NewID is declared as an integer
    'This is so that the program can generate a user ID 
    'for when a new user registers To the program
    'This is a global variable because the register button 
    'subroutine and the log in subroutine need to access the variable
    Dim NewID As Integer

    'Private sub to detect when the Register button is clicked
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        'If any of the register credentials are blank
        'The program will then display a messagebox asking the
        'user to input the relevant information. This prevents any errors
        'including the Argument Out Of Range exception when the program attempts
        'to read more lines than are actually in the file it's reading.
        If ForenameRegister.Text = "" Or SurnameRegister.Text = "" Or PasswordRegister.Text = "" Then
            MsgBox("Please input a valid forname, surname and password")
            'Else - None of the TextBoxes are blank therefore the error won't occur
            'So the program runs as normal and the user can register.
        Else
            If Module1.CheckForAlphaCharacters(ForenameRegister.Text) = False Or Module1.CheckForAlphaCharacters(SurnameRegister.Text) = False Then
                MsgBox("Please input a name without numbers")
            Else
                'Directory is declared as a string and is set to the directory of PersonalDetails.txt
                'This is used to make the directory for the current directory being read/written
                'from by combining File (the path for MyDocuments) with PersonalDirectory(PersonalDetails.txt)
                'which is stored within Module1.
                Dim Directory As String = File & Module1.PersonalDirectory
                'Lines is declared as a string to read all lines of PersonalDetails.txt
                'ReadAllLines reads all of the lines and then closes the program immediately afterwards
                'Used to find the length of PersonalDetails.txt
                Dim lines As String() = IO.File.ReadAllLines(Directory)
                'If the length of PersonalDetails.txt is equal to 0
                'This is used for validation to preven Argument Out of Range
                'Exceptions from occuring. Using if because it allows for else
                'to be used rather than repeating many Cases
                If lines.Length = 0 Then
                    'NewID is set to 0
                    'This is because there are no users currently
                    'Registered to the current version of the program if ran
                    'on a new system for the first time as this time the files
                    'are created.
                    NewID = 0
                    'A message box displays the NewID
                    'This is used to allow the user to login when they come back
                    'to the program after register, the user must remember the ID
                    'in order to actually access their profile within the program in the first time.
                    MessageBox.Show("Your login ID is " & NewID & " note it down as you can't log in without it!")
                    'The register details are set to the relevant information input into the textboxes   
                    RegisterForename = ForenameRegister.Text
                    RegisterSurname = SurnameRegister.Text
                    RegisterPassword = PasswordRegister.Text
                    'Write Subroutine is initiated, passing the register details through as well as the new user ID
                    Write(NewID, RegisterForename, RegisterSurname, RegisterPassword)
                    'Directory is set to the directory of PastID.txt
                    Directory = File & Module1.IDDirectory
                    'Objwriter is declared as a new StreamWriter so the most recent ID is written to PastID.txt
                    Dim objWriter As New System.IO.StreamWriter(Directory)
                    'The ID is written to the file
                    objWriter.WriteLine(NewID.ToString)
                    'The file is closed
                    objWriter.Close()
                    'Else
                Else
                    'Line is declared as the length of PersonalDetails.txt - 6
                    'This is used to find the previous UserID. There is an ID on every
                    '6th line within the file with the other details stored in between, hence - 6 
                    'to find the previous line containing an ID
                    Dim Line As Integer = lines.Length - 6
                    'Directory is set to the directory of PersonalDetails.txt
                    Directory = File & PersonalDirectory
                    'I have used this to read from a file rather than just using streamreader so that
                    'when I need to read a specific line from a file I can use the ReadLine function
                    'and simply enter the line number I would need.
                    'Reader is declared as a Streamreader to read from PersonalDetails.txt
                    Dim Reader As New System.IO.StreamReader(Directory)
                    'allLines is neclared as a list of string values
                    'An example of data stored under allLines would be '28/01/02' which could be a birthday
                    Dim allLines As List(Of String) = New List(Of String)
                    'Loop while Reader doesn't reach the end of the file
                    'This do while loop is used to read all of the lines in the necessary file
                    'and then store the next line read in the allLines list.
                    'I have chosen to use a do while because the loop must execute
                    'at least one or more times whereas if I used a normal while loop
                    'then I wouldn't know If I would need it to loop at all at runtime.
                    Do While Not Reader.EndOfStream
                        'The next line from the file is added to the list of string values(allLines)
                        allLines.Add(Reader.ReadLine)
                    Loop
                    'File is closed
                    Reader.Close()
                    'LastID is declared as an integer so that the last user ID can be written to a variable
                    Dim LastID As Integer
                    'LastID is set to the line containing the last user's in PersonalDetails.txt
                    LastID = ReadLine(Line, allLines)
                    'NewID is declared as the previous ID + 1
                    'UserID increments so the new user can be uniquly identified
                    NewID = LastID + 1
                    'The NewID is displayed to the user so that they are able to log in when they next come to the program.
                    MessageBox.Show("Your login ID is " & NewID & " note it down as you can't log in without it!")
                    'ID in the menu is set to NewID
                    'This displays the user's ID on form1 under the User information
                    Form1.ID = NewID
                    'The register details are set to the relevant information inputted into the textboxes
                    RegisterForename = ForenameRegister.Text
                    RegisterSurname = SurnameRegister.Text
                    RegisterPassword = PasswordRegister.Text
                    'Write Subroutine is initiated, passing the register details through
                    Write(NewID, RegisterForename, RegisterSurname, RegisterPassword)
                End If
            End If
        End If
    End Sub

    'Subroutine write with the register credentials and the new ID passed through ByVal
    Sub Write(ByVal NewID, ByVal RegisterForename, ByVal RegisterSurname, ByVal RegisterPassword)
        'Directory is declared as a string and set to the directory of PersonalDetails.txt
        Dim Directory As String = File & Module1.PersonalDirectory

        'objWriter is declared as a new StreamWriter to ammend to PersonalDetails.txt
        'Writing the first few personal details to the file
        'This includes the user's ID, Forename and Surname
        'The data is encrypeted with a ceaser cipher shift 2
        'ID is not encrypted
        Dim objWriter As New System.IO.StreamWriter(Directory, True)
        objWriter.WriteLine(NewID)
        objWriter.WriteLine(Module1.CC(RegisterForename, 2))
        objWriter.WriteLine(Module1.CC(RegisterSurname, 2))
        'File is closed
        objWriter.Close()
        'Directory is set to the directory of Passwords.txt
        Directory = File & Module1.PassDirectory
        'passWriter is declared as a new StreamWriter to ammend to Passwords.txt
        'Writing the password to the passwords file
        'The user ID is written to the file alonng with the encrypted password (shift 2)
        Dim passWriter As New System.IO.StreamWriter(Directory, True)
        passWriter.WriteLine(NewID)
        passWriter.WriteLine(Module1.CC(RegisterPassword, 2))
        'File is closed
        passWriter.Close()
        'The text in the textbox ID in Form1 is set to the user ID
        Form1.ID = NewID
        'InputPersonal.vb is opened
        InputPersonal.Show()
        'Form Closes
        Me.Close()
    End Sub

    'PersonalTrainer record is declared
    'This is used to store the personal trainer information so that the user can
    'go to the menu option and retieve contact details for personal trainers.
    Structure PersonalTrainer
        'The Trainer's Name, Location, Qualifications, Phone number and email are all stored under the structure
        'This is used to allow for all of the Trainer's information to be written to a file and encrypted so it can later be read
        Dim Name, Location, Qual, Number, Email As String
    End Structure

    'Known record is declard
    'This stores all of the known cyclists and their information
    'Used so the user can search for the statistics that these cyclists
    'completed LEJOG ride
    Structure Known
        'The Name, Year and Days that the pre-set cyclists completed Land's End to John O'Groats are stored under this record
        'This information will later be encrypted and written to a file to be read later.
        Dim Name, Year, Days As String
    End Structure


    'Private sub that runs when the form loads
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Message telling the user to register a user if the system is being used for the first time on a new system.
        MsgBox("You must register a user first in order to use the program if loading the program up for the first time on this device, you can register on the form that will load once this message is dismissed.")
        'InvalidPass label is hidden
        'This is only shown when a user's password input
        'is invalid and not equal to what is in the file.
        InvalidPass.Hide()
        'CheckDirectory is declared as a string which is used to store the 
        'directory for the file currently being read/written
        Dim CheckDirectory As String

        '_Path is declared as a folder in MyDocuments named 'Cycling Tracker Final'
        'Two strings are combined (File and 'Cycling Tracker Final'  to form the path for the folder
        Dim _Path = Path.Combine(File, "Cycling Tracker Final")

        'A search is then carried out in the scan file class
        'If the folder doesn't exist then the folderr will be created
        If Not Directory.Exists(_Path) Then
            Directory.CreateDirectory(_Path)
        End If

        'IPlist is declared as a new list of string values
        'The values in the list are the ends of the path of files to add onto the File variable to complete the path
        Dim IPList As New List(Of String) From {Module1.PersonalDirectory, Module1.IDDirectory, Module1.CyclingDirectory, Module1.CharityDirectory, Module1.PassDirectory, Module1.AdminPassDirectory, Module1.TrainDirectory, Module1.KnownDirectory, Module1.LineNoDirectory, Module1.ParaDirectory}
        'For i is equal to 0 to the length of the list - 1
        'Each file will be created if it doesn't exist already
        For i As Int32 = 0 To IPList.Count - 1
            'CurrentFile is declared and set to the current directory in IPList
            Dim CurrentFile = IPList(i)
            'CheckDirectory is set to the full combined path of the text file directory and that of MyDocuments
            CheckDirectory = File & CurrentFile
            'If the file doesn't exit it will be created
            If IO.File.Exists(CheckDirectory) = False Then
                Dim objWriter As New StreamWriter(CheckDirectory)
                'File closes
                objWriter.Close()
            End If
            'Next increment of i
        Next i
        'CurrentDirectory is set to the directory of the AdminPassword file (Admin.txt)
        CurrentDirectory = File & AdminPassDirectory
        'AdminWrite is declared as a neew StreamWriter to write the adminpassword to Admin.txt
        Dim AdminWrite As New StreamWriter(CurrentDirectory)
        'The admin password is encrypted by shift 2 and written to the file
        AdminWrite.WriteLine(Module1.CC("password", 2))
        'File closes
        AdminWrite.Close()
        '1D Array Trainer is declared with 11 values
        'It's declared as the Structure PersonalTrainer
        Dim Trainer(11) As PersonalTrainer
        'All of the personal trainer's information is written to the Trainer Array in the correct variable under the structure PersonalTrainer
        'Each number of the array corresponds to an individual's information
        'E.g. Trainer(0) stores all of Stuart Harper's information and Trainer(1) stores Stephen Biddulph's
        Trainer(0).Name = "Stuart Harper"
        Trainer(0).Location = "Cannock, Staffordshire"
        Trainer(0).Qual = "Level 2 Coach"
        Trainer(0).Number = "07976802170"
        Trainer(0).Email = "harper_stu@yahoo.co.uk"
        Trainer(1).Name = "Stephen Biddulph"
        Trainer(1).Location = "Burntwood, Staffordshire"
        Trainer(1).Qual = "Level 2 Track Coach, Level 3 RTT Coach"
        Trainer(1).Number = "07807722158"
        Trainer(1).Email = "steviebiddulph@googlemail.com"
        Trainer(2).Name = "Paul Bullock"
        Trainer(2).Location = "Stafford, Staffordshire"
        Trainer(2).Qual = "Level 2 Coach, Level 2 MTB Coach"
        Trainer(2).Number = "07925388413"
        Trainer(2).Email = "picard17@ntlworld.com"
        Trainer(3).Name = "Karen Langford"
        Trainer(3).Location = "Willenhall West Midlands"
        Trainer(3).Qual = "Level 2 Coach"
        Trainer(3).Number = "07961229787"
        Trainer(3).Email = "k.langford@live.co.uk"
        Trainer(4).Name = "Lisa Hemmings"
        Trainer(4).Location = "Uttoxeter, Staffordshire"
        Trainer(4).Qual = "Level 2 Coach"
        Trainer(4).Number = "07885213211"
        Trainer(4).Email = "lisa_leo@dsl.pipex.com"
        Trainer(5).Name = "Stephen  Bradley"
        Trainer(5).Location = "Tamworth, Staffordshire"
        Trainer(5).Qual = "Level 2 Cyclo-Cross Coach"
        Trainer(5).Number = "07775672011"
        Trainer(5).Email = "brad.steve@btinternet.com"
        Trainer(6).Name = "Richard Preece"
        Trainer(6).Location = "Newport, Shropshire"
        Trainer(6).Qual = "Level 2 Track & Cyclo-Cross Coach"
        Trainer(6).Number = "07715994360"
        Trainer(6).Email = "rdpreece100@gmail.com"
        Trainer(7).Name = "Peter Brown"
        Trainer(7).Location = "Birmingham, West Midlands"
        Trainer(7).Qual = "NSI Qualified"
        Trainer(7).Number = "07469741908"
        Trainer(7).Email = "petemite@gmail.com"
        Trainer(8).Name = "Allen Pettitt"
        Trainer(8).Location = "Derby, Derbyshire"
        Trainer(8).Qual = "Level 2 Track Coach"
        Trainer(8).Number = "07960410112"
        Trainer(8).Email = "thepettitts@btinternet.com"
        Trainer(9).Name = "Fiona Ridley"
        Trainer(9).Location = "Stoke-On-Trent, Staffordshire"
        Trainer(9).Qual = "Level 2 Track Coach"
        Trainer(9).Number = "07887800169"
        Trainer(9).Email = "fiona.ridley1@btinternet.com"
        Trainer(10).Name = "Hannah Escott"
        Trainer(10).Location = "Kidderminster, Worcestershire"
        Trainer(10).Qual = "Level 2 MTB Coach"
        Trainer(10).Number = "07790690078"
        Trainer(10).Email = "hannahescott@hotmail.co.uk"
        Trainer(11).Name = "Joanne Lifford"
        Trainer(11).Location = "Hinckley, Leicestershire"
        Trainer(11).Qual = "Level 2 Track Coach"
        Trainer(11).Number = "07590054548"
        Trainer(11).Email = "jolifford@gmail.com"

        '1D Array Cyclist is declared with 5 values
        'It is declareed as the structure Known
        'This is used to store all of the known cyclist's information
        Dim Cyclist(5) As Known
        'All of the known cyclist's information is written to the structure array
        'Each number in the array corresponds to an individual's information
        'E.g. Cyclist(0) is Bailey's information and Cyclist(1) is Broadwith's information
        Cyclist(0).Name = "Bailey"
        Cyclist(0).Year = "2016"
        Cyclist(0).Days = "11.5 days"
        Cyclist(1).Name = "Broadwith"
        Cyclist(1).Year = "2018"
        Cyclist(1).Days = "1.95 days"
        Cyclist(2).Name = "Wheal"
        Cyclist(2).Year = "2017"
        Cyclist(2).Days = "2.75 days"
        Cyclist(3).Name = "Lane"
        Cyclist(3).Year = "2014"
        Cyclist(3).Days = "2.5 days"
        Cyclist(4).Name = "Jones"
        Cyclist(4).Year = "2012"
        Cyclist(4).Days = "10 days"
        Cyclist(5).Name = "Baldwin"
        Cyclist(5).Year = "2016"
        Cyclist(5).Days = "7 days"

        'CurrentDirectory is set to the the directory of PersonalTrainer.txt
        'This is made through the combination the path for MyDocuments (file) with the end of the directory
        'for PersonalTrainer.txt stored in Module1 as TrainDirectory
        CurrentDirectory = File & Module1.TrainDirectory
        'TrainWrite is declared as a new StreamWriter to write to PersonalTrainer.txt
        Dim TrainWrite As New StreamWriter(CurrentDirectory)

        'For i is equal to 0 through 11
        'This is used to encrypt all of the personal trainer's information
        'This is done by shift 2
        For i = 0 To 11
            'All of the personal trainer's information is encrypted by shift 2
            Trainer(i).Name = Module1.CC(Trainer(i).Name, 2)
            Trainer(i).Location = Module1.CC(Trainer(i).Location, 2)
            Trainer(i).Qual = Module1.CC(Trainer(i).Qual, 2)
            Trainer(i).Number = Module1.CC(Trainer(i).Number, 2)
            Trainer(i).Email = Module1.CC(Trainer(i).Email, 2)
            'i increments by 1
        Next i

        'For i is equal to 0 through 11
        'This for loop is used to write the encrypted personal trainer information to PersonalTrainer.txt
        For i = 0 To 11
            'All of the encrypted personal trainer information is written to PersonalTrainer.txt
            TrainWrite.WriteLine(Trainer(i).Name)
            TrainWrite.WriteLine(Trainer(i).Location)
            TrainWrite.WriteLine(Trainer(i).Qual)
            TrainWrite.WriteLine(Trainer(i).Number)
            TrainWrite.WriteLine(Trainer(i).Email)
            'i increments by 1
        Next i
        'PersonalTrainer.txt is closed
        TrainWrite.Close()

        'CurrentDirectory is set to the the directory of KnownCyclists.txt
        'This is made through the combination the path for MyDocuments (file) with the end of the directory
        'for KnownCyclists.txt stored in Module1 as KnownDirectory
        CurrentDirectory = File & Module1.KnownDirectory
        'CycleWrite is declared as a New StreamWriter to write to KnownCyclists.txt
        Dim CycleWrite As New StreamWriter(CurrentDirectory)
        'For i is equal to 0 through 5
        'This for loop writes all of the known LEJOG cyclist's information to the KnownCyclists.txt file
        For i = 0 To 5
            'All of the known cyclist's information is written to the file
            CycleWrite.WriteLine(Cyclist(i).Name)
            CycleWrite.WriteLine(Cyclist(i).Year)
            CycleWrite.WriteLine(Cyclist(i).Days)
            'i increments by 1
        Next i
        'KnownCyclists.txt is closed
        CycleWrite.Close()

    End Sub

    'Provate sub to detect when the exit button is clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'All forms close and program shuts down
        Application.Exit()
    End Sub

    'Private sub to detect LogIn button click
    Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click
        'StrID is declared as a string
        Dim StrID As String
        'StrID is set as the text input into TxtID by the user (textbox)
        StrID = TxtID.Text

        'If the user ID input is blank
        'A messagebox will be displayed asking the user to input the relevant information
        If StrID = "" Then
            MsgBox("Please input an ID and Password")
        Else
            If IsNumeric(TxtID.Text) = False Then
                MsgBox("The ID must be an whole number e.g. 1")
            Else
                'NewID is set to StrID (converted to an integer from string)
                NewID = Convert.ToInt32(StrID)

                'Directory is set to the the directory of Passwords.txt
                'This is made through the combination the path for MyDocuments (file) with the end of the directory
                'for Passwords.txt stored in Module1 as PassDirectory
                Dim Directory As String = File & Module1.PassDirectory
                'lines is declared as a string of all lines read from Passwords.txt
                'This reads all lines from the file and immediately closes
                Dim lines As String() = IO.File.ReadAllLines(Directory)
                'I have used this to read from a file rather than just using streamreader so that
                'when I need to read a specific line from a file I can use the ReadLine function
                'and simply enter the line number I would need.
                'Reader is declared as a Streamreader to read from Passwords.txt
                Dim Reader As New System.IO.StreamReader(Directory)
                'allLines is declared as a list of string values
                'An example of data stored under allLines would be '1' which could be a userID
                Dim allLines As List(Of String) = New List(Of String)
                'To loop while Reader isn't at the end of the text file
                Do While Not Reader.EndOfStream
                    'Loop while Reader doesn't reach the end of the file
                    'This do while loop is used to read all of the lines in the necessary file
                    'and then store the next line read in the allLines list.
                    'I have chosen to use a do while because the loop must execute
                    'at least one or more times whereas if I used a normal while loop
                    'then I wouldn't know If I would need it to loop at all at runtime.
                    allLines.Add(Reader.ReadLine)
                Loop
                'Passwords.txt is closed
                Reader.Close()
                'If the length of Passwords.txt is less than 1
                'Used to prevent Argument Out Of Range Exceptions when the program is used for the first time
                If lines.Length < 1 Then
                    'The text of the label InvalidPass will be changed to "No Users"
                    'InvalidPass label is shown so the user is notified of this information.
                    InvalidPass.Text = "No Users"
                    InvalidPass.Show()
                    'Else - There are enough lines to be read from the file
                Else
                    'If the ID input buy the user (as an integer) is greater than the largest ID stored
                    'A messagebox will be displayed notifying the user that that user doesn't exist within the system
                    If Convert.ToInt64(TxtID.Text) > Convert.ToInt64(ReadLine(lines.Length - 2, allLines)) Then
                        MsgBox("User does not exist")
                        'Else - The user does exist and the password checks are performed
                    Else
                        If NewID < 0 Then
                            MsgBox("Please enter a user ID which is 0 or greater")
                        Else
                            'CheckID is declared as a string and set to read the user's ID line of Passwords.txt
                            Dim CheckID As String = ReadLine(NewID, allLines)
                            'Line is set to NewID * 2 to find the line of that user's data
                            Dim Line As String = NewID * 2
                            'Password is declared as a string and set to read the user ID's password in Passwords.txt
                            'The string read is then decrypted by using a shift of -2
                            Dim Password As String = Module1.CC(ReadLine(Line + 1, allLines), -2)
                            'If the text input in the textbox PasswordLogIn is equal to Password then the ID on the menu(Form1) is set to NewID
                            If PasswordLogIn.Text = Password Then
                                Form1.ID = NewID
                                'InvalidPass label is hidden
                                InvalidPass.Hide()
                                'FileRead subroutine is initiated
                                FileRead()
                                'The menu form is shown and the current form closes
                                Form1.Show()
                                Me.Close()
                                'Else InvalidPass label is shown
                                'Else - the password is incorrect
                            Else
                                'The invalid pass label is shown so the user knows that they have input the wrong password
                                InvalidPass.Show()
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    'Public structure is created 'PersonalDetails' containing all of the user's personal details as string values
    'This is used to store all of the user's information
    Public Structure PersonalDetails
        Public ID As String
        Public FName As String
        Public SName As String
        Public DOB As String
        Public Height As String
        Public Weight As String
    End Structure

    'Array ReadPersonal is declared as a public array with 5 elements
    'This is used when reading from the PersonalDetails.txt file
    Public ReadPersonal(5)

    'Public sub FileRead
    Public Sub FileRead()
        'Line is declared and set to NewID multiplied by 6
        'This is used to find the line of the user's data because in the file the user ID is on every 6th line
        Dim Line As Integer = NewID * 6
        'Directory is declared as a string and set to the directory for PersonalDetails.txt
        'PersonalDetails.txt is opened to be read from
        Dim Directory As String = File & Module1.PersonalDirectory
        'Reader is declared as a new StreamReader to read from the file PersonalDetails.txt
        Dim Reader As New System.IO.StreamReader(Directory)
        'allLines is declared as a list of String values
        Dim allLines As List(Of String) = New List(Of String)
        'Loop while Reader isn't at the end of the file
        Do While Not Reader.EndOfStream
            'The next line read is added to the list allLines
            allLines.Add(Reader.ReadLine())
        Loop
        'The file is closed
        Reader.Close()
        'Values in ReadPersonal array are set to the relevant data read from PersonalDetails.txt
        'All of the details excluding the user ID is encrypted by shift 2
        ReadPersonal(0) = ReadLine(Line, allLines)
        ReadPersonal(1) = Module1.CC(ReadLine(Line + 1, allLines), 2)
        ReadPersonal(2) = Module1.CC(ReadLine(Line + 2, allLines), 2)
        ReadPersonal(3) = Module1.CC(ReadLine(Line + 3, allLines), 2)
        ReadPersonal(4) = Module1.CC(ReadLine(Line + 4, allLines), 2)
        ReadPersonal(5) = Module1.CC(ReadLine(Line + 5, allLines), 2)
    End Sub

    'Public function to allow specific lines to be read from a file
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        'lines(LineNumber) is returned to allow the user to read specific lines from a file.
        Return lines(lineNumber)
    End Function

    'Private subroutine to detect keypresses
    'I have used this to allow for keyboard shortcuts for expert users
    'The F keys are assignes to the Login, Exit and Register buttons.
    'This means when those keyboard keys are pressed then it acts as a button click for those buttons
    Private Sub OpenScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                BtnLogIn.PerformClick()
            Case Keys.F2
                BtnExit.PerformClick()
            Case Keys.F3
                BtnRegister.PerformClick()
        End Select
    End Sub
End Class