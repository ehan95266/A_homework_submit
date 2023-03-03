using System;
using Hrm.Authentication.ApplicationCoreLayer.Contract.Repository;
using Hrm.Authentication.ApplicationCoreLayer.Contract.Service;
using Hrm.Authentication.ApplicationCoreLayer.Entity;
using Hrm.Authentication.ApplicationCoreLayer.Model.Request;
using Hrm.Authentication.ApplicationCoreLayer.Model.Response;

namespace Hrm.Authentication.Infrastructure.Service
{
        public class UserRoleServiceAsync : IUserRoleServiceAsync
        {
            private readonly IUserRoleRepositoryAsync UserRoleRepositoryAsync;

            public UserRoleServiceAsync(IUserRoleRepositoryAsync _UserRoleRepositoryAsync)
            {
                UserRoleRepositoryAsync = _UserRoleRepositoryAsync;
            }

            public Task<int> AddUserRoleAsync(UserRoleRequestModel model)
            {
                UserRole userRole = new UserRole()
                {
                    UserId = model.UserId,
                    RoleId = model.RoleId
                };
                return UserRoleRepositoryAsync.InsertAsync(userRole);
            }

            public Task<int> DeleteUserRoleAsync(int id)
            {
                return UserRoleRepositoryAsync.DeleteAsync(id);
            }

            public async Task<IEnumerable<UserRoleResponseModel>> GetAllUserRoleAsync()
            {
                var result = await UserRoleRepositoryAsync.GetAllAsync();
                if (result != null)
                {
                    return result.ToList().Select(x => new UserRoleResponseModel()
                    { Id = x.Id, UserId = x.UserId, RoleId = x.RoleId });
                }
                return null;
            }

            public async Task<UserRoleResponseModel> GetUserRoleByIdAsync(int id)
            {
                var result = await UserRoleRepositoryAsync.GetByIdAsync(id);
                if (result != null)
                {
                    return new UserRoleResponseModel()
                    {
                        Id = result.Id,
                        UserId = result.UserId,
                        RoleId = result.RoleId
                    };
                }
                return null;
            }

            public Task<int> UpdateUserRoleAsync(UserRoleRequestModel model)
            {
                UserRole userRole = new UserRole()
                {
                    Id = model.Id,
                    UserId = model.UserId,
                    RoleId = model.RoleId
                };
                return UserRoleRepositoryAsync.UpdateAsync(userRole);
            }

        }

    
}

