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
        level = 0
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
                MessageBox.Show("Controls:" & vbCrLf & "Arrow keys = Move" & vbCrLf & "Q = Restart the game" & vbCrLf & "F1 = Shows this window" & vbCrLf & "F2 = About" & vbCrLf & "Your mission is to shoot the asteroids!" & vbCrLf & "And dodge it. Get the highest score and be the king!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Case Keys.F2
                MessageBox.Show("Space Shooter Game" & vbCrLf & "v1.3" & vbCrLf & "By Altaf" & vbCrLf & "Coded with Visual Basic" & vbCrLf & "Created using Microsoft Visual Studio", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If score > 20 And score < 45 Then
            level = 2
            moveSpeed = 7
        End If
        If score >= 45 And score < 100 Then
            level = 3
            shotSpeed = 18
        End If
        If score >= 100 And score < 150 Then
            level = 4
            moveSpeed = 8
        End If
        If score >= 150 And score < 210 Then
            level = 5
            shotSpeed = 20
        End If
        If score >= 210 And score < 300 Then
            level = 6
            moveSpeed = 9
        End If
        If score >= 300 And score < 400 Then
            level = 7
            shotSpeed = 23
        End If
        If score >= 400 And score < 560 Then
            level = 8
            moveSpeed = 10
        End If
        If score >= 560 And score < 750 Then
            level = 9
            shotSpeed = 24
        End If
        If score >= 750 And score < 1000 Then
            level = 10
            moveSpeed = 11
        End If
        If score >= 1000 Then
            level = "The King"
            moveSpeed = 12
            shotSpeed = 25
        End If
        Me.scoreDisplay.Text = score
        Me.levelText.Text = level
    End Sub

    Private Sub Start_Tick(sender As Object, e As EventArgs) Handles Start.Tick
        startCode()
    End Sub
End Class