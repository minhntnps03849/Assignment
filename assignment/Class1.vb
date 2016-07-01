Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=PS03849.mssql.somee.com;packet size=4096;user id=minhntnps03849_SQLLogin_1;pwd=tv7devsera;data source=PS03849.mssql.somee.com;persist security info=False;initial catalog=PS03849"
        'Dim chuoiketnoi As String = "server=(local);database=QLBanHang;trusted_connection=false;uid=sa;pwd=nhatminh"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=PS03849.mssql.somee.com;packet size=4096;user id=minhntnps03849_SQLLogin_1;pwd=tv7devsera;data source=PS03849.mssql.somee.com;persist security info=False;initial catalog=PS03849"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("SELECT MaSP as 'Mã SP' , TenSP as 'Tên Sản phẩm', DongSP as 'Dòng Sản Phẩm', LoaiSP as 'Loại Sản Phẩm', HangSX as 'Hãng Sản Xuất', SoLuong as 'Số Lượng', DonGia as 'Đơn Giá', SoLuong * DonGia as 'Thành Tiền' from SANPHAM", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
