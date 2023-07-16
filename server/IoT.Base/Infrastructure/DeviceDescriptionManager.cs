using SOC.IoTBase.Infrastructure.Zigbee;
using System.Collections.Concurrent;

namespace SOC.IoTBase.Infrastructure;

internal class DeviceDescriptionManager : IDeviceDescriptionManager
{
    private readonly ConcurrentDictionary<string, DeviceDescription> _deviceDescriptions = new();

    public DeviceDescription GetPayload(string deviceId) => _deviceDescriptions[deviceId];

    public void RegisterPayload(string deviceId, DeviceDescription payload)
    {
        if (!_deviceDescriptions.TryAdd(deviceId, payload))
            throw new InvalidOperationException($"Unable to register payload for {deviceId}");
    }
}
