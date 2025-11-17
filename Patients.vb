Public Module Patients
    Public Structure patient
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
        Dim age As Integer


    End Structure

    Public listepatients As New List(Of patient)

    Dim p As patient
    Public Sub ajouterPatient(p As patient)




        p.code = listepatients.Count
        listepatients.Add(p)

    End Sub







End Module
