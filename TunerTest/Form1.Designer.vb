<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtCamNumber = New System.Windows.Forms.TextBox()
        Me.groupCam = New System.Windows.Forms.GroupBox()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.groupPreview = New System.Windows.Forms.GroupBox()
        Me.pbPreview = New System.Windows.Forms.PictureBox()
        Me.lblFPS = New System.Windows.Forms.Label()
        Me.timerFPS = New System.Windows.Forms.Timer(Me.components)
        Me.groupCam.SuspendLayout()
        Me.groupPreview.SuspendLayout()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(6, 56)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(70, 29)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtCamNumber
        '
        Me.txtCamNumber.Location = New System.Drawing.Point(6, 19)
        Me.txtCamNumber.Name = "txtCamNumber"
        Me.txtCamNumber.Size = New System.Drawing.Size(146, 20)
        Me.txtCamNumber.TabIndex = 1
        Me.txtCamNumber.Text = "0"
        '
        'groupCam
        '
        Me.groupCam.Controls.Add(Me.btnDisconnect)
        Me.groupCam.Controls.Add(Me.btnConnect)
        Me.groupCam.Controls.Add(Me.txtCamNumber)
        Me.groupCam.Location = New System.Drawing.Point(12, 12)
        Me.groupCam.Name = "groupCam"
        Me.groupCam.Size = New System.Drawing.Size(166, 100)
        Me.groupCam.TabIndex = 2
        Me.groupCam.TabStop = False
        Me.groupCam.Text = "Camera number:"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(82, 56)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(70, 29)
        Me.btnDisconnect.TabIndex = 2
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'groupPreview
        '
        Me.groupPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.groupPreview.Controls.Add(Me.pbPreview)
        Me.groupPreview.Location = New System.Drawing.Point(12, 118)
        Me.groupPreview.Name = "groupPreview"
        Me.groupPreview.Size = New System.Drawing.Size(783, 327)
        Me.groupPreview.TabIndex = 3
        Me.groupPreview.TabStop = False
        Me.groupPreview.Text = "Preview"
        '
        'pbPreview
        '
        Me.pbPreview.Location = New System.Drawing.Point(6, 19)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(529, 308)
        Me.pbPreview.TabIndex = 0
        Me.pbPreview.TabStop = False
        '
        'lblFPS
        '
        Me.lblFPS.AutoSize = True
        Me.lblFPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFPS.Location = New System.Drawing.Point(195, 22)
        Me.lblFPS.Name = "lblFPS"
        Me.lblFPS.Size = New System.Drawing.Size(102, 33)
        Me.lblFPS.TabIndex = 4
        Me.lblFPS.Text = "Label1"
        '
        'timerFPS
        '
        Me.timerFPS.Enabled = True
        Me.timerFPS.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblFPS)
        Me.Controls.Add(Me.groupPreview)
        Me.Controls.Add(Me.groupCam)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupCam.ResumeLayout(False)
        Me.groupCam.PerformLayout()
        Me.groupPreview.ResumeLayout(False)
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents txtCamNumber As TextBox
    Friend WithEvents groupCam As GroupBox
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents groupPreview As GroupBox
    Friend WithEvents pbPreview As PictureBox
    Friend WithEvents lblFPS As Label
    Friend WithEvents timerFPS As Timer
End Class
