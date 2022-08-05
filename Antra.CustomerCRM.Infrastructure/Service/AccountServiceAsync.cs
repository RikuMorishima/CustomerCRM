using Antra.CustomerCRM.Core.Contracts.Repository;
using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CustomerCRM.Infrastructure.Service
{
    public class AccountServiceAsync : IAccountServiceAsync
    {
        private readonly IAccountRepository accountRepository;

        public AccountServiceAsync(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public Task<SignInResult> LoginAsync(LoginModel model)
        {
            return this.accountRepository.LoginAsync(model);
        }

        public Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            return accountRepository.SignUpAsync(model);
        }
    }
}
