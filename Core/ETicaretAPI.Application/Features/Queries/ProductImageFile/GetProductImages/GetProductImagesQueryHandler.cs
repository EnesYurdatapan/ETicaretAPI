using ETicaretAPI.Application.Repositories.ProductRepository;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.ProductImageFile.GetProductImages
{
    public class GetProductImagesQueryHandler : IRequestHandler<GetProductImagesQueryRequest, List<GetProductImagesQueryResponse>>
    {
        readonly IProductReadRepository _productReadRepository;
        readonly IWebHostEnvironment _webHostEnvironment;

        public GetProductImagesQueryHandler(IProductReadRepository productReadRepository, IWebHostEnvironment webHostEnvironment)
        {
            _productReadRepository = productReadRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<List<GetProductImagesQueryResponse>> Handle(GetProductImagesQueryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Product? product = await _productReadRepository.Table.Include(p => p.ProductImageFiles)
                            .FirstOrDefaultAsync(p => p.Id == Guid.Parse(request.Id));

            var x =product?.ProductImageFiles.Select(p => new GetProductImagesQueryResponse
            {
                Path = Path.Combine(_webHostEnvironment.WebRootPath,p.Path),
                FileName = p.FileName,
                Id = p.Id
            }).ToList(); // istediğimiz şekilde bir dönüş elde etmek için anonim type yaptık        }
            return x;
        }
    }
}
