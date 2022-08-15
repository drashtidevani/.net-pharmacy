Imports System.Data.OleDb
Public Class Billing
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet

    Public Sub display()
        ds.Clear()
        adp = New OleDbDataAdapter("select * from billing", cn)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)



    End Sub

    Private Sub medicine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Notebook\Documents\Visual Studio 2010\Projects\pharmacy.accdb"
        cn.Open()
        display()
        cn.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cn.Open()
            Dim str As String
            str = "insert into billing values (' " & bid.Text & " ' , ' " & bname.Text & " ' ,  ' " & bprice.Text & " ', ' " & bquantity.Text & " '  )"
            cmd = New OleDbCommand(str, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record Inserted")
            display()
        Catch ex As Exception
            MsgBox("Insert Details")
        End Try
        cn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class