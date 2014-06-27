using System.Collections.Generic;
using System.Data;
using System.Linq;
using DTS.AppFramework.SqlBuilder;
using Ims.Core;
using Ims.Domain;

namespace Ims.DataAccess
{
    public interface IAccountDataService
    {
        void Insert(Account account);

        void Update(Account account);

        void DeleteMany(params short[] ids);

        Account SelectByAccountId(short accountId);

        IEnumerable<Account> SelectManyByCompanyId(short companyId);

        ListReturnValue<T> GetListItems<T>(ListRequest listRequest) where T : new();
    }

    public class AccountDataService : IAccountDataService
    {
        private readonly Builder _builder;

        public AccountDataService(Builder builder)
        {
            _builder = builder;
        }

        public virtual void Insert(Account account)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                account.AccountId = transactionScope.ExecuteScalar<short>("companies.Account_Insert", CommandType.StoredProcedure, new Parameter("AccountId", SqlDbType.SmallInt, account.AccountId), new Parameter("AccountCode", SqlDbType.VarChar, account.AccountCode), new Parameter("AccountName", SqlDbType.VarChar, account.AccountName), new Parameter("AccountTypeCode", SqlDbType.Char, account.AccountTypeCode), new Parameter("CompanyId", SqlDbType.SmallInt, account.CompanyId), new Parameter("IsActive", SqlDbType.Bit, account.IsActive));
            }
        }

        public virtual void Update(Account account)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                transactionScope.ExecuteNonQuery("companies.Account_Update", CommandType.StoredProcedure, new Parameter("AccountId", SqlDbType.SmallInt, account.AccountId), new Parameter("AccountCode", SqlDbType.VarChar, account.AccountCode), new Parameter("AccountName", SqlDbType.VarChar, account.AccountName), new Parameter("AccountTypeCode", SqlDbType.Char, account.AccountTypeCode), new Parameter("CompanyId", SqlDbType.SmallInt, account.CompanyId), new Parameter("IsActive", SqlDbType.Bit, account.IsActive));
            }
        }

        public virtual void DeleteMany(params short[] ids)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                transactionScope.ExecuteNonQuery("companies.Account_DeleteMany", CommandType.StoredProcedure, new Parameter("Ids", SqlDbType.Binary, ids.ToByteArray()));
            }
        }

        public virtual Account SelectByAccountId(short accountId)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                DataRow dataRow = transactionScope.ExecuteDataRow("companies.Account_SelectByAccountId", CommandType.StoredProcedure, new Parameter("AccountId", SqlDbType.SmallInt, accountId));

                return dataRow == null ? null : new Account(dataRow.Field<short>("AccountId"), dataRow.Field<string>("AccountCode"), dataRow.Field<string>("AccountName"), dataRow.Field<string>("AccountTypeCode"), dataRow.Field<short>("CompanyId"), dataRow.Field<bool>("IsActive"));
            }
        }

        public virtual IEnumerable<Account> SelectManyByCompanyId(short companyId)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                foreach (DataRow dataRow in transactionScope.ExecuteDataRows("companies.Account_SelectManyByCompanyId", CommandType.StoredProcedure, new Parameter("CompanyId", SqlDbType.SmallInt, companyId)))
                {
                    yield return new Account(dataRow.Field<short>("AccountId"), dataRow.Field<string>("AccountCode"), dataRow.Field<string>("AccountName"), dataRow.Field<string>("AccountTypeCode"), dataRow.Field<short>("CompanyId"), dataRow.Field<bool>("IsActive"));
                }

            }
        }

        public ListReturnValue<T> GetListItems<T>(ListRequest listRequest) where T : new()
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                SelectStatement selectStatement = _builder.CreateSelect("companies.Account", "a")
                    .Join("a.AccountTypeCode", "at")
                    .Join("a.CompanyId", "c")

                    .Select("a.AccountId", columnType: ColumnType.Identifier)
                    .Select("a.AccountCode")
                    .Select("a.AccountName")
                    .Select("at.AccountTypeCode")
                    .Select("c.CompanyCode")
                    .Select("a.IsActive");

                foreach (SelectColumn selectColumn in selectStatement.SelectColumns.Where(item => item.ColumnType != ColumnType.Identifier))
                {
                    ListRequestColumn listRequestColumn = listRequest.ListRequestColumns.SingleOrDefault(item => item.Name == selectColumn.Alias);
                    selectColumn.IsVisible = listRequestColumn != null;
                    selectColumn.OrderByIndex = listRequestColumn == null ? 0 : listRequestColumn.OrderByIndex;
                }
                
                selectStatement.IsPaged = true;
                selectStatement.PageIndex = listRequest.PageIndex;
                selectStatement.PageSize = listRequest.PageSize;

                DataSet dataSet = transactionScope.ExecuteDataSet(selectStatement.Statement, CommandType.Text);



                return new ListReturnValue<T>(dataSet.Tables[0].ObjectForEachRow<T>(),
                    dataSet.Tables[1].Rows[0].Field<int>("Total"),
                    dataSet.Tables[1].Rows[0].Field<int>("PageIndex"));
            }
        }
    }
}
