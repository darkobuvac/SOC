using Newtonsoft.Json;
using SOC.IoTBase.Infrastructure.Zigbee;

namespace SOC.IoTBase.Infrastructure.Zigbee.Properties;

internal class CompositeProperty
{
    [JsonProperty("features")]
    public Expose[] Features { get; init; }
}
