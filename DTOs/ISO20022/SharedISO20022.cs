using System.Xml.Serialization;

namespace XmlTest.DTOs.ISO20022;

public class ApplicationHeader
{
    [XmlElement(ElementName = "Fr")]
    public Fr From { get; set; }

    [XmlElement(ElementName = "To")]
    public To To { get; set; }

    [XmlElement(ElementName = "BizMsgIdr")]
    public string BusinessMessageId { get; set; }

    [XmlElement(ElementName = "MsgDefIdr")]
    public string MessageDefinitionId { get; set; }

    [XmlElement(ElementName = "CreDt")]
    public DateTime CreationDateTime { get; set; }
    [XmlElement(ElementName = "Rltd")]
    public RelatedHeader? RelatedHeader { get; set; }
}

public class RelatedHeader
{
    [XmlElement(ElementName = "Fr")]
    public Fr From { get; set; }

    [XmlElement(ElementName = "To")]
    public To To { get; set; }

    [XmlElement(ElementName = "BizMsgIdr")]
    public string BusinessMessageId { get; set; }

    [XmlElement(ElementName = "MsgDefIdr")]
    public string MessageDefinitionId { get; set; }

    [XmlElement(ElementName = "CreDt")]
    public DateTime CreationDateTime { get; set; }
}

public class Fr
{
    [XmlElement(ElementName = "FIId")]
    public FIId FIId { get; set; }
}

public class To
{
    [XmlElement(ElementName = "FIId")]
    public FIId FIId { get; set; }
}

public class FIId
{
    [XmlElement(ElementName = "FinInstnId")]
    public FinInstnId FinInstnId { get; set; }
}

public class FinInstnId
{
    [XmlElement(ElementName = "Othr")]
    public FinInstnIdOthr Othr { get; set; }
}

public class FinInstnIdOthr
{
    [XmlElement(ElementName = "Id")]
    public string Id { get; set; }
}


public class Assgnmt
{
    [XmlElement(ElementName = "MsgId")]
    public string MsgId { get; set; }

    [XmlElement(ElementName = "CreDtTm")]
    public DateTime CreDtTm { get; set; }

    [XmlElement(ElementName = "Assgnr")]
    public Assgnr Assgnr { get; set; }

    [XmlElement(ElementName = "Assgne")]
    public Assgne Assgne { get; set; }
}

public class Assgnr
{
    [XmlElement(ElementName = "Agt")]
    public Agt Agt { get; set; }
}

public class Assgne
{
    [XmlElement(ElementName = "Agt")]
    public Agt Agt { get; set; }
}

public class Agt
{
    [XmlElement(ElementName = "FinInstnId")]
    public FinInstnId FinInstnId { get; set; }
}
