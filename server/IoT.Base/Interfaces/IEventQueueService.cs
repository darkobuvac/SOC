namespace SOC.IoTBase.Interfaces;

public interface IEventQueueService<T>
{
    public void Publish(T message);
    public IAsyncEnumerable<T> SubscribeAsync(CancellationToken cancellationToken);
}
