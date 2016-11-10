Public Class Form1
    'KfhgF-HFSDH-JHFHD-5F8RS
    Dim PasswortSet As String = "ABCDEFGHICKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
    Dim rnd As New System.Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(Len(PasswortSet))
        TextBox1.Clear()
        Dim tmp As String = ""
        For i As Integer = 0 To 22
            If i = 5 Or i = 11 Or i = 17 Then
                tmp = tmp & "-"
            Else
                Dim x As Integer = rnd.Next(0, 61)
                tmp = tmp & PasswortSet.Chars(x)
            End If
        Next
        TextBox1.Text = tmp
    End Sub
End Class
