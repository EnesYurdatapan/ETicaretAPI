using ETicaretAPI.Application.Repositories.FileRepository;
using ETicaretAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Repositories.FileRepository
{
    public class FileWriteRepository : WriteRepository<Domain.Entities.File>, IFileWriteRepository
     {
        public FileWriteRepository(ETicaretAPIDbContext eTicaretAPIDbContext) : base(eTicaretAPIDbContext)
        {
        }
    }
}
