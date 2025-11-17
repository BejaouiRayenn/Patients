<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LblCd = New Label()
        LblNom = New Label()
        Prènom = New Label()
        LblAge = New Label()
        Txtcd = New TextBox()
        TxtNom = New TextBox()
        TxtPrenom = New TextBox()
        TxtAge = New TextBox()
        LblInfoPatients = New Label()
        SuspendLayout()
        ' 
        ' LblCd
        ' 
        LblCd.AutoSize = True
        LblCd.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        LblCd.Location = New Point(583, 132)
        LblCd.Name = "LblCd"
        LblCd.Size = New Size(59, 28)
        LblCd.TabIndex = 0
        LblCd.Text = "Code"
        ' 
        ' LblNom
        ' 
        LblNom.AutoSize = True
        LblNom.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        LblNom.Location = New Point(584, 183)
        LblNom.Name = "LblNom"
        LblNom.Size = New Size(58, 28)
        LblNom.TabIndex = 1
        LblNom.Text = "Nom"
        ' 
        ' Prènom
        ' 
        Prènom.AutoSize = True
        Prènom.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        Prènom.Location = New Point(584, 247)
        Prènom.Name = "Prènom"
        Prènom.Size = New Size(85, 28)
        Prènom.TabIndex = 2
        Prènom.Text = "Prènom"
        ' 
        ' LblAge
        ' 
        LblAge.AutoSize = True
        LblAge.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic)
        LblAge.Location = New Point(584, 310)
        LblAge.Name = "LblAge"
        LblAge.Size = New Size(48, 28)
        LblAge.TabIndex = 3
        LblAge.Text = "Age"
        ' 
        ' Txtcd
        ' 
        Txtcd.Location = New Point(726, 133)
        Txtcd.Name = "Txtcd"
        Txtcd.Size = New Size(125, 27)
        Txtcd.TabIndex = 4
        ' 
        ' TxtNom
        ' 
        TxtNom.Location = New Point(726, 183)
        TxtNom.Name = "TxtNom"
        TxtNom.Size = New Size(125, 27)
        TxtNom.TabIndex = 5
        ' 
        ' TxtPrenom
        ' 
        TxtPrenom.Location = New Point(726, 248)
        TxtPrenom.Name = "TxtPrenom"
        TxtPrenom.Size = New Size(125, 27)
        TxtPrenom.TabIndex = 6
        ' 
        ' TxtAge
        ' 
        TxtAge.Location = New Point(726, 310)
        TxtAge.Name = "TxtAge"
        TxtAge.Size = New Size(125, 27)
        TxtAge.TabIndex = 7
        ' 
        ' LblInfoPatients
        ' 
        LblInfoPatients.AutoSize = True
        LblInfoPatients.Font = New Font("Segoe UI", 15F, FontStyle.Bold Or FontStyle.Italic)
        LblInfoPatients.Location = New Point(385, 62)
        LblInfoPatients.Name = "LblInfoPatients"
        LblInfoPatients.Size = New Size(316, 35)
        LblInfoPatients.TabIndex = 8
        LblInfoPatients.Text = "Informations Du patients "
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Capture_d_écran_2025_11_17_215137
        ClientSize = New Size(1079, 450)
        Controls.Add(LblInfoPatients)
        Controls.Add(TxtAge)
        Controls.Add(TxtPrenom)
        Controls.Add(TxtNom)
        Controls.Add(Txtcd)
        Controls.Add(LblAge)
        Controls.Add(Prènom)
        Controls.Add(LblNom)
        Controls.Add(LblCd)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblCd As Label
    Friend WithEvents LblNom As Label
    Friend WithEvents Prènom As Label
    Friend WithEvents LblAge As Label
    Friend WithEvents Txtcd As TextBox
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtPrenom As TextBox
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents LblInfoPatients As Label
End Class
