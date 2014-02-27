<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAllRight = New System.Windows.Forms.Button
        Me.btnOneRight = New System.Windows.Forms.Button
        Me.btnOneLeft = New System.Windows.Forms.Button
        Me.btnAllLeft = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnAllRight
        '
        Me.btnAllRight.Location = New System.Drawing.Point(0, 0)
        Me.btnAllRight.Name = "btnAllRight"
        Me.btnAllRight.Size = New System.Drawing.Size(36, 23)
        Me.btnAllRight.TabIndex = 0
        Me.btnAllRight.Text = ">>"
        Me.btnAllRight.UseVisualStyleBackColor = True
        '
        'btnOneRight
        '
        Me.btnOneRight.Location = New System.Drawing.Point(0, 29)
        Me.btnOneRight.Name = "btnOneRight"
        Me.btnOneRight.Size = New System.Drawing.Size(36, 23)
        Me.btnOneRight.TabIndex = 1
        Me.btnOneRight.Text = ">"
        Me.btnOneRight.UseVisualStyleBackColor = True
        '
        'btnOneLeft
        '
        Me.btnOneLeft.Location = New System.Drawing.Point(0, 58)
        Me.btnOneLeft.Name = "btnOneLeft"
        Me.btnOneLeft.Size = New System.Drawing.Size(36, 23)
        Me.btnOneLeft.TabIndex = 2
        Me.btnOneLeft.Text = "<"
        Me.btnOneLeft.UseVisualStyleBackColor = True
        '
        'btnAllLeft
        '
        Me.btnAllLeft.Location = New System.Drawing.Point(0, 87)
        Me.btnAllLeft.Name = "btnAllLeft"
        Me.btnAllLeft.Size = New System.Drawing.Size(36, 23)
        Me.btnAllLeft.TabIndex = 3
        Me.btnAllLeft.Text = "<<"
        Me.btnAllLeft.UseVisualStyleBackColor = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAllLeft)
        Me.Controls.Add(Me.btnOneLeft)
        Me.Controls.Add(Me.btnOneRight)
        Me.Controls.Add(Me.btnAllRight)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(37, 111)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAllRight As System.Windows.Forms.Button
    Friend WithEvents btnOneRight As System.Windows.Forms.Button
    Friend WithEvents btnOneLeft As System.Windows.Forms.Button
    Friend WithEvents btnAllLeft As System.Windows.Forms.Button

End Class
