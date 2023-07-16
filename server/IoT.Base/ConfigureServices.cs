using Microsoft.Extensions.DependencyInjection;
using SOC.IoTBase.Infrastructure;
using SOC.IoTBase.Interfaces;
using SOC.IoTBase.Services;
using SOC.IoTDomain.Entity;

namespace SOC.IoTBase;

public static class ConfigureServices
{
    public static IServiceCollection AddIoTServices(this IServiceCollection services)
    {
        services.AddSingleton<IMqttService, MqttService>();
        services.AddSingleton<IZigbeeService, ZigbeeService>();
        services.AddSingleton<IDeviceDescriptionManager, DeviceDescriptionManager>();
        services.AddSingleton<IDeviceManager, DeviceManager>();
        services.AddSingleton<IEventQueueService<Device>, EventQueueService<Device>>();

        services.AddTransient<IStartupService, StartupService>();
        services.AddTransient<IDeviceWriter, DeviceWriter>();

        return services;
    }
}
