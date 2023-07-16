using SOC.IoTBase.Infrastructure.Zigbee;

namespace SOC.IoTBase.Infrastructure;

public interface IDeviceDescriptionManager
{
    internal void RegisterPayload(string deviceId, DeviceDescription payload);
    internal DeviceDescription GetPayload(string deviceId);
}
