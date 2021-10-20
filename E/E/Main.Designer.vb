<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.欢迎界面 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.欢迎来到 = New System.Windows.Forms.Label()
        Me.收银台 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.shangpinmingcheng = New System.Windows.Forms.Label()
        Me.商品名称 = New System.Windows.Forms.TextBox()
        Me.找零 = New System.Windows.Forms.TextBox()
        Me.实付款 = New System.Windows.Forms.TextBox()
        Me.应付款 = New System.Windows.Forms.TextBox()
        Me.折扣 = New System.Windows.Forms.TextBox()
        Me.单价 = New System.Windows.Forms.TextBox()
        Me.数量 = New System.Windows.Forms.TextBox()
        Me.特价商品类别 = New System.Windows.Forms.ComboBox()
        Me.收款 = New System.Windows.Forms.Button()
        Me.zhaoling = New System.Windows.Forms.Label()
        Me.购物车 = New System.Windows.Forms.ListBox()
        Me.商品列表 = New System.Windows.Forms.ListBox()
        Me.shifukuan = New System.Windows.Forms.Label()
        Me.yingfukuan = New System.Windows.Forms.Label()
        Me.zhekou = New System.Windows.Forms.Label()
        Me.danjia = New System.Windows.Forms.Label()
        Me.shuliang = New System.Windows.Forms.Label()
        Me.tejiashangpinleibie = New System.Windows.Forms.Label()
        Me.后台管理 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.管理员操作窗格 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.修改付款方式 = New System.Windows.Forms.Button()
        Me.删除品牌商品 = New System.Windows.Forms.Button()
        Me.删除商品种类 = New System.Windows.Forms.Button()
        Me.添加品牌商品 = New System.Windows.Forms.Button()
        Me.添加商品种类 = New System.Windows.Forms.Button()
        Me.编辑促销折扣 = New System.Windows.Forms.Button()
        Me.商品信息窗格 = New System.Windows.Forms.Label()
        Me.后台_商品一览 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TB5 = New System.Windows.Forms.TextBox()
        Me.TB6 = New System.Windows.Forms.TextBox()
        Me.TB3 = New System.Windows.Forms.TextBox()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.TB4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.欢迎界面.SuspendLayout()
        Me.收银台.SuspendLayout()
        Me.后台管理.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.欢迎界面)
        Me.TabControl1.Controls.Add(Me.收银台)
        Me.TabControl1.Controls.Add(Me.后台管理)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(799, 451)
        Me.TabControl1.TabIndex = 0
        '
        '欢迎界面
        '
        Me.欢迎界面.BackgroundImage = CType(resources.GetObject("欢迎界面.BackgroundImage"), System.Drawing.Image)
        Me.欢迎界面.Controls.Add(Me.Label1)
        Me.欢迎界面.Controls.Add(Me.欢迎来到)
        Me.欢迎界面.Font = New System.Drawing.Font("微软雅黑", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.欢迎界面.Location = New System.Drawing.Point(4, 25)
        Me.欢迎界面.Name = "欢迎界面"
        Me.欢迎界面.Padding = New System.Windows.Forms.Padding(3)
        Me.欢迎界面.Size = New System.Drawing.Size(791, 422)
        Me.欢迎界面.TabIndex = 0
        Me.欢迎界面.Text = "欢迎界面"
        Me.欢迎界面.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("华文新魏", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(556, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "XX商城！"
        '
        '欢迎来到
        '
        Me.欢迎来到.AutoSize = True
        Me.欢迎来到.Font = New System.Drawing.Font("华文新魏", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.欢迎来到.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.欢迎来到.Location = New System.Drawing.Point(425, 53)
        Me.欢迎来到.Name = "欢迎来到"
        Me.欢迎来到.Size = New System.Drawing.Size(196, 44)
        Me.欢迎来到.TabIndex = 0
        Me.欢迎来到.Text = "欢迎来到"
        '
        '收银台
        '
        Me.收银台.BackColor = System.Drawing.Color.WhiteSmoke
        Me.收银台.Controls.Add(Me.TextBox1)
        Me.收银台.Controls.Add(Me.Label5)
        Me.收银台.Controls.Add(Me.shangpinmingcheng)
        Me.收银台.Controls.Add(Me.商品名称)
        Me.收银台.Controls.Add(Me.找零)
        Me.收银台.Controls.Add(Me.实付款)
        Me.收银台.Controls.Add(Me.应付款)
        Me.收银台.Controls.Add(Me.折扣)
        Me.收银台.Controls.Add(Me.单价)
        Me.收银台.Controls.Add(Me.数量)
        Me.收银台.Controls.Add(Me.特价商品类别)
        Me.收银台.Controls.Add(Me.收款)
        Me.收银台.Controls.Add(Me.zhaoling)
        Me.收银台.Controls.Add(Me.购物车)
        Me.收银台.Controls.Add(Me.商品列表)
        Me.收银台.Controls.Add(Me.shifukuan)
        Me.收银台.Controls.Add(Me.yingfukuan)
        Me.收银台.Controls.Add(Me.zhekou)
        Me.收银台.Controls.Add(Me.danjia)
        Me.收银台.Controls.Add(Me.shuliang)
        Me.收银台.Controls.Add(Me.tejiashangpinleibie)
        Me.收银台.Font = New System.Drawing.Font("微软雅黑", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.收银台.Location = New System.Drawing.Point(4, 25)
        Me.收银台.Name = "收银台"
        Me.收银台.Padding = New System.Windows.Forms.Padding(3)
        Me.收银台.Size = New System.Drawing.Size(791, 422)
        Me.收银台.TabIndex = 1
        Me.收银台.Text = "收银台"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(187, 353)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 27)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Text = "现金"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "付款方式"
        '
        'shangpinmingcheng
        '
        Me.shangpinmingcheng.AutoSize = True
        Me.shangpinmingcheng.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.shangpinmingcheng.Location = New System.Drawing.Point(241, 43)
        Me.shangpinmingcheng.Name = "shangpinmingcheng"
        Me.shangpinmingcheng.Size = New System.Drawing.Size(69, 20)
        Me.shangpinmingcheng.TabIndex = 21
        Me.shangpinmingcheng.Text = "商品名称"
        '
        '商品名称
        '
        Me.商品名称.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.商品名称.Location = New System.Drawing.Point(241, 67)
        Me.商品名称.Name = "商品名称"
        Me.商品名称.Size = New System.Drawing.Size(100, 27)
        Me.商品名称.TabIndex = 20
        '
        '找零
        '
        Me.找零.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.找零.Location = New System.Drawing.Point(467, 353)
        Me.找零.Name = "找零"
        Me.找零.Size = New System.Drawing.Size(100, 27)
        Me.找零.TabIndex = 18
        Me.找零.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '实付款
        '
        Me.实付款.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.实付款.Location = New System.Drawing.Point(309, 353)
        Me.实付款.Name = "实付款"
        Me.实付款.Size = New System.Drawing.Size(100, 27)
        Me.实付款.TabIndex = 17
        Me.实付款.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '应付款
        '
        Me.应付款.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.应付款.Location = New System.Drawing.Point(51, 353)
        Me.应付款.Name = "应付款"
        Me.应付款.Size = New System.Drawing.Size(100, 27)
        Me.应付款.TabIndex = 16
        Me.应付款.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '折扣
        '
        Me.折扣.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.折扣.Location = New System.Drawing.Point(631, 67)
        Me.折扣.Name = "折扣"
        Me.折扣.Size = New System.Drawing.Size(100, 27)
        Me.折扣.TabIndex = 15
        '
        '单价
        '
        Me.单价.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.单价.Location = New System.Drawing.Point(497, 67)
        Me.单价.Name = "单价"
        Me.单价.Size = New System.Drawing.Size(100, 27)
        Me.单价.TabIndex = 14
        '
        '数量
        '
        Me.数量.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.数量.Location = New System.Drawing.Point(390, 67)
        Me.数量.Name = "数量"
        Me.数量.Size = New System.Drawing.Size(74, 27)
        Me.数量.TabIndex = 13
        '
        '特价商品类别
        '
        Me.特价商品类别.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.特价商品类别.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.特价商品类别.FormattingEnabled = True
        Me.特价商品类别.Location = New System.Drawing.Point(51, 69)
        Me.特价商品类别.Name = "特价商品类别"
        Me.特价商品类别.Size = New System.Drawing.Size(116, 28)
        Me.特价商品类别.TabIndex = 11
        '
        '收款
        '
        Me.收款.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.收款.Location = New System.Drawing.Point(635, 346)
        Me.收款.Name = "收款"
        Me.收款.Size = New System.Drawing.Size(99, 34)
        Me.收款.TabIndex = 10
        Me.收款.Text = "收款/重置"
        Me.收款.UseVisualStyleBackColor = True
        '
        'zhaoling
        '
        Me.zhaoling.AutoSize = True
        Me.zhaoling.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.zhaoling.Location = New System.Drawing.Point(464, 323)
        Me.zhaoling.Name = "zhaoling"
        Me.zhaoling.Size = New System.Drawing.Size(39, 20)
        Me.zhaoling.TabIndex = 9
        Me.zhaoling.Text = "找零"
        '
        '购物车
        '
        Me.购物车.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.购物车.FormattingEnabled = True
        Me.购物车.ItemHeight = 20
        Me.购物车.Location = New System.Drawing.Point(241, 112)
        Me.购物车.Name = "购物车"
        Me.购物车.Size = New System.Drawing.Size(490, 164)
        Me.购物车.TabIndex = 8
        '
        '商品列表
        '
        Me.商品列表.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.商品列表.FormattingEnabled = True
        Me.商品列表.ItemHeight = 20
        Me.商品列表.Location = New System.Drawing.Point(51, 112)
        Me.商品列表.Name = "商品列表"
        Me.商品列表.Size = New System.Drawing.Size(143, 164)
        Me.商品列表.TabIndex = 7
        '
        'shifukuan
        '
        Me.shifukuan.AutoSize = True
        Me.shifukuan.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.shifukuan.Location = New System.Drawing.Point(306, 323)
        Me.shifukuan.Name = "shifukuan"
        Me.shifukuan.Size = New System.Drawing.Size(54, 20)
        Me.shifukuan.TabIndex = 6
        Me.shifukuan.Text = "实付款"
        '
        'yingfukuan
        '
        Me.yingfukuan.AutoSize = True
        Me.yingfukuan.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.yingfukuan.Location = New System.Drawing.Point(50, 321)
        Me.yingfukuan.Name = "yingfukuan"
        Me.yingfukuan.Size = New System.Drawing.Size(54, 20)
        Me.yingfukuan.TabIndex = 5
        Me.yingfukuan.Text = "应付款"
        '
        'zhekou
        '
        Me.zhekou.AutoSize = True
        Me.zhekou.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.zhekou.Location = New System.Drawing.Point(628, 43)
        Me.zhekou.Name = "zhekou"
        Me.zhekou.Size = New System.Drawing.Size(39, 20)
        Me.zhekou.TabIndex = 4
        Me.zhekou.Text = "折扣"
        '
        'danjia
        '
        Me.danjia.AutoSize = True
        Me.danjia.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.danjia.Location = New System.Drawing.Point(494, 43)
        Me.danjia.Name = "danjia"
        Me.danjia.Size = New System.Drawing.Size(39, 20)
        Me.danjia.TabIndex = 3
        Me.danjia.Text = "单价"
        '
        'shuliang
        '
        Me.shuliang.AutoSize = True
        Me.shuliang.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.shuliang.Location = New System.Drawing.Point(387, 43)
        Me.shuliang.Name = "shuliang"
        Me.shuliang.Size = New System.Drawing.Size(39, 20)
        Me.shuliang.TabIndex = 2
        Me.shuliang.Text = "数量"
        '
        'tejiashangpinleibie
        '
        Me.tejiashangpinleibie.AutoSize = True
        Me.tejiashangpinleibie.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tejiashangpinleibie.Location = New System.Drawing.Point(47, 43)
        Me.tejiashangpinleibie.Name = "tejiashangpinleibie"
        Me.tejiashangpinleibie.Size = New System.Drawing.Size(99, 20)
        Me.tejiashangpinleibie.TabIndex = 0
        Me.tejiashangpinleibie.Text = "特价商品类别"
        '
        '后台管理
        '
        Me.后台管理.BackColor = System.Drawing.Color.WhiteSmoke
        Me.后台管理.Controls.Add(Me.Label4)
        Me.后台管理.Controls.Add(Me.管理员操作窗格)
        Me.后台管理.Controls.Add(Me.TableLayoutPanel2)
        Me.后台管理.Controls.Add(Me.商品信息窗格)
        Me.后台管理.Controls.Add(Me.后台_商品一览)
        Me.后台管理.Controls.Add(Me.TreeView1)
        Me.后台管理.Controls.Add(Me.TableLayoutPanel1)
        Me.后台管理.Controls.Add(Me.Label3)
        Me.后台管理.Controls.Add(Me.Label2)
        Me.后台管理.Font = New System.Drawing.Font("微软雅黑", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.后台管理.Location = New System.Drawing.Point(4, 25)
        Me.后台管理.Name = "后台管理"
        Me.后台管理.Padding = New System.Windows.Forms.Padding(3)
        Me.后台管理.Size = New System.Drawing.Size(791, 422)
        Me.后台管理.TabIndex = 2
        Me.后台管理.Text = "后台管理"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(622, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 23)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = " "
        Me.Label4.Visible = False
        '
        '管理员操作窗格
        '
        Me.管理员操作窗格.AutoSize = True
        Me.管理员操作窗格.Location = New System.Drawing.Point(482, 221)
        Me.管理员操作窗格.Name = "管理员操作窗格"
        Me.管理员操作窗格.Size = New System.Drawing.Size(129, 23)
        Me.管理员操作窗格.TabIndex = 5
        Me.管理员操作窗格.Text = "管理员操作窗格"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.Controls.Add(Me.修改付款方式, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.删除品牌商品, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.删除商品种类, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.添加品牌商品, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.添加商品种类, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.编辑促销折扣, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(337, 260)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(400, 110)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        '修改付款方式
        '
        Me.修改付款方式.Location = New System.Drawing.Point(271, 58)
        Me.修改付款方式.Name = "修改付款方式"
        Me.修改付款方式.Size = New System.Drawing.Size(125, 48)
        Me.修改付款方式.TabIndex = 6
        Me.修改付款方式.Text = "修改付款方式"
        Me.修改付款方式.UseVisualStyleBackColor = True
        '
        '删除品牌商品
        '
        Me.删除品牌商品.Location = New System.Drawing.Point(4, 58)
        Me.删除品牌商品.Name = "删除品牌商品"
        Me.删除品牌商品.Size = New System.Drawing.Size(127, 48)
        Me.删除品牌商品.TabIndex = 5
        Me.删除品牌商品.Text = "删除品牌商品"
        Me.删除品牌商品.UseVisualStyleBackColor = True
        '
        '删除商品种类
        '
        Me.删除商品种类.Location = New System.Drawing.Point(138, 4)
        Me.删除商品种类.Name = "删除商品种类"
        Me.删除商品种类.Size = New System.Drawing.Size(126, 47)
        Me.删除商品种类.TabIndex = 2
        Me.删除商品种类.Text = "删除商品种类"
        Me.删除商品种类.UseVisualStyleBackColor = True
        '
        '添加品牌商品
        '
        Me.添加品牌商品.Location = New System.Drawing.Point(271, 4)
        Me.添加品牌商品.Name = "添加品牌商品"
        Me.添加品牌商品.Size = New System.Drawing.Size(125, 47)
        Me.添加品牌商品.TabIndex = 1
        Me.添加品牌商品.Text = "添加品牌商品"
        Me.添加品牌商品.UseVisualStyleBackColor = True
        '
        '添加商品种类
        '
        Me.添加商品种类.Location = New System.Drawing.Point(4, 4)
        Me.添加商品种类.Name = "添加商品种类"
        Me.添加商品种类.Size = New System.Drawing.Size(127, 47)
        Me.添加商品种类.TabIndex = 0
        Me.添加商品种类.Text = "添加商品种类"
        Me.添加商品种类.UseVisualStyleBackColor = True
        '
        '编辑促销折扣
        '
        Me.编辑促销折扣.Location = New System.Drawing.Point(139, 58)
        Me.编辑促销折扣.Name = "编辑促销折扣"
        Me.编辑促销折扣.Size = New System.Drawing.Size(125, 48)
        Me.编辑促销折扣.TabIndex = 4
        Me.编辑促销折扣.Text = "编辑促销折扣"
        Me.编辑促销折扣.UseVisualStyleBackColor = True
        '
        '商品信息窗格
        '
        Me.商品信息窗格.AutoSize = True
        Me.商品信息窗格.Location = New System.Drawing.Point(482, 55)
        Me.商品信息窗格.Name = "商品信息窗格"
        Me.商品信息窗格.Size = New System.Drawing.Size(112, 23)
        Me.商品信息窗格.TabIndex = 3
        Me.商品信息窗格.Text = "商品信息窗格"
        '
        '后台_商品一览
        '
        Me.后台_商品一览.AutoSize = True
        Me.后台_商品一览.Location = New System.Drawing.Point(107, 20)
        Me.后台_商品一览.Name = "后台_商品一览"
        Me.后台_商品一览.Size = New System.Drawing.Size(78, 23)
        Me.后台_商品一览.TabIndex = 1
        Me.后台_商品一览.Text = "商品一览"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(46, 55)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(221, 339)
        Me.TreeView1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.TB5, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TB6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TB3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TB2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TB1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TB4, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(337, 100)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(400, 61)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TB5
        '
        Me.TB5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TB5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB5.Location = New System.Drawing.Point(138, 34)
        Me.TB5.Name = "TB5"
        Me.TB5.Size = New System.Drawing.Size(126, 23)
        Me.TB5.TabIndex = 7
        Me.TB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB6
        '
        Me.TB6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TB6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB6.Enabled = False
        Me.TB6.Location = New System.Drawing.Point(271, 34)
        Me.TB6.Name = "TB6"
        Me.TB6.Size = New System.Drawing.Size(125, 23)
        Me.TB6.TabIndex = 6
        Me.TB6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB3
        '
        Me.TB3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TB3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB3.Enabled = False
        Me.TB3.Location = New System.Drawing.Point(271, 4)
        Me.TB3.Name = "TB3"
        Me.TB3.Size = New System.Drawing.Size(125, 23)
        Me.TB3.TabIndex = 5
        Me.TB3.Text = "商品折扣"
        Me.TB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB2
        '
        Me.TB2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TB2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB2.Enabled = False
        Me.TB2.Location = New System.Drawing.Point(138, 4)
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(126, 23)
        Me.TB2.TabIndex = 4
        Me.TB2.Text = "商品价格"
        Me.TB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB1
        '
        Me.TB1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TB1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB1.Enabled = False
        Me.TB1.Location = New System.Drawing.Point(4, 4)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(127, 23)
        Me.TB1.TabIndex = 0
        Me.TB1.Text = "商品名称"
        Me.TB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB4
        '
        Me.TB4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TB4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB4.Enabled = False
        Me.TB4.Location = New System.Drawing.Point(4, 34)
        Me.TB4.Name = "TB4"
        Me.TB4.Size = New System.Drawing.Size(127, 23)
        Me.TB4.TabIndex = 4
        Me.TB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(622, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = " "
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(579, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = " "
        Me.Label2.Visible = False
        '
        'Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "商店管理系统"
        Me.TabControl1.ResumeLayout(False)
        Me.欢迎界面.ResumeLayout(False)
        Me.欢迎界面.PerformLayout()
        Me.收银台.ResumeLayout(False)
        Me.收银台.PerformLayout()
        Me.后台管理.ResumeLayout(False)
        Me.后台管理.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents 欢迎界面 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents 欢迎来到 As Label
    Friend WithEvents 收银台 As TabPage
    Friend WithEvents 找零 As TextBox
    Friend WithEvents 实付款 As TextBox
    Friend WithEvents 应付款 As TextBox
    Friend WithEvents 折扣 As TextBox
    Friend WithEvents 单价 As TextBox
    Friend WithEvents 数量 As TextBox
    'Friend WithEvents 商品名称 As TextBox
    Friend WithEvents 特价商品类别 As ComboBox
    Friend WithEvents 收款 As Button
    Friend WithEvents zhaoling As Label
    Friend WithEvents 购物车 As ListBox
    Friend WithEvents 商品列表 As ListBox
    Friend WithEvents shifukuan As Label
    Friend WithEvents yingfukuan As Label
    Friend WithEvents zhekou As Label
    Friend WithEvents danjia As Label
    Friend WithEvents shuliang As Label
    Friend WithEvents tejiashangpinleibie As Label
    Friend WithEvents 后台管理 As TabPage
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents 商品名称 As TextBox
    Friend WithEvents shangpinmingcheng As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents 后台_商品一览 As Label
    Friend WithEvents 商品信息窗格 As Label
    Friend WithEvents TB1 As TextBox
    Friend WithEvents TB4 As TextBox
    Friend WithEvents TB5 As TextBox
    Friend WithEvents TB6 As TextBox
    Friend WithEvents TB3 As TextBox
    Friend WithEvents TB2 As TextBox
    Friend WithEvents 管理员操作窗格 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents 修改付款方式 As Button
    Friend WithEvents 删除品牌商品 As Button
    Friend WithEvents 删除商品种类 As Button
    Friend WithEvents 添加品牌商品 As Button
    Friend WithEvents 添加商品种类 As Button
    Friend WithEvents 编辑促销折扣 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
