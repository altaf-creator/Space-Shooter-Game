Public Class Form1
    Dim moveSpeed As Integer = 6
    Dim r As New Random
    Dim score As Integer = 0
    Dim lives As Integer = 3
    Dim shotSpeed As Integer = 15
    Dim level As String = 1

    Function startCode() As Object
        asteroid1.Location = New Point(r.Next(100, 716), -100)
        asteroid2.Location = New Point(r.Next(100, 716), -100)
        Player.Location = New Point(371, 379)
        shot.Location = New Point(-50, -50)
        Label1.Visible = False
        Label2.Visible = False
        AsteroidFall.Start()
        asteroid1.Visible = True
        asteroid2.Visible = True
        Player.Visible = True
        shot.Visible = True
        score = 0
        lives = 3
        level = 1
        Return "Game Over"
    End Function

    Function gameOver() As Object
        Label1.Visible = True
        Label2.Visible = True
        AsteroidFall.Stop()
        asteroid2.Visible = False
        asteroid1.Visible = False
        Player.Visible = False
        shot.Visible = False
        shot.Location = New Point(-100, -100)
        asteroid1.Location = New Point(-50, -50)
        asteroid2.Location = New Point(-50, -50)
        Player.Location = New Point(-50, -50)
        Return "Game Over!"
    End Function

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Start()
            Case Keys.Left
                TmrLeft.Start()
            Case Keys.Space
                shot.Location = New Point(Player.Location)
                TmrShot.Start()
                shot.Visible = True
            Case Keys.Q
                Start.Start()
            Case Keys.F1
                Dim helpForm = New HelpForm()
                helpForm.Show()
        End Select
    End Sub

    Private Sub TmrRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        Player.Left += moveSpeed
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Stop()
            Case Keys.Left
                TmrLeft.Stop()
            Case Keys.Q
                Start.Stop()
        End Select
    End Sub

    Private Sub TmrLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        Player.Left -= moveSpeed
    End Sub

    Private Sub TmrShot_Tick(sender As Object, e As EventArgs) Handles TmrShot.Tick
        shot.Top -= shotSpeed
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        shot.Location = New Point(-50, -50)
        asteroid1.Location = New Point(r.Next(100, 716), -100)
        asteroid2.Location = New Point(r.Next(100, 716), -100)
        AsteroidFall.Start()
        Label1.Visible = False
        Label2.Visible = False
        levelUpLabel.Visible = False
        ForeverLoop.Start()
        lives = 3
    End Sub

    Private Sub AsteroidFall_Tick(sender As Object, e As EventArgs) Handles AsteroidFall.Tick
        asteroid1.Top += 2.7
        asteroid2.Top += 2.7
    End Sub

    Private Sub ForeverLoop_Tick(sender As Object, e As EventArgs) Handles ForeverLoop.Tick
        If Player.Bounds.IntersectsWith(asteroid1.Bounds) Then
            lives -= 1
            asteroid1.Location = New Point(r.Next(100, 716), -100)
        End If
        If Player.Bounds.IntersectsWith(asteroid2.Bounds) Then
            lives -= 1
            asteroid2.Location = New Point(r.Next(100, 716), -100)
        End If
        If shot.Bounds.IntersectsWith(asteroid1.Bounds) Then
            asteroid1.Visible = False
            AsteroidFall.Stop()
            TmrShot.Stop()
            shot.Visible = False
            asteroid1.Location = New Point(r.Next(100, 716), -100)
            AsteroidFall.Start()
            asteroid1.Visible = True
            shot.Location = New Point(-50, -50)

            score += 1
        End If
        If shot.Bounds.IntersectsWith(asteroid2.Bounds) Then
            asteroid2.Visible = False
            AsteroidFall.Stop()
            TmrShot.Stop()
            shot.Visible = False
            asteroid2.Location = New Point(r.Next(100, 716), -100)
            AsteroidFall.Start()
            asteroid2.Visible = True
            shot.Location = New Point(-50, -50)
            score += 1
        End If
        If asteroid1.Bounds.IntersectsWith(Void.Bounds) Then
            asteroid1.Location = New Point(r.Next(100, 716), -100)
        End If
        If asteroid2.Bounds.IntersectsWith(Void.Bounds) Then
            asteroid2.Location = New Point(r.Next(100, 716), -100)
        End If
        If lives = 3 Then
            Me.healthDisplay.Image = Space_Shooter_Game.My.Resources.Resources.health3
        End If
        If lives = 2 Then
            Me.healthDisplay.Image = Space_Shooter_Game.My.Resources.Resources.health2
        End If
        If lives = 1 Then
            Me.healthDisplay.Image = Space_Shooter_Game.My.Resources.Resources.health1
        End If
        If lives = 0 Then
            gameOver()
            Me.healthDisplay.Image = Space_Shooter_Game.My.Resources.Resources.health0
        End If
        If score = 20 Then
            level = 2
            moveSpeed = 7
            Me.levelUpLabel.Visible = True
            LevelUpTime.Start()
        End If
        If score = 45 Then
            level = 3
            shotSpeed = 18
            Me.levelUpLabel.Visible = True
            LevelUpTime.Start()
        End If
        If score = 100 Then
            level = 4
            moveSpeed = 8
            Me.levelUpLabel.Visible = True
            LevelUpTime.Start()
        End If
        If score = 150 Then
            level = 5
            shotSpeed = 20
            Me.levelUpLabel.Visible = True
            LevelUpTime.Start()
        End If
        If score = 210 Then
            level = 6
            moveSpeed = 9
            Me.levelUpLabel.Visible = True
            LevelUpTime.Start()
        End If
        If score = 300 Then
            level = 7
            shotSpeed = 23
            Me.levelUpLabel.Visible = True
            LevelUpTime.Start()
        End If
        If score = 400 Then
            level = 8
            moveSpeed = 10
            Me.levelUpLabel.Visible = True
            LevelUpTime.Start()
        End If
        If score = 560 Then
            level = 9
            shotSpeed = 24
            levelUpLabel.Visible = True
            LevelUpTime.Start()
        End If
        If score = 750 Then
            level = 10
            moveSpeed = 11
            Me.levelUpLabel.Visible = True
            LevelUpTime.Start()
        End If
        If score = 1000 Then
            level = "The King"
            moveSpeed = 12
            shotSpeed = 25
            Me.levelUpLabel.Visible = True
            LevelUpTime.Start()
        End If
        Me.scoreDisplay.Text = score
        Me.levelText.Text = level
    End Sub

    Private Sub Start_Tick(sender As Object, e As EventArgs) Handles Start.Tick
        startCode()
    End Sub

    Private Sub LevelUpTime_Tick(sender As Object, e As EventArgs) Handles LevelUpTime.Tick
        Me.levelUpLabel.Visible = False
        LevelUpTime.Stop()
    End Sub
End Class