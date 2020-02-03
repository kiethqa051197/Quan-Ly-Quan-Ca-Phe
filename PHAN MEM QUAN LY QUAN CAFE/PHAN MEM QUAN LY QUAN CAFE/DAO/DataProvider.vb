﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient

Namespace PHAN_MEM_QUAN_LY_QUAN_CAFE.DAO
    Public Class DataProvider
        Private Shared instance As DataProvider

        Public Shared Property _Instance As DataProvider
            Get
                If instance Is Nothing Then instance = New DataProvider()
                Return DataProvider.instance
            End Get
            Private Set(ByVal value As DataProvider)
                DataProvider.instance = value
            End Set
        End Property

        Private Sub New()
        End Sub

        Private connectionSTR As String = "Data Source=BANHANG2\SQL2K16;Initial Catalog=QUANCAFE;Integrated security=False;User ID=sa;Password=htl"

        Public Function ExecuteQuery(ByVal query As String, Optional ByVal parameter As Object() = Nothing) As DataTable
            Dim data As DataTable = New DataTable()

            Using connection As SqlConnection = New SqlConnection(connectionSTR)
                connection.Open()
                Dim command As SqlCommand = New SqlCommand(query, connection)

                If parameter IsNot Nothing Then
                    Dim listPara As String() = query.Split(" "c)
                    Dim i As Integer = 0

                    For Each item As String In listPara

                        If item.Contains("@"c) Then
                            command.Parameters.AddWithValue(item, parameter(i))
                            i += 1
                        End If
                    Next
                End If

                Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)
                adapter.Fill(data)
                connection.Close()
            End Using

            Return data
        End Function

        Public Function ExecuteNoneQuery(ByVal query As String, Optional ByVal parameter As Object() = Nothing) As Integer
            Dim data As Integer = 0

            Using connection As SqlConnection = New SqlConnection(connectionSTR)
                connection.Open()
                Dim command As SqlCommand = New SqlCommand(query, connection)

                If parameter IsNot Nothing Then
                    Dim listPara As String() = query.Split(" "c)
                    Dim i As Integer = 0

                    For Each item As String In listPara

                        If item.Contains("@"c) Then
                            command.Parameters.AddWithValue(item, parameter(i))
                            i += 1
                        End If
                    Next
                End If

                data = command.ExecuteNonQuery()
                connection.Close()
            End Using

            Return data
        End Function

        Public Function ExecuteScalar(ByVal query As String, Optional ByVal parameter As Object() = Nothing) As Object
            Dim data As Object = 0

            Using connection As SqlConnection = New SqlConnection(connectionSTR)
                connection.Open()
                Dim command As SqlCommand = New SqlCommand(query, connection)

                If parameter IsNot Nothing Then
                    Dim listPara As String() = query.Split(" "c)
                    Dim i As Integer = 0

                    For Each item As String In listPara

                        If item.Contains("@"c) Then
                            command.Parameters.AddWithValue(item, parameter(i))
                            i += 1
                        End If
                    Next
                End If

                data = command.ExecuteScalar()
                connection.Close()
            End Using

            Return data
        End Function
    End Class
End Namespace
