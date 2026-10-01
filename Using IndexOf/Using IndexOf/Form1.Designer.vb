<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox3 = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.Location = New Point(4, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 21)
        Label1.TabIndex = 1
        Label1.Text = "FIrst and Last Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(44, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 21)
        Label2.TabIndex = 2
        Label2.Text = "Email Address:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(161, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(148, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(161, 42)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(148, 23)
        TextBox2.TabIndex = 5
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(328, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(240, 235)
        ListBox1.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Button1.Location = New Point(12, 116)
        Button1.Name = "Button1"
        Button1.Size = New Size(297, 29)
        Button1.TabIndex = 8
        Button1.Text = "Space Location"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Button2.Location = New Point(12, 151)
        Button2.Name = "Button2"
        Button2.Size = New Size(297, 29)
        Button2.TabIndex = 11
        Button2.Text = "Validate Name"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Button3.Location = New Point(12, 186)
        Button3.Name = "Button3"
        Button3.Size = New Size(297, 29)
        Button3.TabIndex = 12
        Button3.Text = "Validate Email"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Button4.Location = New Point(12, 221)
        Button4.Name = "Button4"
        Button4.Size = New Size(297, 29)
        Button4.TabIndex = 13
        Button4.Text = "Validate Course ID"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(161, 71)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(148, 23)
        TextBox3.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label4.Location = New Point(76, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 21)
        Label4.TabIndex = 9
        Label4.Text = "Course ID:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(578, 268)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Using IndexOf"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
End Class
