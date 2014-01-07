using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;


namespace Admin.Class
{
    public  class MailWorks 
    {
        public string SmtpAddress;
        private string _SmtpAddress
        {
            get { return SmtpAddress; }
            set { SmtpAddress = value; }
        }


        public string cc;
        private string _cc
        {
            get { return cc; }
            set { cc = value; }
        }

        public  string Domain;
        private string _Domain
        {
            get { return Domain; }
            set { Domain = value; }
        }

        public  string Username;
        private string _Username
        {
            get { return Username; }
            set { Username = value; }
        }

        public  string Password;
        private string _Password
        {
            get { return Password; }
            set { Password = value; }
        }

        public  int Port;
        private int _Port
        {
            get { return Port; }
            set { Port = value; }
        }

        public  bool IsHTML;
        private bool _IsHTML
        {
            get { return IsHTML; }
            set { IsHTML = value; }
        }

        public bool EnableSSL;
        private bool _EnableSSL
        {
            get { return EnableSSL; }
            set { EnableSSL = value; }
        }

        public  string SenderMailAdress;
        private string _SenderMailAdress
        {
            get { return SenderMailAdress; }
            set { SenderMailAdress = value; }
        }

        public string SenderName;
        private string _SenderName
        {
            get { return SenderName; }
            set { SenderName = value; }
        }

        public  string RecipientMailAdress;
        private string _RecipientMailAdress
        {
            get { return RecipientMailAdress; }
            set { RecipientMailAdress = value; }
        }

        public  string RecipientName;
        private string _RecipientName
        {
            get { return RecipientName; }
            set { RecipientName = value; }
        }

        public  string Header;
        private string _Header
        {
            get { return Header; }
            set { Header = value; }
        }

        public  string Body;
        private string _Body
        {
            get { return Body; }
            set { Body = value; }
        }

        public string[] mailSend()
        {
            string[] datas = new string[2];

            string errorMessage = string.Empty;
            try
            {
                SmtpClient sClient = new SmtpClient(_SmtpAddress, Port);
                NetworkCredential netCred = new NetworkCredential();

                netCred.UserName = _Username;
                netCred.Password = _Password;

                sClient.Credentials = netCred;
                sClient.EnableSsl = _EnableSSL;

                MailAddress mailAdressSender = new MailAddress(_SenderMailAdress, _SenderName);
                MailAddress mailAdressRecipient = new MailAddress(_RecipientMailAdress, _RecipientName);
                MailMessage message = new MailMessage(mailAdressSender, mailAdressRecipient);

                if (_cc != null)
                {
                    _cc = _cc.Substring(0, _cc.Length - 1).Replace("'", " ");
                    message.Bcc.Add(_cc);
                }

                message.Subject = _Header;
                message.Body = _Body;
                message.IsBodyHtml = _IsHTML;
                sClient.Send(message);
                datas[0] = "OK";
                return datas;
            }
            catch ( Exception ex) {
                datas[0] = "NO";
                errorMessage = ex.Message.ToString();
                datas[1] = errorMessage;
            }
            return datas;
        }
    }
}