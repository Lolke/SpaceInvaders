<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLevelOne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLevelOne))
        Me.Shooter = New System.Windows.Forms.PictureBox()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.Shot = New System.Windows.Forms.PictureBox()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Shooter
        '
        Me.Shooter.BackColor = System.Drawing.Color.Transparent
        Me.Shooter.Image = CType(resources.GetObject("Shooter.Image"), System.Drawing.Image)
        Me.Shooter.InitialImage = CType(resources.GetObject("Shooter.InitialImage"), System.Drawing.Image)
        Me.Shooter.Location = New System.Drawing.Point(268, 399)
        Me.Shooter.Name = "Shooter"
        Me.Shooter.Size = New System.Drawing.Size(50, 33)
        Me.Shooter.TabIndex = 0
        Me.Shooter.TabStop = False
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1
        '
        'Shot
        '
        Me.Shot.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Shot.Location = New System.Drawing.Point(290, 382)
        Me.Shot.Name = "Shot"
        Me.Shot.Size = New System.Drawing.Size(8, 20)
        Me.Shot.TabIndex = 1
        Me.Shot.TabStop = False
        '
        'FormLevelOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(614, 431)
        Me.Controls.Add(Me.Shot)
        Me.Controls.Add(Me.Shooter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLevelOne"
        Me.Text = "Space Invaders"
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Shooter As System.Windows.Forms.PictureBox
    Friend WithEvents TimerMain As System.Windows.Forms.Timer
    Friend WithEvents Shot As System.Windows.Forms.PictureBox

End Class
