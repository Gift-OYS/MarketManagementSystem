Public Class 修改付款方式
    Shadows parentForm As Main
    Public Sub New(form As Main)
        parentForm = form
        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            parentForm.TextBox1.Text = "现金"
        End If
        If RadioButton2.Checked Then
            parentForm.TextBox1.Text = "微信"
            w.Show()
        End If
        If RadioButton3.Checked Then
            parentForm.TextBox1.Text = "支付宝"
            z.Show()
        End If
        Me.Hide()
    End Sub
End Class