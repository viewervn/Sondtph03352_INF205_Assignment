<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLyBanHang
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
        Me.Dgv_Sanpham = New System.Windows.Forms.DataGridView()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Lbl_Search = New System.Windows.Forms.Label()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb_Chi_Tiet_Hoa_Don = New System.Windows.Forms.RadioButton()
        Me.Rb_HoaDon = New System.Windows.Forms.RadioButton()
        Me.Rb_KhachHang = New System.Windows.Forms.RadioButton()
        Me.Rb_Sanpham = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Class = New System.Windows.Forms.ComboBox()
        Me.cmb_Search = New System.Windows.Forms.ComboBox()
        Me.Bt_AddKH = New System.Windows.Forms.Button()
        Me.Btn_EditKH = New System.Windows.Forms.Button()
        Me.Btn_addHD = New System.Windows.Forms.Button()
        Me.Btn_EHD = New System.Windows.Forms.Button()
        CType(Me.Dgv_Sanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_Sanpham
        '
        Me.Dgv_Sanpham.AllowUserToAddRows = False
        Me.Dgv_Sanpham.AllowUserToDeleteRows = False
        Me.Dgv_Sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Sanpham.Location = New System.Drawing.Point(33, 102)
        Me.Dgv_Sanpham.MultiSelect = False
        Me.Dgv_Sanpham.Name = "Dgv_Sanpham"
        Me.Dgv_Sanpham.ReadOnly = True
        Me.Dgv_Sanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Sanpham.Size = New System.Drawing.Size(482, 360)
        Me.Dgv_Sanpham.TabIndex = 0
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(33, 498)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(112, 23)
        Me.Btn_Add.TabIndex = 1
        Me.Btn_Add.Text = "Add Sản Phẩm"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Location = New System.Drawing.Point(33, 543)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(112, 23)
        Me.Btn_Edit.TabIndex = 2
        Me.Btn_Edit.Text = "Edit Sản Phẩm"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(555, 543)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(144, 23)
        Me.Btn_Delete.TabIndex = 4
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Lbl_Search
        '
        Me.Lbl_Search.AutoSize = True
        Me.Lbl_Search.Location = New System.Drawing.Point(30, 62)
        Me.Lbl_Search.Name = "Lbl_Search"
        Me.Lbl_Search.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_Search.TabIndex = 5
        Me.Lbl_Search.Text = "Search"
        '
        'Txt_Search
        '
        Me.Txt_Search.Location = New System.Drawing.Point(239, 59)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(181, 20)
        Me.Txt_Search.TabIndex = 6
        '
        'Btn_Search
        '
        Me.Btn_Search.Location = New System.Drawing.Point(440, 57)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Search.TabIndex = 7
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rb_Chi_Tiet_Hoa_Don)
        Me.GroupBox1.Controls.Add(Me.Rb_HoaDon)
        Me.GroupBox1.Controls.Add(Me.Rb_KhachHang)
        Me.GroupBox1.Controls.Add(Me.Rb_Sanpham)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cmb_Class)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox1.Location = New System.Drawing.Point(555, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 271)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Rb_Chi_Tiet_Hoa_Don
        '
        Me.Rb_Chi_Tiet_Hoa_Don.AutoSize = True
        Me.Rb_Chi_Tiet_Hoa_Don.Location = New System.Drawing.Point(21, 228)
        Me.Rb_Chi_Tiet_Hoa_Don.Name = "Rb_Chi_Tiet_Hoa_Don"
        Me.Rb_Chi_Tiet_Hoa_Don.Size = New System.Drawing.Size(107, 17)
        Me.Rb_Chi_Tiet_Hoa_Don.TabIndex = 12
        Me.Rb_Chi_Tiet_Hoa_Don.TabStop = True
        Me.Rb_Chi_Tiet_Hoa_Don.Text = "Chi Tiết Hóa Đơn"
        Me.Rb_Chi_Tiet_Hoa_Don.UseVisualStyleBackColor = True
        '
        'Rb_HoaDon
        '
        Me.Rb_HoaDon.AutoSize = True
        Me.Rb_HoaDon.Location = New System.Drawing.Point(21, 185)
        Me.Rb_HoaDon.Name = "Rb_HoaDon"
        Me.Rb_HoaDon.Size = New System.Drawing.Size(68, 17)
        Me.Rb_HoaDon.TabIndex = 11
        Me.Rb_HoaDon.TabStop = True
        Me.Rb_HoaDon.Text = "Hóa Đơn"
        Me.Rb_HoaDon.UseVisualStyleBackColor = True
        '
        'Rb_KhachHang
        '
        Me.Rb_KhachHang.AutoSize = True
        Me.Rb_KhachHang.Location = New System.Drawing.Point(21, 147)
        Me.Rb_KhachHang.Name = "Rb_KhachHang"
        Me.Rb_KhachHang.Size = New System.Drawing.Size(85, 17)
        Me.Rb_KhachHang.TabIndex = 11
        Me.Rb_KhachHang.TabStop = True
        Me.Rb_KhachHang.Text = "Khách Hàng"
        Me.Rb_KhachHang.UseVisualStyleBackColor = True
        '
        'Rb_Sanpham
        '
        Me.Rb_Sanpham.AutoSize = True
        Me.Rb_Sanpham.Location = New System.Drawing.Point(21, 112)
        Me.Rb_Sanpham.Name = "Rb_Sanpham"
        Me.Rb_Sanpham.Size = New System.Drawing.Size(74, 17)
        Me.Rb_Sanpham.TabIndex = 11
        Me.Rb_Sanpham.Text = "Sản Phẩm"
        Me.Rb_Sanpham.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Loại Sản Phẩm:"
        '
        'Cmb_Class
        '
        Me.Cmb_Class.FormattingEnabled = True
        Me.Cmb_Class.Location = New System.Drawing.Point(21, 55)
        Me.Cmb_Class.Name = "Cmb_Class"
        Me.Cmb_Class.Size = New System.Drawing.Size(104, 21)
        Me.Cmb_Class.TabIndex = 0
        '
        'cmb_Search
        '
        Me.cmb_Search.FormattingEnabled = True
        Me.cmb_Search.Items.AddRange(New Object() {"Ma San Pham", "Ten San Pham"})
        Me.cmb_Search.Location = New System.Drawing.Point(90, 57)
        Me.cmb_Search.Name = "cmb_Search"
        Me.cmb_Search.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Search.TabIndex = 9
        '
        'Bt_AddKH
        '
        Me.Bt_AddKH.Location = New System.Drawing.Point(151, 498)
        Me.Bt_AddKH.Name = "Bt_AddKH"
        Me.Bt_AddKH.Size = New System.Drawing.Size(118, 23)
        Me.Bt_AddKH.TabIndex = 10
        Me.Bt_AddKH.Text = "Add Khách Hàng"
        Me.Bt_AddKH.UseVisualStyleBackColor = True
        '
        'Btn_EditKH
        '
        Me.Btn_EditKH.Location = New System.Drawing.Point(152, 543)
        Me.Btn_EditKH.Name = "Btn_EditKH"
        Me.Btn_EditKH.Size = New System.Drawing.Size(117, 23)
        Me.Btn_EditKH.TabIndex = 11
        Me.Btn_EditKH.Text = "Edit Khách Hàng"
        Me.Btn_EditKH.UseVisualStyleBackColor = True
        '
        'Btn_addHD
        '
        Me.Btn_addHD.Location = New System.Drawing.Point(276, 498)
        Me.Btn_addHD.Name = "Btn_addHD"
        Me.Btn_addHD.Size = New System.Drawing.Size(117, 23)
        Me.Btn_addHD.TabIndex = 12
        Me.Btn_addHD.Text = "Add Hóa Đơn"
        Me.Btn_addHD.UseVisualStyleBackColor = True
        '
        'Btn_EHD
        '
        Me.Btn_EHD.Location = New System.Drawing.Point(276, 543)
        Me.Btn_EHD.Name = "Btn_EHD"
        Me.Btn_EHD.Size = New System.Drawing.Size(117, 23)
        Me.Btn_EHD.TabIndex = 12
        Me.Btn_EHD.Text = "Edit Hóa Đơn"
        Me.Btn_EHD.UseVisualStyleBackColor = True
        '
        'QuanLyBanHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 621)
        Me.Controls.Add(Me.Btn_EHD)
        Me.Controls.Add(Me.Btn_addHD)
        Me.Controls.Add(Me.Btn_EditKH)
        Me.Controls.Add(Me.Bt_AddKH)
        Me.Controls.Add(Me.cmb_Search)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.Lbl_Search)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Dgv_Sanpham)
        Me.Name = "QuanLyBanHang"
        Me.Text = "QUẢN LÝ BÁN HÀNG"
        CType(Me.Dgv_Sanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Sanpham As DataGridView
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Lbl_Search As Label
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cmb_Class As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Search As ComboBox
    Friend WithEvents Rb_Sanpham As RadioButton
    Friend WithEvents Rb_HoaDon As RadioButton
    Friend WithEvents Rb_KhachHang As RadioButton
    Friend WithEvents Rb_Chi_Tiet_Hoa_Don As RadioButton
    Friend WithEvents Bt_AddKH As Button
    Friend WithEvents Btn_EditKH As Button
    Friend WithEvents Btn_addHD As Button
    Friend WithEvents Btn_EHD As Button
End Class
