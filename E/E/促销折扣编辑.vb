Public Class 促销折扣编辑
    Dim mDiscount As Double
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If Convert.ToInt32(TrackBar1.Value) = 100 Then
            mDiscount = 9.9
        ElseIf Convert.ToInt32(TrackBar1.Value) = 0 Then
            mDiscount = 0.1
        Else
            mDiscount = Convert.ToInt32(TrackBar1.Value) / 10
        End If
        折扣.Text = "折扣： " & mDiscount & " 折"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Main.mdiscount(mDiscount * 10) = mDiscount * 10
    End Sub

End Class