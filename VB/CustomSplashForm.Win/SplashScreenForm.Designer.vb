Namespace CustomSplashForm.Win
    Partial Public Class SplashScreenForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SplashScreenForm))
            Me.label1 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label2 = New System.Windows.Forms.Label()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' label1
            ' 
            Me.label1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles))
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
            Me.label1.Location = New System.Drawing.Point(11, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(194, 29)
            Me.label1.TabIndex = 1
            Me.label1.Text = "My Application"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
            Me.pictureBox1.Location = New System.Drawing.Point(11, 49)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(194, 194)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.pictureBox1.TabIndex = 2
            Me.pictureBox1.TabStop = False
            ' 
            ' label2
            ' 
            Me.label2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.label2.Location = New System.Drawing.Point(11, 246)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(194, 23)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Loading..."
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ' 
            ' SplashScreenForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.ClientSize = New System.Drawing.Size(217, 278)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SplashScreenForm"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SplashScreenForm"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private label1 As System.Windows.Forms.Label
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private label2 As System.Windows.Forms.Label
    End Class
End Namespace