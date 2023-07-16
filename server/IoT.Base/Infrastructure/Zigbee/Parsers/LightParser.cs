using Newtonsoft.Json.Linq;
using SOC.IoTBase.Infrastructure.Zigbee;
using SOC.IoTDomain.Entity;

namespace SOC.IoTBase.Infrastructure.Zigbee.Parsers;

internal static class LightParser
{
    public static DeviceLight? ParseLight(this DeviceDescription description, JObject payload)
    {
        var brightness = payload["brightness"];

        if (
            payload is null
            || brightness is null
            || !description.NumericValues.ContainsKey("brightness")
        )
            return null;

        var brightnessValue = description.NumericValues["brightness"];
        brightnessValue.SetValue(brightness.ToObject<decimal>()!);

        return new DeviceLight { Brightness = brightnessValue.PercentageOrValue };
    }
}
