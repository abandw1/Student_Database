﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAvMk = New System.Windows.Forms.TextBox()
        Me.btnAddStud = New System.Windows.Forms.Button()
        Me.lstStud = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.txtLastName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date of Birth"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(248, 83)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(100, 20)
        Me.txtDOB.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(354, 83)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(100, 20)
        Me.txtGender.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(460, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Average Mk"
        '
        'txtAvMk
        '
        Me.txtAvMk.Location = New System.Drawing.Point(460, 83)
        Me.txtAvMk.Name = "txtAvMk"
        Me.txtAvMk.Size = New System.Drawing.Size(100, 20)
        Me.txtAvMk.TabIndex = 9
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
        Me.lstStud.Size = New System.Drawing.Size(533, 160)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 391)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstStud)
        Me.Controls.Add(Me.btnAddStud)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAvMk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAvMk As TextBox
    Friend WithEvents btnAddStud As Button


    Friend WithEvents lstStud As ListBox
    Friend WithEvents Label8 As Label
End Class
