﻿using SuperFact.Helper.Comun.Constantes;
using SuperFact.Model.Contract.Intercambio;
using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SuperFact.Ubl.Signed
{
    public class Serializador : ISerializador
    {

        /// <summary>
        /// Genera el XML basado en una clase con el atributo Serializable
        /// </summary>
        /// <typeparam name="T">Clase a serializar</typeparam>
        /// <param name="objectToSerialize">Instancia de la Clase</param>
        /// <returns>Devuelve una cadena Base64 del archivo XML</returns>
        async Task<string> ISerializador.GenerarXml<T>(T objectToSerialize)
        {
            var task = Task.Factory.StartNew(() =>
            {
                var serializer = new XmlSerializer(objectToSerialize.GetType());
                string resultado;

                using (var memStr = new MemoryStream())
                {
                    using (var stream = new StreamWriter(memStr))
                    {
                        serializer.Serialize(stream, objectToSerialize);
                    }
                    resultado = Convert.ToBase64String(memStr.ToArray());
                }
                return resultado;
            });
            return await task;
        }

        /// <summary>
        /// Genera el ZIP del XML basandose en la trama del XML.
        /// </summary>
        /// <param name="tramaXml">Cadena Base64 con el contenido del XML</param>
        /// <param name="nombreArchivo">Nombre del archivo ZIP</param>
        /// <returns>Devuelve Cadena Base64 del archizo ZIP</returns>
        async Task<string> ISerializador.GenerarZip(string tramaXml, string nombreArchivo)
        {
            var task = Task.Factory.StartNew(() =>
            {
                var memOrigen = new MemoryStream(Convert.FromBase64String(tramaXml));
                var memDestino = new MemoryStream();
                string resultado;
                //$"{nombreArchivo}.zip"
                using (var fileZip = new ZipArchive(memDestino, ZipArchiveMode.Create, true))
                {
                    var fileInArchive = fileZip.CreateEntry($"{nombreArchivo}.xml", CompressionLevel.Optimal);
                    using (var entryStream = fileInArchive.Open())
                    {
                        memOrigen.CopyToAsync(entryStream);
                    }
                    //fileZip.AddEntry($"{nombreArchivo}.xml", memOrigen);
                    //fileZip.Save(memDestino);
                    resultado = Convert.ToBase64String(memDestino.ToArray());
                }
                // Liberamos memoria RAM.
                memOrigen.Close();
                memDestino.Close();
                return resultado;
            });
            return await task;
        }

        /// <summary>
        /// Lee la Constancia de Recepción SUNAT y devuelve el contenido
        /// </summary>
        /// <param name="constanciaRecepcion">Trama ZIP del CDR</param>
        /// <returns>Devuelve una clase <see cref="EnviarDocumentoResponse"/></returns>
        public async Task<EnviarDocumentoResponse> GenerarDocumentoRespuesta(string constanciaRecepcion)
        {
            var response = new EnviarDocumentoResponse();
            var returnByte = Convert.FromBase64String(constanciaRecepcion);
            using (var memRespuesta = new MemoryStream(returnByte))
            {
                using (var zipFile = new ZipArchive(memRespuesta))
                {
                    foreach (var entry in zipFile.Entries)
                    {
                        if (!entry.FullName.EndsWith(".xml")) continue;
                        using (var stream = entry.Open())
                        {
                            using (var ms = new MemoryStream())
                            {
                                await stream.CopyToAsync(ms);
                                ms.Position = 0;
                                var responseReader = new StreamReader(ms);
                                var responseString = await responseReader.ReadToEndAsync();
                                try
                                {
                                    var xmlDoc = new XmlDocument();
                                    xmlDoc.LoadXml(responseString);
                                    var xmlnsManager = new XmlNamespaceManager(xmlDoc.NameTable);
                                    xmlnsManager.AddNamespace("ar", EspacioNombres.ar);
                                    xmlnsManager.AddNamespace("cac", EspacioNombres.cac);
                                    xmlnsManager.AddNamespace("cbc", EspacioNombres.cbc);
                                    response.CodigoRespuesta = xmlDoc.SelectSingleNode(EspacioNombres.nodoResponseCode, xmlnsManager)?.InnerText;
                                    response.MensajeRespuesta = xmlDoc.SelectSingleNode(EspacioNombres.nodoDescription, xmlnsManager)?.InnerText;
                                    response.TramaZipCdr = constanciaRecepcion;
                                    response.NombreArchivo = entry.FullName;
                                    response.Exito = true;
                                }
                                catch (Exception ex)
                                {
                                    response.MensajeError = ex.Message;
                                    response.Pila = ex.StackTrace;
                                    response.Exito = false;
                                }
                            }

                        }
                    }
                }
            }
            return response;
        }
    }
}
