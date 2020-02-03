Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
Imports PHAN_MEM_QUAN_LY_QUAN_CAFE.PHAN_MEM_QUAN_LY_QUAN_CAFE.DTO
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class FormBanHang
    Private Sub LoadTable()
        tableLayout.Controls.Clear()
        Dim tableList As List(Of Tables) = TableDAO._Instance.LoadTableList()

        For Each item As Tables In tableList
            Dim btn As Button = New Button() With {
                .Width = TableDAO.TableWidth,
                .Height = TableDAO.TableHeigth
            }
            btn.Text = item._name + Environment.NewLine + item._status
            AddHandler btn.Click, AddressOf btn_Click
            btn.Tag = item

            Select Case item._status
                Case "Bàn trống"
                    btn.BackColor = Color.Aqua
                Case Else
                    btn.BackColor = Color.LightPink
            End Select

            tableLayout.Controls.Add(btn)
        Next
    End Sub

    Private Sub AdminStripMenu_Click(sender As Object, e As EventArgs) Handles AdminStripMenu.Click
        FormAdmin.Show()
    End Sub

    Private Sub ChangeAccount(ByVal type As Integer)
        MenuStrip.Enabled = type = 1
        'AdminStripMenu.Text += " (" & loginAccount.DisplayName & ")"
    End Sub

    Private Sub FormBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub


    Private Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim tableID As Integer = (TryCast((TryCast(sender, Button)).Tag, Tables))._id
        listBill.Tag = (TryCast(sender, Button)).Tag
    End Sub

    Private Sub FormBanHang_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim f As FormDangNhap = New FormDangNhap
        f.Show()
    End Sub
End Class