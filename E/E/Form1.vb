Public Class Form1
    Dim ss As String
    Shadows parentForm As Main
    Public Sub New(form As Main)
        parentForm = form
        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub Button1Click(sender As Object, e As EventArgs) Handles Button1.Click
        parentForm.Label4.Text = RichTextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

End Class