Public Class frmLogin

    Private Sub btn_DangNhap_Click(sender As Object, e As EventArgs) Handles btn_DangNhap.Click
        For Each TK As TaiKhoan In ListDangNhap
            If TK.TaiKhoan = txtTaiKhoan.Text Then
                If TK.MatKhau = txtMatKhau.Text Then
                    MsgBox("Bạn đã đăng nhập thành công", MsgBoxStyle.Information, "Thông báo")
                    Me.Close()
                Else
                    MsgBox("Sai mật khẩu", MsgBoxStyle.Information, "Thông báo")
                End If
                Exit Sub
            End If
        Next
        MsgBox("Sai tên đăng nhập", MsgBoxStyle.Information, "Thông báo")
    End Sub

    Private Sub btn_Thoat_Click(sender As Object, e As EventArgs) Handles btn_Thoat.Click
        Me.Close()
    End Sub
End Class