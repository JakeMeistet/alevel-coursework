'All icons for all buttons are from https://icons8.com/icons where all credit goes to them for the images

'This works in the same way as it did in the prototype, however depending on whether the user is a paracyclist or not, and what specific bike they use then different information will be output to the listbox instead.

Public Class Suggestions

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

    'Private sub to detect if Done button is clicked
    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        'Form closes
        Me.Close()
    End Sub

    'This subroutine has been used to check whether a user is a paracyclist or not.
    'The checks made in this subroutine are necessary for changes in the GUI or changes 
    'with suggestions for equipment the user can use. The subroutine also allows for disabled 
    'users to be taken into account with my system. When the user registers for the first time 
    'they will be asked whether they are a paracyclist this then leads to a menu to specify 
    'what bike they have to use when cycling which then allows for the necessary changes to be made.
    Sub ParacyclistCheck()
        'Directory is set to the path of PastID.txt
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
            'The next line is read from the file and added to IDallLines list
            IDallLines.Add(IDReader.ReadLine)
        Loop
        'The file is closed
        IDReader.Close()
        'ID is declared as string
        'ID is set to the value in the first line of ID.txt
        Dim ID As String = ReadLine(0, IDallLines)
        'Directory is set to the directory for Paracyclists.txt
        'This is done by combining the path for MyDocuments stored under the variable
        'File with the end of the directory for Paracyclists.txt stored in Module1
        'as ParaDirectory.
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
            'The next line is read and added to the allLines2 list
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

        If ParaCheck = "B" Then
            'The background will be made black and the labels will be made white
            'The Listbox is also given white text with a black background
            Me.BackColor = Color.Black
            LblEquipment.ForeColor = Color.White
            ListBox1.ForeColor = Color.White
            ListBox1.BackColor = Color.Black
            'These check which button was clicked and therefore suggests the relevant equipment
            'These maintainence equipment suggestions are the same for all cyclists, however the bikes and clothing change based on disablity
            If Equipment.MClick = True Then
                ListBox1.Items.Add("Item1 - X-Tools Home Truing Stand - £40")
                ListBox1.Items.Add("Allows for you to replace spokes if needed and true(straighten) your wheel at home")
                ListBox1.Items.Add("https://bit.ly/2F2ILv1")
                ListBox1.Items.Add("Item2 - LifeLine Essential Track Pump - £15")
                ListBox1.Items.Add("Allow for the tyre to be inflated")
                ListBox1.Items.Add("https://bit.ly/2F3AQN5")
                ListBox1.Items.Add("Item3 - Park Tool VP11 Puncture Repair Kit - £2")
                ListBox1.Items.Add("Allows for you to repair a punctured tyre")
                ListBox1.Items.Add("https://bit.ly/2s2nVDx")
                'Else
            Else
                'If CClick = True then the relevant information will be displayed in the listbox 
                If Equipment.CClick = True Then
                    ListBox1.Items.Add("Item1 - Altura Thermo Elite Overshoe - £35")
                    ListBox1.Items.Add("Makes cycling shoes waterproof and keeps heat")
                    ListBox1.Items.Add("https://bit.ly/2GPGoNN")
                    ListBox1.Items.Add("Item2 - Specialized Torch 1.0 Road Shoe - £80")
                    ListBox1.Items.Add("Shoes with Cleats")
                    ListBox1.Items.Add("https://bit.ly/2AtFQYa")
                    ListBox1.Items.Add("Item3 - B'TWIN Cycling Tights Mens/Womens - £15 - £35")
                    ListBox1.Items.Add("Trousers to wear whilst cycling on the road")
                    ListBox1.Items.Add("Mens - https://bit.ly/2RpbSyu, Womens - https://bit.ly/2BTnyje")
                    'Else
                Else
                    'If BClick = True then the relevant information will be displayed in the listbox 
                    'Tandem bikes suggested
                    If Equipment.BClick = True Then
                        ListBox1.Items.Add("Item1 - Ridgeback Panorama Tandem - £1799")
                        ListBox1.Items.Add("Complete tandem bike")
                        ListBox1.Items.Add("https://bit.ly/2RUDXtF")
                        ListBox1.Items.Add("Item2 - Dawes Galaxy Twin Tandem - £2000")
                        ListBox1.Items.Add("Complete mid-range tandem bike")
                        ListBox1.Items.Add("https://bit.ly/2GDHM4b")
                        ListBox1.Items.Add("Item3 - Orbit Tandems Velocity Lite - £2200")
                        ListBox1.Items.Add("Top-range tandem bike")
                        ListBox1.Items.Add("https://bit.ly/2Sr0kvX")
                        'Else
                    Else
                        'Form closes
                        Me.Close()
                    End If
                End If
            End If
        ElseIf ParaCheck = "H1 - H5" Then
            'These check which button was clicked and therefore suggests the relevant equipment
            'These maintainence equipment suggestions are the same for all cyclists, however the bikes and clothing change based on disablity
            If Equipment.MClick = True Then
                ListBox1.Items.Add("Item1 - X-Tools Home Truing Stand - £40")
                ListBox1.Items.Add("Allows for you to replace spokes if needed and true(straighten) your wheel at home")
                ListBox1.Items.Add("https://bit.ly/2F2ILv1")
                ListBox1.Items.Add("Item2 - LifeLine Essential Track Pump - £15")
                ListBox1.Items.Add("Allow for the tyre to be inflated")
                ListBox1.Items.Add("https://bit.ly/2F3AQN5")
                ListBox1.Items.Add("Item3 - Park Tool VP11 Puncture Repair Kit - £2")
                ListBox1.Items.Add("Allows for you to repair a punctured tyre")
                ListBox1.Items.Add("https://bit.ly/2s2nVDx")
                'Else
            Else
                'If CClick = True then the relevant information will be displayed in the listbox 
                'Some different clothing suggested
                If Equipment.CClick = True Then
                    ListBox1.Items.Add("Item1 - Kalf Club Thermal Long Sleeve Jersey - £37.50")
                    ListBox1.Items.Add("Used during the winter to keep warm")
                    ListBox1.Items.Add("https://bit.ly/2WX0tG6")
                    ListBox1.Items.Add("Item2 - FWE Multi-lens no fog glassses - £29.99")
                    ListBox1.Items.Add("Glasses to wear to protect eyes")
                    ListBox1.Items.Add("https://bit.ly/2hpnVcB")
                    ListBox1.Items.Add("Item3 - B'TWIN Cycling Tights Mens/Womens - £15 - £35")
                    ListBox1.Items.Add("Trousers to wear whilst cycling on the road")
                    ListBox1.Items.Add("Mens - https://bit.ly/2RpbSyu, Womens - https://bit.ly/2BTnyje")
                    'Else
                Else
                    'If BClick = True then the relevant information will be displayed in the listbox 
                    'Hand bikes suggested
                    If Equipment.BClick = True Then
                        ListBox1.Items.Add("Item1 - Attitude Manual")
                        ListBox1.Items.Add("Hand Bike")
                        ListBox1.Items.Add("https://bit.ly/2UUsufA")
                        ListBox1.Items.Add("Item2 - Attitude Power")
                        ListBox1.Items.Add("Hand Bike")
                        ListBox1.Items.Add("https://bit.ly/2tjX06w")
                        ListBox1.Items.Add("Item3 - Attitude Hybrid")
                        ListBox1.Items.Add("Hand Bike")
                        ListBox1.Items.Add("https://bit.ly/2WXCarh")
                        'Else
                    Else
                        'Form closes
                        Me.Close()
                    End If
                End If
            End If
        ElseIf ParaCheck = "C1 - C5" Or ParaCheck = "N/A" Then
            'These check which button was clicked and therefore suggests the relevant equipment
            'These maintainence equipment suggestions are the same for all cyclists, however the bikes and clothing change based on disablity
            If Equipment.MClick = True Then
                ListBox1.Items.Add("Item1 - X-Tools Home Truing Stand - £40")
                ListBox1.Items.Add("Allows for you to replace spokes if needed and true(straighten) your wheel at home")
                ListBox1.Items.Add("https://bit.ly/2F2ILv1")
                ListBox1.Items.Add("Item2 - LifeLine Essential Track Pump - £15")
                ListBox1.Items.Add("Allow for the tyre to be inflated")
                ListBox1.Items.Add("https://bit.ly/2F3AQN5")
                ListBox1.Items.Add("Item3 - Park Tool VP11 Puncture Repair Kit - £2")
                ListBox1.Items.Add("Allows for you to repair a punctured tyre")
                ListBox1.Items.Add("https://bit.ly/2s2nVDx")
                'Else
            Else
                'If CClick = True then the relevant information will be displayed in the listbox 
                If Equipment.CClick = True Then
                    ListBox1.Items.Add("Item1 - Altura Thermo Elite Overshoe - £35")
                    ListBox1.Items.Add("Makes cycling shoes waterproof and keeps heat")
                    ListBox1.Items.Add("https://bit.ly/2GPGoNN")
                    ListBox1.Items.Add("Item2 - Specialized Torch 1.0 Road Shoe - £80")
                    ListBox1.Items.Add("Shoes with Cleats")
                    ListBox1.Items.Add("https://bit.ly/2AtFQYa")
                    ListBox1.Items.Add("Item3 - B'TWIN Cycling Tights Mens/Womens - £15 - £35")
                    ListBox1.Items.Add("Trousers to wear whilst cycling on the road")
                    ListBox1.Items.Add("Mens - https://bit.ly/2RpbSyu, Womens - https://bit.ly/2BTnyje")
                    'Else
                Else
                    'If BClick = True then the relevant information will be displayed in the listbox 
                    'Road bikes
                    If Equipment.BClick = True Then
                        ListBox1.Items.Add("Item1 - B'Twin Triban 540 - £679")
                        ListBox1.Items.Add("Cheaper range bike")
                        ListBox1.Items.Add("https://bit.ly/2VoKY95")
                        ListBox1.Items.Add("Item2 - Raleigh Mustang Sport 2018 - £800")
                        ListBox1.Items.Add("Mid-range bike")
                        ListBox1.Items.Add("https://bit.ly/2F62LvI")
                        ListBox1.Items.Add("Item3 - Giant Contend SL 1 Disc 2018 - £959")
                        ListBox1.Items.Add("Top-range bike")
                        ListBox1.Items.Add("https://bit.ly/2Ar7eWV")
                        'Else
                    Else
                        'Form closes
                        Me.Close()
                    End If
                End If
            End If
        ElseIf ParaCheck = "T1 - T2" Then
            If Equipment.MClick = True Then
                ListBox1.Items.Add("Item1 - X-Tools Home Truing Stand - £40")
                ListBox1.Items.Add("Allows for you to replace spokes if needed and true(straighten) your wheel at home")
                ListBox1.Items.Add("https://bit.ly/2F2ILv1")
                ListBox1.Items.Add("Item2 - LifeLine Essential Track Pump - £15")
                ListBox1.Items.Add("Allow for the tyre to be inflated")
                ListBox1.Items.Add("https://bit.ly/2F3AQN5")
                ListBox1.Items.Add("Item3 - Park Tool VP11 Puncture Repair Kit - £2")
                ListBox1.Items.Add("Allows for you to repair a punctured tyre")
                ListBox1.Items.Add("https://bit.ly/2s2nVDx")
                'Else
            Else
                'If CClick = True then the relevant information will be displayed in the listbox 
                If Equipment.CClick = True Then
                    ListBox1.Items.Add("Item1 - Altura Thermo Elite Overshoe - £35")
                    ListBox1.Items.Add("Makes cycling shoes waterproof and keeps heat")
                    ListBox1.Items.Add("https://bit.ly/2GPGoNN")
                    ListBox1.Items.Add("Item2 - Specialized Torch 1.0 Road Shoe - £80")
                    ListBox1.Items.Add("Shoes with Cleats")
                    ListBox1.Items.Add("https://bit.ly/2AtFQYa")
                    ListBox1.Items.Add("Item3 - B'TWIN Cycling Tights Mens/Womens - £15 - £35")
                    ListBox1.Items.Add("Trousers to wear whilst cycling on the road")
                    ListBox1.Items.Add("Mens - https://bit.ly/2RpbSyu, Womens - https://bit.ly/2BTnyje")
                    'Else
                Else
                    'If BClick = True then the relevant information will be displayed in the listbox 
                    If Equipment.BClick = True Then
                        ListBox1.Items.Add("Custom Trikes listed under the link below")
                        ListBox1.Items.Add("A range of trikes")
                        ListBox1.Items.Add("https://bit.ly/2SqFiNV")
                        'Else
                    Else
                        'Form closes
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber)
    End Function

    'Private sub to run when the form loads 
    Private Sub Suggestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ParacyclistCheck()
        'If MClick = True then the relevant information will be displayed in the listbox 

    End Sub
End Class