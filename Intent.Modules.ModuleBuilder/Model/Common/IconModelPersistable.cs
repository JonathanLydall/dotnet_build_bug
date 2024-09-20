using System;
using System.Xml.Serialization;

namespace Intent.Modules.ModuleBuilder.Model.Common
{
    public class IconModelPersistable
    {
        private IconType? _type;
        private string _source;

        // Migrate away from xml element to attribute
        [XmlElement("type")]
        public string TypeElement
        {
            get => null;
            set => _type = Enum.TryParse<IconType>(value, out var t) ? t : _type;
        }

        [XmlAttribute("type")]
        public IconType Type
        {
            get => _type.Value;
            set => _type = value;
        }

        // Migrate away from xml element to attribute
        [XmlElement("source")]
        public string SourceElement
        {
            get => null;
            set => _source = value ?? _source;
        }

        [XmlAttribute("source")]
        public string Source
        {
            get => _source;
            set => _source = value;
        }
    }
}