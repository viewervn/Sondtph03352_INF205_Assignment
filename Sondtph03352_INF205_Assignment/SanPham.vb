Public Class SanPham
    Private DBAccess As New DataBaseAccess
    Private isEdits As Boolean = False

    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isEdits = IsEdit
    End Sub

    Private Function InsertSanPham() As Boolean
        Dim sqlQuery As String = "Insert into dbo.San_Pham (Ma_SP, Ten_SP, SoLuong, Mota, Ma_LSP)"
        sqlQuery += String.Format("values ('{0}','{1}','{2}','{3}','{4}') ",
        Txt_Ma_SP.Text, Txt_Ten_SP.Text, Txt_Soluong.Text, Txt_Mota.Text, Txt_Ma_LSP.Text)

        Return DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function UpdateSanPham() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE San_Pham SET Ten_Sp = '{0}', SoLuong = '{1}', Mota = '{2}' Where Ma_SP = '{3}'",
                                               Me.Txt_Ten_SP.Text, Me.Txt_Soluong.Text, Me.Txt_Mota, Me.Txt_Ma_SP.Text)
        Return DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function



    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(Txt_Ma_SP.Text) OrElse String.IsNullOrEmpty(Txt_Ten_SP.Text) OrElse
            String.IsNullOrEmpty(Txt_Mota.Text) OrElse String.IsNullOrEmpty(Txt_Soluong.Text) OrElse
            String.IsNullOrEmpty(Txt_Ma_LSP.Text)
    End Function

    Private Sub SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
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