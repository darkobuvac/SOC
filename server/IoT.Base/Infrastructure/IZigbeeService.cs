namespace SOC.IoTBase.Infrastructure;

internal interface IZigbeeService
{
    Task DiscoverDevicesAsync();
}
