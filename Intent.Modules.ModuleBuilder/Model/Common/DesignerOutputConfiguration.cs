using System.Xml.Serialization;

namespace Intent.Modules.ModuleBuilder.Model.Common
{
    public class DesignerOutputConfiguration
    {
        [XmlElement("packageTypeId")]
        public string PackageTypeId { get; set; }

        [XmlElement("folderTypeId")]
        public string FolderTypeId { get; set; }

        [XmlElement("roleTypeId")]
        public string RoleTypeId { get; set; }

        [XmlElement("templateOutputTypeId")]
        public string TemplateOutputTypeId { get; set; }
    }
}