<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        btfechar = New Button()
        PictureBox1 = New PictureBox()
        txtinserir = New TextBox()
        lblinserir = New Label()
        lblX0 = New Label()
        lblx1 = New Label()
        lblref = New Label()
        BindingSource1 = New BindingSource(components)
        btdeslocar = New Button()
        btautohome = New Button()
        btfw = New Button()
        btrv = New Button()
        IconSplitButton1 = New FontAwesome.Sharp.IconSplitButton()
        txtesqureda = New TextBox()
        txtref = New TextBox()
        txtdireita = New TextBox()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btfechar
        ' 
        btfechar.Location = New Point(687, 371)
        btfechar.Name = "btfechar"
        btfechar.Size = New Size(75, 23)
        btfechar.TabIndex = 0
        btfechar.Text = "Fechar janela"
        btfechar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(124, 93)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(556, 213)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' txtinserir
        ' 
        txtinserir.Location = New Point(75, 374)
        txtinserir.Name = "txtinserir"
        txtinserir.Size = New Size(135, 23)
        txtinserir.TabIndex = 2
        ' 
        ' lblinserir
        ' 
        lblinserir.AutoSize = True
        lblinserir.Location = New Point(100, 356)
        lblinserir.Name = "lblinserir"
        lblinserir.Size = New Size(83, 15)
        lblinserir.TabIndex = 3
        lblinserir.Text = "Inserir Posição"
        ' 
        ' lblX0
        ' 
        lblX0.AutoSize = True
        lblX0.Location = New Point(545, 107)
        lblX0.Name = "lblX0"
        lblX0.Size = New Size(20, 15)
        lblX0.TabIndex = 4
        lblX0.Text = "X0"
        ' 
        ' lblx1
        ' 
        lblx1.AutoSize = True
        lblx1.Location = New Point(239, 107)
        lblx1.Name = "lblx1"
        lblx1.Size = New Size(20, 15)
        lblx1.TabIndex = 5
        lblx1.Text = "X1"
        ' 
        ' lblref
        ' 
        lblref.AutoSize = True
        lblref.Location = New Point(444, 118)
        lblref.Name = "lblref"
        lblref.Size = New Size(28, 15)
        lblref.TabIndex = 6
        lblref.Text = "Xref"
        ' 
        ' btdeslocar
        ' 
        btdeslocar.Location = New Point(250, 374)
        btdeslocar.Name = "btdeslocar"
        btdeslocar.Size = New Size(75, 23)
        btdeslocar.TabIndex = 7
        btdeslocar.Text = "Deslocar"
        btdeslocar.UseVisualStyleBackColor = True
        ' 
        ' btautohome
        ' 
        btautohome.Location = New Point(135, 37)
        btautohome.Name = "btautohome"
        btautohome.Size = New Size(75, 23)
        btautohome.TabIndex = 8
        btautohome.Text = "Auto home"
        btautohome.UseVisualStyleBackColor = True
        ' 
        ' btfw
        ' 
        btfw.Location = New Point(593, 356)
        btfw.Name = "btfw"
        btfw.Size = New Size(75, 23)
        btfw.TabIndex = 9
        btfw.Text = "Manual FW"
        btfw.UseVisualStyleBackColor = True
        ' 
        ' btrv
        ' 
        btrv.Location = New Point(593, 385)
        btrv.Name = "btrv"
        btrv.Size = New Size(75, 23)
        btrv.TabIndex = 10
        btrv.Text = "Manual RV"
        btrv.UseVisualStyleBackColor = True
        ' 
        ' IconSplitButton1
        ' 
        IconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        IconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconSplitButton1.IconColor = Color.Black
        IconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconSplitButton1.IconSize = 48
        IconSplitButton1.Name = "IconSplitButton1"
        IconSplitButton1.Rotation = 0R
        IconSplitButton1.Size = New Size(23, 23)
        IconSplitButton1.Text = "IconSplitButton1"
        ' 
        ' txtesqureda
        ' 
        txtesqureda.Location = New Point(225, 127)
        txtesqureda.Name = "txtesqureda"
        txtesqureda.Size = New Size(45, 23)
        txtesqureda.TabIndex = 11
        ' 
        ' txtref
        ' 
        txtref.Location = New Point(439, 149)
        txtref.Name = "txtref"
        txtref.Size = New Size(38, 23)
        txtref.TabIndex = 12
        ' 
        ' txtdireita
        ' 
        txtdireita.Location = New Point(527, 125)
        txtdireita.Name = "txtdireita"
        txtdireita.Size = New Size(55, 23)
        txtdireita.TabIndex = 13
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtdireita)
        Controls.Add(txtref)
        Controls.Add(txtesqureda)
        Controls.Add(btrv)
        Controls.Add(btfw)
        Controls.Add(btautohome)
        Controls.Add(btdeslocar)
        Controls.Add(lblref)
        Controls.Add(lblx1)
        Controls.Add(lblX0)
        Controls.Add(lblinserir)
        Controls.Add(txtinserir)
        Controls.Add(PictureBox1)
        Controls.Add(btfechar)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btfechar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtinserir As TextBox
    Friend WithEvents lblinserir As Label
    Friend WithEvents lblX0 As Label
    Friend WithEvents lblx1 As Label
    Friend WithEvents lblref As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents btdeslocar As Button
    Friend WithEvents btautohome As Button
    Friend WithEvents btfw As Button
    Friend WithEvents btrv As Button
    Friend WithEvents IconSplitButton1 As FontAwesome.Sharp.IconSplitButton
    Friend WithEvents txtesqureda As TextBox
    Friend WithEvents txtref As TextBox
    Friend WithEvents txtdireita As TextBox
    Friend WithEvents Timer1 As Timer
End Class
