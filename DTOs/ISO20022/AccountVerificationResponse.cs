using System.Xml.Serialization;

namespace XmlTest.DTOs.ISO20022;

[XmlRoot(ElementName = "FPEnvelope", Namespace = "urn:iso:std:iso:20022:tech:xsd:verification_response")]
public class AccountVerificationResponse
{
    [XmlElement(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.03")]
    public ApplicationHeader Header { get; set; }

    [XmlElement(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.03")]
    public IdVerificationReportDocument Document { get; set; }
}

public class IdVerificationReportDocument
{
    [XmlElement(ElementName = "IdVrfctnRpt")]
    public IdVrfctnRpt IdVrfctnRpt { get; set; }
}

public class IdVrfctnRpt
{
    [XmlElement(ElementName = "Assgnmt")]
    public Assgnmt Assignment { get; set; }

    [XmlElement(ElementName = "OrgnlAssgnmt")]
    public OriginalAssignment OrgnlAssgnmt { get; set; }

    [XmlElement(ElementName = "Rpt")]
    public Report Rpt { get; set; }
}

public class OriginalAssignment
{
    [XmlElement(ElementName = "MsgId")]
    public string MsgId { get; set; }

    [XmlElement(ElementName = "CreDtTm")]
    public DateTime CreDtTm { get; set; }
}

public class Report
{
    [XmlElement(ElementName = "OrgnlId")]
    public string OrgnlId { get; set; }

    [XmlElement(ElementName = "Vrfctn")]
    public bool Vrfctn { get; set; }

    [XmlElement(ElementName = "Rsn")]
    public Reason Rsn { get; set; }

    [XmlElement(ElementName = "OrgnlPtyAndAcctId")]
    public OriginalPartyAndAccount OrgnlPtyAndAcctId { get; set; }

    [XmlElement(ElementName = "UpdtdPtyAndAcctId")]
    public UpdatedPartyAndAccount UpdtdPtyAndAcctId { get; set; }
}

public class Reason
{
    [XmlElement(ElementName = "Prtry")]
    public string Prtry { get; set; }
}

public class OriginalPartyAndAccount
{
    [XmlElement(ElementName = "Acct")]
    public Account Acct { get; set; }
}

public class UpdatedPartyAndAccount
{
    [XmlElement(ElementName = "Pty")]
    public Party Pty { get; set; }

    [XmlElement(ElementName = "Acct")]
    public Account Acct { get; set; }
}

public class Party
{
    [XmlElement(ElementName = "Nm")]
    public string Nm { get; set; }
}

public class Account
{
    [XmlElement(ElementName = "Id")]
    public string Id { get; set; }
}
