﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Application.Commands.CreateSubscription
{
    public record CreateSubscriptionCommand(
        string SubscriptionType, 
        Guid AdminId
        ) : IRequest<Guid>;
}
