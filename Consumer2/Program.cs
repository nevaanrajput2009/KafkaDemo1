using Consumer2.Implementations;
using System;
using System.Threading.Tasks;

namespace Consumer
{
  class Program
  {
    private const string topic = "kafka-sample";
    public static async Task Main(string[] args)
    {
      Console.Title = "Kafka Sample Consumer 2";
      Console.WriteLine("Kafka Sample Consumer 2");
      SampleConsumer consumer = new SampleConsumer();
      await consumer.SubscribeAsync(topic, Console.WriteLine);
    }
  }
}
