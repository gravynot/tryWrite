Module Module1
    '   Title:          tryWrite
    '   Author:         Gavrilla.K
    '   Version:        0.1
    '   Date:           15/09/2026
    '   Description:    Writing data to a file
    Sub Main()
        '   The filename
        Dim filename As String = "myData.txt" ' the file name
        '   Data the user will input
        Dim myData As String = ""
        Dim choice As String = "" 'NEW

        '   Ask the use for some data, store in myData
        Console.WriteLine("Please enter sum")
        myData = Console.ReadLine

        '   Create a Link to the file
        Dim writer As IO.StreamWriter 'writer is linking to the file

        '   NEW: Ask if the user wants to append or overwrite the file
        Console.WriteLine("Do you want to append to the file? (Y/N)")
        choice = Console.ReadLine()

        'NEW
        If choice = "Y" Then
            writer = New IO.StreamWriter(filename, True)
        Else
            writer = New IO.StreamWriter(filename, False) 'using variable to ref. to file
            'changing True to False will overwrite the file instead of appending to it
            '   > OPENFILE (filename) FOR APPEND  <- 2 Line code is equivalent to this.

            'True = APPEND
            'False = OVERWRITE
            ' -> OPENFILE (filename) FOR WRITE
        End If

        'write wtv data into file
        writer.WriteLine(myData)
        '   > WRITEFILE (filename, myData)

        writer.Close() 'close the file
        '   > CLOSEFILE (filename)
        ' Although the program closed, the data is still sored,
    End Sub

End Module
