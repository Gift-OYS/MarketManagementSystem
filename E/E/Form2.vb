Public Class Form2
    Shadows parentForm As Main
    Dim ss As String
    Public Sub New(form As Main, s As String)
        parentForm = form
        ss = s
        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        parentForm.Label2.Text = RichTextBox1.Text

        Me.Hide()
    End Sub
End Class