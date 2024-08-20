using ETicaretAPI.Application.Abstraction.Services;
using ETicaretAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Services
{
    public class RoleService : IRoleService
    {
        readonly RoleManager<AppRole> _roleManager;

        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<bool> CreateRole(string name)
        {
           IdentityResult result =  await _roleManager.CreateAsync(new() { Id=Guid.NewGuid().ToString(), Name= name });
            return result.Succeeded;
        }

        public async Task<bool> DeleteRole(string id)
        {
            AppRole appRole = await _roleManager.FindByIdAsync(id);
           IdentityResult result = await _roleManager.DeleteAsync(appRole);
            return result.Succeeded;
        }

        public (object,int) GetAllRolesAsync(int page,int size)
        {
            var query = _roleManager.Roles;
            IQueryable<AppRole> rolesQuery = null;

            if (page != -1 && size != -1)
                rolesQuery = query.Skip(page * size).Take(size);
            else
                rolesQuery = query;

           
            return (rolesQuery.Select(r => new {r.Id,r.Name}),query.Count());
        }

        public async Task<(string id, string name)> GetRoleById(string roleId)
        {
            string role = await _roleManager.GetRoleIdAsync(new() { Id = roleId });
            return (roleId, role);
        }

        public async Task<bool> UpdateRole(string id, string name)
        {
            AppRole appRole = await _roleManager.FindByIdAsync(id);
            appRole.Name = name;
            IdentityResult result = await _roleManager.UpdateAsync(appRole);
            return result.Succeeded;
        }
    }
}
