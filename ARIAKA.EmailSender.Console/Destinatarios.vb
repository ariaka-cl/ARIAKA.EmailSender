Module Destinatarios

    Sub Main()
        Dim ss As New SenderEmail
        Dim listEmail As New List(Of Model.Destinatario)
        listEmail.Add(New Model.Destinatario With {.Email = "jtabilot@gmail.com"})
        listEmail.Add(New Model.Destinatario With {.Email = "diego.bonilla.vargas@gmail.com"})
        ss.SendEmail(listEmail)
    End Sub

End Module
