Imports System.IO
Public Class Form1
    ':::Ruta donde crearemos nuestro archivo txt
    Dim ruta As String = "C:\Users\jeferson\Desktop\"
    ':::Nombre del archivo
    Dim archivo As String = "archivo.txt"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = "C:\Users\jeferson\Pictures"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ':::ListBox1.Items.Add(TextBox1.Text & " , " & TextBox2.Text)
        ':::TextBox2.Text = ""
        ':::TextBox1.Text = ""
        Dim escribir As New StreamWriter(ruta & archivo, True)

        Try

            escribir.WriteLine(TextBox1.Text + " , " + TextBox2.Text)

            escribir.Close()
            MsgBox("Registro guardado correctamente")
            '
            TextBox1.Clear()
            TextBox2.Clear()


        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: ")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) _
       Handles TextBox1.TextChanged, TextBox2.TextChanged

        Button2.Enabled = ((TextBox1.TextLength > 0) And (TextBox2.TextLength > 0))

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
End Class
