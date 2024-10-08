Module Module1
'DEPT:  
'NAME: 
'REG NO: 
'GROUP NO: 
'SERIAL NO: 
Sub Main()
    'PROGRAM TO COMPUTE MEAN AND STANDARD DEVIATION'
    Dim MD2(9) As Single
    Dim MD(9) As Single
    Dim SMD As Single
    Dim SUM As Integer
    Dim Average As Single
    Dim Number(9) As Integer
    Dim STD, VAR As Single
    Dim J As Integer
    Dim StrNumber As String
    Dim StrText As String

    ' Declare variables to store the inputs
    Dim DEPT As String
    Dim FULLNAME As String
    Dim REGNO As String
    Dim GROUPNO As Integer
    Dim SERIALNO As Integer

    ' Get Department Input
    StrText = InputBox("Enter your Department. ", "DEPARTMENT")
    DEPT = StrText ' Store input in DEPT variable
    Console.WriteLine("DEPARTMENT = " & DEPT)
    Console.WriteLine()

    ' Get Full Name Input
    StrText = InputBox("Enter your Fullname. ", "FULLNAME")
    FULLNAME = StrText ' Store input in FULLNAME variable
    Console.WriteLine("FULLNAME = " & FULLNAME)
    Console.WriteLine()

    ' Get Registration Number Input
    StrText = InputBox("Enter your Reg No. ", "REG NO.")
    REGNO = StrText ' Store input in REGNO variable
    Console.WriteLine("REG NO = " & REGNO)
    Console.WriteLine()

    ' Get Group Number Input (Integer)
    StrNumber = InputBox("Enter your Group No. ", "GROUP NO.")
    If Integer.TryParse(StrNumber, GROUPNO) Then ' Ensure valid integer input
        Console.WriteLine("GROUP NO = " & GROUPNO)
    Else
        Console.WriteLine("Invalid Group No. Please enter a valid number.")
        Exit Sub
    End If
    Console.WriteLine()

    ' Get Serial Number Input (Integer)
    StrNumber = InputBox("Enter your Serial No. ", "SERIAL NO.")
    If Integer.TryParse(StrNumber, SERIALNO) Then ' Ensure valid integer input
        Console.WriteLine("SERIAL NO = " & SERIALNO)
    Else
        Console.WriteLine("Invalid Serial No. Please enter a valid number.")
        Exit Sub
    End If
    Console.WriteLine()

    ' Get Data Input and Calculate Mean and Standard Deviation
    For J = 1 To 9
        StrNumber = InputBox("Enter Data ", "Data " & J)
        If Integer.TryParse(StrNumber, Number(J)) Then
            ' Number(J) successfully stores the input
        Else
            Console.WriteLine("Invalid Data. Please enter a valid number.")
            Exit Sub
        End If
    Next

    SUM = 0 : SMD = 0

    ' Calculate Total or Sum of Numbers
    For J = 1 To 9
        SUM = SUM + Number(J)
    Next J

    'Compute Mean or Average
    Average = SUM / 9
    Console.WriteLine(" ")

    'Calculate Mean Deviation
    For J = 1 To 9
        MD(J) = Number(J) - Average
        MD2(J) = MD(J) ^ 2
        SMD = SMD + MD2(J)
    Next J
    ' Compute Standard Deviation and Variance
    
    STD = (SMD / 9) ^ 0.5
    VAR = STD ^ 2
    Console.WriteLine("NUMBER" & " " & "        MD " & " " & "        SMD")
    Console.WriteLine(StrDup(33, "=="))
    
    'Print Result
    Console.WriteLine()
    For J = 1 To 9
        Console.WriteLine(Number(J) & "       " & MD(J) & "    " & MD2(J))
        Console.WriteLine()
    Next J
    Console.WriteLine() : Console.WriteLine()
    Console.WriteLine("Sum =  " & SUM)
    Console.WriteLine("Average = " & Average)
    Console.WriteLine()
    Console.WriteLine("Mean = " & Average)
    Console.WriteLine("Standard Deviation = " & STD)
    Console.WriteLine(("Variance = " & VAR))
    Console.WriteLine()
End Sub
End Module
























