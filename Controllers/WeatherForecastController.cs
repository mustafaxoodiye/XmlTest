using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using XmlTest.DTOs.ISO20022;

namespace XmlTest.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpPost("Deserialize/AccountVerificationRequest")]
    [Consumes("application/xml")]
    public async Task<IActionResult> Deserialize()
    {
        using StreamReader rawXmlReader = new StreamReader(Request.Body);
        string rawXml = await rawXmlReader.ReadToEndAsync();

        var serializer = new XmlSerializer(typeof(AccountVerificationRequest));

        using var reader = new StringReader(rawXml);
        var x = (AccountVerificationRequest)serializer.Deserialize(reader);

        return Ok(x);
    }

    [HttpPost("Serialize/AccountVerificationRequest")]
    public async Task<IActionResult> Serialize(AccountVerificationRequest envelope)
    {
        var serializer = new XmlSerializer(typeof(AccountVerificationRequest));

        using var stringWriter = new StringWriter();
        var xmlNamespaces = new XmlSerializerNamespaces();
        xmlNamespaces.Add("document", "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.03");
        xmlNamespaces.Add("header", "urn:iso:std:iso:20022:tech:xsd:head.001.001.03");

        serializer.Serialize(stringWriter, envelope, xmlNamespaces);
        var x = stringWriter.ToString();


        return Ok(x);
    }

    [HttpPost("Deserialize/AccountVerificationResponse")]
    [Consumes("application/xml")]
    public async Task<IActionResult> DeserializeAccountVerificationResponse()
    {
        try
        {
            using StreamReader rawXmlReader = new StreamReader(Request.Body);
            string rawXml = await rawXmlReader.ReadToEndAsync();

            var serializer = new XmlSerializer(typeof(AccountVerificationResponse));

            using var reader = new StringReader(rawXml);
            var x = (AccountVerificationResponse)serializer.Deserialize(reader);

            return Ok(x);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("Serialize/AccountVerificationResponse")]
    public async Task<IActionResult> SerializeAccountVerificationResponse(AccountVerificationResponse envelope)
    {
        try
        {
            var serializer = new XmlSerializer(typeof(AccountVerificationResponse));

            using var stringWriter = new StringWriter();
            var xmlNamespaces = new XmlSerializerNamespaces();
            xmlNamespaces.Add("document", "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.03");
            xmlNamespaces.Add("header", "urn:iso:std:iso:20022:tech:xsd:head.001.001.03");

            serializer.Serialize(stringWriter, envelope, xmlNamespaces);
            var x = stringWriter.ToString();


            return Ok(x);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


}

