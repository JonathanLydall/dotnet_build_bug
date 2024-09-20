using System.Xml.Serialization;

namespace Intent.Modules.ModuleBuilder.Model.Settings;

public enum AssociationVisualLineType
{
    [XmlEnum(Name = "Elbow-Connector")]
    ElbowConnector = 0,
    [XmlEnum(Name = "Curved")]
    Curved = 1,
}