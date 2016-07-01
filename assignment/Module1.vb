Imports System.IO

Module Module1
    ' Quản Lý Đăng Nhập
    Public ListDangNhap As New List(Of TaiKhoan)

    Sub OpenDangNhap()
        ListDangNhap.Clear()
        Dim InPut As New StreamReader("Data/Dang-Nhap.txt")
        While Not InPut.EndOfStream
            Dim Line() As String = InPut.ReadLine().Split(vbTab)

            Dim TK As New TaiKhoan
            TK.TaiKhoan = Line(0)
            TK.MatKhau = Line(1)

            ListDangNhap.Add(TK)
        End While
        InPut.Close()
    End Sub

    Sub SaveDangNhap()
        Dim OutPut = New StreamWriter("Data/Dang-Nhap.txt", True)
        For Each TK As TaiKhoan In ListDangNhap
            OutPut.Write(TK.TaiKhoan)
            OutPut.Write(vbTab)

            OutPut.WriteLine(TK.MatKhau)
        Next
        OutPut.Close()
    End Sub
End Module
