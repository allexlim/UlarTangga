<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlay
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnDadu = New System.Windows.Forms.Button()
        Me.LbDadu = New System.Windows.Forms.Label()
        Me.BtnCheat = New System.Windows.Forms.Button()
        Me.TbCheat = New System.Windows.Forms.TextBox()
        Me.Tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tmrandom1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tmrandom2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BtnDadu
        '
        Me.BtnDadu.Location = New System.Drawing.Point(579, 99)
        Me.BtnDadu.Name = "BtnDadu"
        Me.BtnDadu.Size = New System.Drawing.Size(75, 23)
        Me.BtnDadu.TabIndex = 0
        Me.BtnDadu.Text = "Dadu"
        Me.BtnDadu.UseVisualStyleBackColor = True
        '
        'LbDadu
        '
        Me.LbDadu.AutoSize = True
        Me.LbDadu.Font = New System.Drawing.Font("Niagara Engraved", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDadu.Location = New System.Drawing.Point(576, 9)
        Me.LbDadu.Name = "LbDadu"
        Me.LbDadu.Size = New System.Drawing.Size(46, 68)
        Me.LbDadu.TabIndex = 1
        Me.LbDadu.Text = "_"
        '
        'BtnCheat
        '
        Me.BtnCheat.Location = New System.Drawing.Point(579, 193)
        Me.BtnCheat.Name = "BtnCheat"
        Me.BtnCheat.Size = New System.Drawing.Size(75, 23)
        Me.BtnCheat.TabIndex = 2
        Me.BtnCheat.Text = "Cheat"
        Me.BtnCheat.UseVisualStyleBackColor = True
        '
        'TbCheat
        '
        Me.TbCheat.Location = New System.Drawing.Point(568, 147)
        Me.TbCheat.Name = "TbCheat"
        Me.TbCheat.Size = New System.Drawing.Size(100, 20)
        Me.TbCheat.TabIndex = 3
        '
        'Tm1
        '
        Me.Tm1.Interval = 500
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(485, 264)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 4
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(634, 264)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(565, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(628, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "0"
        '
        'Tmrandom1
        '
        Me.Tmrandom1.Interval = 50
        '
        'Tmrandom2
        '
        Me.Tmrandom2.Enabled = True
        Me.Tmrandom2.Interval = 50
        '
        'FormPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TbCheat)
        Me.Controls.Add(Me.BtnCheat)
        Me.Controls.Add(Me.LbDadu)
        Me.Controls.Add(Me.BtnDadu)
        Me.Name = "FormPlay"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnDadu As Button
    Friend WithEvents LbDadu As Label
    Friend WithEvents BtnCheat As Button
    Friend WithEvents TbCheat As TextBox
    Friend WithEvents Tm1 As Timer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tmrandom1 As Timer
    Friend WithEvents Tmrandom2 As Timer
End Class
