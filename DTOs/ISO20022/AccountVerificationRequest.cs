using System;
using System.Xml.Serialization;

namespace XmlTest.DTOs.ISO20022;

[XmlRoot(ElementName = "FPEnvelope", Namespace = "urn:iso:std:iso:20022:tech:xsd:verification_request")]
public class AccountVerificationRequest
{
    [XmlElement(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.03")]
    public ApplicationHeader Header { get; set; }

    [XmlElement(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.023.001.03")]
    public IdVerificationRequestDocument Document { get; set; }
}

public class IdVerificationRequestDocument
{
    [XmlElement(ElementName = "IdVrfctnReq")]
    public IdVrfctnReq IdVrfctnReq { get; set; }
}

public class IdVrfctnReq
{
    [XmlElement(ElementName = "Assgnmt")]
    public Assgnmt Assgnmt { get; set; }

    [XmlElement(ElementName = "Vrfctn")]
    public Vrfctn Vrfctn { get; set; }
}


public class Vrfctn
{
    [XmlElement(ElementName = "Id")]
    public string Id { get; set; }

    [XmlElement(ElementName = "PtyAndAcctId")]
    public PtyAndAcctId PtyAndAcctId { get; set; }
}

public class PtyAndAcctId
{
    [XmlElement(ElementName = "Acct")]
    public Acct Acct { get; set; }
}

public class Acct
{
    [XmlElement(ElementName = "Id")]
    public Id Id { get; set; }
}

public class Id
{
    [XmlElement(ElementName = "Othr")]
    public AcctIdOthr Othr { get; set; }
}

public class AcctIdOthr
{
    [XmlElement(ElementName = "Id")]
    public string Id { get; set; }
    [XmlElement(ElementName = "SchmeNm")]
    public SchmeNm SchmeNm { get; set; }
}

public class SchmeNm
{
    [XmlElement(ElementName = "Prtry")]
    public string Prtry { get; set; }
}
