using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Contracts2
{
    public interface IConsumer
    {
        Task SubscribeAsync(string topic, Action<string> message);

    }
}
