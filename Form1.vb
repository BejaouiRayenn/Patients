Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblDate.Text = Date.Today.ToLongDateString()
    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        Dim A As patient
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
        If String.IsNullOrWhiteSpace(TxtNom.Text) Then
            ErrorProvider1.SetError(TxtNom, "Nom invalide")
            Return
        End If
        If String.IsNullOrWhiteSpace(TxtPrénom.Text) Then
            ErrorProvider1.SetError(TxtPrénom, "Nom invalide")
            Return

        End If
        age = CInt(TxtAge.Text)
        A.nom = TxtNom.Text
        A.prenom = TxtPrénom.Text
        A.age = age
        ajouterPatient(A)
        init()
        MAJ_DGV()
    End Sub
    Private Sub init()
        TxtAge.ResetText()
        TxtNom.Clear()
        TxtPrénom.Clear()

    End Sub
    Private Sub MAJ_DGV()
        dgvp.Rows.Clear()
        For Each A As patient In listepatients
            dgvp.Rows.Add(A.code, A.nom, A.prenom, A.age)
        Next
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        TxtNom.Clear()
        TxtPrénom.Clear()
    End Sub

    Private Sub BtnLstPatients_Click(sender As Object, e As EventArgs) Handles BtnLstPatients.Click

        Dim form As New Form2
        form.Txtcd.Text = dgvp.CurrentRow.Cells(0).Value.ToString()
        form.TxtNom.Text = dgvp.CurrentRow.Cells(1).Value.ToString()
        form.TxtPrenom.Text = dgvp.CurrentRow.Cells(2).Value.ToString()
        form.TxtAge.Text = dgvp.CurrentRow.Cells(3).Value.ToString()
        form.ShowDialog()

    End Sub
End Class
