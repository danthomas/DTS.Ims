using DTS.AppFramework.SqlBuilder;
using Ims.Business.Services;
using Ims.Business.ViewModels;
using Ims.Core;
using Ims.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ims.Tests.Business
{
    [TestClass]
    public class AccountBusinessServiceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Builder builder = new Builder(new DataSource("Ims"));

            builder.LoadDefinitions();

            AccountBusinessService accountBusinessService = new AccountBusinessService(new AccountDataService(builder));

            ListRequest listRequest = new ListRequest(0, 10, new[] { new ListRequestColumn("AccountCode", 1) });

            ListReturnValue<AccountListItem> listReturnValue = accountBusinessService.GetListItems(listRequest);
        }
    }
}
