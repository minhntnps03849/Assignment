Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmTimSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03849.mssql.somee.com;packet size=4096;user id=minhntnps03849_SQLLogin_1;pwd=tv7devsera;data source=PS03849.mssql.somee.com;persist security info=False;initial catalog=PS03849"
    'Dim chuoiketnoi As String = "server=(local);database=QLBanHang;trusted_connection=false;uid=sa;pwd=nhatminh"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btn_Xem_Click(sender As Object, e As EventArgs)
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP where SANPHAM.MASP ='" & txtMaSP.Text & "' ", connect)
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMaSP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMaSP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_XemAll_Click(sender As Object, e As EventArgs) Handles btn_XemAll.Click
        Dim hienthi As New Class1
        dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub

    Private Sub btn_TimMa_Click(sender As Object, e As EventArgs) Handles btn_TimMa.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("SELECT MaSP as 'Mã SP' ,TenSP as 'Tên Sản Phẩm', DongSP as 'Dòng Sản Phẩm', LoaiSP as 'Loại Sản Phẩm', HangSX as 'Hãng Sản Xuất', SoLuong as 'Số Lượng', DonGia as 'Đơn giá', SoLuong * DonGia as 'Thành Tiền' from SANPHAM where SANPHAM.MASP ='" & txtMaSP.Text & "' ", connect)
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMaSP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMaSP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_TimTen_Click(sender As Object, e As EventArgs) Handles btn_TimTen.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("SELECT MaSP as 'Mã SP' ,TenSP as 'Tên Sản Phẩm', DongSP as 'Dòng Sản Phẩm', LoaiSP as 'Loại Sản Phẩm', HangSX as 'Hãng Sản Xuất', SoLuong as 'Số Lượng', DonGia as 'Đơn giá', SoLuong * DonGia as 'Thành Tiền' from SANPHAM where SANPHAM.TenSP like '%" & txtTenSP.Text & "%' ", connect)
        Try
            If txtTenSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMaSP.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMaSP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class