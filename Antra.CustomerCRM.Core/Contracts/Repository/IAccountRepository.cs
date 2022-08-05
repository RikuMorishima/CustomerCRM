using Antra.CustomerCRM.Core.Entities;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Core.Contracts.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel user);
        public Task<SignInResult> LoginAsync(LoginModel model);
    }
}
