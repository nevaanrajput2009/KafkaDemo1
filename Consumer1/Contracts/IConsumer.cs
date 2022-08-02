using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consumer1.Contracts
{
    public interface IConsumer
    {
        Task SubscribeAsync(string topic, Action<string> message);

    }
}
