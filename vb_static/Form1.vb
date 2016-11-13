Public Class Form1


    Public Class cls
        Private Shared a As Integer
        Public Shared Sub set_a(ByVal ast As Integer)
            a = ast
        End Sub
        Public Function get_a() As Integer
            Return a '
        End Function
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As New cls
        cls.set_a(5)

        ListBox1.Items.Add(c.get_a())
        Dim cb As New cls
        ListBox1.Items.Add(cb.get_a())
    End Sub
End Class
