<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Ma_LSP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Ma_SP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Ten_SP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Mota = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Soluong = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Btn_Ok
        '
        Me.Btn_Ok.Location = New System.Drawing.Point(104, 252)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Ok.TabIndex = 9
        Me.Btn_Ok.Text = "&Ok"
        Me.Btn_Ok.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(234, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mã Loại Sản Phẩm:"
        '
        'Txt_Ma_LSP
        '
        Me.Txt_Ma_LSP.Location = New System.Drawing.Point(156, 30)
        Me.Txt_Ma_LSP.Name = "Txt_Ma_LSP"
        Me.Txt_Ma_LSP.Size = New System.Drawing.Size(205, 20)
        Me.Txt_Ma_LSP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm:"
        '
        'Txt_Ma_SP
        '
        Me.Txt_Ma_SP.Location = New System.Drawing.Point(156, 76)
        Me.Txt_Ma_SP.Name = "Txt_Ma_SP"
        Me.Txt_Ma_SP.Size = New System.Drawing.Size(205, 20)
        Me.Txt_Ma_SP.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên Sản Phẩm:"
        '
        'Txt_Ten_SP
        '
        Me.Txt_Ten_SP.Location = New System.Drawing.Point(156, 121)
        Me.Txt_Ten_SP.Name = "Txt_Ten_SP"
        Me.Txt_Ten_SP.Size = New System.Drawing.Size(205, 20)
        Me.Txt_Ten_SP.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mô Tả:"
        '
        'Txt_Mota
        '
        Me.Txt_Mota.Location = New System.Drawing.Point(156, 164)
        Me.Txt_Mota.Name = "Txt_Mota"
        Me.Txt_Mota.Size = New System.Drawing.Size(205, 20)
        Me.Txt_Mota.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số Lượng:"
        '
        'Txt_Soluong
        '
        Me.Txt_Soluong.Location = New System.Drawing.Point(156, 205)
        Me.Txt_Soluong.Name = "Txt_Soluong"
        Me.Txt_Soluong.Size = New System.Drawing.Size(205, 20)
        Me.Txt_Soluong.TabIndex = 1
        '
        'SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 307)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_Ok)
        Me.Controls.Add(Me.Txt_Soluong)
        Me.Controls.Add(Me.Txt_Mota)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_Ma_SP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Ten_SP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Ma_LSP)
        Me.Controls.Add(Me.Label5)
        Me.Name = "SanPham"
        Me.Text = "Quan Ly San Pham"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Btn_Ok As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Ma_LSP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Ma_SP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Ten_SP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Mota As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Soluong As TextBox
End Class
