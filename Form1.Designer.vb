<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        LblNom = New Label()
        LblPrénom = New Label()
        LblAge = New Label()
        LblAjoutPatient = New Label()
        BtnAjouter = New Button()
        BtnAnnuler = New Button()
        TxtNom = New TextBox()
        TxtPrénom = New TextBox()
        TxtAge = New NumericUpDown()
        dgvp = New DataGridView()
        Code = New DataGridViewTextBoxColumn()
        Nom = New DataGridViewTextBoxColumn()
        Prènom = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        LblDate = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        BtnLstPatients = New Button()
        CType(TxtAge, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvp, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblNom
        ' 
        LblNom.AutoSize = True
        LblNom.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblNom.Location = New Point(73, 62)
        LblNom.Name = "LblNom"
        LblNom.Size = New Size(44, 20)
        LblNom.TabIndex = 0
        LblNom.Text = "Nom"
        ' 
        ' LblPrénom
        ' 
        LblPrénom.AutoSize = True
        LblPrénom.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblPrénom.Location = New Point(73, 112)
        LblPrénom.Name = "LblPrénom"
        LblPrénom.Size = New Size(64, 20)
        LblPrénom.TabIndex = 1
        LblPrénom.Text = "Prénom"
        ' 
        ' LblAge
        ' 
        LblAge.AutoSize = True
        LblAge.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblAge.Location = New Point(73, 165)
        LblAge.Name = "LblAge"
        LblAge.Size = New Size(37, 20)
        LblAge.TabIndex = 2
        LblAge.Text = "Age"
        ' 
        ' LblAjoutPatient
        ' 
        LblAjoutPatient.AutoSize = True
        LblAjoutPatient.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LblAjoutPatient.Location = New Point(73, 9)
        LblAjoutPatient.Name = "LblAjoutPatient"
        LblAjoutPatient.Size = New Size(337, 32)
        LblAjoutPatient.TabIndex = 3
        LblAjoutPatient.Text = "Ajouter un nouveau Patient "
        ' 
        ' BtnAjouter
        ' 
        BtnAjouter.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnAjouter.ForeColor = SystemColors.ControlDarkDark
        BtnAjouter.Location = New Point(65, 238)
        BtnAjouter.Name = "BtnAjouter"
        BtnAjouter.Size = New Size(129, 63)
        BtnAjouter.TabIndex = 4
        BtnAjouter.Text = "Ajouter"
        BtnAjouter.UseVisualStyleBackColor = True
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnAnnuler.ForeColor = SystemColors.ControlDarkDark
        BtnAnnuler.Location = New Point(212, 238)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(129, 63)
        BtnAnnuler.TabIndex = 5
        BtnAnnuler.Text = "Annuler"
        BtnAnnuler.UseVisualStyleBackColor = True
        ' 
        ' TxtNom
        ' 
        TxtNom.Location = New Point(162, 62)
        TxtNom.Name = "TxtNom"
        TxtNom.Size = New Size(125, 27)
        TxtNom.TabIndex = 6
        ' 
        ' TxtPrénom
        ' 
        TxtPrénom.Location = New Point(162, 112)
        TxtPrénom.Name = "TxtPrénom"
        TxtPrénom.Size = New Size(125, 27)
        TxtPrénom.TabIndex = 7
        ' 
        ' TxtAge
        ' 
        TxtAge.Location = New Point(162, 165)
        TxtAge.Name = "TxtAge"
        TxtAge.Size = New Size(150, 27)
        TxtAge.TabIndex = 8
        ' 
        ' dgvp
        ' 
        dgvp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvp.Columns.AddRange(New DataGridViewColumn() {Code, Nom, Prènom, Age})
        dgvp.Location = New Point(362, 149)
        dgvp.Name = "dgvp"
        dgvp.RowHeadersWidth = 51
        dgvp.Size = New Size(525, 188)
        dgvp.TabIndex = 12
        ' 
        ' Code
        ' 
        Code.HeaderText = "Code"
        Code.MinimumWidth = 6
        Code.Name = "Code"
        Code.Width = 125
        ' 
        ' Nom
        ' 
        Nom.HeaderText = "Nom"
        Nom.MinimumWidth = 6
        Nom.Name = "Nom"
        Nom.Width = 125
        ' 
        ' Prènom
        ' 
        Prènom.HeaderText = "Prènom"
        Prènom.MinimumWidth = 6
        Prènom.Name = "Prènom"
        Prènom.Width = 125
        ' 
        ' Age
        ' 
        Age.HeaderText = "Age"
        Age.MinimumWidth = 6
        Age.Name = "Age"
        Age.Width = 125
        ' 
        ' LblDate
        ' 
        LblDate.AutoSize = True
        LblDate.Location = New Point(486, 25)
        LblDate.Name = "LblDate"
        LblDate.Size = New Size(0, 20)
        LblDate.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' BtnLstPatients
        ' 
        BtnLstPatients.Location = New Point(65, 342)
        BtnLstPatients.Name = "BtnLstPatients"
        BtnLstPatients.Size = New Size(276, 58)
        BtnLstPatients.TabIndex = 13
        BtnLstPatients.Text = "BtnAfficherPatients"
        BtnLstPatients.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(920, 450)
        Controls.Add(BtnLstPatients)
        Controls.Add(LblDate)
        Controls.Add(dgvp)
        Controls.Add(TxtAge)
        Controls.Add(TxtPrénom)
        Controls.Add(TxtNom)
        Controls.Add(BtnAnnuler)
        Controls.Add(BtnAjouter)
        Controls.Add(LblAjoutPatient)
        Controls.Add(LblAge)
        Controls.Add(LblPrénom)
        Controls.Add(LblNom)
        Name = "Form1"
        Text = "Form1"
        CType(TxtAge, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvp, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblNom As Label
    Friend WithEvents LblPrénom As Label
    Friend WithEvents LblAge As Label
    Friend WithEvents LblAjoutPatient As Label
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtPrénom As TextBox
    Friend WithEvents TxtAge As NumericUpDown
    Friend WithEvents dgvp As DataGridView
    Friend WithEvents LblDate As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prènom As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents BtnLstPatients As Button

End Class
