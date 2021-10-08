using EShop.DataLayer.Context;
using EShop.Entities;
using EShop.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using EShop.Services.Contracts.Identity;

namespace EShop.Services.EFServices.Identity
{
    public class UserStoreService
    : UserStore<User, Role, EShopDbContext, int, UserClaim, UserRole, UserLogin, UserToken, RoleClaim>,
        IUserStoreService
    {
        public UserStoreService(
            IUnitOfWork uow,
            IdentityErrorDescriber describer = null
            )
        : base((EShopDbContext)uow, describer)
        {
        }
    }
}
