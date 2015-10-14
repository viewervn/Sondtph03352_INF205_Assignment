Public Class QuanLyBanHang
    Private DBAccess As New DataBaseAccess

    Private IsLoading As Boolean = False

    Private Sub LoadDataOnComBobox()

        Dim sqlQuery As String = "select Ma_LSP , Ten_LSP  from dbo.Loai_San_Pham"
            Dim dTable As DataTable = DBAccess.GetDataTable(sqlQuery)
            Me.Cmb_Class.DataSource = dTable
            Me.Cmb_Class.ValueMember = "Ma_LSP"
        Me.Cmb_Class.DisplayMember = "Ten_LSP"
    End Sub

    Private Sub LoadDataOnGridView(Ma_LSP As String)

        Dim SqlQuery As String = String.Format("Select Ma_SP, Ten_SP, SoLuong, Mota from dbo.San_Pham where Ma_LSP = '{0}'", Ma_LSP)
        Dim dTable As DataTable = (DBAccess.GetDataTable(SqlQuery))
        Me.Dgv_Sanpham.DataSource = dTable
        With Me.Dgv_Sanpham
            .Columns(0).HeaderText = "Ma_SP"
            .Columns(1).HeaderText = "Ten_SP"
            .Columns(2).HeaderText = "Soluong"
            .Columns(3).HeaderText = "Mota"
            .Columns(3).Width = 200
        End With


    End Sub
    Private Function LoadDataOnGridView1()
        Dim SqlQuery As String = String.Format("select Ma_KH, Ten_KH, SDT, DiaChi from dbo.Khach_Hang")
        Dim dTable As DataTable = (DBAccess.GetDataTable(SqlQuery))
        Me.Dgv_Sanpham.DataSource = dTable
        With Me.Dgv_Sanpham
            .Columns(0).HeaderText = "Ma_KH"
            .Columns(1).HeaderText = "Ten_KH"
            .Columns(2).HeaderText = "SDT"
            .Columns(3).HeaderText = "DiaChi"
            .Columns(2).Width = 200
        End With
    End Function

    Private Function LoadDataOnGridView2(Ma_KH As String)
        Dim SqlQuery As String = String.Format("select Ma_HD, NgayLap from dbo.Hoa_Don where Ma_KH = '{0}'", Ma_KH)
        Dim dTable As DataTable = (DBAccess.GetDataTable(SqlQuery))
        Me.Dgv_Sanpham.DataSource = dTable
        With Me.Dgv_Sanpham
            .Columns(0).HeaderText = "Ma_HD"
            .Columns(1).HeaderText = "Ma_KH"
            .Columns(2).HeaderText = "NgayLap"
            .Columns(2).Width = 200
        End With
    End Function
    Private Function LoadDataOnGridView3()
        Dim SqlQuery As String = String.Format("select Ma_HD, Ma_SP, DonGia, SoLuong from dbo.Chi_Tiet_Hoa_Don")
        Dim dTable As DataTable = (DBAccess.GetDataTable(SqlQuery))
        Me.Dgv_Sanpham.DataSource = dTable
        With Me.Dgv_Sanpham
            .Columns(0).HeaderText = "Ma_HD"
            .Columns(1).HeaderText = "Ma_KH"
            .Columns(2).HeaderText = "DonGia"
            .Columns(3).HeaderText = "SoLuong"
            .Columns(2).Width = 200
        End With
    End Function



    Private Sub QuanLyBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsLoading = True



        LoadDataOnComBobox()

        LoadDataOnGridView(Me.Cmb_Class.SelectedValue)
        IsLoading = False


    End Sub

    Private Sub Cmb_Class_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Class.SelectedIndexChanged
        If Not IsLoading Then
            LoadDataOnGridView(Me.Cmb_Class.SelectedValue)



        End If
    End Sub

    Private Sub SearchSanPham(Ma_LSP As String, value As String)
        Dim SqlQuery As String = String.Format("Select Ma_SP, Ten_SP, SoLuong, Mota from dbo.San_Pham where Ma_LSP = '{0}'", Ma_LSP)
        If Me.cmb_Search.SelectedIndex = 0 Then
            SqlQuery += String.Format(" AND Ma_SP LIKE   '{0}%'", value)
        ElseIf Me.cmb_Search.SelectedIndex = 1 Then
            SqlQuery += String.Format(" AND Ten_SP LIKE  '{0}%'", value)

        End If
        Dim dTable As DataTable = (DBAccess.GetDataTable(SqlQuery))
        Me.Dgv_Sanpham.DataSource = dTable
        With Me.Dgv_Sanpham
            .Columns(0).HeaderText = "Ma SP"
            .Columns(1).HeaderText = "Ten SP"
            .Columns(2).HeaderText = "Soluong"
            .Columns(3).HeaderText = "Mota"
            .Columns(3).Width = 200
        End With
    End Sub

    Private Function SearchKhachHang()
        Dim SqlQuery As String = String.Format("Select Ma_KH, Ten_KH, SDT, DiaChi from dbo.Khach_Hang")

        Dim dTable As DataTable = (DBAccess.GetDataTable(SqlQuery))
        Me.Dgv_Sanpham.DataSource = dTable
        With Me.Dgv_Sanpham
            .Columns(0).HeaderText = "Ma_KH"
            .Columns(1).HeaderText = "Ten_KH"
            .Columns(2).HeaderText = "SDT"
            .Columns(3).HeaderText = "DiaChi"
            .Columns(3).Width = 200
        End With
    End Function

    Private Function SearchHoaDon()
        Dim SqlQuery As String = String.Format("Select Ma_HD, Ten_HD, NgayCap from dbo.Khach_Hang")

        Dim dTable As DataTable = (DBAccess.GetDataTable(SqlQuery))
        Me.Dgv_Sanpham.DataSource = dTable
        With Me.Dgv_Sanpham
            .Columns(0).HeaderText = "Ma_HD"
            .Columns(1).HeaderText = "Ten_HD"
            .Columns(2).HeaderText = "NgayCap"

        End With
    End Function

    Private Function SearchChiTiet()
        Dim SqlQuery As String = String.Format("Select Ma_HD, Ma_SP, DonGia, SoLuong from dbo.Chi_Tiet_Hoa_Don")

        Dim dTable As DataTable = (DBAccess.GetDataTable(SqlQuery))
        Me.Dgv_Sanpham.DataSource = dTable
        With Me.Dgv_Sanpham
            .Columns(0).HeaderText = "Ma_HD"
            .Columns(1).HeaderText = "Ma_SP"
            .Columns(2).HeaderText = "DonGia"
            .Columns(3).HeaderText = "SoLuong"
            .Columns(2).Width = 200
        End With
    End Function

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        SearchSanPham(Me.Cmb_Class.SelectedValue, Me.Txt_Search.Text)


        'If Me.Rb_KhachHang.Checked Then
        '    SearchKhachHang(Me.Txt_Search.Text)
        'ElseIf Rb_HoaDon.Checked Then
        '    SearchHoaDon(Me.Txt_Search.Text)
        'ElseIf Rb_Chi_Tiet_Hoa_Don.Checked Then
        '    SearchChiTiet(Me.Txt_Search.Text)

        'End If

    End Sub




    Public Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click

        Dim frm As New SanPham(False)
        frm.Txt_Ma_LSP.Text = Me.Cmb_Class.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            LoadDataOnGridView(Me.Cmb_Class.SelectedValue)

        End If

    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Dim frm As New SanPham(True)
        frm.Txt_Ma_LSP.Text = Me.Cmb_Class.SelectedValue
        frm.Txt_Ma_SP.ReadOnly = True
        With Me.Dgv_Sanpham
            frm.Txt_Mota.Text = .Rows(.CurrentCell.RowIndex).Cells("Mota").Value
            frm.Txt_Ma_SP.Text = .Rows(.CurrentCell.RowIndex).Cells("Ma_SP").Value
            frm.Txt_Ten_SP.Text = .Rows(.CurrentCell.RowIndex).Cells("Ten_SP").Value
            frm.Txt_Soluong.Text = .Rows(.CurrentCell.RowIndex).Cells("SoLuong").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            LoadDataOnGridView(Me.Cmb_Class.SelectedValue)
        End If
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click

        Dim Ma_SP As String = Me.Dgv_Sanpham.Rows(Me.Dgv_Sanpham.CurrentCell.RowIndex).Cells("Ma_SP").Value

        Dim sqlQuery As String = String.Format("Delete San_Pham where Ma_SP = '{0}'", Ma_SP)

        If DBAccess.ExecuteNoneQuery(sqlQuery) Then
            MessageBox.Show("Đã xóa dữ liệu thành công!")
            LoadDataOnGridView(Me.Cmb_Class.SelectedValue)
        Else
            MessageBox.Show("Lỗi xóa dữ liệu!")
        End If

    End Sub
    Private Function ShowSanPham()
        Dim sqlQuery As String = "select Ma_LSP , Ten_LSP  from dbo.Loai_San_Pham"
        Dim dTable As DataTable = DBAccess.GetDataTable(sqlQuery)
        Me.Cmb_Class.DataSource = dTable
        Me.Cmb_Class.ValueMember = "Ma_LSP"
        Me.Cmb_Class.DisplayMember = "Ten_LSP"
    End Function

    Private Sub Rb_Sanpham_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Sanpham.CheckedChanged
        ShowSanPham()

    End Sub



    Private Sub Rb_KhachHang_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_KhachHang.CheckedChanged
        LoadDataOnGridView1()



    End Sub

    Private Sub Rb_HoaDon_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_HoaDon.CheckedChanged
        LoadDataOnGridView2(Me.Cmb_Class.SelectedValue)
    End Sub

    Private Sub Rb_Chi_Tiet_Hoa_Don_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Chi_Tiet_Hoa_Don.CheckedChanged
        LoadDataOnGridView3()
    End Sub

    Private Sub Bt_AddKH_Click(sender As Object, e As EventArgs) Handles Bt_AddKH.Click
        Dim frm As New KhachHang(False)

        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            LoadDataOnGridView1()

        End If
    End Sub

    Private Sub Btn_EditKH_Click(sender As Object, e As EventArgs) Handles Btn_EditKH.Click
        Dim frm As New KhachHang(True)
        frm.Txt_Ma_KH.ReadOnly = True
        With Me.Dgv_Sanpham
            frm.Txt_DiaChi.Text = .Rows(.CurrentCell.RowIndex).Cells("DiaChi").Value
            frm.Txt_Ma_KH.Text = .Rows(.CurrentCell.RowIndex).Cells("Ma_KH").Value
            frm.Txt_Ten_KH.Text = .Rows(.CurrentCell.RowIndex).Cells("Ten_KH").Value
            frm.Txt_SDT.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            LoadDataOnGridView1()
        End If
    End Sub

    Private Sub Btn_addHD_Click(sender As Object, e As EventArgs) Handles Btn_addHD.Click
        Dim frm As New HoaDon(False)
        frm.Txt_MaKH.Text = Me.Cmb_Class.SelectedValue
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            LoadDataOnGridView2(Me.Cmb_Class.SelectedValue)

        End If

    End Sub
End Class
