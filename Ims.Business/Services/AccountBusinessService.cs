using System;
using Ims.Business.ViewModels;
using Ims.Core;
using Ims.DataAccess;

namespace Ims.Business.Services
{
    public class AccountBusinessService
    {
        private readonly IAccountDataService _accountDataService;

        public AccountBusinessService(IAccountDataService accountDataService)
        {
            _accountDataService = accountDataService;
        }

        public ListReturnValue<AccountListItem> GetListItems(ListRequest listRequest)
        {
            return _accountDataService.GetListItems<AccountListItem>(listRequest);
        }
    }
}
