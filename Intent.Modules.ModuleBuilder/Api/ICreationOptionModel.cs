using Intent.Metadata.Models;
using Intent.Modules.ModuleBuilder.Model.Settings;

namespace Intent.ModuleBuilder.Api
{
    public interface ICreationOptionModel
    {
        IIconModel Icon { get; }
        bool AllowMultiple();
        ElementCreationOption ToPersistable();
    }
}