//private MailMessage mail = new MailMessage ()

//void sendEmails(){


//	mail.From = new MailAddress("datasetanalysis@gmail.com\t");
//	mail.To.Add("alexandre.matov@gmail.com");

//	SmtpClient smtpServer = new SmtpClient("stmp.google.com");
//	smtpServer.Port = 587;//993;//GIVE CORRECT PORT HERE
//	mail.Subject = "test unity email";
//	mail.Body = "testing another method to send an email";
//	smtpServer.Credentials = new System.Net.NetworkCredential("stmp.google.com", "Smuchi12345Duhai12345") as ICredentialsByHost;
//	smtpServer.EnableSsl = true;
//	ServicePointManager.ServerCertificateValidationCallback =
//		delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
//	{ return true; };
//	smtpServer.Send(mail);
//	smtpServer.SendAsync(mail)
//	Debug.Log("success");
