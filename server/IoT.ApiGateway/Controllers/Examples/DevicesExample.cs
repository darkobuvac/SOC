using SOC.IoT.Models;
using SOC.IoTDomain.Entity;
using SOC.IoTDomain.Enum;
using Swashbuckle.AspNetCore.Filters;

namespace SOC.IoT.Controllers.Examples;

internal class DevicesExample : IExamplesProvider<IEnumerable<DeviceDTO>>
{
    public IEnumerable<DeviceDTO> GetExamples() =>
        new[]
        {
            new DeviceDTO(
                new Device
                {
                    Id = "0x0123456789abcdef",
                    Capabilities = new[]
                    {
                        DeviceCapability.Temperature,
                        DeviceCapability.Humidity,
                        DeviceCapability.Battery
                    }
                }
            ),
            new DeviceDTO(
                new Device
                {
                    Id = "0xfedcba9876543210",
                    Capabilities = new[]
                    {
                        DeviceCapability.State,
                        DeviceCapability.Light,
                        DeviceCapability.ColorXy
                    },
                    State = new DeviceState { State = true }
                }
            )
        };
}
