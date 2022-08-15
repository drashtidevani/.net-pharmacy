Imports System.Data.OleDb
Public Class Manufacturer
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet

    Public Sub display()
        ds.Clear()
        adp = New OleDbDataAdapter("select * from manufacturer", cn)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub medicine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Notebook\Documents\Visual Studio 2010\Projects\pharmacy.accdb"
        cn.Open()
        display()
        cn.Close()
    End Sub


    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub UnameTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Manufacturer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Open()
            Dim str As String
            str = "insert into manufacturer values (' " & cid.Text & " ' , ' " & cname.Text & " ' ,  ' " & cphone.Text & " ', ' " & cadd.Text & " '  )"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Inserted")
            display()
        Catch ex As Exception
            MsgBox("Insert Details")
        End Try
        cn.Close()

    End Sub
End Class