Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True

        ComboBox1.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        Button3.Enabled = True
        TextBox1.Focus()
        'Button3.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("INGRESE NOMBRE")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("INGRESE APELLIDO")
            TextBox2.Focus()
            Exit Sub
        End If
        ListBox1.Items.Add(TextBox1.Text)
        ListBox2.Items.Add(TextBox2.Text)
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex > -1 Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox1.Text = ListBox1.SelectedItem
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
