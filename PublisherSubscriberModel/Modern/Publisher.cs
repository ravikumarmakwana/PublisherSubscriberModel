namespace PublisherSubscriberModel.Modern
{
    public class Publisher
    {
        public event Action<string> NewPublisher;

        public void Publish(string news)
        {
            NewPublisher?.Invoke(news);
        }
    }
}
