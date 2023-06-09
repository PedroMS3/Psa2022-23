Public Class Form1

    Dim fs As New FaconSvr.FaconServer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fs.OpenProject("C:\Portico_srv\PLC_1.fcs")
        fs.Connect()
        Timer1.Start()
        Timer1.Interval = 100
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub lblX0_Click(sender As Object, e As EventArgs) Handles lblX0.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblref.Click

    End Sub

    Private Sub btautohome_Click(sender As Object, e As EventArgs) Handles btautohome.Click
        fs.SetItem("Channel0.Station0.Group0", "M11", 1)
        fs.SetItem("Channel0.Station0.Group0", "M0", 1)
    End Sub

    Private Sub lblx1_Click(sender As Object, e As EventArgs) Handles lblx1.Click

    End Sub

    Private Sub btfechar_Click(sender As Object, e As EventArgs) Handles btfechar.Click
        End
    End Sub

    Private Sub btdeslocar_Click(sender As Object, e As EventArgs) Handles btdeslocar.Click
        fs.SetItem("Channel0.Station0.Group0", "D0", txtinserir.Text)
        fs.SetItem("Channel0.Station0.Group0", "M12", 1)
        fs.SetItem("Channel0.Station0.Group0", "M2", 1)
    End Sub

    Private Sub btfw_Click(sender As Object, e As EventArgs) Handles btfw.MouseDown
        fs.SetItem("Channel0.Station0.Group0", "M11", 1)
        fs.SetItem("Channel0.Station0.Group0", "M1", 1)
    End Sub

    Private Sub btfw_MouseUp(sender As Object, e As MouseEventArgs) Handles btfw.MouseUp
        fs.SetItem("Channel0.Station0.Group0", "M11", 0)
        fs.SetItem("Channel0.Station0.Group0", "M1", 0)
    End Sub

    Private Sub btrv_MouseDown(sender As Object, e As EventArgs) Handles btrv.MouseDown
        fs.SetItem("Channel0.Station0.Group0", "M12", 1)
        fs.SetItem("Channel0.Station0.Group0", "M1", 1)
    End Sub

    Private Sub btrv_Click(sender As Object, e As EventArgs) Handles btrv.MouseUp
        fs.SetItem("Channel0.Station0.Group0", "M12", 0)
        fs.SetItem("Channel0.Station0.Group0", "M1", 0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtesqureda.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim X0, X1, Xref As Boolean
        X0 = fs.GetItem("Channel0.Station0.Group0", "X4")
        X1 = fs.GetItem("Channel0.Station0.Group0", "X5")
        Xref = fs.GetItem("Channel0.Station0.Group0", "X3")

        If Xref = True Then
            txtref.BackColor = Color.Green
        Else
            txtref.BackColor = Color.Red
        End If

        If X1 = True Then
            txtesqureda.BackColor = Color.Green
        Else
            txtesqureda.BackColor = Color.Red
        End If

        If X0 = True Then
            txtdireita.BackColor = Color.Green
        Else
            txtdireita.BackColor = Color.Red
        End If

    End Sub
End Class
