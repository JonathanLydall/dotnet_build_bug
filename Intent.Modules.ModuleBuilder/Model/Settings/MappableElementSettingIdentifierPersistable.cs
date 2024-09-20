using System.Xml.Serialization;

namespace Intent.Modules.ModuleBuilder.Model.Settings;

public class MappableElementSettingIdentifierPersistable
{
    [XmlAttribute("id")]
    public string Id { get; set; }

    [XmlAttribute("name")]
    public string Name { get; set; }
}