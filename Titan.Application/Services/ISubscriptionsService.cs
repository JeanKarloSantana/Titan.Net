﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Application.Services
{
    public interface ISubscriptionsService
    {
        Guid CreateSubscription(string subscriptionType, Guid adminId);
    }
}
