namespace PublisherSubscriberModel.Traditional
{
    public class NewsEventArgs : EventArgs
    {
        public string News { get; set; }
        public string Source { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
