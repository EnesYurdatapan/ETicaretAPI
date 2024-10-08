﻿using ETicaretAPI.Application.Abstraction.Hubs;
using ETicaretAPI.SignalR.Hubs;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.SignalR.HubServices
{
    public class ProductHubService : IProductHubService
    {
        readonly IHubContext<ProductHub> _context;

        public ProductHubService(IHubContext<ProductHub> context)
        {
            _context = context;
        }

        public async Task ProductAddedMessageAsync(string message)
        {
            await _context.Clients.All.SendAsync(ReceiveFunctionNames.ProductAddedMessage, message);
        }
    }
}
