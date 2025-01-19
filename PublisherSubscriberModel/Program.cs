using PublisherSubscriberModel.Modern;

public class Program
{
    public static void Main(string[] args)
    {
        Publisher publisher = new Publisher();

        Subscriber subscriber = new Subscriber();
        EmailSubscriber emailSubscriber = new EmailSubscriber();
        TextSubscriber textSubscriber = new TextSubscriber();

        publisher.NewPublisher += subscriber.OnNewRecive;
        publisher.NewPublisher += emailSubscriber.OnNewRecive;
        publisher.NewPublisher += textSubscriber.OnNewRecive;

        publisher.Publish("Hello World");

        publisher.NewPublisher -= subscriber.OnNewRecive;

        publisher.Publish("Stock Prices has been increased 50%");

        PublisherSubscriberModel.Traditional.Publisher traditionalPublisher = new();
        PublisherSubscriberModel.Traditional.Subscriber traditionalSubscriber = new();

        traditionalPublisher.PublishedNews += traditionalSubscriber.OnNewsRecived;

        traditionalPublisher.PublishNews("Hello World!", "Google");
    }
}

