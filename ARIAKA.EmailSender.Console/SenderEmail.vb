Imports System.Net.Mail
Public Class SenderEmail

    Public Sub SendEmail(listEmail As List(Of Model.Destinatario))
        Try

            Dim SmtpServer As New SmtpClient
            Dim mail As New MailMessage
            SmtpServer.Credentials = New Net.NetworkCredential("contacto@aricamediamaratontpa.cl", "1234.abc")
            SmtpServer.Port = 25
            SmtpServer.EnableSsl = False
            SmtpServer.Host = "mail.aricamediamaratontpa.cl"
            For Each destinatario As Model.Destinatario In listEmail
                mail = New MailMessage()
                mail.From = New MailAddress("contacto@aricamediamaratontpa.cl")
                mail.To.Add(destinatario.Email)
                mail.Subject = "Pago Inscripción Zona VIP Media Maratón TPA Arica"
                mail.Body = BoddyMessage()
                mail.IsBodyHtml = True
                SmtpServer.Send(mail)
            Next
            MsgBox("mail send")
        Catch ex As Exception
            System.Console.WriteLine(ex.Message)
            System.Console.ReadKey()
        End Try

    End Sub

    Public Function BoddyMessage() As String
        Dim boddyM As String = "<table class='m_8381840519564656972wrapper' style='border-collapse:collapse;table-layout:fixed;min-width:320px;width:100%;background-color:#2baaff' cellpadding='0' cellspacing='0' role='presentation'>
<tbody>
<tr>
<td>
<div role='banner'>
<div class='m_8381840519564656972preheader' style='Margin:0 auto;max-width:560px;min-width:280px;width:280px;width:calc(28000% - 167440px)'>
<div class='m_8381840519564656972header' style='Margin:0 auto;max-width:600px;min-width:320px;width:320px;width:calc(28000% - 167400px)' id='m_8381840519564656972emb-email-header-container'>

<p></p>
<div class='m_8381840519564656972logo m_8381840519564656972emb-logo-margin-box' style='font-size:26px;line-height:32px;Margin-top:6px;Margin-bottom:20px;color:#c3ced9;font-family:Roboto,Tahoma,sans-serif;Margin-left:20px;Margin-right:20px' align='center'>
<div class='m_8381840519564656972logo-center' align='center' id='m_8381840519564656972emb-email-header'><img style='display:block;height:auto;width:100%;border:0;max-width:170px' alt='' width='170' src='https://ci4.googleusercontent.com/proxy/T2mvn9ucCR0JO3jUgzQZOpeAhv0nihP-17llBRaisZOzvf7YNVYEjUsiskea9g2sVqR_Ay0JaTjhCZPIWSmLPKL4RbKneVjZWjnLo7Rkocgz5B4lpvxfhJhOPWc=s0-d-e1-ft#https://i1.createsend1.com/ei/j/BB/5EC/8A4/154232/csfinal/image002.png' class='CToWUd a6T' tabindex='0'><div class='a6S' dir='ltr' style='opacity: 0.01; left: 312.5px; top: 493.391px;'><div id=':17y' class='T-I J-J5-Ji aQv T-I-ax7 L3 a5q' role='button' tabindex='0' aria-label='Descargar el archivo adjunto ' data-tooltip-class='a1V' data-tooltip='Descargar'><div class='aSK J-J5-Ji aYr'></div></div></div></div>
<p></p>
</div>
<p></p>
</div>
<p></p>
</div>
<div role='section'>
<div class='m_8381840519564656972layout m_8381840519564656972one-col m_8381840519564656972fixed-width' style='Margin:0 auto;max-width:600px;min-width:320px;width:320px;width:calc(28000% - 167400px);word-wrap:break-word;word-break:break-word'>
<div class='m_8381840519564656972layout__inner' style='border-collapse:collapse;display:table;width:100%;background-color:#ffffff'>

<p></p>
<div class='m_8381840519564656972column' style='text-align:left;color:#000;font-size:14px;line-height:21px;font-family:Avenir,sans-serif;max-width:600px;min-width:320px;width:320px;width:calc(28000% - 167400px)'>
<div style='Margin-left:20px;Margin-right:20px;Margin-top:24px'>
<div style='line-height:20px;font-size:1px'>&nbsp;</div>
<p></p>
</div>
<div style='Margin-left:20px;Margin-right:20px'>
<h1 style='Margin-top:0;Margin-bottom:0;font-style:normal;font-weight:normal;color:#000;font-size:34px;line-height:43px;text-align:center'>
<strong>Estas a un paso de ganar la carrera!</strong></h1>
<h4 style='Margin-top:20px;Margin-bottom:0;font-style:normal;font-weight:normal;color:#000;font-size:18px;line-height:26px;text-align:center'>
Estimado, ya estas pre-inscrito para la<br>
<strong>DÉCIMA PRIMERA MEDIA MARATÓN TPA</strong>, para finalizar este proceso haz click en el link que te redirigirá a webpay: https://www.webpay.cl/portalpagodirecto/pages/institucion.jsf?idEstablecimiento=32154667 , valor de la inscripción $ 3.500.</h4>
<h3 style='Margin-top:12px;Margin-bottom:0;font-style:normal;font-weight:normal;color:#000;font-size:18px;line-height:26px;text-align:center'>
Recuerda, el evento es el:</h3>
<h2 style='Margin-top:12px;Margin-bottom:16px;font-style:normal;font-weight:normal;color:#000;font-size:28px;line-height:36px;text-align:center'>
<strong>01 Octubre, 2017</strong></h2>
<p></p>
</div>
<div style='Margin-left:20px;Margin-right:20px'>
<div style='line-height:20px;font-size:1px'>&nbsp;</div>
<p></p>
</div>
<div style='Margin-left:20px;Margin-right:20px;Margin-bottom:24px'>
<div style='line-height:10px;font-size:1px'>&nbsp;</div>
<p></p>
</div>
<p></p>
</div>
<p></p>
</div>
<p></p>
</div>
<div class='m_8381840519564656972layout m_8381840519564656972one-col m_8381840519564656972fixed-width' style='Margin:0 auto;max-width:600px;min-width:320px;width:320px;width:calc(28000% - 167400px);word-wrap:break-word;word-break:break-word'>
<div class='m_8381840519564656972layout__inner' style='border-collapse:collapse;display:table;width:100%;background-color:#ffffff'>

<p></p>
<div class='m_8381840519564656972column' style='text-align:left;color:#000;font-size:14px;line-height:21px;font-family:Avenir,sans-serif;max-width:600px;min-width:320px;width:320px;width:calc(28000% - 167400px)'>
<div style='Margin-left:20px;Margin-right:20px;Margin-top:24px;Margin-bottom:24px'>
<p style='Margin-top:0;Margin-bottom:0'></p>
</div>
</div>
<p></p>
</div>
<p></p>
</div>
<div role='contentinfo'>
<div class='m_8381840519564656972layout m_8381840519564656972email-footer' style='Margin:0 auto;max-width:600px;min-width:320px;width:320px;width:calc(28000% - 167400px);word-wrap:break-word;word-break:break-word'>
<div class='m_8381840519564656972layout__inner' style='border-collapse:collapse;display:table;width:100%'>

<p></p>
<div class='m_8381840519564656972column m_8381840519564656972wide' style='text-align:left;font-size:12px;line-height:19px;color:#000;font-family:Avenir,sans-serif;Float:left;max-width:400px;min-width:320px;width:320px;width:calc(8000% - 47600px)'>
<div style='Margin-left:20px;Margin-right:20px;Margin-top:10px;Margin-bottom:10px'>
<table class='m_8381840519564656972email-footer__links m_8381840519564656972emb-web-links' style='border-collapse:collapse;table-layout:fixed' role='presentation'>
<tbody>
<tr role='navigation'>
<td class='m_8381840519564656972emb-web-links' style='padding:0;width:26px'><a style='text-decoration:underline;color:#000' href='http://notengo.createsend1.com/t/j-l-uuydukd-l-r/' target='_blank' data-saferedirecturl='https://www.google.com/url?hl=es&amp;q=http://notengo.createsend1.com/t/j-l-uuydukd-l-r/&amp;source=gmail&amp;ust=1505531925029000&amp;usg=AFQjCNH6PYpdo0Jq_YMThfl1ippo_z8IwA'><img style='border:0' width='26' height='26' src='https://ci6.googleusercontent.com/proxy/SEgyDJuT_hCvYKfWQxuJUD6q6cIHdFvrIwsn4t60Tr1Cj-t6BqT7DajnVqTG1MTj8dercHMOy_CWZvkoJQTtdG_0o_Xm5vSCFbAx90ugiywQK0nYuwKtQcedSF4tJoyVOlQGkiLoG_U=s0-d-e1-ft#https://i2.createsend1.com/static/eb/master/13-the-blueprint-3/images/facebook.png' class='CToWUd'></a></td>
<td class='m_8381840519564656972emb-web-links' style='padding:0 0 0 3px;width:26px'><a style='text-decoration:underline;color:#000' href='http://notengo.createsend1.com/t/j-l-uuydukd-l-y/' target='_blank' data-saferedirecturl='https://www.google.com/url?hl=es&amp;q=http://notengo.createsend1.com/t/j-l-uuydukd-l-y/&amp;source=gmail&amp;ust=1505531925029000&amp;usg=AFQjCNER6JAEz8xlnmcjST09hHoM-Itp5A'><img style='border:0' width='26' height='26' src='https://ci3.googleusercontent.com/proxy/VUusPqCi2E-LcsrC-eQFjNcKsMtYyyal4_IsIs95uW9J5uov6EtjeZ2B6gVr3xkh-A7whpfiTy5PSR5NuApV6BUyslXcWogw4OgSkhpL5KIbh6ZqBN5VTK-azaSMLVA4zksevxxgvXdj=s0-d-e1-ft#https://i5.createsend1.com/static/eb/master/13-the-blueprint-3/images/instagram.png' class='CToWUd'></a></td>
</tr>
</tbody>
</table>
<p></p>
</div>
<p></p>
</div>
<p></p>
<div class='m_8381840519564656972column m_8381840519564656972narrow' style='text-align:left;font-size:12px;line-height:19px;color:#000;font-family:Avenir,sans-serif;Float:left;max-width:320px;min-width:200px;width:320px;width:calc(72200px - 12000%)'>
<div style='Margin-left:20px;Margin-right:20px;Margin-top:10px;Margin-bottom:10px'>
</div>
<p></p>
</div>
<p></p>
</div>
<p></p>
</div>
<p></p>
</div>
<div style='line-height:40px;font-size:40px'>&nbsp;</div>
<p></p>
</div>
</div>
</td>
</tr>
</tbody>
</table>"
        Return boddyM
    End Function

End Class
