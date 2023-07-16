using Newtonsoft.Json.Linq;
using SOC.IoTBase.Infrastructure.Zigbee;
using SOC.IoTDomain.Entity;

namespace SOC.IoTBase.Interfaces;

public interface IDeviceWriter
{
    public JObject GeneratePayload(Device device);
    internal Device ReadDevice(DeviceDescription description, JObject payload);
}
