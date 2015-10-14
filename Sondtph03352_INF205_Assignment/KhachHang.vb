Public Class KhachHang
    Private DBAccess As New DataBaseAccess
    Private isEdits As Boolean = False

    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isEdits = IsEdit
    End Sub

    Private Function InsertSanPham() As Boolean
        Dim sqlQuery As String = "Insert into dbo.Khach_Hang (Ma_KH, Ten_KH, SDT,DiaChi)"
        sqlQuery += String.Format("values ('{0}','{1}','{2}','{3}') ",
        Txt_Ma_KH.Text, Txt_Ten_KH.Text, Txt_SDT.Text, Txt_DiaChi.Text)

        Return DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function UpdateSanPham() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE Khach_Hang SET Ten_KH = '{0}', SDT = '{1}', DiaChi = '{2}' Where Ma_KH = '{3}'",
                                               Me.Txt_Ten_KH.Text, Me.Txt_SDT.Text, Me.Txt_DiaChi, Me.Txt_Ma_KH.Text)
        Return DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(Txt_Ma_KH.Text) OrElse String.IsNullOrEmpty(Txt_Ten_KH.Text) OrElse
            String.IsNullOrEmpty(Txt_SDT.Text) OrElse String.IsNullOrEmpty(Txt_DiaChi.Text)

    End Function

    Private Sub KhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Okk.Click
        If IsEmpty() Then
            MessageBox.Show("Nhập giá trị vào trước khi ghi vào databae", "Error", MessageBoxButtons.OK)

        Else
            If isEdits Then

                If UpdateSanPham() Then
                    MessageBox.Show("Sửa dữ liệu thành công!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("Lỗi sửa dữ liệu", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.No
                End If

            Else
                If InsertSanPham() Then
                    MessageBox.Show("Thêm dữ liệu thành công!", "Information", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.OK

                Else
                    MessageBox.Show("Lỗi thêm dữ liệu!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.No

                End If
            End If


            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class