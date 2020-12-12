<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.TmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TmrShot = New System.Windows.Forms.Timer(Me.components)
        Me.AsteroidFall = New System.Windows.Forms.Timer(Me.components)
        Me.ForeverLoop = New System.Windows.Forms.Timer(Me.components)
        Me.Start = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.help = New System.Windows.Forms.Timer(Me.components)
        Me.healthDisplay = New System.Windows.Forms.PictureBox()
        Me.Void = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.shot = New System.Windows.Forms.PictureBox()
        Me.asteroid1 = New System.Windows.Forms.PictureBox()
        Me.asteroid2 = New System.Windows.Forms.PictureBox()
        CType(Me.healthDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Void, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asteroid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asteroid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(221, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 73)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Game Over!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(296, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 100)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Move with arrow keys" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shot with space" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restart with ""Q""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press F1 for help"
        '
        'TmrRight
        '
        Me.TmrRight.Interval = 5
        '
        'TmrLeft
        '
        Me.TmrLeft.Interval = 5
        '
        'TmrShot
        '
        Me.TmrShot.Interval = 10
        '
        'AsteroidFall
        '
        Me.AsteroidFall.Interval = 5
        '
        'ForeverLoop
        '
        Me.ForeverLoop.Interval = 10
        '
        'Start
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Score:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(60, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "<score>"
        '
        'healthDisplay
        '
        Me.healthDisplay.BackColor = System.Drawing.Color.Transparent
        Me.healthDisplay.Image = CType(resources.GetObject("healthDisplay.Image"), System.Drawing.Image)
        Me.healthDisplay.Location = New System.Drawing.Point(13, 13)
        Me.healthDisplay.Name = "healthDisplay"
        Me.healthDisplay.Size = New System.Drawing.Size(85, 25)
        Me.healthDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.healthDisplay.TabIndex = 12
        Me.healthDisplay.TabStop = False
        '
        'Void
        '
        Me.Void.Location = New System.Drawing.Point(0, 500)
        Me.Void.Name = "Void"
        Me.Void.Size = New System.Drawing.Size(801, 23)
        Me.Void.TabIndex = 7
        Me.Void.TabStop = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Player.Image = Global.Space_Shooter_Game.My.Resources.Resources.spaceship
        Me.Player.Location = New System.Drawing.Point(371, 378)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(58, 59)
        Me.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Player.TabIndex = 1
        Me.Player.TabStop = False
        '
        'shot
        '
        Me.shot.BackColor = System.Drawing.Color.Transparent
        Me.shot.Image = Global.Space_Shooter_Game.My.Resources.Resources.Laser
        Me.shot.Location = New System.Drawing.Point(371, 396)
        Me.shot.Name = "shot"
        Me.shot.Size = New System.Drawing.Size(58, 41)
        Me.shot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.shot.TabIndex = 2
        Me.shot.TabStop = False
        '
        'asteroid1
        '
        Me.asteroid1.Image = CType(resources.GetObject("asteroid1.Image"), System.Drawing.Image)
        Me.asteroid1.Location = New System.Drawing.Point(0, 0)
        Me.asteroid1.Name = "asteroid1"
        Me.asteroid1.Size = New System.Drawing.Size(98, 77)
        Me.asteroid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.asteroid1.TabIndex = 13
        Me.asteroid1.TabStop = False
        '
        'asteroid2
        '
        Me.asteroid2.Image = CType(resources.GetObject("asteroid2.Image"), System.Drawing.Image)
        Me.asteroid2.Location = New System.Drawing.Point(0, 0)
        Me.asteroid2.Name = "asteroid2"
        Me.asteroid2.Size = New System.Drawing.Size(98, 77)
        Me.asteroid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.asteroid2.TabIndex = 14
        Me.asteroid2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.healthDisplay)
        Me.Controls.Add(Me.asteroid2)
        Me.Controls.Add(Me.asteroid1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Void)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.shot)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Space Shooter Game"
        CType(Me.healthDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Void, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asteroid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asteroid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Player As PictureBox
    Friend WithEvents shot As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TmrRight As Timer
    Friend WithEvents TmrLeft As Timer
    Friend WithEvents TmrShot As Timer
    Friend WithEvents AsteroidFall As Timer
    Friend WithEvents ForeverLoop As Timer
    Friend WithEvents Start As Timer
    Friend WithEvents Void As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents healthDisplay As PictureBox
    Friend WithEvents help As Timer
    Friend WithEvents asteroid1 As PictureBox
    Friend WithEvents asteroid2 As PictureBox
End Class
