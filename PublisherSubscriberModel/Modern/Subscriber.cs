namespace PublisherSubscriberModel.Modern
{
    public class Subscriber
    {
        public void OnNewRecive(string news)
        {
            Console.WriteLine($"News Received: {news}");
        }
    }
}
