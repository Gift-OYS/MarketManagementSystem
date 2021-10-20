Public Class Main
    Structure Item '单独一件商品
        Dim name As String
        Dim price As Integer
        Public Sub New(newName As String, newPrice As Integer)
            name = newName
            price = newPrice
        End Sub
    End Structure
    Structure Type '一类商品
        Dim name As String
        Dim count As Integer
        Public Sub New(newName As String, newCount As Integer)
            count = newCount
            name = newName
        End Sub
    End Structure

    Public 商品(,) As Item = {{New Item("幸福羊毛衫", 400), New Item("幸福男裤", 350), New Item("米奇T恤", 200), New Item("真维斯衬衫", 180), New Item(" ", 0), New Item(" ", 0)},
        {New Item("红蜻蜓女鞋", 500), New Item("星期六女鞋", 600), New Item("苹果男鞋", 550), New Item("袋鼠男鞋", 400), New Item("幸福童鞋", 260), New Item(" ", 0)},
        {New Item("鳄鱼皮包", 400), New Item("POLO女包", 500), New Item("米奇休闲包", 300), New Item(" ", 0), New Item(" ", 0), New Item(" ", 0)},
        {New Item("小护士大礼包", 100), New Item("欧莱雅保湿露", 300), New Item("兰蔻眼霜", 350), New Item(" ", 0), New Item(" ", 0), New Item(" ", 0)},
        {New Item("睡得香双人被", 400), New Item("幸福4件套", 300), New Item("舒服服按摩枕", 200), New Item(" ", 0), New Item(" ", 0), New Item(" ", 0)},
        {New Item(" ", 0), New Item(" ", 0), New Item(" ", 0), New Item(" ", 0), New Item(" ", 0), New Item(" ", 0)},
        {New Item(" ", 0), New Item(" ", 0), New Item(" ", 0), New Item(" ", 0), New Item(" ", 0), New Item(" ", 0)}}
    Public 商品类别() As Type = {New Type("服装", 4), New Type("鞋", 5), New Type("箱包", 3), New Type("化妆品", 3), New Type("床上用品", 3), New Type(" ", 0), New Type(" ", 0)}
    Dim sum As Double = 0
    Dim reset As Boolean = False
    Dim discount As Double = 30
    Public QUANJU As String
    Dim quan As String
    Dim count As Integer = 0
    Dim countLEI As Integer = 5
    Function StringToInteger(text As String) As Integer '自定义可以抛出异常的函数
        If IsNumeric(text) = False Then
            Throw New InvalidCastException
        ElseIf Convert.ToInt32(数量.Text) < 0 Then
            Throw New InvalidCastException
        Else
            Return Convert.ToInt32(数量.Text)
        End If
    End Function

    Function IsReasonable(shifukuan As Integer, yingfukuan As Integer) As Boolean
        If Convert.ToInt32(shifukuan) < Convert.ToInt32(yingfukuan) Then
            Return False
        Else
            If shifukuan - yingfukuan > 100 Then
                Return False
            ElseIf (shifukuan - yingfukuan) Mod 100 = 0 Then
                Return True
            ElseIf shifukuan = 50 And (shifukuan - yingfukuan) Mod 10 <> 0 Then
                Return True
            ElseIf shifukuan = 100 And (shifukuan - yingfukuan) Mod 50 <> 0 Then
                Return True
            ElseIf (shifukuan - yingfukuan) Mod 10 = 0 And (shifukuan - yingfukuan) Mod 50 <> 0 Then
                Return True
            ElseIf (shifukuan - yingfukuan) Mod 50 = 0 And (shifukuan - yingfukuan) Mod 100 <> 0 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Sub 数量_KeyDown(sender As Object, e As KeyEventArgs) Handles 数量.KeyDown
        If e.KeyCode = Keys.Enter Then
            If 数量.Text <> "" And 商品名称.Text <> "" Then
                Try
                    Dim flag As Boolean = False '判断用户是否已经把改商品添加到购物车
                    For Each i In 购物车.Items
                        If InStr(i.ToString, 商品名称.Text) Then
                            flag = True '该用户已经把该商品添加到购物车
                        End If
                    Next
                    If flag Then
                        购物车.Items.Add(商品名称.Text & vbTab & StringToInteger(数量.Text) & vbTab & vbTab & 单价.Text & vbTab & vbTab & "100%" & vbTab & vbTab & StringToInteger(数量.Text) * Convert.ToInt32(单价.Text))
                        sum += StringToInteger(数量.Text) * Convert.ToInt32(单价.Text)
                    Else
                        If StringToInteger(数量.Text) > 1 Then
                            折扣.Text = "--"
                            If count < 5 Then
                                购物车.Items.Add(商品名称.Text & vbTab & 1 & vbTab & vbTab & 单价.Text & vbTab & vbTab & discount & "%" & vbTab & vbTab & Convert.ToInt32(单价.Text) * discount / 100)
                                sum += Convert.ToInt32(单价.Text) * discount / 100
                                count += 1
                            Else
                                购物车.Items.Add(商品名称.Text & vbTab & 1 & vbTab & vbTab & 单价.Text & vbTab & vbTab & 100 & "%" & vbTab & vbTab & Convert.ToInt32(单价.Text))
                                sum += Convert.ToInt32(单价.Text)
                            End If
                            购物车.Items.Add(商品名称.Text & vbTab & StringToInteger(数量.Text) - 1 & vbTab & vbTab & 单价.Text & vbTab & vbTab & "100%" & vbTab & vbTab & (StringToInteger(数量.Text) - 1) * Convert.ToInt32(单价.Text))
                            sum += (StringToInteger(数量.Text) - 1) * Convert.ToInt32(单价.Text)
                        Else
                            If StringToInteger(数量.Text) = 1 And count < 5 Then
                                折扣.Text = discount & "%"
                                购物车.Items.Add(商品名称.Text & vbTab & 1 & vbTab & vbTab & 单价.Text & vbTab & vbTab & discount & "%" & vbTab & vbTab & Convert.ToInt32(单价.Text) * discount / 100)
                                sum += Convert.ToInt32(单价.Text) * discount / 100
                                count += 1
                            Else
                                折扣.Text = 100 & "%"
                                购物车.Items.Add(商品名称.Text & vbTab & 1 & vbTab & vbTab & 单价.Text & vbTab & vbTab & 100 & "%" & vbTab & vbTab & Convert.ToInt32(单价.Text))
                                sum += Convert.ToInt32(单价.Text)
                            End If
                        End If
                    End If
                Catch ex As InvalidCastException
                    MessageBox.Show("商品数量输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Finally
                    应付款.Text = sum
                End Try
            End If
        End If
    End Sub

    Private Sub 实付款_KeyDown(sender As Object, e As KeyEventArgs) Handles 实付款.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim shifukuan As Integer = 0
                shifukuan = StringToInteger(实付款.Text)
            Catch ex As InvalidCastException
                MessageBox.Show("实付款输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                实付款.Text = ""
            End Try
        End If
    End Sub

    Private Sub 商品列表_SelectedIndexChanged(sender As Object, e As EventArgs) Handles 商品列表.SelectedIndexChanged
        For i As Integer = 0 To 商品.GetLength(0) - 1
            For j As Integer = 0 To 商品.GetLength(1) - 1
                If 商品(i, j).name = 商品列表.SelectedItem.ToString Then
                    商品名称.Text = 商品(i, j).name
                    单价.Text = 商品(i, j).price
                End If
            Next
        Next
    End Sub

    Private Sub 特价商品类别_SelectedIndexChanged(sender As Object, e As EventArgs) Handles 特价商品类别.SelectedIndexChanged
        商品列表.Visible = True
        If 商品列表.Items.Count <> 0 Then
            商品列表.Items.Clear()
        End If
        For i As Integer = 0 To 商品.GetLength(0) - 1
            If i = 特价商品类别.SelectedIndex Then
                For j As Integer = 0 To 商品.GetLength(1) - 1
                    商品列表.Items.Add(商品(i, j).name)
                Next
            End If
        Next
    End Sub

    Private Sub 收款_Click(sender As Object, e As EventArgs) Handles 收款.Click
        If reset Then
            商品列表.Items.Clear()
            购物车.Items.Clear()
            购物车.Items.Add("商品名称" & vbTab & vbTab & "数量" & vbTab & vbTab & "单价" & vbTab & vbTab & "折扣" & vbTab & vbTab & "总额")
            商品名称.Text = ""
            特价商品类别.Text = ""
            数量.Text = ""
            单价.Text = ""
            折扣.Text = ""
            应付款.Text = 0
            实付款.Text = ""
            找零.Text = ""
            sum = 0
            reset = False
        Else
            Try
                If 实付款.Text <> "" Then
                    If IsReasonable(Convert.ToInt32(实付款.Text), Convert.ToInt32(应付款.Text)) Then
                        找零.Text = Convert.ToInt32(实付款.Text) - Convert.ToInt32(应付款.Text)
                        reset = True
                    Else
                        MessageBox.Show("实付款输入不合理！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("请输入实付款！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As InvalidCastException
                MessageBox.Show("实付款输入不合理！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i As Integer = 0 To 商品类别.Length - 1
            If 商品类别(i).name <> " " Then
                特价商品类别.Items.Add(商品类别(i).name)
            End If
        Next
        购物车.Items.Add("商品名称" & vbTab & vbTab & "数量" & vbTab & vbTab & "单价" & vbTab & vbTab & "折扣" & vbTab & vbTab & "总额")
        应付款.Text = 0
        For i As Integer = 0 To 商品.GetLength(0) - 1
            If 商品类别(i).name <> " " Then
                TreeView1.Nodes.Add(商品类别(i).name)

                For j As Integer = 0 To 商品.GetLength(1) - 1
                    If 商品(i, j).name <> " " Then
                        TreeView1.Nodes(i).Nodes.Add(商品(i, j).name)
                    End If
                Next
            End If
        Next
        添加商品种类.Enabled = False
        删除商品种类.Enabled = False
        添加品牌商品.Enabled = False
        删除品牌商品.Enabled = False
        修改付款方式.Enabled = True
    End Sub

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        TreeView1.SelectedNode = e.Node
        Dim isType As Boolean = True
        For i As Integer = 0 To 商品.GetLength(0) - 1
            For j As Integer = 0 To 商品.GetLength(1) - 1
                If 商品(i, j).name = TreeView1.SelectedNode.Text Then
                    isType = False
                    TB4.Text = TreeView1.SelectedNode.Text
                    TB5.Text = 商品(i, j).price
                    TB6.Text = discount & "%"
                End If
            Next
        Next
        If isType Then
            添加商品种类.Enabled = True
            删除商品种类.Enabled = True
            添加品牌商品.Enabled = False
            删除品牌商品.Enabled = False
            TB4.Text = ""
            TB5.Text = ""
            TB6.Text = ""
        Else
            添加商品种类.Enabled = False
            删除商品种类.Enabled = False
            添加品牌商品.Enabled = True
            删除品牌商品.Enabled = True
        End If
    End Sub

    Private Sub 编辑促销折扣_Click(sender As Object, e As EventArgs) Handles 编辑促销折扣.Click
        促销折扣编辑.Show()
    End Sub

    WriteOnly Property mdiscount(newdiscount)
        Set
            Me.discount = newdiscount
        End Set
    End Property

    Private Sub 添加商品种类_Click(sender As Object, e As EventArgs) Handles 添加商品种类.Click
        Dim newForm As Form1 = New Form1(Me)
        newForm.Show()
    End Sub

    Private Sub Label4_TextChanged(sender As Object, e As EventArgs) Handles Label4.TextChanged
        If countLEI = 7 Then
            MessageBox.Show("商品种类数量达到上限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim flag As Integer = 0
            For i As Integer = 0 To 商品类别.Length - 1
                If 商品类别(i).name = " " And flag = 0 And Label4.Text <> " " Then
                    商品类别(i).name = Label4.Text
                    TreeView1.Nodes.Add(Label4.Text)
                    特价商品类别.Items.Add(Label4.Text)
                    countLEI += 1
                    flag = 1
                End If
            Next
        End If
    End Sub

    Private Sub 添加品牌商品_Click(sender As Object, e As EventArgs) Handles 添加品牌商品.Click
        Dim newform As Form2 = New Form2(Me, TreeView1.SelectedNode.Text )
        newform.Show()
        quan = TreeView1.SelectedNode.Text
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        Dim f = 0
        For i As Integer = 0 To 商品.GetLength(0) - 1
            Dim cunzai As Integer = 0
            For j As Integer = 0 To 商品.GetLength(1) - 1
                If 商品(i, j).name = quan Then
                    cunzai = 1
                End If
            Next

            If cunzai = 1 Then
                If 商品类别(i).count = 6 Then
                    MessageBox.Show("品牌商品数量达到上限！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If f = 0 Then
                        For j As Integer = 0 To 商品.GetLength(1) - 1
                            If 商品(i, j).name = " " And f = 0 Then
                                商品(i, j).name = Label2.Text
                                TreeView1.Nodes(i).Nodes.Add(Label2.Text)
                                商品类别(i).count += 1
                                f = 1
                            End If
                        Next
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub 删除品牌商品_Click(sender As Object, e As EventArgs) Handles 删除品牌商品.Click
        If MessageBox.Show("你确定要删除该品牌商品吗？", "删除品牌商品", MessageBoxButtons.YesNo， MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim temp As String = TreeView1.SelectedNode.Text
            Dim n As Integer
            Dim f As Integer
            TreeView1.Nodes.Remove(TreeView1.SelectedNode)
            For i As Integer = 0 To 商品.GetLength(0) - 1
                For j As Integer = 0 To 商品.GetLength(1) - 1
                    If 商品(i, j).name = temp Then
                        n = i
                        For k As Integer = j To 商品.GetLength(1) - 2
                            商品(i, k) = 商品(i, k + 1)
                        Next
                        商品类别(i).count -= 1
                    End If
                Next
            Next
            For i As Integer = 1 To 商品.GetLength(1) - 1
                If 商品(n, i).name = 商品(n, i - 1).name Then
                    商品(n, i) = New Item("", 0)
                    f = 1
                End If
            Next
        End If
    End Sub

    Private Sub 删除商品种类_Click(sender As Object, e As EventArgs) Handles 删除商品种类.Click
        If MessageBox.Show("你确定要删除该商品种类吗？", "删除商品种类", MessageBoxButtons.YesNo， MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim temp As String = TreeView1.SelectedNode.Text
            TreeView1.Nodes.Remove(TreeView1.SelectedNode)
            For i As Integer = 0 To 商品类别.Length - 1
                If 商品类别(i).name = temp Then
                    For j As Integer = i To 商品类别.Length - 2
                        商品类别(j).name = 商品类别(j + 1).name
                        For k As Integer = 0 To 商品.GetLength(1) - 1
                            商品(j, k) = 商品(j + 1, k)
                        Next
                    Next
                End If
            Next
        End If
        countLEI -= 1
        For i As Integer = 1 To 商品类别.Length - 1
            If 商品类别(i).name = 商品类别(i - 1).name Then
                商品类别(i).name = " "
            End If
        Next
        特价商品类别.Items.Clear()
        For i As Integer = 0 To 商品类别.Length - 1
            If 商品类别(i).name <> " " Then
                特价商品类别.Items.Add(商品类别(i).name)
            End If
        Next
    End Sub

    Private Sub 修改付款方式_Click(sender As Object, e As EventArgs) Handles 修改付款方式.Click
        Dim newform As 修改付款方式 = New 修改付款方式(Me)
        newform.Show()
    End Sub

    Private Sub TB5_TextChanged(sender As Object, e As EventArgs) Handles TB5.TextChanged
        If TB5.Text <> "" Then
            For i As Integer = 0 To 商品.GetLength(0) - 1
                For j As Integer = 0 To 商品.GetLength(1) - 1
                    If 商品(i, j).name = TB4.Text Then
                        商品(i, j).price = Convert.ToInt32(TB5.Text)
                    End If
                Next
            Next
        End If
    End Sub
End Class
