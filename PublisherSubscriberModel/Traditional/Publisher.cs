namespace PublisherSubscriberModel.Traditional
{
    public class Publisher
    {
        public delegate void NewPublisher(object sender, NewsEventArgs eventArgs);
        public event NewPublisher PublishedNews;

        public void PublishNews(string news, string source)
        {
            PublishedNews?.Invoke(this, new NewsEventArgs() { News = news, Source = source, Timestamp = DateTime.Now });
        }
    }
}
