<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeScreen))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BorderLeftPictureBox = New System.Windows.Forms.PictureBox()
        Me.BorderRightPictureBox = New System.Windows.Forms.PictureBox()
        Me.BorderBottomPictureBox = New System.Windows.Forms.PictureBox()
        Me.BorderTopPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoadingProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadingTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderLeftPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderRightPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderBottomPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorderTopPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SupremeInventorySystem.My.Resources.Resources.bookhublogo
        Me.PictureBox2.Location = New System.Drawing.Point(293, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(182, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'BorderLeftPictureBox
        '
        Me.BorderLeftPictureBox.BackColor = System.Drawing.Color.Red
        Me.BorderLeftPictureBox.Location = New System.Drawing.Point(0, -1)
        Me.BorderLeftPictureBox.Name = "BorderLeftPictureBox"
        Me.BorderLeftPictureBox.Size = New System.Drawing.Size(1, 298)
        Me.BorderLeftPictureBox.TabIndex = 4
        Me.BorderLeftPictureBox.TabStop = False
        '
        'BorderRightPictureBox
        '
        Me.BorderRightPictureBox.BackColor = System.Drawing.Color.Red
        Me.BorderRightPictureBox.Location = New System.Drawing.Point(499, 1)
        Me.BorderRightPictureBox.Name = "BorderRightPictureBox"
        Me.BorderRightPictureBox.Size = New System.Drawing.Size(1, 296)
        Me.BorderRightPictureBox.TabIndex = 3
        Me.BorderRightPictureBox.TabStop = False
        '
        'BorderBottomPictureBox
        '
        Me.BorderBottomPictureBox.BackColor = System.Drawing.Color.Red
        Me.BorderBottomPictureBox.Location = New System.Drawing.Point(0, 297)
        Me.BorderBottomPictureBox.Name = "BorderBottomPictureBox"
        Me.BorderBottomPictureBox.Size = New System.Drawing.Size(500, 1)
        Me.BorderBottomPictureBox.TabIndex = 2
        Me.BorderBottomPictureBox.TabStop = False
        '
        'BorderTopPictureBox
        '
        Me.BorderTopPictureBox.BackColor = System.Drawing.Color.Red
        Me.BorderTopPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.BorderTopPictureBox.Name = "BorderTopPictureBox"
        Me.BorderTopPictureBox.Size = New System.Drawing.Size(500, 1)
        Me.BorderTopPictureBox.TabIndex = 1
        Me.BorderTopPictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.SupremeInventorySystem.My.Resources.Resources.miku_v4
        Me.PictureBox1.Location = New System.Drawing.Point(-79, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 428)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LoadingProgressBar
        '
        Me.LoadingProgressBar.Location = New System.Drawing.Point(282, 234)
        Me.LoadingProgressBar.Name = "LoadingProgressBar"
        Me.LoadingProgressBar.Size = New System.Drawing.Size(205, 23)
        Me.LoadingProgressBar.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Now Loading..."
        '
        'LoadingTimer
        '
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(500, 298)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoadingProgressBar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BorderLeftPictureBox)
        Me.Controls.Add(Me.BorderRightPictureBox)
        Me.Controls.Add(Me.BorderBottomPictureBox)
        Me.Controls.Add(Me.BorderTopPictureBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WelcomeScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Hub"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderLeftPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderRightPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderBottomPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderTopPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BorderTopPictureBox As PictureBox
    Friend WithEvents BorderBottomPictureBox As PictureBox
    Friend WithEvents BorderRightPictureBox As PictureBox
    Friend WithEvents BorderLeftPictureBox As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LoadingProgressBar As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadingTimer As Timer
End Class
