using Intent.Metadata.Models;
using Intent.Modules.ModuleBuilder.Model.Common;
using IconType = Intent.Modules.ModuleBuilder.Model.Common.IconType;

namespace Intent.ModuleBuilder.Api
{
    public static class ModelExtensions
    {
        public static IconModelPersistable ToPersistable(this IIconModel icon)
        {
            return icon != null ? new IconModelPersistable { Type = (IconType) icon.Type, Source = icon.Source } : null;
        }
    }
}