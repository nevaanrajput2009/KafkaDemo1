using Consumer.Implementations;
using System;
using System.Threading.Tasks;

namespace Consumer
{
    class Program
    {
        private const string topic = "kafka-sample";
        public static async Task Main(string[] args)
        {
            Console.Title = "Kafka Sample Consumer 1";
            Console.WriteLine("Kafka Sample Consumer 1");
            SampleConsumer consumer = new SampleConsumer();
            await consumer.SubscribeAsync(topic, Console.WriteLine);
        }
    }
}
