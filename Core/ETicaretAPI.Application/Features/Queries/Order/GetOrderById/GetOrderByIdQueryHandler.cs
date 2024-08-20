﻿using ETicaretAPI.Application.Abstraction.Services;
using ETicaretAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Order.GetOrderById
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQueryRequest, GetOrderByIdQueryResponse>
    {
        readonly IOrderService _orderService;

        public GetOrderByIdQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<GetOrderByIdQueryResponse> Handle(GetOrderByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data =  await _orderService.GetOrderByIdAsync(request.Id);
            return new()
            {
                Id = data.Id,
                Description = data.Description,
                Address = data.Address,
                BasketItems = data.BasketItems,
                CreatedDate = data.CreatedDate,
                OrderCode = data.OrderCode,
                Completed = data.Completed,
            };
        }
    }
}
