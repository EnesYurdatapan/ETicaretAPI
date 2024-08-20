using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstraction.Services
{
    public interface IRoleService
    {
        (object,int) GetAllRolesAsync(int page, int size);
        Task<(string id, string name)> GetRoleById(string roleId);
        Task <bool>CreateRole(string name);
        Task <bool>DeleteRole(string id);
        Task <bool>UpdateRole(string id,string name);
    }
}
