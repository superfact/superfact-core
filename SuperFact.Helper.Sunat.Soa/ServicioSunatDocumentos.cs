using SuperFact.Helper.Comun.Constantes;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace SuperFact.Helper.Sunat.Soa
{
    public class ServicioSunatDocumentos : IServicioSunatDocumentos
    {
        private Documentos.billServiceClient _proxyDocumentos;

        Binding CreateBinding()
        {
            var binding = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential);
            var elements = binding.CreateBindingElements();
            elements.Find<SecurityBindingElement>().IncludeTimestamp = false;
            return new CustomBinding(elements);
        }

        void IServicioSunat.Inicializar(ParametrosConexion parametros)
        {
            System.Net.ServicePointManager.UseNagleAlgorithm = true;
            System.Net.ServicePointManager.Expect100Continue = false;
            System.Net.ServicePointManager.CheckCertificateRevocationList = true;

            _proxyDocumentos = new Documentos.billServiceClient(CreateBinding(), new EndpointAddress(parametros.EndPointUrl))
            {
                ClientCredentials =
                {
                    UserName =
                    {
                        UserName = parametros.Ruc + parametros.UserName,
                        Password = parametros.Password
                    }
                }
            };
        }

        RespuestaSincrono IServicioSunatDocumentos.EnviarDocumento(DocumentoSunat request)
        {
            var dataOrigen = Convert.FromBase64String(request.TramaXml);
            var response = new RespuestaSincrono();

            try
            {
                _proxyDocumentos.OpenAsync();
                var resultado = _proxyDocumentos.sendBillAsync(request.NombreArchivo, dataOrigen, "");

                _proxyDocumentos.CloseAsync();

                response.ConstanciaDeRecepcion = Convert.ToBase64String(resultado.Result.applicationResponse);
                response.Exito = true;
            }
            catch (FaultException ex)
            {
                response.MensajeError = string.Concat(ex.Code.Name, ex.Message);
            }
            catch (Exception ex)
            {
                var msg = string.Concat(ex.InnerException?.Message, ex.Message);
                if (msg.Contains(Formatos.FaultCode))
                {
                    var posicion = msg.IndexOf(Formatos.FaultCode, StringComparison.Ordinal);
                    var codigoError = msg.Substring(posicion + Formatos.FaultCode.Length, 4);
                    msg = $"El Código de Error es {codigoError}";
                }
                response.MensajeError = msg;
            }

            return response;
        }

        RespuestaAsincrono IServicioSunatDocumentos.EnviarResumen(DocumentoSunat request)
        {
            var dataOrigen = Convert.FromBase64String(request.TramaXml);
            var response = new RespuestaAsincrono();

            try
            {
                _proxyDocumentos.OpenAsync();
                var resultado = _proxyDocumentos.sendSummaryAsync(request.NombreArchivo, dataOrigen, "");

                _proxyDocumentos.CloseAsync();

                response.NumeroTicket = resultado.Result.ticket;
                response.Exito = true;
            }
            catch (FaultException ex)
            {
                response.MensajeError = string.Concat(ex.Code.Name, ex.Message);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? string.Concat(ex.InnerException.Message, ex.Message) : ex.Message;
                if (msg.Contains(Formatos.FaultCode))
                {
                    var posicion = msg.IndexOf(Formatos.FaultCode, StringComparison.Ordinal);
                    var codigoError = msg.Substring(posicion + Formatos.FaultCode.Length, 4);
                    msg = $"El Código de Error es {codigoError}";
                }
                response.MensajeError = msg;
            }

            return response;
        }

        RespuestaSincrono IServicioSunatDocumentos.ConsultarTicket(string numeroTicket)
        {
            var response = new RespuestaSincrono();

            try
            {
                _proxyDocumentos.OpenAsync();
                var resultado = _proxyDocumentos.getStatusAsync(numeroTicket);

                _proxyDocumentos.CloseAsync();

                var estado = (resultado.Result.status.statusCode != "98");

                response.ConstanciaDeRecepcion = estado
                    ? Convert.ToBase64String(resultado.Result.status.content) : "Aun en proceso";
                response.Exito = true;
            }
            catch (FaultException ex)
            {
                response.MensajeError = string.Concat(ex.Code.Name, ex.Message);
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? string.Concat(ex.InnerException.Message, ex.Message) : ex.Message;
                if (msg.Contains(Formatos.FaultCode))
                {
                    var posicion = msg.IndexOf(Formatos.FaultCode, StringComparison.Ordinal);
                    var codigoError = msg.Substring(posicion + Formatos.FaultCode.Length, 4);
                    msg = $"El Código de Error es {codigoError}";
                }
                response.MensajeError = msg;
            }

            return response;
        }


    }
}
