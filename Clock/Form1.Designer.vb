<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Label1.Location = New Point(14, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 157)
        Label1.TabIndex = 0
        Label1.Text = "00:00"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Label2.Location = New Point(43, 260)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 59)
        Label2.TabIndex = 1
        Label2.Text = "NULL"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(398, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Clock"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label

End Class
