using System;
using System.Collections.Generic;
using System.Data;
using Ims.Core;
using Ims.Domain;

namespace Ims.DataAccess
{
    public interface IRequestDataService
    {
        void Insert(Request request);

        void Update(Request request);

        void DeleteMany(params int[] ids);

        Request SelectByRequestId(int requestId);

        IEnumerable<Request> SelectManyByRequestTypeIdCreatedByCompanyId(byte requestTypeId, short createdByCompanyId);
    }

    public class RequestDataService : IRequestDataService
    {
        public virtual void Insert(Request request)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                request.RequestId = transactionScope.ExecuteScalar<int>("inventory.Request_Insert", CommandType.StoredProcedure, new Parameter("RequestId", SqlDbType.Int, request.RequestId), new Parameter("RequestTypeId", SqlDbType.TinyInt, request.RequestTypeId), new Parameter("CreatedByCompanyId", SqlDbType.SmallInt, request.CreatedByCompanyId), new Parameter("FromCompanyId", SqlDbType.SmallInt, request.FromCompanyId), new Parameter("ToCompanyId", SqlDbType.SmallInt, request.ToCompanyId), new Parameter("Total", SqlDbType.SmallInt, request.Total), new Parameter("IncompleteCount", SqlDbType.SmallInt, request.IncompleteCount), new Parameter("AcceptedCount", SqlDbType.SmallInt, request.AcceptedCount), new Parameter("RejectedCount", SqlDbType.SmallInt, request.RejectedCount), new Parameter("DateTimeCreated", SqlDbType.DateTime2, request.DateTimeCreated));
            }
        }

        public virtual void Update(Request request)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                transactionScope.ExecuteNonQuery("inventory.Request_Update", CommandType.StoredProcedure, new Parameter("RequestId", SqlDbType.Int, request.RequestId), new Parameter("RequestTypeId", SqlDbType.TinyInt, request.RequestTypeId), new Parameter("CreatedByCompanyId", SqlDbType.SmallInt, request.CreatedByCompanyId), new Parameter("FromCompanyId", SqlDbType.SmallInt, request.FromCompanyId), new Parameter("ToCompanyId", SqlDbType.SmallInt, request.ToCompanyId), new Parameter("Total", SqlDbType.SmallInt, request.Total), new Parameter("IncompleteCount", SqlDbType.SmallInt, request.IncompleteCount), new Parameter("AcceptedCount", SqlDbType.SmallInt, request.AcceptedCount), new Parameter("RejectedCount", SqlDbType.SmallInt, request.RejectedCount), new Parameter("DateTimeCreated", SqlDbType.DateTime2, request.DateTimeCreated));
            }
        }

        public virtual void DeleteMany(params int[] ids)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                transactionScope.ExecuteNonQuery("inventory.Request_DeleteMany", CommandType.StoredProcedure, new Parameter("Ids", SqlDbType.Binary, ids.ToByteArray()));
            }
        }

        public virtual Request SelectByRequestId(int requestId)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                DataRow dataRow = transactionScope.ExecuteDataRow("inventory.Request_SelectByRequestId", CommandType.StoredProcedure, new Parameter("RequestId", SqlDbType.Int, requestId));

                return dataRow == null ? null : new Request(dataRow.Field<int>("RequestId"), dataRow.Field<byte>("RequestTypeId"), dataRow.Field<short>("CreatedByCompanyId"), dataRow.Field<short>("FromCompanyId"), dataRow.Field<short>("ToCompanyId"), dataRow.Field<short>("Total"), dataRow.Field<short>("IncompleteCount"), dataRow.Field<short>("AcceptedCount"), dataRow.Field<short>("RejectedCount"), dataRow.Field<DateTime>("DateTimeCreated"));
            }
        }

        public virtual IEnumerable<Request> SelectManyByRequestTypeIdCreatedByCompanyId(byte requestTypeId, short createdByCompanyId)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                foreach(DataRow dataRow in transactionScope.ExecuteDataRows("inventory.Request_SelectManyByRequestTypeIdCreatedByCompanyId", CommandType.StoredProcedure, new Parameter("RequestTypeId", SqlDbType.TinyInt, requestTypeId), new Parameter("CreatedByCompanyId", SqlDbType.SmallInt, createdByCompanyId)))
                {
                    yield return new Request(dataRow.Field<int>("RequestId"), dataRow.Field<byte>("RequestTypeId"), dataRow.Field<short>("CreatedByCompanyId"), dataRow.Field<short>("FromCompanyId"), dataRow.Field<short>("ToCompanyId"), dataRow.Field<short>("Total"), dataRow.Field<short>("IncompleteCount"), dataRow.Field<short>("AcceptedCount"), dataRow.Field<short>("RejectedCount"), dataRow.Field<DateTime>("DateTimeCreated"));
                }

            }
        }
    }
}
