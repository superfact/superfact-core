using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace SuperFact.Helper.Sunat.Soa
{
    public class PasswordDigestMessageInspector : IClientMessageInspector
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public PasswordDigestMessageInspector(string username, string password)
        {
            Username = username;
            Password = password;
        }

        #region IClientMessageInspector Members

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            return;
        }

        public object BeforeSendRequest(ref Message request, System.ServiceModel.IClientChannel channel)
        {
            //var token = new UsernameToken(Username, Password, PasswordOption.SendPlainText);

            //var securityToken = token.GetXml(new XmlDocument());

            //// Modificamos el XML Generado.
            //var nodo = securityToken.GetElementsByTagName("wsse:Nonce").Item(0);
            //nodo?.RemoveAll();

            //var securityHeader = MessageHeader.CreateHeader("Security",
            //    EspacioNombres.wssecurity,
            //    securityToken, false);
            //request.Headers.Add(securityHeader);

            return Convert.DBNull;
        }

        #endregion
    }
}
