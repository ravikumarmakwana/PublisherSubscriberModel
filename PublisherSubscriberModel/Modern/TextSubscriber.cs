namespace PublisherSubscriberModel.Modern
{
    public class TextSubscriber
    {
        public void OnNewRecive(string news)
        {
            Console.WriteLine($"News Received: {news}. Send Text Message to User");
        }
    }
}
