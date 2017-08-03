' Patricia Nellas
' 21503005
' 9 September 2015
' Tutor: Kevin Shedlock
' Version 1.0.1

Public Class frmRabbitApp
    'VARIABLES DECLARED
    'int variable for score
    Dim intScore As Integer
    'string variables for each rabbit image that will be called to determine
    'if the rabbit image is already clicked or not
    Dim rabbit1 As String = "not captured"
    Dim rabbit2 As String = "not captured"
    Dim rabbit3 As String = "not captured"
    Dim rabbit4 As String = "not captured"

    'START BUTTON
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'default rabbit status is set to string "not captured"
        rabbit1 = "not captured"
        rabbit2 = "not captured"
        rabbit3 = "not captured"
        rabbit4 = "not captured"

        'sets timer interval for each rabbit image
        tmrRabbit1.Interval = 500
        tmrRabbit2.Interval = 500
        tmrRabbit3.Interval = 500
        tmrRabbit4.Interval = 500

        'calls and enables the timers set for each rabbit image
        tmrRabbit1.Enabled = True
        tmrRabbit2.Enabled = True
        tmrRabbit3.Enabled = True
        tmrRabbit4.Enabled = True

        ''''''*FIXES BUTTON BUG
        'START BUTTON disabled to prevent bugs when re-clicked
        btnStart.Enabled = False

    End Sub

    'RABBIT 1 TIMER
    Private Sub tmrRabbit1_Tick(sender As Object, e As EventArgs) Handles tmrRabbit1.Tick
        picRabbit1.Enabled = True 'makes picRabbit1 image appear as soon as tmrRabbit1 starts

        'If/Then statement that will make the rabbit image blink 
        If picRabbit1.Visible = True Then
            picRabbit1.Visible = False
        ElseIf picRabbit1.Visible = False Then
            picRabbit1.Visible = True
        End If
    End Sub

    'RABBIT 2 TIMER
    Private Sub tmrRabbit2_Tick(sender As Object, e As EventArgs) Handles tmrRabbit2.Tick
        picRabbit2.Enabled = True 'makes picRabbit2 image appear as soon as tmrRabbit2 starts

        'If/Then statement that will make the rabbit image blink
        If picRabbit2.Visible = True Then
            picRabbit2.Visible = False
        ElseIf picRabbit2.Visible = False Then
            picRabbit2.Visible = True
        End If
    End Sub

    'RABBIT 3 TIMER
    Private Sub tmrRabbit3_Tick(sender As Object, e As EventArgs) Handles tmrRabbit3.Tick
        picRabbit3.Enabled = True 'makes picRabbit3 image appear as soon as tmrRabbit3 starts

        'If/Then statement that will make the rabbit image blink
        If picRabbit3.Visible = True Then
            picRabbit3.Visible = False
        ElseIf picRabbit3.Visible = False Then
            picRabbit3.Visible = True
        End If
    End Sub

    'RABBIT 4 TIMER
    Private Sub tmrRabbit4_Tick(sender As Object, e As EventArgs) Handles tmrRabbit4.Tick
        picRabbit4.Enabled = True 'makes picRabbit4 image appear as soon as tmrRabbit4 starts

        'If/Then statement that will make the rabbit image blink
        If picRabbit4.Visible = True Then
            picRabbit4.Visible = False
        ElseIf picRabbit4.Visible = False Then
            picRabbit4.Visible = True
        End If
    End Sub

    'RABBIT 1 IMAGE
    'disables visibility of picRabbit1 when selected
    'disables timer - tmrRabbit1
    'increments integer variable '''intScore'''
    'converts integer variable '''intScore''' to String and assigns it to lblScore.Text
    'sets String variable '''rabbit1''' to "captured"

    Private Sub picRabbit1_Click(sender As Object, e As EventArgs) Handles picRabbit1.Click

        picRabbit1.Visible = False
        tmrRabbit1.Enabled = False
        intScore += 1
        lblScore.Text = intScore.ToString
        rabbit1 = "captured"

        'If/Then statement to determine if rabbit image has already been selected or not
        If rabbit1 = "captured" And rabbit2 = "captured" And rabbit3 = "captured" And rabbit4 = "captured" Then

            'Start button is clickable if all rabbit images have been selected
            btnStart.Enabled = True

            'MessageBox appears with message when all the rabbit images have been selected
            MessageBox.Show("Congratulations! You caught all the rabbits in the garden!")

        Else


            '''''''''''''''''''*FIXES BUG FOR START BUTTON WHEN GAME IS IN PLAY
            ''''''Start button is disabled/not clickable if game is ongoing
            btnStart.Enabled = False

            'MessageBox appears with default message when only one rabbit image is selected
            MessageBox.Show("Ooh! You caught me!")

        End If
    End Sub

    'RABBIT 2 IMAGE
    'disables visibility of picRabbit2 when selected
    'disables timer - tmrRabbit2
    'increments integer variable '''intScore'''
    'converts integer variable '''intScore''' to String and assigns it to lblScore.Text
    'sets String variable '''rabbit2''' to "captured"

    Private Sub picRabbit2_Click(sender As Object, e As EventArgs) Handles picRabbit2.Click
        picRabbit2.Visible = False
        tmrRabbit2.Enabled = False
        intScore += 1
        lblScore.Text = intScore.ToString
        rabbit2 = "captured"

        'If/Then statement to determine if rabbit image has already been selected or not
        If rabbit1 = "captured" And rabbit2 = "captured" And rabbit3 = "captured" And rabbit4 = "captured" Then

            'Start button is clickable if all rabbit images have been selected
            btnStart.Enabled = True

            'MessageBox appears with message when all the rabbit images have been selected
            MessageBox.Show("Congratulations! You caught all the rabbits in the garden!")

        Else


            '''''''''''''''''''*FIXES BUG FOR START BUTTON WHEN GAME IS IN PLAY
            ''''''''Start button is disabled/not clickable if game is ongoing
            btnStart.Enabled = False

            'MessageBox appears with default message when only one rabbit image is selected
            MessageBox.Show("Ooh! You caught me!")

        End If
    End Sub

    'RABBIT 3 IMAGE
    'disables visibility of picRabbit3 when selected
    'disables timer - tmrRabbit3
    'increments integer variable '''intScore'''
    'converts integer variable '''intScore''' to String and assigns it to lblScore.Text
    'sets String variable '''rabbit3''' to "captured"

    Private Sub picRabbit3_Click(sender As Object, e As EventArgs) Handles picRabbit3.Click
        picRabbit3.Visible = False
        tmrRabbit3.Enabled = False
        intScore += 1
        lblScore.Text = intScore.ToString
        rabbit3 = "captured"

        'If/Then statement to determine if rabbit image has already been selected or not
        If rabbit1 = "captured" And rabbit2 = "captured" And rabbit3 = "captured" And rabbit4 = "captured" Then

            'Start button is clickable if all rabbit images have been selected
            btnStart.Enabled = True

            'MessageBox appears with message when all the rabbit images have been selected
            MessageBox.Show("Congratulations! You caught all the rabbits in the garden!")

        Else


            '''''''''''''''''''*FIXES BUG FOR START BUTTON WHEN GAME IS IN PLAY
            ''''''''Start button is disabled/not clickable if game is ongoing
            btnStart.Enabled = False

            'MessageBox appears with default message when only one rabbit image is selected
            MessageBox.Show("Ooh! You caught me!")

        End If
    End Sub

    'RABBIT 4 IMAGE
    'disables visibility of picRabbit4 when selected
    'disables timer - tmrRabbit4
    'increments integer variable '''intScore'''
    'converts integer variable '''intScore''' to String and assigns it to lblScore.Text
    'sets String variable '''rabbi4''' to "captured"

    Private Sub picRabbit4_Click(sender As Object, e As EventArgs) Handles picRabbit4.Click
        picRabbit4.Visible = False
        tmrRabbit4.Enabled = False
        intScore += 1
        lblScore.Text = intScore.ToString
        rabbit4 = "captured"

        'If/Then statement to determine if rabbit image has already been selected or not
        If rabbit1 = "captured" And rabbit2 = "captured" And rabbit3 = "captured" And rabbit4 = "captured" Then

            'Start button is clickable if all rabbit images have been selected
            btnStart.Enabled = True

            'MessageBox appears with message when all the rabbit images have been selected
            MessageBox.Show("Congratulations! You caught all the rabbits in the garden!")

        Else


            '''''''''''''''''''*FIXES BUG FOR START BUTTON WHEN GAME IS IN PLAY
            ''''''''Start button is disabled/not clickable if game is ongoing
            btnStart.Enabled = False


            'MessageBox appears with default message when only one rabbit image is selected
            MessageBox.Show("Ooh! You caught me!")

        End If
    End Sub

    'PAUSE BUTTON
    'stops timers 
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click


        tmrRabbit1.Stop()
        tmrRabbit2.Stop()
        tmrRabbit3.Stop()
        tmrRabbit4.Stop()

        ''*FIXES UNCLICKABLE RABBIT BUG*
        '''''''''''''renders rabbit images unclickable
        picRabbit1.Enabled = False
        picRabbit2.Enabled = False
        picRabbit3.Enabled = False
        picRabbit4.Enabled = False

        btnResume.Visible = True 'RESUME BUTTON appears - to differentiate between pause button when game is paused
        btnStart.Enabled = False 'START BUTTON disabled to avoid bugs
    End Sub

    'RESUME BUTTON
    '***extra button***
    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click

        'If/Then statement calling rabbit1 String variable to determine rabbit status
        If rabbit1 = "not captured" Then
            tmrRabbit1.Start()
        End If

        'If/Then statement calling rabbit2 String variable to determine rabbit status
        If rabbit2 = "not captured" Then
            tmrRabbit2.Start()
        End If

        'If/Then statement calling rabbit3 String variable to determine rabbit status
        If rabbit3 = "not captured" Then
            tmrRabbit3.Start()
        End If

        'If/Then statement calling rabbit4 String variable to determine rabbit status
        If rabbit4 = "not captured" Then
            tmrRabbit4.Start()
        End If

        'If/Then statement to determine if rabbit image has already been selected or not
        If rabbit1 = "captured" And rabbit2 = "captured" And rabbit3 = "captured" And rabbit4 = "captured" Then
            btnStart.Enabled = True
        Else
            btnStart.Enabled = False 'START BUTTON disabled to avoid bugs when clicked while game is ongoing
        End If

        btnResume.Visible = False 'RESUME BUTTON's visibility disabled to make way for PAUSE BUTTON
    End Sub

    'RESET BUTTON
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        intScore = 0 'resets int variable intScore to nil
        lblScore.Text = "0" 'assigns 0 to lblScore.Text on the form

        'resets all rabbits' status to "not captured"
        rabbit1 = "not captured"
        rabbit2 = "not captured"
        rabbit3 = "not captured"
        rabbit4 = "not captured"

        'stops all rabbit timers
        tmrRabbit1.Stop()
        tmrRabbit2.Stop()
        tmrRabbit3.Stop()
        tmrRabbit4.Stop()

        'disables all rabbit images visibility
        picRabbit1.Visible = False
        picRabbit2.Visible = False
        picRabbit3.Visible = False
        picRabbit4.Visible = False

        'sets the timers' interval
        tmrRabbit1.Interval = 500
        tmrRabbit2.Interval = 500
        tmrRabbit3.Interval = 500
        tmrRabbit4.Interval = 500

        'restarts all rabbit timers
        tmrRabbit1.Enabled = True
        tmrRabbit2.Enabled = True
        tmrRabbit3.Enabled = True
        tmrRabbit4.Enabled = True
        btnStart.Enabled = False
    End Sub

    'CLOSE BUTTON
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'closes application
    End Sub
End Class
