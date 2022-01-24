<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpForm))
        Me.Title = New System.Windows.Forms.Label()
        Me.SubtitleControls = New System.Windows.Forms.Label()
        Me.DescriptonControls = New System.Windows.Forms.Label()
        Me.DescriptionMission = New System.Windows.Forms.Label()
        Me.SubtitleMission = New System.Windows.Forms.Label()
        Me.DescriptionAbout = New System.Windows.Forms.Label()
        Me.SubtitleAbout = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        resources.ApplyResources(Me.Title, "Title")
        Me.Title.Name = "Title"
        '
        'SubtitleControls
        '
        resources.ApplyResources(Me.SubtitleControls, "SubtitleControls")
        Me.SubtitleControls.Name = "SubtitleControls"
        '
        'DescriptonControls
        '
        resources.ApplyResources(Me.DescriptonControls, "DescriptonControls")
        Me.DescriptonControls.Name = "DescriptonControls"
        '
        'DescriptionMission
        '
        resources.ApplyResources(Me.DescriptionMission, "DescriptionMission")
        Me.DescriptionMission.Name = "DescriptionMission"
        '
        'SubtitleMission
        '
        resources.ApplyResources(Me.SubtitleMission, "SubtitleMission")
        Me.SubtitleMission.Name = "SubtitleMission"
        '
        'DescriptionAbout
        '
        resources.ApplyResources(Me.DescriptionAbout, "DescriptionAbout")
        Me.DescriptionAbout.Name = "DescriptionAbout"
        '
        'SubtitleAbout
        '
        resources.ApplyResources(Me.SubtitleAbout, "SubtitleAbout")
        Me.SubtitleAbout.Name = "SubtitleAbout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Space_Shooter_Game.My.Resources.Resources.spaceship
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        '
        'LinkLabel2
        '
        resources.ApplyResources(Me.LinkLabel2, "LinkLabel2")
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.TabStop = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'LinkLabel3
        '
        resources.ApplyResources(Me.LinkLabel3, "LinkLabel3")
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.TabStop = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'LinkLabel4
        '
        resources.ApplyResources(Me.LinkLabel4, "LinkLabel4")
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.TabStop = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'HelpForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DescriptionAbout)
        Me.Controls.Add(Me.SubtitleAbout)
        Me.Controls.Add(Me.DescriptionMission)
        Me.Controls.Add(Me.SubtitleMission)
        Me.Controls.Add(Me.DescriptonControls)
        Me.Controls.Add(Me.SubtitleControls)
        Me.Controls.Add(Me.Title)
        Me.MaximizeBox = False
        Me.Name = "HelpForm"
        Me.ShowIcon = False
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents SubtitleControls As Label
    Friend WithEvents DescriptonControls As Label
    Friend WithEvents DescriptionMission As Label
    Friend WithEvents SubtitleMission As Label

    Private Sub DescriptonControls_Click(sender As Object, e As EventArgs) Handles DescriptonControls.Click

    End Sub

    Friend WithEvents DescriptionAbout As Label
    Friend WithEvents SubtitleAbout As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/altaf-creator")
    End Sub

    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label1 As Label

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://github.com/altaf-creator/Space-Shooter-Game")
    End Sub

    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label2 As Label

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://www.pngkit.com/view/u2q8q8o0a9q8y3r5_player-space-ship-space-ship-png-pixel-art/")
    End Sub

    Friend WithEvents LinkLabel4 As LinkLabel

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("https://www.kindpng.com/imgv/wmmowx_pixel-art-asteroid-sprite-hd-png-download/")
    End Sub

    Friend WithEvents Label3 As Label
End Class
