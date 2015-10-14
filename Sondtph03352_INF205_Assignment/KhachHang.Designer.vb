<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KhachHang
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
        Me.Txt_Ma_KH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Ten_KH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_SDT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_DiaChi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btn_Okk = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_Ma_KH
        '
        Me.Txt_Ma_KH.Location = New System.Drawing.Point(143, 54)
        Me.Txt_Ma_KH.Name = "Txt_Ma_KH"
        Me.Txt_Ma_KH.Size = New System.Drawing.Size(137, 20)
        Me.Txt_Ma_KH.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Khách Hàng:"
        '
        'Txt_Ten_KH
        '
        Me.Txt_Ten_KH.Location = New System.Drawing.Point(143, 98)
        Me.Txt_Ten_KH.Name = "Txt_Ten_KH"
        Me.Txt_Ten_KH.Size = New System.Drawing.Size(137, 20)
        Me.Txt_Ten_KH.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Khách Hàng:"
        '
        'Txt_SDT
        '
        Me.Txt_SDT.Location = New System.Drawing.Point(143, 144)
        Me.Txt_SDT.Name = "Txt_SDT"
        Me.Txt_SDT.Size = New System.Drawing.Size(137, 20)
        Me.Txt_SDT.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Số Điện Thoại"
        '
        'Txt_DiaChi
        '
        Me.Txt_DiaChi.Location = New System.Drawing.Point(143, 195)
        Me.Txt_DiaChi.Name = "Txt_DiaChi"
        Me.Txt_DiaChi.Size = New System.Drawing.Size(137, 20)
        Me.Txt_DiaChi.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Địa Chỉ"
        '
        'Btn_Okk
        '
        Me.Btn_Okk.Location = New System.Drawing.Point(72, 270)
        Me.Btn_Okk.Name = "Btn_Okk"
        Me.Btn_Okk.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Okk.TabIndex = 2
        Me.Btn_Okk.Text = "&Ok"
        Me.Btn_Okk.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(183, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'KhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 367)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_Okk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_DiaChi)
        Me.Controls.Add(Me.Txt_SDT)
        Me.Controls.Add(Me.Txt_Ten_KH)
        Me.Controls.Add(Me.Txt_Ma_KH)
        Me.Name = "KhachHang"
        Me.Text = "Khách Hàng"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Ma_KH As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Ten_KH As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_SDT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_DiaChi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Okk As Button
    Friend WithEvents Button2 As Button
End Class
