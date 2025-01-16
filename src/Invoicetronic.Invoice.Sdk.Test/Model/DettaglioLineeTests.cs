/*
 * Italian eInvoice API
 *
 * The Italian eInvoice API is a RESTful API that allows you to send and receive invoices through the Italian [Servizio di Interscambio (SDI)][1], or Interchange Service. The API is designed by Invoicetronic to be simple and easy to use, abstracting away SDI complexity while providing complete control over the invoice send/receive process. The API also provides advanced features as encryption at rest, invoice validation, multiple upload formats, webhooks, event logging, client SDKs for commonly used languages, and CLI tools.  For more information, see  [Invoicetronic website][2]  [1]: https://www.fatturapa.gov.it/it/sistemainterscambio/cose-il-sdi/ [2]: https://invoicetronic.com/
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@invoicetronic.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Invoicetronic.Invoice.Sdk.Model;
using Invoicetronic.Invoice.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Invoicetronic.Invoice.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing DettaglioLinee
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DettaglioLineeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DettaglioLinee
        //private DettaglioLinee instance;

        public DettaglioLineeTests()
        {
            // TODO uncomment below to create an instance of DettaglioLinee
            //instance = new DettaglioLinee();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DettaglioLinee
        /// </summary>
        [Fact]
        public void DettaglioLineeInstanceTest()
        {
            // TODO uncomment below to test "IsType" DettaglioLinee
            //Assert.IsType<DettaglioLinee>(instance);
        }

        /// <summary>
        /// Test the property 'NumeroLinea'
        /// </summary>
        [Fact]
        public void NumeroLineaTest()
        {
            // TODO unit test for the property 'NumeroLinea'
        }

        /// <summary>
        /// Test the property 'TipoCessionePrestazione'
        /// </summary>
        [Fact]
        public void TipoCessionePrestazioneTest()
        {
            // TODO unit test for the property 'TipoCessionePrestazione'
        }

        /// <summary>
        /// Test the property 'CodiceArticolo'
        /// </summary>
        [Fact]
        public void CodiceArticoloTest()
        {
            // TODO unit test for the property 'CodiceArticolo'
        }

        /// <summary>
        /// Test the property 'Descrizione'
        /// </summary>
        [Fact]
        public void DescrizioneTest()
        {
            // TODO unit test for the property 'Descrizione'
        }

        /// <summary>
        /// Test the property 'Quantita'
        /// </summary>
        [Fact]
        public void QuantitaTest()
        {
            // TODO unit test for the property 'Quantita'
        }

        /// <summary>
        /// Test the property 'UnitaMisura'
        /// </summary>
        [Fact]
        public void UnitaMisuraTest()
        {
            // TODO unit test for the property 'UnitaMisura'
        }

        /// <summary>
        /// Test the property 'DataInizioPeriodo'
        /// </summary>
        [Fact]
        public void DataInizioPeriodoTest()
        {
            // TODO unit test for the property 'DataInizioPeriodo'
        }

        /// <summary>
        /// Test the property 'DataFinePeriodo'
        /// </summary>
        [Fact]
        public void DataFinePeriodoTest()
        {
            // TODO unit test for the property 'DataFinePeriodo'
        }

        /// <summary>
        /// Test the property 'PrezzoUnitario'
        /// </summary>
        [Fact]
        public void PrezzoUnitarioTest()
        {
            // TODO unit test for the property 'PrezzoUnitario'
        }

        /// <summary>
        /// Test the property 'ScontoMaggiorazione'
        /// </summary>
        [Fact]
        public void ScontoMaggiorazioneTest()
        {
            // TODO unit test for the property 'ScontoMaggiorazione'
        }

        /// <summary>
        /// Test the property 'PrezzoTotale'
        /// </summary>
        [Fact]
        public void PrezzoTotaleTest()
        {
            // TODO unit test for the property 'PrezzoTotale'
        }

        /// <summary>
        /// Test the property 'AliquotaIva'
        /// </summary>
        [Fact]
        public void AliquotaIvaTest()
        {
            // TODO unit test for the property 'AliquotaIva'
        }

        /// <summary>
        /// Test the property 'Ritenuta'
        /// </summary>
        [Fact]
        public void RitenutaTest()
        {
            // TODO unit test for the property 'Ritenuta'
        }

        /// <summary>
        /// Test the property 'Natura'
        /// </summary>
        [Fact]
        public void NaturaTest()
        {
            // TODO unit test for the property 'Natura'
        }

        /// <summary>
        /// Test the property 'RiferimentoAmministrazione'
        /// </summary>
        [Fact]
        public void RiferimentoAmministrazioneTest()
        {
            // TODO unit test for the property 'RiferimentoAmministrazione'
        }

        /// <summary>
        /// Test the property 'AltriDatiGestionali'
        /// </summary>
        [Fact]
        public void AltriDatiGestionaliTest()
        {
            // TODO unit test for the property 'AltriDatiGestionali'
        }
    }
}
