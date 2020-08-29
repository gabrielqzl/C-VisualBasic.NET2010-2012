Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Hola Mundo", MsgBoxStyle.AbortRetryIgnore, "Abort Retry Ignore")
        MsgBox("Aplication Modal", MsgBoxStyle.ApplicationModal, "AplicationModal")
        MsgBox("Critical", MsgBoxStyle.Critical, "Critical")
        MsgBox("Default Button1", MsgBoxStyle.DefaultButton1, "Default Button1")
        MsgBox("Default Button2", MsgBoxStyle.DefaultButton2, "Default Button2")
        MsgBox("Default Button3", MsgBoxStyle.DefaultButton3, "Default Button3")
        MsgBox("Exclamation", MsgBoxStyle.Exclamation, "Exclamation")
        MsgBox("Information", MsgBoxStyle.Information, "Information")
        MsgBox("Box Help", MsgBoxStyle.MsgBoxHelp, "Help")
        MsgBox("Box Right", MsgBoxStyle.MsgBoxRight, "Box Right")
        MsgBox("BoxRtlReading", MsgBoxStyle.MsgBoxRtlReading, "BoxRtlReading")
        MsgBox("BoxSetForegroond", MsgBoxStyle.MsgBoxSetForeground, "MsgBoxSetForeground")
        MsgBox("Box OkCancel", MsgBoxStyle.OkCancel, "OkCancel")
        MsgBox("Box OkOnly", MsgBoxStyle.OkOnly, "Ok Only")
        MsgBox("Box Question", MsgBoxStyle.Question, "Question")
        MsgBox("Box RetryCancel ", MsgBoxStyle.RetryCancel, "RetryCancel")
        MsgBox("Box YesNo", MsgBoxStyle.YesNo, "YesNo")
        MsgBox("Box YesNoCancel", MsgBoxStyle.YesNoCancel, "YesNoCancel")
    End Sub
End Class
