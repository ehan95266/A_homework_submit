using System;
using Hrm.Authentication.ApplicationCoreLayer.Contract.Repository;
using Hrm.Authentication.ApplicationCoreLayer.Contract.Service;
using Hrm.Authentication.ApplicationCoreLayer.Entity;
using Hrm.Authentication.ApplicationCoreLayer.Model.Request;
using Hrm.Authentication.ApplicationCoreLayer.Model.Response;

namespace Hrm.Authentication.Infrastructure.Service
{
        public class RoleServiceAsync : IRoleServiceAsync
        {
            private readonly IRoleRepositoryAsync RoleRepositoryAsync;

            public RoleServiceAsync(IRoleRepositoryAsync _RoleRepositoryAsync)
            {
                RoleRepositoryAsync = _RoleRepositoryAsync;
            }

            public Task<int> AddRoleAsync(RoleRequestModel model)
            {
                Role role = new Role()
                {
                    Name = model.Name,
                    Description = model.Description
                };
                return RoleRepositoryAsync.InsertAsync(role);
            }

            public Task<int> DeleteRoleAsync(int id)
            {
                return RoleRepositoryAsync.DeleteAsync(id);
            }

            public async Task<IEnumerable<RoleResponseModel>> GetAllRoleAsync()
            {
                var result = await RoleRepositoryAsync.GetAllAsync();
                if (result != null)
                {
                    return result.ToList().Select(x => new RoleResponseModel()
                    { Id = x.Id, Name = x.Name,Description = x.Description });
                }
                return null;
            }

            public async Task<RoleResponseModel> GetRoleByIdAsync(int id)
            {
                var result = await RoleRepositoryAsync.GetByIdAsync(id);
                if (result != null)
                {
                    return new RoleResponseModel()
                    {
                        Id = result.Id,
                        Name = result.Name,
                        Description = result.Description
                    };
                }
                return null;
            }

            public Task<int> UpdateRoleAsync(RoleRequestModel model)
            {
                Role role = new Role()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description
                };
                return RoleRepositoryAsync.UpdateAsync(role);
            }

        }
    
}

