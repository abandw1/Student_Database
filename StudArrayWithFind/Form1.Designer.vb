<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentDatabaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddStud = New System.Windows.Forms.Button()
        Me.lstStud = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtPaid = New System.Windows.Forms.CheckBox()
        Me.MaleBtn = New System.Windows.Forms.RadioButton()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.OtherBtn = New System.Windows.Forms.RadioButton()
        Me.txtDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtAvMk = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(36, 83)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Student Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(142, 83)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date of Birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(470, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(580, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Average Mk"
        '
        'btnAddStud
        '
        Me.btnAddStud.Location = New System.Drawing.Point(39, 129)
        Me.btnAddStud.Name = "btnAddStud"
        Me.btnAddStud.Size = New System.Drawing.Size(104, 23)
        Me.btnAddStud.TabIndex = 11
        Me.btnAddStud.Text = "Add Student"
        Me.btnAddStud.UseVisualStyleBackColor = True
        '
        'lstStud
        '
        Me.lstStud.FormattingEnabled = True
        Me.lstStud.Location = New System.Drawing.Point(36, 202)
        Me.lstStud.Name = "lstStud"
        Me.lstStud.Size = New System.Drawing.Size(700, 277)
        Me.lstStud.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of entered students (for testing)"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(149, 127)
        Me.txtPhone.Mask = "0000-000-000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 9
        '
        'txtPaid
        '
        Me.txtPaid.AutoSize = True
        Me.txtPaid.Location = New System.Drawing.Point(255, 129)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(47, 17)
        Me.txtPaid.TabIndex = 10
        Me.txtPaid.Text = "Paid"
        Me.txtPaid.UseVisualStyleBackColor = True
        '
        'MaleBtn
        '
        Me.MaleBtn.AutoSize = True
        Me.MaleBtn.Location = New System.Drawing.Point(473, 84)
        Me.MaleBtn.Name = "MaleBtn"
        Me.MaleBtn.Size = New System.Drawing.Size(48, 17)
        Me.MaleBtn.TabIndex = 4
        Me.MaleBtn.TabStop = True
        Me.MaleBtn.Text = "Male"
        Me.MaleBtn.UseVisualStyleBackColor = True
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Location = New System.Drawing.Point(473, 107)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(59, 17)
        Me.Female.TabIndex = 5
        Me.Female.TabStop = True
        Me.Female.Text = "Female"
        Me.Female.UseVisualStyleBackColor = True
        '
        'OtherBtn
        '
        Me.OtherBtn.AutoSize = True
        Me.OtherBtn.Location = New System.Drawing.Point(473, 130)
        Me.OtherBtn.Name = "OtherBtn"
        Me.OtherBtn.Size = New System.Drawing.Size(51, 17)
        Me.OtherBtn.TabIndex = 6
        Me.OtherBtn.TabStop = True
        Me.OtherBtn.Text = "Other"
        Me.OtherBtn.UseVisualStyleBackColor = True
        '
        'txtDOB
        '
        Me.txtDOB.AllowDrop = True
        Me.txtDOB.Location = New System.Drawing.Point(255, 84)
        Me.txtDOB.MaxDate = New Date(2020, 10, 31, 0, 0, 0, 0)
        Me.txtDOB.MinDate = New Date(1902, 1, 2, 0, 0, 0, 0)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(192, 20)
        Me.txtDOB.TabIndex = 2
        Me.txtDOB.Value = New Date(2020, 10, 31, 0, 0, 0, 0)
        '
        'txtAvMk
        '
        Me.txtAvMk.Location = New System.Drawing.Point(583, 84)
        Me.txtAvMk.Mask = "00.000000"
        Me.txtAvMk.Name = "txtAvMk"
        Me.txtAvMk.Size = New System.Drawing.Size(100, 20)
        Me.txtAvMk.TabIndex = 17
        '
        'StudentDatabaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(760, 502)
        Me.Controls.Add(Me.txtAvMk)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.OtherBtn)
        Me.Controls.Add(Me.Female)
        Me.Controls.Add(Me.MaleBtn)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstStud)
        Me.Controls.Add(Me.btnAddStud)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "StudentDatabaseForm"
        Me.Text = "Student Database Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddStud As Button


    Friend WithEvents lstStud As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtPaid As CheckBox
    Friend WithEvents MaleBtn As RadioButton
    Friend WithEvents Female As RadioButton
    Friend WithEvents OtherBtn As RadioButton
    Friend WithEvents txtDOB As DateTimePicker
    Friend WithEvents txtAvMk As MaskedTextBox
End Class
