using SOC.IoT.Models;
using SOC.IoTDomain.Entity;
using SOC.IoTDomain.Enum;
using Swashbuckle.AspNetCore.Filters;

namespace SOC.IoT.Controllers.Examples;

public class DeviceExample : IExamplesProvider<DeviceDTO>
{
    public DeviceDTO GetExamples() =>
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
        );
}
