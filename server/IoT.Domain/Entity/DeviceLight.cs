using System.ComponentModel.DataAnnotations;

namespace SOC.IoTDomain.Entity;

public class DeviceLight
{
    [Range(0.0, 1.0)]
    public decimal? Brightness { get; set; }
}
