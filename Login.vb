Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = txtuser.Text
        password = txtpass.Text
        If (username.Equals("drashti") And password.Equals("12345")) Then
            MessageBox.Show("Login Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim obj = New Home

            obj.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error!!!", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.TextChanged

    End Sub
End Class