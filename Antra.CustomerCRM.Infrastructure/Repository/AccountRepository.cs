using Antra.CustomerCRM.Core.Contracts.Repository;
using Antra.CustomerCRM.Core.Entities;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Infrastructure.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IAccountRepository _accountRepository;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> _manager;
        public AccountRepository(UserManager<ApplicationUser> manager, SignInManager<ApplicationUser> signInManager)
        {
            this._manager = manager;
            this.signInManager = signInManager;
        }
        public Task<IdentityResult> SignUpAsync(SignUpModel user)
        {
            ApplicationUser appuser = new()
            {
                FirstName = user.FirstName,
                LastName=user.LastName,
                Email = user.Email,
                UserName=user.Email

            };

            return _manager.CreateAsync(appuser, user.Password);
        }

        public Task<SignInResult> LoginAsync(LoginModel model)
        {
            return signInManager.PasswordSignInAsync(model.Email, model.Password,model.Remember,false);

        }
    }
}
