Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace CustomSplashForm.Win
    Partial Public Class SplashScreenForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Friend Sub UpdateInfo(ByVal info As String)
            label2.Text = info
        End Sub
    End Class
End Namespace
