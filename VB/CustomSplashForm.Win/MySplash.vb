Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp.Win

Namespace CustomSplashForm.Win
    Public Class MySplash
        Implements ISplash, ISupportUpdateSplash

        Private Shared form As SplashScreenForm
        Private Shared _isStarted As Boolean = False
        Public Sub Start() Implements ISplash.Start
            _isStarted = True
            form = New SplashScreenForm()
            form.Show()
            System.Windows.Forms.Application.DoEvents()
        End Sub
        Public Sub [Stop]() Implements ISplash.Stop
            If form IsNot Nothing Then
                form.Hide()
                form.Close()
                form = Nothing
            End If
            _isStarted = False
        End Sub
        Public Sub SetDisplayText(ByVal displayText As String) Implements ISplash.SetDisplayText
        End Sub
        Public ReadOnly Property IsStarted() As Boolean Implements ISplash.IsStarted
            Get
                Return _isStarted
            End Get
        End Property
        Public Sub UpdateSplash(ByVal caption As String, ByVal description As String, ParamArray ByVal additionalParams() As Object) Implements ISupportUpdateSplash.UpdateSplash
            form.UpdateInfo(description)
        End Sub
    End Class

End Namespace
