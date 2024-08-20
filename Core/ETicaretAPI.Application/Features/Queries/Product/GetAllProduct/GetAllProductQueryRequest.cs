using ETicaretAPI.Application.RequestParameters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Product.GetAllProduct
{
    public class GetAllProductQueryRequest : IRequest<GetAllProductQueryResponse> //MediatR'da request nesnesine karşılık geldiğini ve sonucunda ne döndüreceğini belirtir
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
