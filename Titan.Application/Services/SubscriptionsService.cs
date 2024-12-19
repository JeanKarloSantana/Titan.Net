using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Application.Services
{
    public class SubscriptionsWriteService : ISubscriptionsWriteService
    {
        public Guid CreateSubscription(string subscriptionType, Guid adminId)
        {
            return Guid.NewGuid();
        }
    }
}
