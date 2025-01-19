namespace PublisherSubscriberModel.Modern
{
    public class EmailSubscriber
    {
        public void OnNewRecive(string news)
        {
            Console.WriteLine($"News Received: {news}. Send Email to User");
        }
    }
}
