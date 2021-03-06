﻿Public Class StudentDatabaseForm
    'set up a record or "class" for a student
    Public tempgender As Char
    Public dotplaced As Boolean = False
    Public ErrorCol As Color = Color.FromArgb(255, 0, 0)
    Public nameValid As Boolean = False
    Public phoneValid As Boolean = False
    Public mkValid As Boolean = False
    Public genderValid As Boolean = False

    Class STUDENT
        Public firstname As String
        Public lastname As String
        Public DOB As String
        Public gender As Char
        Public avMk As Single
        Public phoneNo As String
        Public paid As Boolean

    End Class
    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0
    Dim Flip As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        For i = 0 To 9
            students(i) = New STUDENT
        Next
        'load 4 test records
        students(0).firstname = "Johnny"
        students(0).lastname = "Depp"
        students(0).DOB = "9/6/63"
        students(0).gender = "m"
        students(0).avMk = 78.2
        students(0).phoneNo = "9119108773"
        students(0).paid = True
        students(1).firstname = "Jennifer"
        students(1).lastname = "Lawrence"
        students(1).DOB = "15/8/90"
        students(1).gender = "f"
        students(1).avMk = 88.2
        students(1).phoneNo = "0123456789"
        students(1).paid = False
        students(2).firstname = "George"
        students(2).lastname = "Clooney"
        students(2).DOB = "6/5/61"
        students(2).gender = "f"
        students(2).avMk = 68.2
        students(2).phoneNo = "0119233441"
        students(2).paid = True
        students(3).firstname = "Scarlett"
        students(3).lastname = "Johansson"
        students(3).DOB = "22/11/84"
        students(3).gender = "f"
        students(3).avMk = 72.2
        'set the student count to the number of students which have been entered
        studentCount = 4
        displayList()
    End Sub
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstname = txtFirstName.Text
        students(studentCount).lastname = txtLastName.Text
        students(studentCount).DOB = txtDOB.Text
        students(studentCount).gender = tempgender
        students(studentCount).avMk = txtAvMk.Text
        students(studentCount).phoneNo = txtPhone.Text
        students(studentCount).paid = txtPaid.Checked
        studentCount += 1
        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDOB.Text = ""
        Female.Checked = False
        MaleBtn.Checked = False
        OtherBtn.Checked = False
        txtAvMk.Text = ""
        txtPhone.Text = ""
        txtPaid.Checked = False
        displayList()
    End Sub
    Private Sub displayList()
        'clear the list box as it keeps the earlier loop
        lstStud.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            lstStud.Items.Add(students(i).firstname & " - " & students(i).lastname & " - " &
                              students(i).DOB & " - " & students(i).gender & " - " & students(i).avMk & "-" & students(i).phoneNo & "-" & students(i).paid & ".
")
        Next
    End Sub



    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        If (txtFirstName.Text.Length = 1) Then
            Dim First = txtFirstName.Text(0)
            txtFirstName.Text = UCase(First)
            txtFirstName.Select(txtFirstName.Text.Length, 0)
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        If (txtLastName.Text.Length = 1) Then
            Dim Last = txtLastName.Text(0)
            txtLastName.Text = UCase(Last)
            txtLastName.Select(txtLastName.Text.Length, 0)
        End If
        If txtLastName.Text.Length > 0 Then
            If txtFirstName.Text.Length > 0 Then
                If nameValid = False Then
                    nameValid = True
                    If nameValid And phoneValid And genderValid Then

                    End If
                End If
            End If
        End If
    End Sub

End Class
