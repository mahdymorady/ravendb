using System.ComponentModel;
using Raven.Server.Config.Attributes;
using Sparrow;
using Sparrow.LowMemory;

namespace Raven.Server.Config.Categories
{
    public class MemoryConfiguration : ConfigurationCategory
    {
        public MemoryConfiguration()
        {
            var memoryInfo = MemoryInformation.GetMemoryInfo();

            LowMemoryLimit = Size.Min(
                new Size(2, SizeUnit.Gigabytes), 
                memoryInfo.TotalPhysicalMemory / 10);
        }

        [Description("The minimum amount of available memory RavenDB will attempt to achieve (free memory lower than this value will trigger low memory behavior)")]
        [DefaultValue(DefaultValueSetInConstructor)]
        [SizeUnit(SizeUnit.Megabytes)]
        [ConfigurationEntry("Memory.LowMemoryLimitInMb", ConfigurationEntryScope.ServerWideOnly)]
        public Size LowMemoryLimit { get; set; }
    }
}
