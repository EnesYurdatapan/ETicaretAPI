using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrastructure.Filters
{
    public class ValidationFilter : IAsyncActionFilter // action'a gelen isteklerde devreye giren bir filter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
               var errors = context.ModelState    // errorları yakalayıp sonuca verdik
                    .Where(x => x.Value.Errors.Any())
                    .ToDictionary(e => e.Key, e => e.Value.Errors.Select(e => e.ErrorMessage))
                    .ToArray();

                context.Result = new BadRequestObjectResult(errors);
                return;
            }

            await next(); // next delegate'i bir sonraki filter'ı temsil ettiği için ona geçmesi için tetikledik
        }
    }
}
