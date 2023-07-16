using MQTTnet.Client;
using Newtonsoft.Json.Linq;

namespace SOC.IoTBase.Infrastructure;

internal interface IMqttService
{
    public Task SubscribeAsync(
        string topic,
        Func<MqttApplicationMessageReceivedEventArgs, Task> action
    );
    public Task PublishAsync(string topic, JObject message);
    public Task UnsubscribeAsync(string topic);
}
