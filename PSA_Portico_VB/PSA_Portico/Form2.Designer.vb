<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Btn_Connect = New Button()
        Btn_LerBaseDados = New Button()
        Btn_InserirRegisto = New Button()
        Btn_LerRegisto = New Button()
        Btn_UpdateRegisto = New Button()
        Btn_ApagarRegisto = New Button()
        Txt_Leitura = New TextBox()
        Lbl_LeituraRegisto = New Label()
        Lbl_Registo = New Label()
        Btn_Terminar = New Button()
        Lbl_Usuario = New Label()
        Lbl_Posição = New Label()
        Txt_Nome = New TextBox()
        Txt_Posição = New TextBox()
        Txt_mode = New TextBox()
        Lbl_mode = New Label()
        Txt_ID = New TextBox()
        Bt_Back = New Button()
        Bt_Dump = New Button()
        SuspendLayout()
        ' 
        ' Btn_Connect
        ' 
        Btn_Connect.Location = New Point(10, 19)
        Btn_Connect.Margin = New Padding(3, 2, 3, 2)
        Btn_Connect.Name = "Btn_Connect"
        Btn_Connect.Size = New Size(123, 29)
        Btn_Connect.TabIndex = 0
        Btn_Connect.Text = "Connect"
        Btn_Connect.UseVisualStyleBackColor = True
        ' 
        ' Btn_LerBaseDados
        ' 
        Btn_LerBaseDados.Location = New Point(10, 52)
        Btn_LerBaseDados.Margin = New Padding(3, 2, 3, 2)
        Btn_LerBaseDados.Name = "Btn_LerBaseDados"
        Btn_LerBaseDados.Size = New Size(123, 29)
        Btn_LerBaseDados.TabIndex = 1
        Btn_LerBaseDados.Text = "Ler Base Dados"
        Btn_LerBaseDados.UseVisualStyleBackColor = True
        ' 
        ' Btn_InserirRegisto
        ' 
        Btn_InserirRegisto.Location = New Point(10, 86)
        Btn_InserirRegisto.Margin = New Padding(3, 2, 3, 2)
        Btn_InserirRegisto.Name = "Btn_InserirRegisto"
        Btn_InserirRegisto.Size = New Size(123, 29)
        Btn_InserirRegisto.TabIndex = 2
        Btn_InserirRegisto.Text = "Inserir Registo"
        Btn_InserirRegisto.UseVisualStyleBackColor = True
        ' 
        ' Btn_LerRegisto
        ' 
        Btn_LerRegisto.Location = New Point(10, 120)
        Btn_LerRegisto.Margin = New Padding(3, 2, 3, 2)
        Btn_LerRegisto.Name = "Btn_LerRegisto"
        Btn_LerRegisto.Size = New Size(123, 29)
        Btn_LerRegisto.TabIndex = 3
        Btn_LerRegisto.Text = "Ler Registo"
        Btn_LerRegisto.UseVisualStyleBackColor = True
        ' 
        ' Btn_UpdateRegisto
        ' 
        Btn_UpdateRegisto.Location = New Point(10, 154)
        Btn_UpdateRegisto.Margin = New Padding(3, 2, 3, 2)
        Btn_UpdateRegisto.Name = "Btn_UpdateRegisto"
        Btn_UpdateRegisto.Size = New Size(123, 29)
        Btn_UpdateRegisto.TabIndex = 4
        Btn_UpdateRegisto.Text = "Update Registo"
        Btn_UpdateRegisto.UseVisualStyleBackColor = True
        ' 
        ' Btn_ApagarRegisto
        ' 
        Btn_ApagarRegisto.Location = New Point(10, 188)
        Btn_ApagarRegisto.Margin = New Padding(3, 2, 3, 2)
        Btn_ApagarRegisto.Name = "Btn_ApagarRegisto"
        Btn_ApagarRegisto.Size = New Size(123, 29)
        Btn_ApagarRegisto.TabIndex = 5
        Btn_ApagarRegisto.Text = "Apagar Registo"
        Btn_ApagarRegisto.UseVisualStyleBackColor = True
        ' 
        ' Txt_Leitura
        ' 
        Txt_Leitura.Location = New Point(172, 54)
        Txt_Leitura.Margin = New Padding(3, 2, 3, 2)
        Txt_Leitura.Multiline = True
        Txt_Leitura.Name = "Txt_Leitura"
        Txt_Leitura.Size = New Size(489, 170)
        Txt_Leitura.TabIndex = 6
        ' 
        ' Lbl_LeituraRegisto
        ' 
        Lbl_LeituraRegisto.AutoSize = True
        Lbl_LeituraRegisto.Location = New Point(172, 37)
        Lbl_LeituraRegisto.Name = "Lbl_LeituraRegisto"
        Lbl_LeituraRegisto.Size = New Size(85, 15)
        Lbl_LeituraRegisto.TabIndex = 7
        Lbl_LeituraRegisto.Text = "Leitura Registo"
        ' 
        ' Lbl_Registo
        ' 
        Lbl_Registo.AutoSize = True
        Lbl_Registo.Location = New Point(172, 258)
        Lbl_Registo.Name = "Lbl_Registo"
        Lbl_Registo.Size = New Size(46, 15)
        Lbl_Registo.TabIndex = 8
        Lbl_Registo.Text = "Registo"
        ' 
        ' Btn_Terminar
        ' 
        Btn_Terminar.Location = New Point(566, 297)
        Btn_Terminar.Margin = New Padding(3, 2, 3, 2)
        Btn_Terminar.Name = "Btn_Terminar"
        Btn_Terminar.Size = New Size(123, 29)
        Btn_Terminar.TabIndex = 9
        Btn_Terminar.Text = "Terminar"
        Btn_Terminar.UseVisualStyleBackColor = True
        ' 
        ' Lbl_Usuario
        ' 
        Lbl_Usuario.AutoSize = True
        Lbl_Usuario.Location = New Point(178, 347)
        Lbl_Usuario.Name = "Lbl_Usuario"
        Lbl_Usuario.Size = New Size(40, 15)
        Lbl_Usuario.TabIndex = 11
        Lbl_Usuario.Text = "Nome"
        ' 
        ' Lbl_Posição
        ' 
        Lbl_Posição.AutoSize = True
        Lbl_Posição.Location = New Point(179, 374)
        Lbl_Posição.Name = "Lbl_Posição"
        Lbl_Posição.Size = New Size(48, 15)
        Lbl_Posição.TabIndex = 12
        Lbl_Posição.Text = "Posição"
        ' 
        ' Txt_Nome
        ' 
        Txt_Nome.Location = New Point(239, 344)
        Txt_Nome.Margin = New Padding(3, 2, 3, 2)
        Txt_Nome.Multiline = True
        Txt_Nome.Name = "Txt_Nome"
        Txt_Nome.Size = New Size(254, 24)
        Txt_Nome.TabIndex = 14
        ' 
        ' Txt_Posição
        ' 
        Txt_Posição.Location = New Point(239, 371)
        Txt_Posição.Margin = New Padding(3, 2, 3, 2)
        Txt_Posição.Multiline = True
        Txt_Posição.Name = "Txt_Posição"
        Txt_Posição.Size = New Size(254, 24)
        Txt_Posição.TabIndex = 15
        ' 
        ' Txt_mode
        ' 
        Txt_mode.Location = New Point(239, 316)
        Txt_mode.Margin = New Padding(3, 2, 3, 2)
        Txt_mode.Multiline = True
        Txt_mode.Name = "Txt_mode"
        Txt_mode.Size = New Size(171, 24)
        Txt_mode.TabIndex = 16
        ' 
        ' Lbl_mode
        ' 
        Lbl_mode.AutoSize = True
        Lbl_mode.Location = New Point(179, 319)
        Lbl_mode.Name = "Lbl_mode"
        Lbl_mode.Size = New Size(39, 15)
        Lbl_mode.TabIndex = 17
        Lbl_mode.Text = "Modo"
        ' 
        ' Txt_ID
        ' 
        Txt_ID.Location = New Point(239, 288)
        Txt_ID.Margin = New Padding(3, 2, 3, 2)
        Txt_ID.Multiline = True
        Txt_ID.Name = "Txt_ID"
        Txt_ID.Size = New Size(171, 24)
        Txt_ID.TabIndex = 18
        ' 
        ' Bt_Back
        ' 
        Bt_Back.Location = New Point(566, 367)
        Bt_Back.Margin = New Padding(3, 2, 3, 2)
        Bt_Back.Name = "Bt_Back"
        Bt_Back.Size = New Size(123, 29)
        Bt_Back.TabIndex = 19
        Bt_Back.Text = "Voltar"
        Bt_Back.UseVisualStyleBackColor = True
        ' 
        ' Bt_Dump
        ' 
        Bt_Dump.Location = New Point(12, 221)
        Bt_Dump.Margin = New Padding(3, 2, 3, 2)
        Bt_Dump.Name = "Bt_Dump"
        Bt_Dump.Size = New Size(123, 29)
        Bt_Dump.TabIndex = 20
        Bt_Dump.Text = "Apagar Tabela"
        Bt_Dump.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        ClientSize = New Size(751, 456)
        Controls.Add(Bt_Dump)
        Controls.Add(Bt_Back)
        Controls.Add(Txt_ID)
        Controls.Add(Lbl_mode)
        Controls.Add(Txt_mode)
        Controls.Add(Txt_Posição)
        Controls.Add(Txt_Nome)
        Controls.Add(Lbl_Posição)
        Controls.Add(Lbl_Usuario)
        Controls.Add(Btn_Terminar)
        Controls.Add(Lbl_Registo)
        Controls.Add(Lbl_LeituraRegisto)
        Controls.Add(Txt_Leitura)
        Controls.Add(Btn_ApagarRegisto)
        Controls.Add(Btn_UpdateRegisto)
        Controls.Add(Btn_LerRegisto)
        Controls.Add(Btn_InserirRegisto)
        Controls.Add(Btn_LerBaseDados)
        Controls.Add(Btn_Connect)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        Text = "Base De Dados"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_Connect As Button
    Friend WithEvents Btn_LerBaseDados As Button
    Friend WithEvents Btn_InserirRegisto As Button
    Friend WithEvents Btn_LerRegisto As Button
    Friend WithEvents Btn_UpdateRegisto As Button
    Friend WithEvents Btn_ApagarRegisto As Button
    Friend WithEvents Txt_Leitura As TextBox
    Friend WithEvents Lbl_LeituraRegisto As Label
    Friend WithEvents Lbl_Registo As Label
    Friend WithEvents Btn_Terminar As Button
    Friend WithEvents Lbl_Usuario As Label
    Friend WithEvents Lbl_Posição As Label
    Friend WithEvents Txt_Nome As TextBox
    Friend WithEvents Txt_Posição As TextBox
    Friend WithEvents Txt_mode As TextBox
    Friend WithEvents Lbl_mode As Label
    Friend WithEvents Txt_ID As TextBox
    Friend WithEvents Bt_Back As Button
    Friend WithEvents Bt_Dump As Button
End Class
