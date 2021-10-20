<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 促销折扣编辑
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.折扣 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TrackBar1.Location = New System.Drawing.Point(103, 71)
        Me.TrackBar1.Maximum = 98
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(227, 56)
        Me.TrackBar1.TabIndex = 0
        Me.TrackBar1.TickFrequency = 2
        '
        '折扣
        '
        Me.折扣.AutoSize = True
        Me.折扣.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.折扣.Location = New System.Drawing.Point(160, 143)
        Me.折扣.Name = "折扣"
        Me.折扣.Size = New System.Drawing.Size(81, 20)
        Me.折扣.TabIndex = 1
        Me.折扣.Text = "折扣：   折"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '促销折扣编辑
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(419, 292)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.折扣)
        Me.Controls.Add(Me.TrackBar1)
        Me.Name = "促销折扣编辑"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "编辑促销折扣"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents 折扣 As Label
    Friend WithEvents Button1 As Button
End Class
