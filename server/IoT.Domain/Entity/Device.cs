using SOC.IoTDomain.Enum;
using System.ComponentModel.DataAnnotations;

namespace SOC.IoTDomain.Entity;

public class Device
{
    [Required]
    public string Id { get; set; }
    public ICollection<DeviceCapability> Capabilities { get; set; } = new List<DeviceCapability>();

    public DeviceState? State { get; set; }
    public DeviceLight? Light { get; set; }
    public DeviceColorXy? ColorXy { get; set; }
    public DeviceTemperature? Temperature { get; set; }
    public DeviceHumidity? Humidity { get; set; }
    public DeviceEnergy? Energy { get; set; }
    public DeviceContact? Contact { get; set; }
}
