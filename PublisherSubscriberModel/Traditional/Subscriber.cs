namespace PublisherSubscriberModel.Traditional
{
    public class Subscriber
    {
        public void OnNewsRecived(object sender, NewsEventArgs eventArgs)
        {
            Console.WriteLine($"News Received: {eventArgs.News}, Source: {eventArgs.Source}");
        }
    }
}
