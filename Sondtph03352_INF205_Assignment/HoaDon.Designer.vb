<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HoaDon
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_MaKH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_MaHD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_OK = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Dtp_NgayLap = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Khách Hàng:"
        '
        'Txt_MaKH
        '
        Me.Txt_MaKH.Location = New System.Drawing.Point(147, 55)
        Me.Txt_MaKH.Name = "Txt_MaKH"
        Me.Txt_MaKH.Size = New System.Drawing.Size(173, 20)
        Me.Txt_MaKH.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Hóa Đơn:"
        '
        'Txt_MaHD
        '
        Me.Txt_MaHD.Location = New System.Drawing.Point(147, 106)
        Me.Txt_MaHD.Name = "Txt_MaHD"
        Me.Txt_MaHD.Size = New System.Drawing.Size(173, 20)
        Me.Txt_MaHD.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ngày Lập"
        '
        'Btn_OK
        '
        Me.Btn_OK.Location = New System.Drawing.Point(86, 217)
        Me.Btn_OK.Name = "Btn_OK"
        Me.Btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.Btn_OK.TabIndex = 2
        Me.Btn_OK.Text = "&Ok"
        Me.Btn_OK.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Dtp_NgayLap
        '
        Me.Dtp_NgayLap.Location = New System.Drawing.Point(147, 166)
        Me.Dtp_NgayLap.Name = "Dtp_NgayLap"
        Me.Dtp_NgayLap.Size = New System.Drawing.Size(173, 20)
        Me.Dtp_NgayLap.TabIndex = 3
        '
        'HoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 296)
        Me.Controls.Add(Me.Dtp_NgayLap)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_OK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_MaHD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_MaKH)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HoaDon"
        Me.Text = "Hoa Don"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_MaKH As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_MaHD As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_OK As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Dtp_NgayLap As DateTimePicker
End Class
