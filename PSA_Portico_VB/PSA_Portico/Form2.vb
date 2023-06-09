Imports Microsoft.Win32
Imports MySql.Data.MySqlClient

Public Class Form2
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim data_reader As MySqlDataReader



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Connect_Click(sender As Object, e As EventArgs) Handles Btn_Connect.Click
        ' Ligação e Abertura da Base de Dados e Selecção do Esquema
        cn.ConnectionString = "Server=localhost; User Id=root; Password=; Database=portico_x"
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
                MsgBox("Ligação Correcta à Base de Dados pòrtico...")
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox("Ligação Incorrecta à Base de Dados pòrtico...")
        End Try
        cmd.Connection = cn
    End Sub

    Private Sub Btn_LerBaseDados_Click(sender As Object, e As EventArgs) Handles Btn_LerBaseDados.Click
        ' Leitura sequencial dos dados existentes na base de dados
        Dim str As String
        'Selecção da tabela da base de dados para leitura dos dados
        cmd.CommandText = "SELECT * FROM portico_x2"
        data_reader = cmd.ExecuteReader
        ' Leitura sequencial da tabela.. Guarda o conteúdo dos registos na variável str
        While data_reader.Read()
            str = str & data_reader("ID") & vbTab & data_reader("Nome") & vbTab & data_reader("Modo") & vbTab & data_reader("Posição") & vbTab & data_reader("Data") & vbTab & data_reader("Hora") & vbCrLf
        End While
        Txt_Leitura.Text = str ' Visualiza os dados de todos os registos
        data_reader.Close()
    End Sub

    Private Sub Btn_InserirRegisto_Click(sender As Object, e As EventArgs) Handles Btn_InserirRegisto.Click
        ' Insere Registo numa Base de Dados 
        cmd.CommandText = "Insert into portico_x(Nome,Posição,Data,Hora,Modo) Values('" &
        Txt_Nome.Text & "','" & Txt_Posição.Text & "','" & DateString & "','" & TimeString & "','" & Txt_mode.Text & "')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Btn_LerRegisto_Click(sender As Object, e As EventArgs) Handles Btn_LerRegisto.Click
        Dim str As String
        ' Procura do Registo pretendido
        cmd.CommandText = "Select * From pòrtico Where idpòrtico='" & Txt_Id.Text & "'"
        'cmd.CommandText = "Select * From pórtico_eixo x Where nome='xx' "
        data_reader = cmd.ExecuteReader
        ' Leitura do Registo
        data_reader.Read()
        Txt_Nome.Text = data_reader("Nome")
        Txt_Posição.Text = data_reader("Posição")
        data_reader.Close()
    End Sub

    Private Sub Btn_UpdateRegisto_Click(sender As Object, e As EventArgs) Handles Btn_UpdateRegisto.Click
        ' Update de um registo existente
        cmd.CommandText = "UPDATE pòrtico Set Nome='" & Txt_Nome.Text & "', Posição='" & Txt_Posição.Text &
        "' where idpòrtico='" & CInt(Txt_Id.Text) & "'"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Btn_ApagarRegisto_Click(sender As Object, e As EventArgs) Handles Btn_ApagarRegisto.Click
        ' Apagar Registo através da chave de indexação
        cmd.CommandText = "Delete From portico_x Where ID='" & Txt_ID.Text & "' "
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Btn_Terminar_Click(sender As Object, e As EventArgs) Handles Btn_Terminar.Click
        End
    End Sub

    Private Sub Bt_Dump_Click(sender As Object, e As EventArgs) Handles Bt_Back.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Bt_Dump_Click_1(sender As Object, e As EventArgs) Handles Bt_Dump.Click
        cmd.CommandText = "Delete From portico_x2"
        cmd.ExecuteNonQuery()
    End Sub
End Class