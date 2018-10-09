Imports Emgu.CV
Public Class Form1
    Dim camera As Emgu.CV.VideoCapture
    Dim img As Emgu.CV.Mat
    Dim frameCount As Integer = 0

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim camNumber As Integer = txtCamNumber.Text
        camera = New Emgu.CV.VideoCapture(camNumber)
        img = New Emgu.CV.Mat()

        camera.Start()
        AddHandler camera.ImageGrabbed, AddressOf FrameReceived

    End Sub

    Private Sub FrameReceived(sender As Object, e As EventArgs)
        camera.Retrieve(img)
        pbPreview.Invalidate()
        frameCount += 1
    End Sub

    Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        camera.Stop()
        camera.Dispose()
    End Sub

    Private Sub pbPreview_Paint(sender As Object, e As PaintEventArgs) Handles pbPreview.Paint
        If Not IsNothing(img) Then
            If img.Width <> pbPreview.Width Then
                pbPreview.Width = img.Width
                groupPreview.Width = img.Width
            End If
            If img.Height <> pbPreview.Height Then
                pbPreview.Height = img.Height
                groupPreview.Height = img.Height
            End If

            e.Graphics.DrawImage(img.Bitmap, New PointF(0, 0))

        End If
    End Sub

    Private Sub timerFPS_Tick(sender As Object, e As EventArgs) Handles timerFPS.Tick
        lblFPS.Text = (frameCount * 2) & "FPS"
        frameCount = 0
    End Sub
End Class
