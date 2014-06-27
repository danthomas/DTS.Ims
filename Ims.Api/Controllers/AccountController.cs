using System.Web.Http;
using Ims.Business;
using Ims.Business.Services;
using Ims.Business.ViewModels;
using Ims.Core;

namespace Ims.Api.Controllers
{
    public class AccountController : ApiController
    {
        private readonly AccountBusinessService _accountBusinessService;

        public AccountController(AccountBusinessService accountBusinessService)
        {
            _accountBusinessService = accountBusinessService;
        }

        public ListReturnValue<AccountListItem> GetAccountListItems(ListRequest listRequest)
        {
            return _accountBusinessService.GetListItems(listRequest);
        }
    }
}
