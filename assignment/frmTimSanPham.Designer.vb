<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimSanPham
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
        Me.dgvXemsp = New System.Windows.Forms.DataGridView()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_XemAll = New System.Windows.Forms.Button()
        Me.btn_TimTen = New System.Windows.Forms.Button()
        Me.btn_TimMa = New System.Windows.Forms.Button()
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvXemsp
        '
        Me.dgvXemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemsp.Location = New System.Drawing.Point(12, 99)
        Me.dgvXemsp.Name = "dgvXemsp"
        Me.dgvXemsp.Size = New System.Drawing.Size(570, 239)
        Me.dgvXemsp.TabIndex = 3
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(70, 67)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(160, 20)
        Me.txtTenSP.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tên SP:"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(70, 28)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(160, 20)
        Me.txtMaSP.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mã SP:"
        '
        'btn_Close
        '
        Me.btn_Close.Image = Global.assignment.My.Resources.Resources.remove
        Me.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Close.Location = New System.Drawing.Point(463, 21)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(119, 33)
        Me.btn_Close.TabIndex = 12
        Me.btn_Close.Text = "Đóng"
        Me.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'btn_XemAll
        '
        Me.btn_XemAll.Image = Global.assignment.My.Resources.Resources.accept
        Me.btn_XemAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_XemAll.Location = New System.Drawing.Point(463, 60)
        Me.btn_XemAll.Name = "btn_XemAll"
        Me.btn_XemAll.Size = New System.Drawing.Size(119, 33)
        Me.btn_XemAll.TabIndex = 9
        Me.btn_XemAll.Text = "Xem tất cả"
        Me.btn_XemAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_XemAll.UseVisualStyleBackColor = True
        '
        'btn_TimTen
        '
        Me.btn_TimTen.Image = Global.assignment.My.Resources.Resources.search_add
        Me.btn_TimTen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_TimTen.Location = New System.Drawing.Point(320, 60)
        Me.btn_TimTen.Name = "btn_TimTen"
        Me.btn_TimTen.Size = New System.Drawing.Size(137, 33)
        Me.btn_TimTen.TabIndex = 10
        Me.btn_TimTen.Text = "Tìm Tên Sản Phẩm"
        Me.btn_TimTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_TimTen.UseVisualStyleBackColor = True
        '
        'btn_TimMa
        '
        Me.btn_TimMa.Image = Global.assignment.My.Resources.Resources.search
        Me.btn_TimMa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_TimMa.Location = New System.Drawing.Point(320, 21)
        Me.btn_TimMa.Name = "btn_TimMa"
        Me.btn_TimMa.Size = New System.Drawing.Size(137, 33)
        Me.btn_TimMa.TabIndex = 11
        Me.btn_TimMa.Text = "Tìm Mã Sản Phẩm"
        Me.btn_TimMa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_TimMa.UseVisualStyleBackColor = True
        '
        'frmTimSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 352)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_XemAll)
        Me.Controls.Add(Me.btn_TimTen)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.btn_TimMa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvXemsp)
        Me.Name = "frmTimSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xem sản phẩm"
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvXemsp As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_XemAll As System.Windows.Forms.Button
    Friend WithEvents btn_TimTen As System.Windows.Forms.Button
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents btn_TimMa As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
