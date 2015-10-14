Public Class HoaDon

    Private DBAccess As New DataBaseAccess
    Private isEdits As Boolean = False

    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isEdits = IsEdit
    End Sub

    Private Function InsertHoaDon() As Boolean
        Dim sqlQuery As String = "Insert into dbo.San_Pham (Ma_HD, NgayLap,  Ma_KH)"
        sqlQuery += String.Format("values ('{0}','{1}','{2}') ",
        Txt_MaHD.Text, Dtp_NgayLap.Text, Txt_MaKH.Text)

        Return DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function UpdateSanPham() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE San_Pham SET Ten_Sp = '{0}', SoLuong = '{1}' Where Ma_SP = '{2}'",
                                               Me.Txt_MaHD.Text, Me.Dtp_NgayLap.Text, Me.Txt_MaKH)
        Return DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function



    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(Txt_MaHD.Text) OrElse String.IsNullOrEmpty(Dtp_NgayLap.Text) OrElse
            String.IsNullOrEmpty(Txt_MaKH.Text)
    End Function

    Private Sub HoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click
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
                If InsertHoaDon() Then
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