﻿Imports System.Data.OleDb
Public Class frmCommission

    Private Sub frmCommission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objData As New DataTier.clsData()
        Dim dsData As New DataSet

        Try
            'connect to database
            objData.connect()
            dsData = objData.getCommission()
            'get data from database
            dgvCommission.DataSource = dsData.Tables(0)

        Catch ex As Exception
            sendMessage(ex.Message, "Error")
        End Try

    End Sub




End Class
