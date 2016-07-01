Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03849.mssql.somee.com;packet size=4096;user id=minhntnps03849_SQLLogin_1;pwd=tv7devsera;data source=PS03849.mssql.somee.com;persist security info=False;initial catalog=PS03849"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("SELECT MaSP as 'Mã SP' , TenSP as 'Tên Sản phẩm', DongSP as 'Dòng Sản Phẩm', LoaiSP as 'Loại Sản Phẩm', HangSX as 'Hãng Sản Xuất', SoLuong as 'Số Lượng', DonGia as 'Đơn Giá', SoLuong * DonGia as 'Thành Tiền' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtMaSP.Text = ""
        txtTenSP.Text = ""
        txtDongSP.Text = ""
        txtLoaiSP.Text = ""
        txtHangSX.Text = ""
        txtSoLuong.Text = ""
        txtDonGia.Text = ""
        txtMaSP.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        OpenDangNhap()
        frmLogin.ShowDialog()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Chưa nhập Mã Sản Phẩm")
            txtMaSP.Focus()
        ElseIf txtTenSP.Text = "" Then
            MessageBox.Show("Chưa nhập Tên Sản Phẩm")
            txtTenSP.Focus()
        ElseIf txtDongSP.Text = "" Then
            MessageBox.Show("Chưa nhập Dòng Sản Phẩm")
            txtDongSP.Focus()
        ElseIf txtLoaiSP.Text = "" Then
            MessageBox.Show("Chưa nhập Loại Sản Phẩm")
            txtLoaiSP.Focus()
        ElseIf txtHangSX.Text = "" Then
            MessageBox.Show("Chưa nhập Hãng Sản Xuất")
            txtHangSX.Focus()
        ElseIf txtSoLuong.Text = "" Then
            MessageBox.Show("Chưa nhập Số Lượng")
            txtSoLuong.Focus()
        ElseIf txtDonGia.Text = "" Then
            MessageBox.Show("Chưa nhập Đơn Giá")
            txtDonGia.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "INSERT INTO SANPHAM VALUES(@MASP,@TENSP,@DONGSP,@LOAISP,@HANGSX,@SOLUONG,@DONGIA)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMaSP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTenSP.Text)
            save.Parameters.AddWithValue("@DONGSP", txtDongSP.Text)
            save.Parameters.AddWithValue("@LOAISP", txtLoaiSP.Text)
            save.Parameters.AddWithValue("@HANGSX", txtHangSX.Text)
            save.Parameters.AddWithValue("@SOLUONG", txtSoLuong.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDonGia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Cập nhập Dữ Liệu Thành Công")
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Nhập Mã Sản Phẩm Muốn Xóa")
            txtMaSP.Focus()
        Else
            Dim delquery As String = "DELETE FROM SANPHAM WHERE MaSP=@MASP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MASP", txtMaSP.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMaSP.ReadOnly = True
            btnSua.Text = "Update"
            txtDongSP.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "UPDATE SANPHAM SET TenSP=@TENSP, DongSP=@DONGSP, LoaiSP=@LOAISP, HangSX=@HANGSX, SoLuong=@SOLUONG, DonGia=@DONGIA WHERE MaSP=@MASP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMaSP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTenSP.Text)
            save.Parameters.AddWithValue("@DONGSP", txtDongSP.Text)
            save.Parameters.AddWithValue("@LOAISP", txtLoaiSP.Text)
            save.Parameters.AddWithValue("@HANGSX", txtHangSX.Text)
            save.Parameters.AddWithValue("@SOLUONG", txtSoLuong.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDonGia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaSP.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaSP.Text = DataGridView1.Item(0, click).Value
        txtTenSP.Text = DataGridView1.Item(1, click).Value
        txtDongSP.Text = DataGridView1.Item(2, click).Value
        txtLoaiSP.Text = DataGridView1.Item(3, click).Value
        txtHangSX.Text = DataGridView1.Item(4, click).Value
        txtSoLuong.Text = DataGridView1.Item(5, click).Value
        txtDonGia.Text = DataGridView1.Item(6, click).Value
        'txtMaSP.Text = DataGridView1.Item(0, click).Value
        'txtTenSP.Text = DataGridView1.Item(1, click).Value
        'txtDongSP.Text = DataGridView1.Item(2, click).Value
        'txtLoaiSP.Text = DataGridView1.Item(3, click).Value
        'txtHangSX.Text = DataGridView1.Item(4, click).Value
        'txtSoLuong.Text = DataGridView1.Item(5, click).Value
        'txtDonGia.Text = DataGridView1.Item(6, click).Value
    End Sub

End Class